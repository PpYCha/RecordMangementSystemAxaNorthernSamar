using RecordManagementSystemInAxaNSamar.Model;
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


            bt_FAMonitoring.Enabled = true;
            bt_FAMonitoring.BackColor = Color.Firebrick;

            button3.BackColor = Color.DimGray;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                dataGridView_Client.DataSource = ctx.Clients.Where(x => x.CFirstName.Contains(tb_SearchEmployee.Text)).ToList();
            }
            dataGridView_Client.Visible = true;
            dataGridView_FinancialAdvisor.Visible = false;


            bt_FAMonitoring.Enabled = false;
            bt_FAMonitoring.BackColor = Color.DimGray;
            button3.BackColor = Color.Firebrick;
            button3.Enabled = true;
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
            lb_Search.Focus();
        }

        private void tb_SearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (tb_SearchEmployee.TextLength > 0)
            {
                lb_Search.Hide();
            }
            else
            {

                lb_Search.Show();



            }
        }
    }
}
