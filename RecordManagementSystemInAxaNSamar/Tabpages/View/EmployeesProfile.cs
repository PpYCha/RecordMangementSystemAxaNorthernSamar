using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar
{
    public partial class EmployeesProfile : Form
    {
        public EmployeesProfile()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }

        private void LoadClientList()
        {

        }

        private void dataGridView_ListOfEmployee_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView_ListOfEmployee_Click(object sender, EventArgs e)
        {


            //int fEmployeeId = Int32.Parse(dataGridView_ListOfEmployee.SelectedRows[0].Cells[0].Value.ToString());

            //using (AxaContext ctx = new AxaContext())
            //{
            //    var result = from ee in ctx.Clients
            //                 where ee.EmployeeId == fEmployeeId
            //                 select new

            //                 {
            //                     ee.CFirstName,
            //                     ee.CMiddleName,
            //                     ee.CLastName,

            //                 };

            //    dataGridView_Clients.DataSource = result.ToList();
            //    dataGridView_Clients.Columns[0].HeaderCell.Value = "First Name";
            //    dataGridView_Clients.Columns[1].HeaderCell.Value = "Middle Name";
            //    dataGridView_Clients.Columns[2].HeaderCell.Value = "Last Name";


            //}

        }

        private void dataGridView_ListOfEmployee_DoubleClick(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee();
            addEditEmployee.dgvrAddEditEmployee = dataGridView_ListOfEmployee.SelectedRows[0];

            addEditEmployee.Show();

        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Close_Click_1(object sender, EventArgs e)
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

        private void tb_SearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    loadEmployeeList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void loadEmployeeList()
        {
            using (AxaContext ctx = new AxaContext())
            {
                if (tb_SearchEmployee.Text == "")

                {

                    dataGridView_ListOfEmployee.DataSource = ctx.Employees.ToList();

                }
                else
                {


                    dataGridView_ListOfEmployee.DataSource = ctx.Employees.Where(x => x.EFirstName == tb_SearchEmployee.Text).ToList();

                }


                //dataGridView_ListOfEmployee.DataSource = ctx.Employees.Where(x => x.EFirstName == tb_SearchEmployee.Text + x.EMiddleName == tb_SearchEmployee.Text)

            }
        }

        private void bt_SaveUser_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee();
            addEditEmployee.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                dataGridView_ListOfEmployee.DataSource = ctx.Employees.ToList();
            }
        }


    }
}
