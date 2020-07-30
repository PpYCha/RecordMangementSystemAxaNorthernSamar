using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    public partial class AddEditPlanClient : Form
    {

        public DataGridView dgvr;


        public AddEditPlanClient()
        {
            InitializeComponent();
        }

        private void AddEditPlanClient_Load(object sender, EventArgs e)
        {
            //LoadPlanDescription();
            LOadPlans();
        }

        private void LOadPlans()
        {
            using (AxaContext ctx = new AxaContext())
            {
                planBindingSource.DataSource = ctx.Plans.ToList();
            }
        }

        //private void LoadPlanDescription()
        //{
        //    using (AxaContext ctx = new AxaContext())
        //    {
        //        var classfication_List = ctx.Plans.ToList();


        //        cb_Description.DataSource = classfication_List;
        //        //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
        //        cb_Description.DisplayMember = "Description";
        //        cb_Description.ValueMember = "PlanIds";
        //        cb_Description.SelectedIndex = -1;


        //    }
        //}

        private void cb_ModeOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ModeOfPayment.SelectedIndex == 0)
            {
                label_Due.Text = "Monthly Due:";
            }
            else if (cb_ModeOfPayment.SelectedIndex == 1)
            {
                label_Due.Text = "Quarterly Due:";
            }
            else if (cb_ModeOfPayment.SelectedIndex == 2)
            {
                label_Due.Text = "Semi Anual Due:";
            }
            else if (cb_ModeOfPayment.SelectedIndex == 3)
            {
                label_Due.Text = "Anual Due:";
            }
            else
            {
                label_Due.Text = "Due:";
            }
        }

        private void dataGridView_LoadPlans_Click(object sender, EventArgs e)
        {

            tb_PlanType.Text = dataGridView_LoadPlans.SelectedRows[0].Cells[1].Value.ToString();
            tb_Category.Text = dataGridView_LoadPlans.SelectedRows[0].Cells[2].Value.ToString();
            tb_Description.Text = dataGridView_LoadPlans.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void bt_AddPlan_Click(object sender, EventArgs e)
        {

            int planId = Int32.Parse(dataGridView_LoadPlans.SelectedRows[0].Cells[0].Value.ToString());

            GetData(planId/*, tb_PolicyNo.Text, tb_SumInsured.Text, cb_ModeOfPayment.SelectedIndex.ToString(), tb_DuePayment.Text, tb_PlanType.Text, tb_Category.Text, tb_Description.Text*/);

            this.Close();
            this.Dispose();


        }

        public void GetData(int PlanId/*, string PolicyNo, string SumInsured, string ModeOfPayment, string Due, string PlanType, string Category, string Description*/)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int planId = Int32.Parse(dataGridView_LoadPlans.SelectedRows[0].Cells[0].Value.ToString());


            //dataGridView1.Rows.Add(planId, tb_PolicyNo.Text, tb_SumInsured.Text, cb_ModeOfPayment.SelectedIndex.ToString(), tb_DuePayment.Text, tb_PlanType.Text, tb_Category.Text, tb_Description.Text);
        }

        private void dataGridView_LoadPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
