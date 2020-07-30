using RecordManagementSystemInAxaNSamar.Tabpages.AddEdit;
using RecordManagementSystemInAxaNSamar.Tabpages.View;
using System;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                this.Visible = true;
                //button1.Visible = false;
            }
            else if (loginForm.LoginAsClerk == true)
            {
                bt_ManageUser.Visible = false;
                bt_ManageAxaForms.Visible = false;
                bt_EmployessProfile.Visible = false;
                bt_ManagePlan.Visible = false;
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddEditEmployee addEditEmployee = new AddEditEmployee();
            //addEditEmployee.ShowDialog();

        }

        private void managePlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditPlan addEditPlan = new AddEditPlan();
            addEditPlan.ShowDialog();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditClient addEditClient = new AddEditClient();
            addEditClient.action = "Add";
            addEditClient.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditAxaForm addEditAxaForm = new AddEditAxaForm();
            addEditAxaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeesProfile employeesProfile = new EmployeesProfile();
            employeesProfile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SmsNotification smsNotification = new SmsNotification();
            smsNotification.ShowDialog();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditUser addEditUser = new AddEditUser();
            addEditUser.ShowDialog();
        }

        private void bt_ClientsRecords_Click(object sender, EventArgs e)
        {
            ClientesRecords clientesRecords = new ClientesRecords();
            clientesRecords.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ListLabel.Text = "List of: AXA FORMS";
            //ListDataGridView.Tag = "AXAFORMS";
            //var AllFiles = new DirectoryInfo(Application.StartupPath + "\\AXA FORMS").GetDirectories();
            //ListDataGridView.DataSource = AllFiles;
            AxaForms axaForms = new AxaForms();
            axaForms.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Login login = new Login();
            login.ShowDialog();


        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControlUpperDisplay1_Load(object sender, EventArgs e)
        {

        }

        private void bt_ManageUser_Click(object sender, EventArgs e)
        {
            AddEditUser addEditUser = new AddEditUser();
            addEditUser.ShowDialog();
        }

        private void bt_ManagePlan_Click(object sender, EventArgs e)
        {
            AddEditPlan addEditPlan = new AddEditPlan();
            addEditPlan.ShowDialog();
        }

        private void bt_ManageAxaForms_Click(object sender, EventArgs e)
        {
            AddEditAxaForm addEditAxaForm = new AddEditAxaForm();
            addEditAxaForm.ShowDialog();
        }

       
      
    }
}
