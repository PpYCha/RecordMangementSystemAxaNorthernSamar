namespace RecordManagementSystemInAxaNSamar
{
    partial class ClientesRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesRecords));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_FinancialAdvisor = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl_Form = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.bt_FAMonitoring = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FinancialAdvisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.aw;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "FINANCIAL ADVISORS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.gender_neutral_user_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "AXA CLIENTS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_FinancialAdvisor
            // 
            this.dataGridView_FinancialAdvisor.AllowUserToAddRows = false;
            this.dataGridView_FinancialAdvisor.AllowUserToDeleteRows = false;
            this.dataGridView_FinancialAdvisor.AutoGenerateColumns = false;
            this.dataGridView_FinancialAdvisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_FinancialAdvisor.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView_FinancialAdvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FinancialAdvisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.eFirstNameDataGridViewTextBoxColumn,
            this.eMiddleNameDataGridViewTextBoxColumn,
            this.eLastNameDataGridViewTextBoxColumn,
            this.IdPicture});
            this.dataGridView_FinancialAdvisor.DataSource = this.employeeBindingSource;
            this.dataGridView_FinancialAdvisor.Location = new System.Drawing.Point(279, 151);
            this.dataGridView_FinancialAdvisor.Name = "dataGridView_FinancialAdvisor";
            this.dataGridView_FinancialAdvisor.ReadOnly = true;
            this.dataGridView_FinancialAdvisor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FinancialAdvisor.Size = new System.Drawing.Size(675, 396);
            this.dataGridView_FinancialAdvisor.TabIndex = 10;
            this.dataGridView_FinancialAdvisor.Visible = false;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // eFirstNameDataGridViewTextBoxColumn
            // 
            this.eFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EFirstName";
            this.eFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.eFirstNameDataGridViewTextBoxColumn.Name = "eFirstNameDataGridViewTextBoxColumn";
            this.eFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMiddleNameDataGridViewTextBoxColumn
            // 
            this.eMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "EMiddleName";
            this.eMiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.eMiddleNameDataGridViewTextBoxColumn.Name = "eMiddleNameDataGridViewTextBoxColumn";
            this.eMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eLastNameDataGridViewTextBoxColumn
            // 
            this.eLastNameDataGridViewTextBoxColumn.DataPropertyName = "ELastName";
            this.eLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.eLastNameDataGridViewTextBoxColumn.Name = "eLastNameDataGridViewTextBoxColumn";
            this.eLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdPicture
            // 
            this.IdPicture.DataPropertyName = "IdPicture";
            this.IdPicture.HeaderText = "IdPicture";
            this.IdPicture.Name = "IdPicture";
            this.IdPicture.ReadOnly = true;
            this.IdPicture.Visible = false;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.Employee);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(399, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "CLIENTS RECORDS";
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.AllowUserToAddRows = false;
            this.dataGridView_Client.AllowUserToDeleteRows = false;
            this.dataGridView_Client.AutoGenerateColumns = false;
            this.dataGridView_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Client.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.cFirstNameDataGridViewTextBoxColumn,
            this.cMiddleNameDataGridViewTextBoxColumn,
            this.cLastNameDataGridViewTextBoxColumn});
            this.dataGridView_Client.DataSource = this.clientBindingSource;
            this.dataGridView_Client.Location = new System.Drawing.Point(279, 151);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.ReadOnly = true;
            this.dataGridView_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Client.Size = new System.Drawing.Size(675, 396);
            this.dataGridView_Client.TabIndex = 17;
            this.dataGridView_Client.Visible = false;
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
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(1002, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(25, 25);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 25;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bunifuElipse_Form
            // 
            this.bunifuElipse_Form.ElipseRadius = 10;
            this.bunifuElipse_Form.TargetControl = this;
            // 
            // bunifuDragControl_Form
            // 
            this.bunifuDragControl_Form.Fixed = true;
            this.bunifuDragControl_Form.Horizontal = true;
            this.bunifuDragControl_Form.TargetControl = this;
            this.bunifuDragControl_Form.Vertical = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.client_management_32px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(4, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 44);
            this.button3.TabIndex = 31;
            this.button3.Text = "CLIENTS MONITORING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_FAMonitoring
            // 
            this.bt_FAMonitoring.BackColor = System.Drawing.Color.Firebrick;
            this.bt_FAMonitoring.FlatAppearance.BorderSize = 0;
            this.bt_FAMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_FAMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FAMonitoring.ForeColor = System.Drawing.Color.Black;
            this.bt_FAMonitoring.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.dashboard_32px;
            this.bt_FAMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_FAMonitoring.Location = new System.Drawing.Point(4, 199);
            this.bt_FAMonitoring.Name = "bt_FAMonitoring";
            this.bt_FAMonitoring.Size = new System.Drawing.Size(269, 44);
            this.bt_FAMonitoring.TabIndex = 32;
            this.bt_FAMonitoring.Text = "FA DASHBOARD";
            this.bt_FAMonitoring.UseVisualStyleBackColor = false;
            this.bt_FAMonitoring.Click += new System.EventHandler(this.bt_FAMonitoring_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ClientesRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_FAMonitoring);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Client);
            this.Controls.Add(this.dataGridView_FinancialAdvisor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients_Records";
            this.Load += new System.EventHandler(this.ClientesRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FinancialAdvisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_FinancialAdvisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastNameDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Form;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl_Form;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_FAMonitoring;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}