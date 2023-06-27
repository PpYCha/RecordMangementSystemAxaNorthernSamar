using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar
{
    public partial class SmsNotification : Form
    {
        private delegate void SetTextCallback(string text);
        private GsmCommMain commMain;


        public SmsNotification()
        {
            InitializeComponent();
        }

        private void message_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessagesFormat()
        {

        }

        private void tb_Birthday_Click(object sender, EventArgs e)
        {
            LoadClientBday();
        }

        private void LoadClientBday()
        {
            using (AxaContext ctx = new AxaContext())
            {
                DateTime dt = DateTime.Now;



                var result = from f in ctx.Clients


                             where f.CBirthday.Day == dt.Day && f.CBirthday.Month == dt.Month
                             select new

                             {

                                 f.CFirstName,
                                 f.CMiddleName,
                                 f.CLastName,
                                 f.CellphoneNo

                             };
                dataGridView_ClientList.DataSource = result.ToList();
                //dataGridView_ClientList.DataSource = ctx.Clients.Where(x => x.Due) ToList();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                tb_message.Text = @"Good Day Sir/ Madam
Greetings of Peace!
            
    Thank you for choosing AXA as your business partner in your financial security.
We wish that you have a great day today, may your dreams come true.

HAPPY BIRTHDAY!

AXA PHILIPPINES - CATARMAN BRANCH";
                checkBox1.Checked = false;
                checkBox2.Checked = false;

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                tb_message.Text = @"Good Day Sir/Madam
Greetings of Peace!

    Thank you for choosing AXA as your business partner in your financial security.
This is to notify you that you have an outstanding monthly premium due. Please settled your account to avoid lapses of your policy. If payment has been made please disregard this message.

Thank you and God bless.

AXA PHILIPPINES-CATARMAN BRANCH";
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                tb_message.Text = @"Good Day Sir/Madam
Greetings of Peace!

    Thank you for choosing AXA as your business partner in your financial security.
We would like to inform you that your premium payment for this month/quarter/annual has been received and posted to your monthly/quarterly/annual premium due.

Thank you and God bless.

AXA PHILIPPINES-CATARMAN BRANCH";


                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }

        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SmsNotification_Load(object sender, EventArgs e)
        {

        }

        private void tb_DueClients_Click(object sender, EventArgs e)
        {

        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Send();
            Cursor.Current = Cursors.Default;
        }

        private void Send()
        {
            if (commMain != null && commMain.IsConnected())
            {


                try
                {
                    if (dataGridView_ClientList.SelectedRows.Count > 0)
                    {


                        string cpNumber = dataGridView_ClientList.SelectedRows[0].Cells[4].Value.ToString();
                        SmsSubmitPdu pdu;
                        int count = 0;
                        int countPos = 0;

                        foreach (char c in tb_message.Text)
                        {
                            count++;
                            if (count >= 150)
                            {


                                string firstFivChar = new string(tb_message.Text.Substring(countPos, count).ToArray());
                                pdu = new SmsSubmitPdu(firstFivChar, cpNumber, string.Empty);
                                commMain.SendMessage(pdu);
                                countPos = countPos + 150;
                                count = count - count;

                            }
                        }

                        if (count <= 150)
                        {
                            string lastText = new string(tb_message.Text.Substring(countPos, count).ToArray());
                            pdu = new SmsSubmitPdu(lastText, cpNumber, "");
                            commMain.SendMessage(pdu);
                            countPos = countPos + 150;
                            count = count - count;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please selecet Client number");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check if simcard properly loaded. Please check if simcard have load.");

                }
            }


        }




        private void DeleteMessages()
        {
            commMain.DeleteMessages(DeleteScope.All, PhoneStorageType.Sim);
        }



        private void tb_Connect_Click(object sender, EventArgs e)
        {
            if (commMain != null && commMain.IsConnected())
            {
                MessageBox.Show("Already Connected");




            }
            else
            {
                try
                {

                    string portnnumber = cb_PortNumber.Text;

                    //commMain = new GsmCommMain(portNumber: 3, baudRate: 115200, timeout: 500);
                    commMain = new GsmCommMain(portnnumber, baudRate: 115200, timeout: 500);
                    commMain.Open();

                    MessageBox.Show("Successfully Connected");
                }
                catch (Exception ex)
                {
                    ShowException(ex);
                }

            }
        }

        private void ShowException(Exception ex)
        {
            MessageBox.Show("No modem found");

        }

        private void tb_PaidClients_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                dataGridView_ClientList.DataSource = ctx.Clients.ToList();
            }
        }

        private class SMSRouter
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteMessages();
        }

        private void bt_BatchSend_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (DataGridView item in dataGridView_ClientList.Rows)
            //    {

            BulkSend();
            //}
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Select Category");
            //}

        }

        private void BulkSend()
        {
            if (commMain != null && commMain.IsConnected())
            {

                int counterNumber = 0;
                try
                {
                    foreach (DataGridView item in dataGridView_ClientList.Rows)
                    {






                        string cpNumber = dataGridView_ClientList.SelectedRows[0].Cells[4].Value.ToString();
                        SmsSubmitPdu pdu;
                        int count = 0;
                        int countPos = 0;

                        foreach (char c in tb_message.Text)
                        {
                            count++;
                            if (count >= 150)
                            {


                                string firstFivChar = new string(tb_message.Text.Substring(countPos, count).ToArray());
                                pdu = new SmsSubmitPdu(firstFivChar, cpNumber, string.Empty);
                                commMain.SendMessage(pdu);
                                countPos = countPos + 150;
                                count = count - count;

                            }
                        }

                        if (count <= 150)
                        {
                            string lastText = new string(tb_message.Text.Substring(countPos, count).ToArray());
                            pdu = new SmsSubmitPdu(lastText, cpNumber, "");
                            commMain.SendMessage(pdu);
                            countPos = countPos + 150;
                            count = count - count;
                        }

                        counterNumber++;


                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check if simcard properly loaded. Please check if simcard have load.");

                }
            }
            else
            {
                MessageBox.Show("Please connect the Modem first");
            }
        }
    }
}
