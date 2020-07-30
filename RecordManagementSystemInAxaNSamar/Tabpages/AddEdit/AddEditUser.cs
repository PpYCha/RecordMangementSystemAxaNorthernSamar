using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    public partial class AddEditUser : Form
    {
        public AddEditUser()
        {
            InitializeComponent();
        }

        private DataGridViewRow userId;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_SaveUser_Click(object sender, System.EventArgs e)
        {
            SaveUser();


        }

        private void SaveUser()
        {
            using (AxaContext ctx = new AxaContext())
            {



                if (tb_FName.Text == "")
                {
                    MessageBox.Show("Please Filled up all the fields");
                }
                else
                {



                    if (dataGridView_User.SelectedRows.Count > 0)
                    {
                        try
                        {
                            bool statusAccount = false;
                            if (radioButton1.Checked == true)
                            {
                                statusAccount = true;
                            }
                            else
                            {
                                statusAccount = false;
                            }


                            int userId = Int32.Parse(dataGridView_User.SelectedRows[0].Cells[0].Value.ToString());




                            var userUpdate = new User
                            {
                                UserId = userId,
                                UFirstName = tb_FName.Text,
                                UMiddleName = tb_MName.Text,
                                ULastName = tb_LName.Text,
                                ContactNumber = tb_ContactNo.Text,
                                UserName = tb_Username.Text,
                                Password = tb_Password.Text,
                                UAddress = tb_Address.Text,
                                UGender = cb_Gender.GetItemText(cb_Gender.SelectedItem),
                                Role = cb_Role.GetItemText(cb_Role.SelectedItem),
                                IsActive = statusAccount

                            };
                            ctx.Users.Attach(userUpdate);
                            ctx.Entry(userUpdate).State = System.Data.Entity.EntityState.Modified;
                            ctx.SaveChanges();
                            ClearTextField();
                            LoadUserList();
                            MessageBox.Show("Update Successful");
                        }
                        catch (Exception)
                        {


                        }
                    }
                    else
                    {

                        var user = new User
                        {
                            UFirstName = tb_FName.Text,
                            UMiddleName = tb_MName.Text,
                            ULastName = tb_LName.Text,
                            ContactNumber = tb_ContactNo.Text,
                            UserName = tb_Username.Text,
                            Password = tb_Password.Text,
                            UAddress = tb_Address.Text,
                            UGender = cb_Gender.GetItemText(cb_Gender.SelectedItem),
                            Role = cb_Role.GetItemText(cb_Role.SelectedItem)

                        };

                        ctx.Users.Add(user);
                        ctx.SaveChanges();
                        ClearTextField();
                        LoadUserList();
                        MessageBox.Show("Save Successful");

                    }

                }
            }
        }

        private void ClearTextField()
        {
            tb_FName.Text = "";
            tb_MName.Text = "";
            tb_LName.Text = "";
            tb_ContactNo.Text = "";
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Address.Text = "";
            cb_Gender.SelectedIndex = -1;
            cb_Role.SelectedIndex = -1;
        }

        private void AddEditUser_Load(object sender, System.EventArgs e)
        {
            LoadUserList();

        }


        public void isNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void LoadUserList()
        {
            using (AxaContext ctx = new AxaContext())
            {

                userBindingSource.DataSource = ctx.Users.ToList();

            }
            dataGridView_User.ClearSelection();
        }

        private void dataGridView_User_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_User.Columns[e.ColumnIndex].Name == "passwordDataGridViewTextBoxColumn" && e.Value != null)
            {
                dataGridView_User.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void dataGridView_User_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_User.SelectedRows.Count > 0)
                {
                    userId = dataGridView_User.SelectedRows[0];

                    tb_Username.Text = userId.Cells[1].Value.ToString();
                    tb_Password.Text = userId.Cells[2].Value.ToString();
                    cb_Role.Text = userId.Cells[3].Value.ToString();
                    tb_FName.Text = userId.Cells[4].Value.ToString();
                    tb_MName.Text = userId.Cells[5].Value.ToString();
                    tb_LName.Text = userId.Cells[6].Value.ToString();
                    cb_Gender.Text = userId.Cells[7].Value.ToString();
                    tb_ContactNo.Text = userId.Cells[8].Value.ToString();
                    tb_Address.Text = userId.Cells[9].Value.ToString();
                    
                    bool cbValue = Convert.ToBoolean(userId.Cells[10].Value.ToString());
                    if (cbValue == true)
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                 
                }
            }
            catch (Exception)
            {


            }

        }

        private void AddEditUser_Click(object sender, EventArgs e)
        {
            dataGridView_User.ClearSelection();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
