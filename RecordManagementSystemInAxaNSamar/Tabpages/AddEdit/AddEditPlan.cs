using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    public partial class AddEditPlan : Form
    {
        public AddEditPlan()
        {
            InitializeComponent();
        }

        //private DataGridViewRow tempIdplan;

        private void AddEditPlan_Load(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                planBindingSource.DataSource = ctx.Plans.ToList();
            }

            dataGridView_Plan.ClearSelection();
        }






        private void bt_SavePlan_Click(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                if (tb_Description.Text == "")
                {
                    MessageBox.Show("Please filled up all fields");
                }
                else
                {


                    if (dataGridView_Plan.SelectedRows.Count > 0)
                    {
                        int tempIdplan = Int32.Parse(dataGridView_Plan.SelectedRows[0].Cells[0].Value.ToString());

                        var planUpdate = new Plan
                        {
                            PlanId = tempIdplan,
                            Description = tb_Description.Text,
                            PlanType = cb_PlanType.SelectedItem.ToString(),
                            Category = cb_PlanCategory.SelectedItem.ToString(),
                        };

                        ctx.Plans.Attach(planUpdate);
                        ctx.Entry(planUpdate).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                        ClearTextField();
                        AddEditPlan_Load(null, null);
                        MessageBox.Show("Plan Succesfully Updated");
                    }
                    else
                    {
                        var plan = new Plan
                        {
                            Description = tb_Description.Text,
                            PlanType = cb_PlanType.SelectedItem.ToString(),
                            Category = cb_PlanCategory.SelectedItem.ToString(),
                        };

                        ctx.Plans.Add(plan);
                        ctx.SaveChanges();
                        ClearTextField();
                        AddEditPlan_Load(null, null);
                        MessageBox.Show("Plan SUccesfully Added");
                    }

                }
            }
        }

        private void ClearTextField()
        {
            tb_Description.Clear();
            cb_PlanType.SelectedIndex = -1;
            cb_PlanCategory.SelectedIndex = -1;
        }

        private void dataGridView_Plan_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Plan.SelectedRows.Count > 0)
            {
                tb_Description.Text = dataGridView_Plan.SelectedRows[0].Cells[1].Value.ToString();
                cb_PlanType.Text = dataGridView_Plan.SelectedRows[0].Cells[2].Value.ToString();
                cb_PlanCategory.Text = dataGridView_Plan.SelectedRows[0].Cells[3].Value.ToString();
            }
        }



        private void AddEditPlan_Click(object sender, EventArgs e)
        {
            dataGridView_Plan.ClearSelection();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
