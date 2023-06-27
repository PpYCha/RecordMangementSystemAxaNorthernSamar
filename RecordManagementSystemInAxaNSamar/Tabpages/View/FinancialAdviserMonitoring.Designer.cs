namespace RecordManagementSystemInAxaNSamar.Tabpages.View
{
    partial class FinancialAdviserMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialAdviserMonitoring));
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ViewClientInformation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FAName = new System.Windows.Forms.Label();
            this.dataGridView_ListOfClients = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_SaveUser = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_SearchEmployee = new System.Windows.Forms.TextBox();
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl_FA = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(259, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "List of Clients:";
            // 
            // bt_ViewClientInformation
            // 
            this.bt_ViewClientInformation.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_ViewClientInformation.FlatAppearance.BorderSize = 0;
            this.bt_ViewClientInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ViewClientInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ViewClientInformation.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.information_32px;
            this.bt_ViewClientInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ViewClientInformation.Location = new System.Drawing.Point(1, 245);
            this.bt_ViewClientInformation.Name = "bt_ViewClientInformation";
            this.bt_ViewClientInformation.Size = new System.Drawing.Size(259, 52);
            this.bt_ViewClientInformation.TabIndex = 0;
            this.bt_ViewClientInformation.Text = "VIEW CLIENT INFORMATION";
            this.bt_ViewClientInformation.UseVisualStyleBackColor = false;
            this.bt_ViewClientInformation.Click += new System.EventHandler(this.bt_ViewClientInformation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "FINANCIAL ADVISOR DASHBOARD";
            // 
            // FAName
            // 
            this.FAName.BackColor = System.Drawing.Color.White;
            this.FAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAName.Location = new System.Drawing.Point(25, 165);
            this.FAName.Name = "FAName";
            this.FAName.Size = new System.Drawing.Size(188, 16);
            this.FAName.TabIndex = 11;
            this.FAName.Text = "display here the name of the FA selected";
            // 
            // dataGridView_ListOfClients
            // 
            this.dataGridView_ListOfClients.AllowUserToAddRows = false;
            this.dataGridView_ListOfClients.AllowUserToDeleteRows = false;
            this.dataGridView_ListOfClients.AutoGenerateColumns = false;
            this.dataGridView_ListOfClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListOfClients.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView_ListOfClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.cFirstNameDataGridViewTextBoxColumn,
            this.cMiddleNameDataGridViewTextBoxColumn,
            this.cLastNameDataGridViewTextBoxColumn});
            this.dataGridView_ListOfClients.DataSource = this.clientBindingSource;
            this.dataGridView_ListOfClients.Location = new System.Drawing.Point(263, 184);
            this.dataGridView_ListOfClients.Name = "dataGridView_ListOfClients";
            this.dataGridView_ListOfClients.ReadOnly = true;
            this.dataGridView_ListOfClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListOfClients.Size = new System.Drawing.Size(693, 363);
            this.dataGridView_ListOfClients.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // bt_SaveUser
            // 
            this.bt_SaveUser.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_SaveUser.FlatAppearance.BorderSize = 0;
            this.bt_SaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SaveUser.ForeColor = System.Drawing.Color.White;
            this.bt_SaveUser.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.add_user_male_32px;
            this.bt_SaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SaveUser.Location = new System.Drawing.Point(1, 297);
            this.bt_SaveUser.Margin = new System.Windows.Forms.Padding(0);
            this.bt_SaveUser.Name = "bt_SaveUser";
            this.bt_SaveUser.Size = new System.Drawing.Size(259, 52);
            this.bt_SaveUser.TabIndex = 27;
            this.bt_SaveUser.Text = "ADD CLIENT";
            this.bt_SaveUser.UseVisualStyleBackColor = false;
            this.bt_SaveUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.BackColor = System.Drawing.Color.DimGray;
            this.bt_Update.FlatAppearance.BorderSize = 0;
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Update.ForeColor = System.Drawing.Color.White;
            this.bt_Update.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.refresh_32px;
            this.bt_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Update.Location = new System.Drawing.Point(1, 349);
            this.bt_Update.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(259, 52);
            this.bt_Update.TabIndex = 28;
            this.bt_Update.Text = "      UPDATE CLIENT";
            this.bt_Update.UseVisualStyleBackColor = false;
            this.bt_Update.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.find_user_male_32px;
            this.pictureBox2.Location = new System.Drawing.Point(922, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tb_SearchEmployee
            // 
            this.tb_SearchEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_SearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchEmployee.Location = new System.Drawing.Point(453, 115);
            this.tb_SearchEmployee.Multiline = true;
            this.tb_SearchEmployee.Name = "tb_SearchEmployee";
            this.tb_SearchEmployee.Size = new System.Drawing.Size(503, 37);
            this.tb_SearchEmployee.TabIndex = 29;
            this.tb_SearchEmployee.Text = "Search name";
            this.tb_SearchEmployee.TextChanged += new System.EventHandler(this.tb_SearchEmployee_TextChanged);
            this.tb_SearchEmployee.Enter += new System.EventHandler(this.tb_SearchEmployee_Enter);
            this.tb_SearchEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SearchEmployee_KeyDown);
            this.tb_SearchEmployee.Leave += new System.EventHandler(this.tb_SearchEmployee_Leave);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(1001, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(25, 25);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 85;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bunifuElipse_Form
            // 
            this.bunifuElipse_Form.ElipseRadius = 15;
            this.bunifuElipse_Form.TargetControl = this;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(28, 183);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(185, 10);
            this.bunifuSeparator1.TabIndex = 86;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuDragControl_FA
            // 
            this.bunifuDragControl_FA.Fixed = true;
            this.bunifuDragControl_FA.Horizontal = true;
            this.bunifuDragControl_FA.TargetControl = this;
            this.bunifuDragControl_FA.Vertical = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cFirstNameDataGridViewTextBoxColumn
            // 
            this.cFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CFirstName";
            this.cFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.cFirstNameDataGridViewTextBoxColumn.Name = "cFirstNameDataGridViewTextBoxColumn";
            this.cFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cMiddleNameDataGridViewTextBoxColumn
            // 
            this.cMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "CMiddleName";
            this.cMiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.cMiddleNameDataGridViewTextBoxColumn.Name = "cMiddleNameDataGridViewTextBoxColumn";
            this.cMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLastNameDataGridViewTextBoxColumn
            // 
            this.cLastNameDataGridViewTextBoxColumn.DataPropertyName = "CLastName";
            this.cLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.cLastNameDataGridViewTextBoxColumn.Name = "cLastNameDataGridViewTextBoxColumn";
            this.cLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.Client);
            // 
            // FinancialAdviserMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 551);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_SearchEmployee);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_SaveUser);
            this.Controls.Add(this.bt_ViewClientInformation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FAName);
            this.Controls.Add(this.dataGridView_ListOfClients);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinancialAdviserMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancialAdviserMonitoring";
            this.Load += new System.EventHandler(this.FinancialAdviserMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ViewClientInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FAName;
        private System.Windows.Forms.DataGridView dataGridView_ListOfClients;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_SaveUser;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_SearchEmployee;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastNameDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl_FA;
    }
}