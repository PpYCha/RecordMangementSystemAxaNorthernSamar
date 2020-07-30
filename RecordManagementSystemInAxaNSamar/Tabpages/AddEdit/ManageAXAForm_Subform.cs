using System;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    public partial class ManageAXAForm_Subform : Form
    {
        public string input { get; set; }
        public ManageAXAForm_Subform()
        {
            InitializeComponent();
        }

        private void ManageAXAForm_Subform_Load(object sender, EventArgs e)
        {
            textBoxCategory.Text = input;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            input = textBoxCategory.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
