using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
