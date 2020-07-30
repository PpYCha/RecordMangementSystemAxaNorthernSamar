namespace RecordManagementSystemInAxaNSamar
{
    partial class EmployeesProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesProfile));
            this.tb_SearchEmployee = new System.Windows.Forms.TextBox();
            this.dataGridView_ListOfEmployee = new System.Windows.Forms.DataGridView();
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl_EmployessProfile = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse_EmployeeProfile = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_SaveUser = new System.Windows.Forms.Button();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designatedPostionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_SearchEmployee
            // 
            this.tb_SearchEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_SearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchEmployee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchEmployee.Location = new System.Drawing.Point(29, 50);
            this.tb_SearchEmployee.Multiline = true;
            this.tb_SearchEmployee.Name = "tb_SearchEmployee";
            this.tb_SearchEmployee.Size = new System.Drawing.Size(503, 37);
            this.tb_SearchEmployee.TabIndex = 9;
            this.tb_SearchEmployee.TextChanged += new System.EventHandler(this.tb_SearchEmployee_TextChanged);
            this.tb_SearchEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SearchEmployee_KeyDown);
            // 
            // dataGridView_ListOfEmployee
            // 
            this.dataGridView_ListOfEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView_ListOfEmployee.AutoGenerateColumns = false;
            this.dataGridView_ListOfEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListOfEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.eFirstNameDataGridViewTextBoxColumn,
            this.eMiddleNameDataGridViewTextBoxColumn,
            this.eLastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.civilStatusDataGridViewTextBoxColumn,
            this.cellphoneNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.designatedPostionDataGridViewTextBoxColumn,
            this.idPictureDataGridViewImageColumn,
            this.clientDataGridViewTextBoxColumn});
            this.dataGridView_ListOfEmployee.DataSource = this.employeeBindingSource;
            this.dataGridView_ListOfEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_ListOfEmployee.Location = new System.Drawing.Point(29, 126);
            this.dataGridView_ListOfEmployee.Name = "dataGridView_ListOfEmployee";
            this.dataGridView_ListOfEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListOfEmployee.Size = new System.Drawing.Size(784, 356);
            this.dataGridView_ListOfEmployee.TabIndex = 10;
            this.dataGridView_ListOfEmployee.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_ListOfEmployee_DataError);
            this.dataGridView_ListOfEmployee.DoubleClick += new System.EventHandler(this.dataGridView_ListOfEmployee_DoubleClick);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(834, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(48, 48);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 25;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click_1);
            // 
            // bunifuDragControl_EmployessProfile
            // 
            this.bunifuDragControl_EmployessProfile.Fixed = true;
            this.bunifuDragControl_EmployessProfile.Horizontal = true;
            this.bunifuDragControl_EmployessProfile.TargetControl = this;
            this.bunifuDragControl_EmployessProfile.Vertical = true;
            // 
            // bunifuElipse_EmployeeProfile
            // 
            this.bunifuElipse_EmployeeProfile.ElipseRadius = 15;
            this.bunifuElipse_EmployeeProfile.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.find_user_male_32px;
            this.pictureBox1.Location = new System.Drawing.Point(498, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_Search
            // 
            this.lb_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Search.BackColor = System.Drawing.Color.White;
            this.lb_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.Location = new System.Drawing.Point(38, 58);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(315, 23);
            this.lb_Search.TabIndex = 27;
            this.lb_Search.Text = "Search Username, Lastname, Firstname && press Enter";
            this.lb_Search.Click += new System.EventHandler(this.lb_Search_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "List of Employees:";
            // 
            // bt_SaveUser
            // 
            this.bt_SaveUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_SaveUser.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_SaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveUser.ForeColor = System.Drawing.Color.White;
            this.bt_SaveUser.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.add_user_male_32px;
            this.bt_SaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SaveUser.Location = new System.Drawing.Point(547, 50);
            this.bt_SaveUser.Margin = new System.Windows.Forms.Padding(0);
            this.bt_SaveUser.Name = "bt_SaveUser";
            this.bt_SaveUser.Size = new System.Drawing.Size(134, 37);
            this.bt_SaveUser.TabIndex = 30;
            this.bt_SaveUser.Text = "ADD EMPLOYEE";
            this.bt_SaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_SaveUser.UseVisualStyleBackColor = false;
            this.bt_SaveUser.Click += new System.EventHandler(this.bt_SaveUser_Click);
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // eFirstNameDataGridViewTextBoxColumn
            // 
            this.eFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EFirstName";
            this.eFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.eFirstNameDataGridViewTextBoxColumn.Name = "eFirstNameDataGridViewTextBoxColumn";
            // 
            // eMiddleNameDataGridViewTextBoxColumn
            // 
            this.eMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "EMiddleName";
            this.eMiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.eMiddleNameDataGridViewTextBoxColumn.Name = "eMiddleNameDataGridViewTextBoxColumn";
            // 
            // eLastNameDataGridViewTextBoxColumn
            // 
            this.eLastNameDataGridViewTextBoxColumn.DataPropertyName = "ELastName";
            this.eLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.eLastNameDataGridViewTextBoxColumn.Name = "eLastNameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // civilStatusDataGridViewTextBoxColumn
            // 
            this.civilStatusDataGridViewTextBoxColumn.DataPropertyName = "CivilStatus";
            this.civilStatusDataGridViewTextBoxColumn.HeaderText = "CivilStatus";
            this.civilStatusDataGridViewTextBoxColumn.Name = "civilStatusDataGridViewTextBoxColumn";
            this.civilStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // cellphoneNoDataGridViewTextBoxColumn
            // 
            this.cellphoneNoDataGridViewTextBoxColumn.DataPropertyName = "CellphoneNo";
            this.cellphoneNoDataGridViewTextBoxColumn.HeaderText = "CellphoneNo";
            this.cellphoneNoDataGridViewTextBoxColumn.Name = "cellphoneNoDataGridViewTextBoxColumn";
            this.cellphoneNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // designatedPostionDataGridViewTextBoxColumn
            // 
            this.designatedPostionDataGridViewTextBoxColumn.DataPropertyName = "DesignatedPostion";
            this.designatedPostionDataGridViewTextBoxColumn.HeaderText = "Designated Postion";
            this.designatedPostionDataGridViewTextBoxColumn.Name = "designatedPostionDataGridViewTextBoxColumn";
            // 
            // idPictureDataGridViewImageColumn
            // 
            this.idPictureDataGridViewImageColumn.DataPropertyName = "IdPicture";
            this.idPictureDataGridViewImageColumn.HeaderText = "IdPicture";
            this.idPictureDataGridViewImageColumn.Name = "idPictureDataGridViewImageColumn";
            this.idPictureDataGridViewImageColumn.Visible = false;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.Employee);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.Client);
            // 
            // EmployeesProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 485);
            this.Controls.Add(this.bt_SaveUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.dataGridView_ListOfEmployee);
            this.Controls.Add(this.tb_SearchEmployee);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTS RECORDS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_SearchEmployee;
        private System.Windows.Forms.DataGridView dataGridView_ListOfEmployee;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl_EmployessProfile;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_EmployeeProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_SaveUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designatedPostionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn idPictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
    }
}