using RecordManagementSystemInAxaNSamar.Model;
using RecordManagementSystemInAxaNSamar.Tabpages.AddEdit;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.View
{
    public partial class FinancialAdviserMonitoring : Form
    {
        public FinancialAdviserMonitoring()
        {
            InitializeComponent();
        }

        public DataGridViewRow dgvr;

        private void FinancialAdviserMonitoring_Load(object sender, EventArgs e)
        {
            FAName.Text = dgvr.Cells[1].Value.ToString() + " " + dgvr.Cells[2].Value.ToString() + " " + dgvr.Cells[3].Value.ToString();
            AddEditClient.tempFinancialAdvisorName = FAName.Text;
            string imagePath = Application.StartupPath + "\\EmployeePicture\\" + dgvr.Cells[4].Value.ToString();
            PopulateClientIDImage(imagePath, 1);
          //  PopulateClientIDImage(dgvr.Cells[4].Value.ToString(), 1);


            int clientId = Int32.Parse(dgvr.Cells[0].Value.ToString());

            using (AxaContext ctx = new AxaContext())
            {
                clientBindingSource.DataSource = ctx.Clients.Where((x => x.EmployeeId == clientId)).ToList();
            }
        }

        public void PopulateClientIDImage(string id_path, int _id)
        {
            if ((id_path != null) && System.IO.File.Exists(id_path))
            {
                if (_id == 1)
                {
                    pictureBox1.Image = Image.FromFile(id_path);
                }

                else { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEditClient addEditClient = new AddEditClient();
            AddEditClient.tempEmployeeId = Convert.ToInt32(dgvr.Cells[0].Value.ToString());
            AddEditClient.action = "Add";
            addEditClient.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListOfClients.SelectedRows.Count > 0)
            {
                AddEditClient.action = "Edit";
                AddEditClient.selected_client = Int32.Parse(dataGridView_ListOfClients.SelectedRows[0].Cells[0].Value.ToString());
               
                AddEditClient addEditClient = new AddEditClient();
                addEditClient.ShowDialog();

                    
      
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ViewClientInformation_Click(object sender, EventArgs e)
        {
            try
            {

           
            ViewInformationForm viewInformationForm = new ViewInformationForm();
            viewInformationForm.selected_client_id = Int32.Parse(dataGridView_ListOfClients.SelectedRows[0].Cells[0].Value.ToString());
            viewInformationForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Select Client");
            }
        }

        private void lb_Search_Click(object sender, EventArgs e)
        {
       
        }

        private void tb_SearchEmployee_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tb_SearchEmployee_Enter(object sender, EventArgs e)
        {
            if (tb_SearchEmployee.Text.Contains("Search name"))
            {
                tb_SearchEmployee.Clear();
            }
        }

        private void tb_SearchEmployee_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_SearchEmployee.Text))
            {
                tb_SearchEmployee.Text = "Search name";
            }
        }

        private void tb_SearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (AxaContext ctx = new AxaContext())
                {

                    int clientId = Int32.Parse(dgvr.Cells[0].Value.ToString());
                    clientBindingSource.DataSource = ctx.Clients.Where(x => x.CFirstName.Contains(tb_SearchEmployee.Text) || x.CMiddleName.Contains(tb_SearchEmployee.Text) || x.CLastName.Contains(tb_SearchEmployee.Text)).ToList();
                    tb_SearchEmployee.Text = "Search name";
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                int clientId = Int32.Parse(dgvr.Cells[0].Value.ToString());
                if (String.IsNullOrWhiteSpace(tb_SearchEmployee.Text) || tb_SearchEmployee.Text.Contains("Search name"))
                {
                    clientBindingSource.DataSource = ctx.Clients.Where(x => x.EmployeeId == clientId).ToList();

                }
                else
                {

                    clientBindingSource.DataSource = ctx.Clients.Where(x => x.CFirstName.Contains(tb_SearchEmployee.Text) || x.CMiddleName.Contains(tb_SearchEmployee.Text) || x.CLastName.Contains(tb_SearchEmployee.Text)).ToList();
                }
            }
            tb_SearchEmployee.Text = "Search name";
        }
    }
}
