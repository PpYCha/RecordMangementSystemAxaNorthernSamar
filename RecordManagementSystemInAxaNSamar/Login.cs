using RecordManagementSystemInAxaNSamar.Model;
using RecordManagementSystemInAxaNSamar.Tabpages;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool LoginAsClerk = false;

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void ValidateUser()
        {
            using (AxaContext ctx = new AxaContext())
            {
                var user = ctx.Users.Where(u => u.UserName.Equals(tb_Username.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password != tb_Password.Text)
                    {
                        MessageBox.Show("Invalid Password.");
                    }
                    //else if (user.IsActive == false)
                    //{
                    //    MessageBox.Show("Your Account is suspended. Please contact the administraor");


                    //}
                    else if (user.Role == "Admin")
                    {
                        this.Close();
                        //this.Dispose();
                    }
                    else if (user.Role == "Clerk")
                    {
                        LoginAsClerk = true;
                        this.Close();
                    }

                    else
                    {

                        this.Close();
                        //this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("No (" + tb_Username.Text + ") user found");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQLCon.dbCon();
        }
    }
}
