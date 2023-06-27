using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
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

        public static int selected_client;
        public static int selected_FinancialAdvisor;
        public static int tempEmployeeId;
        public static string tempFinancialAdvisorName;
        public static string action;
        private bool updatePlan = false;
        private bool updateB = false;

        private void AddEditClient_Load(object sender, System.EventArgs e)
        {
            tb_FinancialAdvisor.Text = tempFinancialAdvisorName;


            if (action == "Edit")
            {
                populateClient();
                populateClientPlans();
                populateBeneficiaries();

            }
            else if (action == "Add")
            {

            }


            gb_IfMarried.Enabled = false;

            LoadPlanType();

        }

        private void populateClient()
        {
            using (AxaContext ctx = new AxaContext())
            {
                var client = from p in ctx.Clients
                             where p.ClientId == selected_client
                             select new
                             {
                                 fname = p.CFirstName,
                                 mname = p.CMiddleName,
                                 lname = p.CLastName,
                                 sfname = p.SpouseFirstName,
                                 smname = p.SpouseMiddleName,
                                 sLname = p.SpouseLastName,
                                 gender = p.Gender,
                                 civilStatus = p.CivilStatus,
                                 poliycyStatus = p.PolicyStatus,
                                 cBirthday = p.CBirthday,
                                 age = p.Age,
                                 placeOfBirth = p.PlaceOfBirth,
                                 height = p.Height,
                                 weight = p.Weight,
                                 cAddress = p.CAddress,
                                 cellPhoneNo = p.CellphoneNo,
                                 telephoneNo = p.TelephoneNo,
                                 emailAddress = p.EmailAddress,
                                 occupation = p.Occupation,
                                 workSalary = p.WorkSalary,
                                 businessIncome = p.BusinessIncome,
                                 otherSource = p.OtherSource,
                                 companyName = p.CompanyName,
                                 companyAddress = p.CompanyAddress,
                                 companyContact = p.CompanyContact,
                                 natureOfBusiness = p.NatureOfBusiness,
                                 taxIdNumber = p.TaxIdNumber,
                                 sss_GsisNumber = p.Sss_gsisNumber,
                                 valid1 = p.ValidId1,
                                 valid2 = p.ValidId2,
                             };

                foreach (var c in client)
                {
                    tb_FirstName.Text = c.fname;
                    tb_MiddleName.Text = c.mname;
                    tb_LastName.Text = c.lname;
                    tb_SFirstName.Text = c.sfname;
                    tb_SMiddleName.Text = c.smname;
                    tb_SLastName.Text = c.sLname;
                    if (c.gender == "Male")
                    {
                        cb_Gender.SelectedIndex = 0;
                    }
                    if (c.gender == "Femail")
                    {
                        cb_Gender.SelectedIndex = 1;
                    }
                    switch (c.civilStatus)
                    {
                        case "Single":
                            cb_CivilStatus.SelectedIndex = 0;
                            break;
                        case "Married":
                            cb_CivilStatus.SelectedIndex = 1;
                            break;
                        case "Widowed":
                            cb_CivilStatus.SelectedIndex = 2;
                            break;
                    }
                    switch (c.poliycyStatus)
                    {
                        case "In Force":
                            break;
                        case "Auto Surrender":
                            break;
                        case "Lapse":
                            break;
                        case "Claim/ Insured Dead":
                            break;
                    }
                    dtp_Dob.Value = c.cBirthday;
                    tb_Age.Text = c.age;
                    tb_PlaceOfBirth.Text = c.placeOfBirth;
                    tb_Height.Text = c.height.ToString();
                    tb_Weight.Text = c.weight.ToString();
                    tb_Address.Text = c.cAddress;
                    tb_CellphoneNo.Text = c.cellPhoneNo;
                    tb_TelephoneNo.Text = c.telephoneNo;
                    tb_EmailAddress.Text = c.emailAddress;
                    tb_COccupation.Text = c.occupation;
                    tb_CWorkSalary.Text = c.workSalary.ToString();
                    tb_CBusinessIncome.Text = c.businessIncome.ToString();
                    tb_COtherSource.Text = c.otherSource.ToString();
                    tb_CName.Text = c.companyName;
                    tb_CAddress.Text = c.companyAddress;
                    tb_CompanyContactNo.Text = c.companyContact;
                    tb_CNatureOfBusiness.Text = c.natureOfBusiness;
                    tb_TaxIdentication.Text = c.taxIdNumber;
                    tb_SSSorGSIS_Number.Text = c.sss_GsisNumber;
                    idPic1.Text = c.valid1;
                    idPic2.Text = c.valid2;

                }

            }
        }

        private void populateBeneficiaries()
        {
            using (AxaContext ctx = new AxaContext())
            {
                var beneficiariesList = from p in ctx.ClientBeneficiaries
                                        where p.ClientId == selected_client
                                        select new
                                        {
                                            fn = p.BFirstName,
                                            mn = p.BMiddleName,
                                            ln = p.BLastName,
                                            bd = p.Birthday,
                                            bp = p.BirthPlace,
                                            r = p.Relationship,
                                            o = p.Occupation,
                                            s = p.Share
                                        };
                foreach (var item in beneficiariesList)
                {

                    dataGridView_Beneficiares.Rows.Add(item.fn, item.mn, item.ln, item.bd, item.bp, item.r, item.o, item.s);
                }
            }
        }

        private void populateClientPlans()
        {
            using (AxaContext ctx = new AxaContext())
            {
                var objList = from p in ctx.ClientPlans
                              join o in ctx.Plans
                              on p.PlanId equals o.PlanId
                              where p.ClientId == selected_client
                              select new
                              {
                                  pn = p.PolicyNo,
                                  si = p.SumInsured,
                                  mop = p.ModeOfPayment,
                                  dop = p.DueOfPayment,
                                  pt = o.PlanType,
                                  c = o.Category,
                                  d = o.Description

                              };

                foreach (var item in objList)
                {
                    dataGridView_LoadPlans.Rows.Add(item.pn, item.si, item.mop, item.dop, item.pt, item.c, item.d);
                }

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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (dataGridView_Beneficiares.Rows.Count == 0 || dataGridView_LoadPlans.Rows.Count == 0)
                {
                    MessageBox.Show("Dont forget add Plan or Beneficiaries");
                }
                else
                {
                    SaveClient();
                }
            }
        }

        private void SaveClient()
        {
            //Add Client user
            using (AxaContext ctx = new AxaContext())
            {
                if (action.Contains("Add"))
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
                        Height = float.Parse(tb_Height.Text),
                        Weight = float.Parse(tb_Weight.Text),

                        CAddress = tb_Address.Text,
                        CellphoneNo = tb_CellphoneNo.Text,
                        TelephoneNo = tb_TelephoneNo.Text,
                        EmailAddress = tb_EmailAddress.Text,
                        Occupation = tb_COccupation.Text,
                        WorkSalary = float.Parse(tb_CWorkSalary.Text),
                        BusinessIncome = float.Parse(tb_CBusinessIncome.Text),
                        OtherSource = float.Parse(tb_COtherSource.Text),
                        //WorkSalary = 11,
                        //BusinessIncome = 11,
                        //OtherSource = 11,
                        CompanyName = tb_CName.Text,
                        CompanyAddress = tb_CAddress.Text,
                        CompanyContact = tb_CompanyContactNo.Text,
                        NatureOfBusiness = tb_CNatureOfBusiness.Text,
                        TaxIdNumber = tb_TaxIdentication.Text,
                        Sss_gsisNumber = tb_SSSorGSIS_Number.Text,
                        ValidId1 = idPic1.Text,
                        ValidId2 = idPic2.Text,
                        EmployeeId = tempEmployeeId



                    };
                    ctx.Clients.Add(clientInfo);
                    ctx.SaveChanges();


                    // save client plan
                    var clientPlan = new ClientPlan();
                    foreach (DataGridViewRow item in dataGridView_LoadPlans.Rows)
                    {


                        clientPlan.PolicyNo = item.Cells["col_PolicyNo"].Value.ToString();
                        clientPlan.SumInsured = item.Cells["col_SumInsured"].Value.ToString();
                        clientPlan.ModeOfPayment = item.Cells["col_ModeOfPayment"].Value.ToString();
                        clientPlan.DueOfPayment = Int32.Parse(item.Cells["col_DueOfPayment"].Value.ToString());


                        string tempPlanCategory = item.Cells["col_PlanCategory"].Value.ToString();
                        string tempPlanAvail = item.Cells["col_PlanAvail"].Value.ToString();
                        var tempPlanId = ctx.Plans.Where(x => x.Category == tempPlanCategory && x.Description == tempPlanAvail).Select(p => p.PlanId).FirstOrDefault().ToString();



                        clientPlan.PlanId = Convert.ToInt32(tempPlanId);
                        clientPlan.ClientId = clientInfo.ClientId;

                        ctx.ClientPlans.Add(clientPlan);
                        ctx.SaveChanges();
                    }

                    //Save Beneficiaries
                    var clientBeneficiaries = new ClientBeneficiaries();
                    foreach (DataGridViewRow row in dataGridView_Beneficiares.Rows)
                    {
                        clientBeneficiaries.BFirstName = row.Cells["Column8"].Value.ToString();
                        clientBeneficiaries.BMiddleName = row.Cells["Column9"].Value.ToString();
                        clientBeneficiaries.BLastName = row.Cells["Column10"].Value.ToString();
                        clientBeneficiaries.Birthday = row.Cells["Column11"].Value.ToString();
                        clientBeneficiaries.BirthPlace = row.Cells["Column12"].Value.ToString();
                        clientBeneficiaries.Relationship = row.Cells["Column13"].Value.ToString();
                        clientBeneficiaries.Occupation = row.Cells["Column14"].Value.ToString();
                        clientBeneficiaries.Share = float.Parse(row.Cells["Column15"].Value.ToString());

                        clientBeneficiaries.ClientId = clientInfo.ClientId;
                        ctx.ClientBeneficiaries.Add(clientBeneficiaries);
                        ctx.SaveChanges();
                    }

                    MessageBox.Show("Added Succesfully");
                }

                //Update Client Info
                else if (action.Contains("Edit"))
                {
                    var clientInfo = new Client
                    {
                        ClientId = selected_client,
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
                        Height = float.Parse(tb_Height.Text),
                        Weight = float.Parse(tb_Weight.Text),

                        CAddress = tb_Address.Text,
                        CellphoneNo = tb_CellphoneNo.Text,
                        TelephoneNo = tb_TelephoneNo.Text,
                        EmailAddress = tb_EmailAddress.Text,
                        Occupation = tb_COccupation.Text,
                        WorkSalary = float.Parse(tb_CWorkSalary.Text),
                        BusinessIncome = float.Parse(tb_CBusinessIncome.Text),
                        OtherSource = float.Parse(tb_COtherSource.Text),
                        //WorkSalary = 11,
                        //BusinessIncome = 11,
                        //OtherSource = 11,
                        CompanyName = tb_CName.Text,
                        CompanyAddress = tb_CAddress.Text,
                        CompanyContact = tb_CompanyContactNo.Text,
                        NatureOfBusiness = tb_CNatureOfBusiness.Text,
                        TaxIdNumber = tb_TaxIdentication.Text,
                        Sss_gsisNumber = tb_SSSorGSIS_Number.Text,
                        ValidId1 = idPic1.Text,
                        ValidId2 = idPic2.Text,
                        EmployeeId = selected_FinancialAdvisor



                    };
                    ctx.Clients.Attach(clientInfo);
                    ctx.Entry(clientInfo).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();


                    // update client plan
                    var clientPlan = new ClientPlan();
                    foreach (DataGridViewRow item in dataGridView_LoadPlans.Rows)
                    {
                        string pnTest = item.Cells["col_PolicyNo"].Value.ToString();
                        //var checkPlan = from o in ctx.ClientPlans
                        //                where pnTest == o.PolicyNo && o.ClientId == selected_client
                        //                select new { pn = o.PolicyNo };

                        if (!(ctx.ClientPlans.Any(x => x.PolicyNo == pnTest)))
                        {
                            clientPlan.PolicyNo = item.Cells["col_PolicyNo"].Value.ToString();
                            clientPlan.SumInsured = item.Cells["col_SumInsured"].Value.ToString();
                            clientPlan.ModeOfPayment = item.Cells["col_ModeOfPayment"].Value.ToString();
                            clientPlan.DueOfPayment = Int32.Parse(item.Cells["col_DueOfPayment"].Value.ToString());


                            string tempPlanCategory = item.Cells["col_PlanCategory"].Value.ToString();
                            string tempPlanAvail = item.Cells["col_PlanAvail"].Value.ToString();
                            var tempPlanId = ctx.Plans.Where(x => x.Category == tempPlanCategory && x.Description == tempPlanAvail).Select(p => p.PlanId).FirstOrDefault().ToString();



                            clientPlan.PlanId = Convert.ToInt32(tempPlanId);
                            clientPlan.ClientId = selected_client;

                            ctx.ClientPlans.Add(clientPlan);
                            ctx.SaveChanges();

                        }
                        else
                        {

                            string tempPlanCategory = item.Cells["col_PlanCategory"].Value.ToString();
                            string tempPlanAvail = item.Cells["col_PlanAvail"].Value.ToString();
                            string tempPolicyNumber = item.Cells["col_PolicyNo"].Value.ToString();
                            var tempPlanId = ctx.Plans.Where(x => x.Category == tempPlanCategory && x.Description == tempPlanAvail)
                                                      .Select(p => p.PlanId).FirstOrDefault();


                            var ClientPlanId = ctx.ClientPlans.Where(x => x.PolicyNo == tempPolicyNumber)
                                                     .Select(p => p.ClientPlanId).FirstOrDefault();


                            var planTest = new ClientPlan
                            {
                                ClientPlanId = ClientPlanId,
                                PolicyNo = item.Cells["col_PolicyNo"].Value.ToString(),
                                SumInsured = item.Cells["col_SumInsured"].Value.ToString(),
                                ModeOfPayment = item.Cells["col_ModeOfPayment"].Value.ToString(),
                                DueOfPayment = Int32.Parse(item.Cells["col_DueOfPayment"].Value.ToString()),
                                PlanId = tempPlanId,
                                ClientId = selected_client


                            };

                            //clientPlan.PolicyNo = item.Cells["col_PolicyNo"].Value.ToString();
                            //clientPlan.SumInsured = item.Cells["col_SumInsured"].Value.ToString();
                            //clientPlan.ModeOfPayment = item.Cells["col_ModeOfPayment"].Value.ToString();
                            //clientPlan.DueOfPayment = Int32.Parse(item.Cells["col_DueOfPayment"].Value.ToString());




                            //clientPlan.PlanId = Convert.ToInt32(tempPlanId);
                            // clientPlan.ClientId = clientInfo.ClientId;


                            ctx.ClientPlans.Attach(planTest);
                            ctx.Entry(planTest).State = System.Data.Entity.EntityState.Modified;
                            ctx.SaveChanges();

                        }


                    }

                    //Update Client Benificiaries
                    var clientBeneficiaries = new ClientBeneficiaries();
                    foreach (DataGridViewRow itemBenefiCiaries in dataGridView_Beneficiares.Rows)
                    {
                        string fname = itemBenefiCiaries.Cells["Column8"].Value.ToString();
                        string mname = itemBenefiCiaries.Cells["Column9"].Value.ToString();
                        string lname = itemBenefiCiaries.Cells["Column10"].Value.ToString();


                        if (!(ctx.ClientBeneficiaries.Any(x => x.BFirstName == fname && x.BMiddleName == mname && x.BLastName == lname)))
                        {
                            clientBeneficiaries.BFirstName = itemBenefiCiaries.Cells["Column8"].Value.ToString();
                            clientBeneficiaries.BMiddleName = itemBenefiCiaries.Cells["Column9"].Value.ToString();
                            clientBeneficiaries.BLastName = itemBenefiCiaries.Cells["Column10"].Value.ToString();
                            clientBeneficiaries.Birthday = (itemBenefiCiaries.Cells["Column11"].Value.ToString());
                            clientBeneficiaries.BirthPlace = (itemBenefiCiaries.Cells["Column12"].Value.ToString());
                            clientBeneficiaries.Relationship = (itemBenefiCiaries.Cells["Column13"].Value.ToString());
                            clientBeneficiaries.Occupation = (itemBenefiCiaries.Cells["Column14"].Value.ToString());
                            clientBeneficiaries.Share = Int32.Parse(itemBenefiCiaries.Cells["Column15"].Value.ToString());

                            clientBeneficiaries.ClientId = selected_client;
                            ctx.ClientBeneficiaries.Add(clientBeneficiaries);
                            ctx.SaveChanges();

                        }
                        else
                        {

                            var beneficiareId = ctx.ClientBeneficiaries.Where(x => x.BFirstName == fname && x.BMiddleName == mname && x.BLastName == lname).Select(p => p.ClientBeneficiaresId).FirstOrDefault().ToString();

                            clientBeneficiaries.BFirstName = itemBenefiCiaries.Cells["Column8"].Value.ToString();
                            clientBeneficiaries.BMiddleName = itemBenefiCiaries.Cells["Column9"].Value.ToString();
                            clientBeneficiaries.BLastName = itemBenefiCiaries.Cells["Column10"].Value.ToString();
                            clientBeneficiaries.Birthday = (itemBenefiCiaries.Cells["Column11"].Value.ToString());
                            clientBeneficiaries.BirthPlace = (itemBenefiCiaries.Cells["Column12"].Value.ToString());
                            clientBeneficiaries.Relationship = (itemBenefiCiaries.Cells["Column13"].Value.ToString());
                            clientBeneficiaries.Occupation = (itemBenefiCiaries.Cells["Column14"].Value.ToString());
                            clientBeneficiaries.Share = Int32.Parse(itemBenefiCiaries.Cells["Column15"].Value.ToString());
                            clientBeneficiaries.ClientBeneficiaresId = Int32.Parse(beneficiareId);
                            clientBeneficiaries.ClientId = selected_client;



                            ctx.ClientBeneficiaries.Attach(clientBeneficiaries);
                            ctx.Entry(clientBeneficiaries).State = System.Data.Entity.EntityState.Modified;
                            ctx.SaveChanges();

                        }
                    }

                }
            }
            MessageBox.Show("Update Succesfully");
            this.Close();
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
            try
            {


                if (updateB == true)
                {
                    dataGridView_Beneficiares.SelectedRows[0].Cells[0].Value = tb_BFirstName.Text;
                    dataGridView_Beneficiares.SelectedRows[0].Cells[1].Value = tb_BMiddleName.Text;
                    dataGridView_Beneficiares.SelectedRows[0].Cells[2].Value = tb_BLastName.Text;
                    dataGridView_Beneficiares.SelectedRows[0].Cells[3].Value = dtp_BDoB.Value.Date;
                    dataGridView_Beneficiares.SelectedRows[0].Cells[4].Value = tb_BBirthPlace.Text;
                    dataGridView_Beneficiares.SelectedRows[0].Cells[5].Value = tb_BRelationship.Text;
                    dataGridView_Beneficiares.SelectedRows[0].Cells[6].Value = tb_BOccupation.Text;
                    dataGridView_Beneficiares.SelectedRows[0].Cells[7].Value = tb_PercentShare.Text;
                    updateB = false;
                    MessageBox.Show("Succesfully Updated");
                }
                else if (updateB == false)
                {
                    if (true)
                    {

                    }
                    dataGridView_Beneficiares.Rows.Add(tb_BFirstName.Text, tb_BMiddleName.Text, tb_BLastName.Text, dtp_BDoB.Value.Date, tb_BBirthPlace.Text, tb_BRelationship.Text, tb_BOccupation.Text, tb_PercentShare.Text);
                    MessageBox.Show("Succesfully Added");
                }
            }
            catch (Exception)
            {


            }
        }


        private void bt_AddPlan_Click(object sender, EventArgs e)
        {
            if (updatePlan == true)
            {
                try
                {


                    string categroy = cb_Category.GetItemText(cb_Category.SelectedItem);

                    string descr = cb_Description.GetItemText(cb_Description.SelectedItem);


                    dataGridView_LoadPlans.SelectedRows[0].Cells[0].Value = tb_PolicyNo.Text;
                    dataGridView_LoadPlans.SelectedRows[0].Cells[1].Value = tb_SumInsured.Text;
                    dataGridView_LoadPlans.SelectedRows[0].Cells[2].Value = cb_ModeOfPayment.Text;
                    dataGridView_LoadPlans.SelectedRows[0].Cells[3].Value = tb_DuePayment.Text;
                    dataGridView_LoadPlans.SelectedRows[0].Cells[4].Value = cb_PlanType.SelectedItem.ToString();
                    dataGridView_LoadPlans.SelectedRows[0].Cells[5].Value = categroy;
                    dataGridView_LoadPlans.SelectedRows[0].Cells[6].Value = descr;
                    updatePlan = false;
                    MessageBox.Show("Plan Succesfully Updated");
                }
                catch (Exception)
                {


                }
            }
            else if (updatePlan == false)

            {

                try
                {


                    string categroy = cb_Category.GetItemText(cb_Category.SelectedItem);

                    string descr = cb_Description.GetItemText(cb_Description.SelectedItem);
                    dataGridView_LoadPlans.Rows.Add(tb_PolicyNo.Text, tb_SumInsured.Text, cb_ModeOfPayment.Text, tb_DuePayment.Text, cb_PlanType.SelectedItem.ToString(), categroy, descr);


                    ClearPlanFields();
                    MessageBox.Show("Plan Succesfully Added");
                }
                catch (Exception)
                {


                }
            }
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

        private void dataGridView_LoadPlans_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_LoadPlans.SelectedRows.Count > 0)
            {
                tb_PolicyNo.Text = dataGridView_LoadPlans.SelectedRows[0].Cells["col_PolicyNo"].Value.ToString();
                tb_SumInsured.Text = dataGridView_LoadPlans.SelectedRows[0].Cells["col_SumInsured"].Value.ToString();
                cb_ModeOfPayment.Text = dataGridView_LoadPlans.SelectedRows[0].Cells["col_ModeOfPayment"].Value.ToString();
                tb_DuePayment.Text = dataGridView_LoadPlans.SelectedRows[0].Cells["col_DueOfPayment"].Value.ToString();
                cb_PlanType.Text = dataGridView_LoadPlans.SelectedRows[0].Cells["col_PlanType"].Value.ToString();
                cb_Category.Text = dataGridView_LoadPlans.SelectedRows[0].Cells["col_PlanCategory"].Value.ToString();
                cb_Description.Text = dataGridView_LoadPlans.SelectedRows[0].Cells["col_PlanAvail"].Value.ToString();

                updatePlan = true;
            }
        }

        private void dataGridView_Beneficiares_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Beneficiares.SelectedRows.Count > 0)
            {
                tb_BFirstName.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column8"].Value.ToString();
                tb_BMiddleName.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column9"].Value.ToString();
                tb_BLastName.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column10"].Value.ToString();
                dtp_BDoB.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column11"].Value.ToString();
                tb_BBirthPlace.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column12"].Value.ToString();
                tb_BRelationship.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column13"].Value.ToString();
                tb_BOccupation.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column14"].Value.ToString();
                tb_PercentShare.Text = dataGridView_Beneficiares.SelectedRows[0].Cells["Column15"].Value.ToString();
                updateB = true;

            }
        }

        private void tb_PolicyNo_TextChanged(object sender, EventArgs e)
        {

            if (tb_PolicyNo.Text.Length > 3 && !(tb_PolicyNo.Text.Contains("-")))
            {
                string digits = tb_PolicyNo.Text;
                tb_PolicyNo.Text = digits.Insert(3, "-");
                tb_PolicyNo.Focus();
                tb_PolicyNo.SelectionStart = tb_PolicyNo.Text.Length;

            }
        }

        private void tb_PolicyNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {


                if (e.KeyCode == Keys.Back)
                {

                    tb_PolicyNo.Text = tb_PolicyNo.Text.Remove(tb_PolicyNo.Text.Length - 1, 1);
                    tb_PolicyNo.SelectionStart = tb_PolicyNo.Text.Length;

                }
            }
            catch (Exception)
            {


            }
        }



        private void ValidateTextbox(object sender, System.ComponentModel.CancelEventArgs e, TextBox textBox)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "Don't leave it blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
        }

        private void tb_LastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextbox(sender, e, tb_LastName);
        }

        private void tb_FirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextbox(sender, e, tb_FirstName);
        }

        private void tb_MiddleName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextbox(sender, e, tb_MiddleName);
        }

        private void tb_PlaceOfBirth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextbox(sender, e, tb_PlaceOfBirth);
        }

        private void tb_EmailAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextbox(sender, e, tb_EmailAddress);
        }


        private void tb_Address_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextbox(sender, e, tb_Address);
        }

        private void tb_CellphoneNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTextbox(sender, e, tb_CellphoneNo);
        }
    }
}
