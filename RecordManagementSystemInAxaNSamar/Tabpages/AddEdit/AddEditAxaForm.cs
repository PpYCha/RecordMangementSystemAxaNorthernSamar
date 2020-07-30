using System;
using System.IO;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    public partial class AddEditAxaForm : Form
    {
        public AddEditAxaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEditAxaForm_Load(object sender, EventArgs e)
        {
            cb_AxaForms.DisplayMember = "Name";
            cb_AxaForms.ValueMember = "FullName";
            listBoxAXAFiles.DisplayMember = "Name";
            listBoxAXAFiles.ValueMember = "FullName";

            var AllFiles = new DirectoryInfo(Application.StartupPath + "\\AXA FORMS").GetDirectories();
            cb_AxaForms.Items.Clear();
            foreach (var f in AllFiles)
            {
                cb_AxaForms.Items.Add(f);
            }
        }



        private void cb_AxaForms_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_AxaForms.Text != "")
            {
                var AllFiles = new DirectoryInfo(Application.StartupPath + "\\AXA FORMS\\" + cb_AxaForms.Text).GetFiles();
                listBoxAXAFiles.Items.Clear();
                foreach (var f in AllFiles)
                {
                    listBoxAXAFiles.Items.Add(f);
                }
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            var input = GetInputText("");
            if (input != "")
            {
                try
                {
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\\AXA FORMS\\" + input);
                    MessageBox.Show("New Category added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AddEditAxaForm_Load(null, null);
                cb_AxaForms.Text = input;
            }
        }

        private String GetInputText(String settext)
        {
            ManageAXAForm_Subform form = new ManageAXAForm_Subform();
            form.input = settext;
            if (form.ShowDialog() == DialogResult.OK)
            {
                return form.input;
            }
            else
            {
                return "";
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (cb_AxaForms.Text != "")
            {
                if (MessageBox.Show(null, "Are you sure? Delete " + cb_AxaForms.Text, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.IO.Directory.Delete(Application.StartupPath + "\\AXA FORMS\\" + cb_AxaForms.Text, true);
                    AddEditAxaForm_Load(null, null);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (cb_AxaForms.Text != "")
            {
                if (MessageBox.Show(null, "Are you sure? Delete " + cb_AxaForms.Text, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.IO.Directory.Delete(Application.StartupPath + "\\AXA FORMS\\" + cb_AxaForms.Text, true);
                    AddEditAxaForm_Load(null, null);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_AxaForms.Text != "")
            {
                if (listBoxAXAFiles.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show(null, "Delete this " + listBoxAXAFiles.Text, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            var dir = Application.StartupPath + "\\AXA FORMS\\" + cb_AxaForms.Text + "\\" + listBoxAXAFiles.SelectedItem.ToString();
                            File.Delete(dir);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        cb_AxaForms_SelectedValueChanged(null, null);
                    }
                }
            }
        }

        private void bt_AddFile_Click(object sender, EventArgs e)
        {
            if (cb_AxaForms.Text != "")
            {
                OpenFileDialog opd = new OpenFileDialog();
                opd.Title = "Browse the form to be added.";
                opd.Filter = "All files (*.*)|*.*";
                opd.Multiselect = false;
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(opd.FileName, Application.StartupPath + "\\AXA FORMS\\" + cb_AxaForms.Text + "\\" + opd.SafeFileName);
                        MessageBox.Show("New AXA form added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    cb_AxaForms_SelectedValueChanged(null, null);
                }
            }
        }

        private void listBoxAXAFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
