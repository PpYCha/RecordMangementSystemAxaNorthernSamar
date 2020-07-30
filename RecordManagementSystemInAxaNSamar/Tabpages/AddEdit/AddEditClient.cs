using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    public partial class AddEditClient : Form
    {




        public AddEditClient()
        {
            InitializeComponent();



        }

        public Client selected_client { set; get; }
        public static int tempEmployeeId;
        public static string tempFinancialAdvisorName;
        public string action { get; set; }

        private void AddEditClient_Load(object sender, System.EventArgs e)
        {

            //tb_FinancialAdvisor.Text = tempFinancialAdvisorName;

            //if (this.action == "Edit")
            //{


            //populateClientBeneficiaries(selected_client.client_id);
            //}
            //else if (this.action == "Add")
            //{

            //}
            //else
            //{
            //    this.Close();
            //    this.Dispose();
            //}

            gb_IfMarried.Enabled = false;

            LoadPlanType();

        }

        private void populateClientPlans()
        {
            using (AxaContext ctx = new AxaContext())
            {


                var result = from e in ctx.ClientPlans

                             join d in ctx.Plans on e.PlanId equals d.PlanId

                             //into empDept

                             //from ed in empDept.DefaultIfEmpty()
                             where e.ClientId == 1

                             select new

                             {

                                 e.PolicyNo,
                                 e.SumInsured,
                                 e.ModeOfPayment,
                                 e.DueOfPayment,
                                 d.PlanType,
                                 d.Category,
                                 d.Description,

                             };



                clientPlanBindingSource.DataSource = ctx.ClientPlans.Where(x => x.ClientId == 1).ToList();
                //dataGridView_LoadPlans.Rows.Add("a", "aa", "aa");
                //dataGridView_LoadPlans.Rows.Add(result.ToList());

            }
        }

        private void LoadPlanType()
        {
            List<string> list = new List<string>();
            list.Add("Traditional");
            list.Add("Non-Traditional");
            list.Add("Variable");
            list.Add("Other");

            foreach (var item in list)
            {
                cb_PlanType.DataSource = list;
                //cb_PlanType.DisplayMember = "PlanType";
                //cb_PlanType.ValueMember = "PlanId";

            }
            cb_PlanType.SelectedIndex = -1;
            cb_Category.Enabled = false;
            cb_Description.Enabled = false;
        }

        private void cb_FinancialAdvisor_Format(object sender, ListControlConvertEventArgs e)
        {
            string lastname = ((Employee)e.ListItem).ELastName;
            string firstname = ((Employee)e.ListItem).EFirstName;
            string middlename = ((Employee)e.ListItem).EMiddleName;
            e.Value = lastname + ", " + firstname + " " + middlename;
        }

        private void bt_SaveAll_Click(object sender, System.EventArgs e)
        {
            SaveClient();

        }

        private void SaveClient()
        {
            //Add Client user
            using (AxaContext ctx = new AxaContext())
            {
                var clientInfo = new Client
                {
                    CLastName = tb_LastName.Text,
                    CMiddleName = tb_MiddleName.Text,
                    CFirstName = tb_FirstName.Text,
                    SpouseLastName = tb_SLastName.Text,
                    SpouseMiddleName = tb_SMiddleName.Text,
                    SpouseFirstName = tb_SFirstName.Text,
                    Gender = cb_Gender.Text,
                    CivilStatus = cb_CivilStatus.Text,
                    PolicyStatus = cb_PolicyStatus.Text,
                    CBirthday = dtp_Dob.Value,
                    Age = tb_Age.Text,
                    PlaceOfBirth = tb_PlaceOfBirth.Text,
                    Height = 11,
                    //Height = float.Parse(tb_Height.Text),
                    //Weight = float.Parse(tb_Weight.Text),
                    Weight = 11,
                    CAddress = tb_Address.Text,
                    CellphoneNo = tb_CellphoneNo.Text,
                    TelephoneNo = tb_TelephoneNo.Text,
                    EmailAddress = tb_EmailAddress.Text,
                    Occupation = tb_COccupation.Text,
                    //WorkSalary = float.Parse(tb_CWorkSalary.Text),
                    //BusinessIncome = float.Parse(tb_CBusinessIncome.Text),
                    //OtherSource = float.Parse(tb_COtherSource.Text),
                    WorkSalary = 11,
                    BusinessIncome = 11,
                    OtherSource = 11,
                    CompanyName = tb_CName.Text,
                    CompanyAddress = tb_CAddress.Text,
                    CompanyContact = tb_CompanyContactNo.Text,
                    NatureOfBusiness = tb_CNatureOfBusiness.Text,
                    TaxIdNumber = tb_TaxIdentication.Text,
                    Sss_gsisNumber = tb_SSSorGSIS_Number.Text,
                    ValidId1 = idPic1.Text,
                    ValidId2 = idPic2.Text,
                    //   EmployeeId = tempEmployeeId
                    EmployeeId = 1


                };
                ctx.Clients.Add(clientInfo);
                ctx.SaveChanges();


                // save client plan
                var clientPlan = new ClientPlan();
                for (int row = 0; row < dataGridView_LoadPlans.Rows.Count; row++)
                {
                    clientPlan.PolicyNo = dataGridView_LoadPlans.Rows[row].Cells["col_PolicyNo"].Value.ToString();
                    clientPlan.SumInsured = dataGridView_LoadPlans.Rows[row].Cells["col_SumInsured"].Value.ToString();
                    clientPlan.ModeOfPayment = dataGridView_LoadPlans.Rows[row].Cells["col_ModeOfPayment"].Value.ToString();
                    clientPlan.DueOfPayment = Int32.Parse(dataGridView_LoadPlans.Rows[row].Cells["col_DueOfPayment"].Value.ToString());


                    string tempPlanCategory = dataGridView_LoadPlans.Rows[row].Cells["col_PlanCategory"].Value.ToString();
                    string tempPlanAvail = dataGridView_LoadPlans.Rows[row].Cells["col_PlanAvail"].Value.ToString();
                    var tempPlanId = ctx.Plans.Where(x => x.Category == tempPlanCategory && x.Description == tempPlanAvail).Select(p => p.PlanId).FirstOrDefault().ToString();



                    clientPlan.PlanId = Convert.ToInt32(tempPlanId);
                    clientPlan.ClientId = clientInfo.ClientId;
                    ctx.ClientPlans.Add(clientPlan);
                    ctx.SaveChanges();
                }
            }
        }



        private void ClearAllFields()
        {

            tb_LastName.Clear();
            tb_Age.Clear();
            tb_EmailAddress.Clear();
            tb_CellphoneNo.Clear();
            tb_Height.Clear();
            cb_PolicyStatus.SelectedIndex = -1;
            tb_FirstName.Clear();
            tb_MiddleName.Clear();
            tb_PlaceOfBirth.Clear();
            tb_Address.Clear();
            tb_TelephoneNo.Clear();
            tb_Weight.Clear();
            cb_Gender.SelectedIndex = -1;
            cb_CivilStatus.SelectedIndex = -1;

            tb_SLastName.Clear();
            tb_SLastName.Clear();
            tb_SMiddleName.Clear();

            tb_COccupation.Clear();
            tb_CWorkSalary.Clear();
            tb_CBusinessIncome.Clear();
            tb_COtherSource.Clear();
            tb_CName.Clear();
            tb_CAddress.Clear();
            tb_CompanyContactNo.Clear();
            tb_CNatureOfBusiness.Clear();
            tb_TaxIdentication.Clear();
            tb_SSSorGSIS_Number.Clear();

        }

        private void cb_CivilStatus_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cb_CivilStatus.SelectedIndex == 0 || cb_CivilStatus.SelectedIndex == 2)
            {
                gb_IfMarried.Enabled = false;
            }
            else
            {
                gb_IfMarried.Enabled = true;
            }
        }

        private void tb_BSave_Click(object sender, EventArgs e)
        {
            AddBeneficiares();

            tb_BFirstName.Clear();
            tb_BMiddleName.Clear();
            tb_BLastName.Clear();
            tb_BBirthPlace.Clear();
            tb_BRelationship.Clear();
            tb_BOccupation.Clear();
            tb_PercentShare.Clear();
        }

        private void AddBeneficiares()
        {

            dataGridView_Beneficiares.Rows.Add(tb_BFirstName.Text, tb_BMiddleName.Text, tb_BLastName.Text, dtp_BDoB.Value.Date, tb_BBirthPlace.Text, tb_BRelationship.Text, tb_BOccupation.Text, tb_PercentShare.Text);
            MessageBox.Show("Succesfully Added");
        }


        private void bt_AddPlan_Click(object sender, EventArgs e)
        {
            string categroy = cb_Category.GetItemText(cb_Category.SelectedItem);

            string descr = cb_Description.GetItemText(cb_Description.SelectedItem);
            dataGridView_LoadPlans.Rows.Add(tb_PolicyNo.Text, tb_SumInsured.Text, cb_ModeOfPayment.Text, tb_DuePayment.Text, cb_PlanType.SelectedItem.ToString(), categroy, descr);


            ClearPlanFields();
            MessageBox.Show("Plan Succesfully Added");
        }

        private void ClearPlanFields()
        {
            tb_PolicyNo.Clear();
            tb_SumInsured.Clear();
            cb_ModeOfPayment.SelectedIndex = -1;
            tb_DuePayment.Clear();
            cb_PlanType.SelectedIndex = -1;
            cb_Category.SelectedIndex = -1;
            cb_Description.SelectedIndex = -1;

        }

        private void cb_PlanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                if (cb_PlanType.SelectedIndex == -1)
                {

                }
                else
                {

                    try
                    {
                        string tempPlan = cb_PlanType.SelectedItem.ToString();
                        var category_list = ctx.Plans.Where(x => x.PlanType == tempPlan).ToList();
                        cb_Category.DataSource = category_list;
                        //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
                        cb_Category.DisplayMember = "Category";
                        cb_Category.ValueMember = "PlanId";
                        cb_Category.SelectedIndex = -1;
                        cb_Category.SelectionLength = 0;
                        cb_Category.Enabled = true;
                        cb_Description.Enabled = false;
                    }
                    catch (Exception)
                    {

                    }

                }
            }
        }

        public void isNumeric(object sender, KeyPressEventArgs e)
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

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AxaContext ctx = new AxaContext())
            {
                var classfication_List = ctx.Plans.Where(x => x.Category == cb_Category.Text).ToList();



                cb_Description.DataSource = classfication_List;
                //cb_Course.Items.Add(cb_Course.DataSource = ctx.Courses.ToString());
                cb_Description.DisplayMember = "Description";
                cb_Description.ValueMember = "PlanId";
                cb_Description.SelectedIndex = -1;
                cb_Description.Enabled = true;


            }
        }

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

        private void dataGridView_LoadPlans_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bt_RemoveBeneficiares_Click(object sender, EventArgs e)
        {
            if (dataGridView_Beneficiares.SelectedRows.Count > 0)
            {
                try
                {
                    dataGridView_Beneficiares.Rows.RemoveAt(this.dataGridView_Beneficiares.SelectedRows[0].Index);
                    MessageBox.Show("Succesfully Remove");
                }
                catch (Exception)
                {

                }

            }
        }

        private string Copy_browsed_id(string sourcepath, long client_id, string _id)
        {
            try
            {
                if (_id == "1") { pictureBox1.Image.Dispose(); }
                else if (_id == "2") { pictureBox2.Image.Dispose(); }
                else { }
                string final_destination_path = Application.StartupPath + "\\ID_S\\" + client_id.ToString() + _id + DateTime.Now.Ticks.ToString() + ".jpeg";
                System.IO.File.Copy(sourcepath, final_destination_path, true);
                PopulateClientIDImage(final_destination_path, Int32.Parse(_id));
                return final_destination_path;
            }
            catch
            {
                return Application.StartupPath + "\\ID_S\\" + "DefaultID.jpeg";
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
                else if (_id == 2)
                {
                    pictureBox2.Image = Image.FromFile(id_path);
                }
                else { }
            }
        }

        private void bt_AddPicture1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Browse Image file for ID";
            opd.DefaultExt = "jpg";
            opd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            opd.Multiselect = false;
            if (opd.ShowDialog() == DialogResult.OK)
            {
                idPic1.Text = opd.FileName;

                pictureBox1.Image = Image.FromFile(opd.FileName);


            }
        }

        private void idPic1_TextChanged(object sender, EventArgs e)
        {
            PopulateClientIDImage(idPic1.Text, 1);
        }

        private void bt_AddPicutre2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Browse Image file for ID";
            opd.DefaultExt = "jpg";
            opd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            opd.Multiselect = false;
            if (opd.ShowDialog() == DialogResult.OK)
            {
                idPic2.Text = opd.FileName;
                pictureBox2.Image = Image.FromFile(opd.FileName);


            }
        }

        private void idPic2_TextChanged(object sender, EventArgs e)
        {
            PopulateClientIDImage(idPic2.Text, 2);
        }

        private void bt_RemovePlan_Click(object sender, EventArgs e)
        {
            if (dataGridView_LoadPlans.SelectedRows.Count > 0)
            {
                try
                {
                    dataGridView_LoadPlans.Rows.RemoveAt(this.dataGridView_LoadPlans.SelectedRows[0].Index);
                    MessageBox.Show("Succesfully Remove");
                }
                catch (Exception)
                {

                }

            }
        }





        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_Dob_ValueChanged(object sender, EventArgs e)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - dtp_Dob.Value.Year;

            // Go back to the year the person was born in case of a leap year
            if (dtp_Dob.Value.Date > today.AddYears(-age)) age--;

            tb_Age.Text = age.ToString();
        }

    }



}
