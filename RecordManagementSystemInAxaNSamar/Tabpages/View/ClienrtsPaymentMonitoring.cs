using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.View
{
    public partial class ClienrtsPaymentMonitoring : Form
    {
        public ClienrtsPaymentMonitoring()
        {
            InitializeComponent();
        }
        public DataGridViewRow dgvrClientPlanMonitoring;

        private void ClienrtsPaymentMonitoring_Load(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {




                if (dgvrClientPlanMonitoring == null)
                {

                }
                else
                {
                    int clientId = Int32.Parse(dgvrClientPlanMonitoring.Cells[0].Value.ToString());

                    clientPlanBindingSource.DataSource = ctx.ClientPlans.Where(x => x.ClientId == clientId).ToList();
                }




            }
        }

        private void bt_SelectClient_Click(object sender, EventArgs e)
        {
            try
            {
                lb_PolicyNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lb_SumInsurred.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lb_PaymentMethod.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                lb_TotalPayment.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lb_PremiumAmount.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                loadPaymentRecords();
            }
            catch (Exception)
            {


            }



        }

        private void bt_AddPayment_Click(object sender, EventArgs e)
        {




            AddPayment();
            loadPaymentRecords();

        }

        private void AddPayment()
        {
            SQLCon.dbCon();
            SQLCon.sqlCommand = new SqlCommand("INSERT INTO PaymentRecords VALUES (@2, @3, @4)", SQLCon.sqlConnection);
            SQLCon.sqlCommand.CommandType = CommandType.Text;

            SQLCon.sqlCommand.Parameters.AddWithValue("@2", Int32.Parse(lb_SumInsurred.Text));
            SQLCon.sqlCommand.Parameters.AddWithValue("@3", DateTime.Now.ToString());
            SQLCon.sqlCommand.Parameters.AddWithValue("@4", lb_PolicyNo.Text);
            SQLCon.sqlCommand.ExecuteNonQuery();
        }

        private void loadPaymentRecords()
        {

            SQLCon.sqlDataAdapter = new SqlDataAdapter("SELECT PolicyNumberPayment AS [POLICY NO], PaidDate AS [DATE PAID], PaymentPaid AS [PAYMENT PAID] FROM PaymentRecords WHERE PolicyNumberPayment='" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "'", SQLCon.sqlConnection);
            //SQLCon.sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@1", "%" + lb_PolicyNo.Text + "%");
            SQLCon.dbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataAdapter.Fill(SQLCon.dataTable);
            dataGridView_PaymentRecordss.DataSource = SQLCon.dataTable;

            try
            {
                int totalPaid = 0;
                int finalTotal = 0;
                foreach (DataGridViewRow item in dataGridView_PaymentRecordss.Rows)
                {
                    totalPaid = Convert.ToInt32(item.Cells["PAYMENT PAID"].Value.ToString());
                    finalTotal += totalPaid;
                }

                lbl_totalPaid.Text = finalTotal.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void isNumeric(object sender, KeyPressEventArgs e)
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

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_SearchEmployee_Enter(object sender, EventArgs e)
        {
            if (tb_SearchEmployee.Text.Contains("Search Policy Number"))
            {
                tb_SearchEmployee.Clear();
            }
        }

        private void tb_SearchEmployee_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_SearchEmployee.Text))
            {
                tb_SearchEmployee.Text = "Search Policy Number";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                int clientId = Int32.Parse(dgvrClientPlanMonitoring.Cells[0].Value.ToString());
                if (String.IsNullOrWhiteSpace(tb_SearchEmployee.Text) || tb_SearchEmployee.Text.Contains("Search Policy Number"))
                {
                    clientPlanBindingSource.DataSource = ctx.ClientPlans.Where(x => x.ClientId == clientId).ToList();

                }
                else
                {

                    clientPlanBindingSource.DataSource = ctx.ClientPlans.Where(x => x.PolicyNo == tb_SearchEmployee.Text).ToList();
                }
            }
            tb_SearchEmployee.Text = "Search Policy Number";
        }

        private void tb_SearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (AxaContext ctx = new AxaContext())
                {

                    int clientId = Int32.Parse(dgvrClientPlanMonitoring.Cells[0].Value.ToString());
                    clientPlanBindingSource.DataSource = ctx.ClientPlans.Where(x => x.PolicyNo == tb_SearchEmployee.Text).ToList();
                    tb_SearchEmployee.Text = "Search Policy Number";
                }
            }
        }
    }
}
