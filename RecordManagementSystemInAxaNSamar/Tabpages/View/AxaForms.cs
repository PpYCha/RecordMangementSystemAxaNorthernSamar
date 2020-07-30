using System;
using System.IO;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.View
{
    public partial class AxaForms : Form
    {
        public AxaForms()
        {
            InitializeComponent();
        }

        private void AxaForms_Load(object sender, EventArgs e)
        {
            var AllFiles = new DirectoryInfo(Application.StartupPath + "\\AXA FORMS").GetDirectories();
            ListDataGridView.DataSource = AllFiles;

            foreach (DataGridViewColumn c in ListDataGridView.Columns)
            {
                if (c.HeaderText != "Name")
                {
                    c.Visible = false;
                }
            }

        }

        private void ListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListDataGridView.SelectedRows.Count > 0)
            {
                System.Diagnostics.Process.Start(ListDataGridView.SelectedRows[0].Cells["FullName"].Value.ToString());
            }
        }

        private void ListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListDataGridView_Click(object sender, EventArgs e)
        {
            try
            {

                var AllFiles = new DirectoryInfo(ListDataGridView.SelectedRows[0].Cells["FullName"].Value.ToString()).GetFiles();
                ListDataGridView.DataSource = AllFiles;
                ListDataGridView.ClearSelection();
            }
            catch (Exception)
            {


            }
        }

        private void ListDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ListDataGridView.SelectedRows.Count > 0)
            {
                System.Diagnostics.Process.Start(ListDataGridView.SelectedRows[0].Cells["FullName"].Value.ToString());
            }
        }

        private void ListDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn c in ListDataGridView.Columns)
            {
                if (c.HeaderText != "Name")
                {
                    c.Visible = false;
                }
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
