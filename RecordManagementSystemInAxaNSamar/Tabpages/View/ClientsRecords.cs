using RecordManagementSystemInAxaNSamar.Model;
using RecordManagementSystemInAxaNSamar.Tabpages.AddEdit;
using RecordManagementSystemInAxaNSamar.Tabpages.View;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar
{
    public partial class ClientesRecords : Form
    {
        public ClientesRecords()
        {
            InitializeComponent();
        }

        private void ClientesRecords_Load(object sender, EventArgs e)
        {
            LoadClientList();
            button3.Enabled = false;
            bt_FAMonitoring.Enabled = false;

            using (AxaContext ctx = new AxaContext())
            {
                dataGridView_FinancialAdvisor.DataSource = ctx.Employees.Where(x => x.DesignatedPostion == "Financial advisor").ToList();
            }
            dataGridView_FinancialAdvisor.Visible = true;
            dataGridView_Client.Visible = false;
            dataGridView_FinancialAdvisor.Columns[0].Visible = false;

            bt_FAMonitoring.Enabled = true;
            bt_FAMonitoring.BackColor = Color.Firebrick;

            button3.BackColor = Color.DimGray;
            button3.Enabled = false;

            label2.Text = "Financial Advisor List:";
        }

        private void LoadClientList()
        {
            try
            {
                using (AxaContext ctx = new AxaContext())
                {
                    employeeBindingSource.DataSource = ctx.Users.ToList();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No Database");
            }
           
        }

        private void bt_FAMonitoring_Click(object sender, EventArgs e)
        {


            FinancialAdviserMonitoring financialAdviserMonitoring = new FinancialAdviserMonitoring();
            AddEditClient.selected_FinancialAdvisor = Int32.Parse(dataGridView_FinancialAdvisor.SelectedRows[0].Cells[0].Value.ToString());
           financialAdviserMonitoring.dgvr = dataGridView_FinancialAdvisor.SelectedRows[0];
            financialAdviserMonitoring.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                dataGridView_FinancialAdvisor.DataSource = ctx.Employees.Where(x => x.DesignatedPostion == "Financial advisor").ToList();
            }
            dataGridView_FinancialAdvisor.Visible = true;
            dataGridView_Client.Visible = false;
            dataGridView_FinancialAdvisor.Columns[0].Visible = false;

            bt_FAMonitoring.Enabled = true;
            bt_FAMonitoring.BackColor = Color.Firebrick;

            button3.BackColor = Color.DimGray;
            button3.Enabled = false;

            label2.Text = "Financial Advisor List:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                dataGridView_Client.DataSource = ctx.Clients.ToList();
            }
            dataGridView_Client.Visible = true;
            dataGridView_FinancialAdvisor.Visible = false;


            bt_FAMonitoring.Enabled = false;
            bt_FAMonitoring.BackColor = Color.DimGray;
            button3.BackColor = Color.Firebrick;
            button3.Enabled = true;

            label2.Text = "Client List:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

                ClienrtsPaymentMonitoring clienrtsPaymentMonitoring = new ClienrtsPaymentMonitoring();
                clienrtsPaymentMonitoring.dgvrClientPlanMonitoring = dataGridView_Client.SelectedRows[0];
                clienrtsPaymentMonitoring.ShowDialog();
         


        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_Search_Click(object sender, EventArgs e)
        {
           
        }

        private void tb_SearchEmployee_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tb_SearchEmployee_Enter(object sender, EventArgs e)
        {
          
        }

        private void tb_SearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void tb_SearchEmployee_Leave(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
