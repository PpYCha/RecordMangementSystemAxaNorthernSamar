using RecordManagementSystemInAxaNSamar.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace RecordManagementSystemInAxaNSamar
{
    public partial class AddEditEmployee : Form
    {

        public AddEditEmployee()
        {
            InitializeComponent();
        }

        public DataGridViewRow dgvrAddEditEmployee;
        public DataGridViewRow dgvrListOfClients;
        private string fileName;
        private void bt_SaveEmployee_Click(object sender, System.EventArgs e)
        {
            SaveEmployee();
        }

        private void SaveEmployee()
        {

            if (dgvrAddEditEmployee == null)
            {
                try
                {

                    using (AxaContext ctx = new AxaContext())
                    {






                        var employee = new Employee
                        {
                            IdPicture = fileName,
                            ELastName = tb_LastName.Text,
                            EMiddleName = tb_MiddleName.Text,
                            EFirstName = tb_FirstName.Text,
                            BirthDate = dateTimePicker1.Value.Date,
                            Age = tb_Age.Text,
                            EmailAddress = tb_EmailAddress.Text,
                            Gender = cb_Gender.SelectedItem.ToString(),
                            CivilStatus = cb_CivilStatus.Text,
                            CellphoneNo = tb_CellphoneNo.Text,
                            Address = tb_Address.Text,
                            DesignatedPostion = cb_DisignatedPosition.SelectedItem.ToString(),

                        };

                        ctx.Employees.Add(employee);
                        ctx.SaveChanges();

                        MessageBox.Show("Save Successful");
                        this.Close();
                        this.Dispose();
                        // Clearfields();
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Save unSuccessful");

                }
            }
            else
            {
                try
                {
                    int tempEployeeId = Int32.Parse(dgvrAddEditEmployee.Cells[0].Value.ToString());


                    using (AxaContext ctx = new AxaContext())
                    {



                        var employeeUpdate = new Employee
                        {
                            EmployeeId = tempEployeeId,
                            IdPicture = fileName,
                            ELastName = tb_LastName.Text,
                            EMiddleName = tb_MiddleName.Text,
                            EFirstName = tb_FirstName.Text,
                            BirthDate = dateTimePicker1.Value.Date,
                            Age = tb_Age.Text,
                            EmailAddress = tb_EmailAddress.Text,
                            Gender = cb_Gender.SelectedItem.ToString(),
                            CivilStatus = cb_CivilStatus.Text,
                            CellphoneNo = tb_CellphoneNo.Text,
                            Address = tb_Address.Text,
                            DesignatedPostion = cb_DisignatedPosition.SelectedItem.ToString(),


                        };
                        ctx.Employees.Attach(employeeUpdate);
                        ctx.Entry(employeeUpdate).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();


                        MessageBox.Show("Update Successful");


                        this.Close();
                        this.Dispose();

                    }
                }
                catch
                {

                }


            }


        }

        private void Clearfields()
        {

            pictureBox1.Image = null;
            tb_LastName.Clear();
            tb_MiddleName.Clear();
            tb_FirstName.Clear();
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            tb_Age.Clear();
            tb_EmailAddress.Clear();
            cb_Gender.SelectedIndex = -1;
            cb_CivilStatus.SelectedIndex = -1;
            tb_CellphoneNo.Clear();
            tb_Address.Clear();
            cb_DisignatedPosition.SelectedIndex = -1;

            ;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Browse Image file for ID";
            opd.DefaultExt = "jpg";
            opd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            opd.Multiselect = false;
            if (opd.ShowDialog() == DialogResult.OK)
            {
                DateTime foo = DateTime.UtcNow;
                long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();
                fileName = unixTime + opd.SafeFileName;
                textBox1.Text = opd.SafeFileName;
                pictureBox1.Image = Image.FromFile(opd.FileName);


                File.Copy(opd.FileName, Application.StartupPath + "\\EmployeePicture\\" + fileName);



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

        private void tb_CellphoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumeric(sender, e);
        }

        private void tb_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumeric(sender, e);
        }

        private void AddEditEmployee_Load(object sender, System.EventArgs e)
        {
            if (dgvrAddEditEmployee == null)
            {

            }
            else
            {
                tb_LastName.Text = dgvrAddEditEmployee.Cells[1].Value.ToString();
                tb_MiddleName.Text = dgvrAddEditEmployee.Cells[2].Value.ToString();
                tb_FirstName.Text = dgvrAddEditEmployee.Cells[3].Value.ToString();
                //dateTimePicker1.Value = dgvrAddEditEmployee.Cells[4].Value.GetType();
                tb_Age.Text = dgvrAddEditEmployee.Cells[5].Value.ToString();
                tb_EmailAddress.Text = dgvrAddEditEmployee.Cells[1].Value.ToString();
                cb_Gender.Text = dgvrAddEditEmployee.Cells[7].Value.ToString();
                cb_CivilStatus.Text = dgvrAddEditEmployee.Cells[8].Value.ToString();
                tb_CellphoneNo.Text = dgvrAddEditEmployee.Cells[9].Value.ToString();
                tb_Address.Text = dgvrAddEditEmployee.Cells[10].Value.ToString();
                cb_DisignatedPosition.Text = dgvrAddEditEmployee.Cells[11].Value.ToString();
                //PopulateClientIDImage(dgvrAddEditEmployee.Cells[12].Value.ToString(), 1);
                string imagePath = Application.StartupPath + "\\EmployeePicture\\" + dgvrAddEditEmployee.Cells[12].Value.ToString();
                PopulateClientIDImage(imagePath, 1);


                loadListOfClients();

            }
        }

        private void loadListOfClients()
        {
            int tempEployeeId = Int32.Parse(dgvrAddEditEmployee.Cells[0].Value.ToString());

            using (AxaContext ctx = new AxaContext())
            {
                var result = from ee in ctx.Clients
                             where ee.EmployeeId == tempEployeeId
                             select new

                             {
                                 ee.CFirstName,
                                 ee.CMiddleName,
                                 ee.CLastName,

                             };

                dataGrid_ListClients.DataSource = result.ToList();
                dataGrid_ListClients.Columns[0].HeaderCell.Value = "First Name";
                dataGrid_ListClients.Columns[1].HeaderCell.Value = "Middle Name";
                dataGrid_ListClients.Columns[2].HeaderCell.Value = "Last Name";


            }
        }

        private string Copy_browsed_id(string sourcepath, long client_id, string _id)
        {
            try
            {
                if (_id == "1") { pictureBox1.Image.Dispose(); }

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

                else { }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PopulateClientIDImage(textBox1.Text, 1);
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
