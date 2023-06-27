namespace RecordManagementSystemInAxaNSamar.Tabpages.View
{
    partial class ClienrtsPaymentMonitoring
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienrtsPaymentMonitoring));
            this.bt_SelectClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientPlanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumInsuredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_PremiumAmount = new System.Windows.Forms.Label();
            this.bt_AddPayment = new System.Windows.Forms.Button();
            this.dateTimePicker_PaidDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_totalPaid = new System.Windows.Forms.Label();
            this.dataGridView_PaymentRecordss = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_SumInsurred = new System.Windows.Forms.TextBox();
            this.lb_TotalPayment = new System.Windows.Forms.Label();
            this.lb_PaymentMethod = new System.Windows.Forms.Label();
            this.lb_PolicyNo = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.paymentRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_SearchEmployee = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPlanBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PaymentRecordss)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_SelectClient
            // 
            this.bt_SelectClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.bt_SelectClient.FlatAppearance.BorderSize = 0;
            this.bt_SelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectClient.ForeColor = System.Drawing.Color.White;
            this.bt_SelectClient.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.planner_32px;
            this.bt_SelectClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SelectClient.Location = new System.Drawing.Point(129, 280);
            this.bt_SelectClient.Name = "bt_SelectClient";
            this.bt_SelectClient.Size = new System.Drawing.Size(183, 43);
            this.bt_SelectClient.TabIndex = 15;
            this.bt_SelectClient.Text = "SELECT PLAN";
            this.bt_SelectClient.UseVisualStyleBackColor = false;
            this.bt_SelectClient.Click += new System.EventHandler(this.bt_SelectClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientPlanIdDataGridViewTextBoxColumn,
            this.policyNoDataGridViewTextBoxColumn,
            this.sumInsuredDataGridViewTextBoxColumn,
            this.modeOfPaymentDataGridViewTextBoxColumn,
            this.dueOfPaymentDataGridViewTextBoxColumn,
            this.planIdDataGridViewTextBoxColumn,
            this.planDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientPlanBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(29, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 179);
            this.dataGridView1.TabIndex = 11;
            // 
            // clientPlanIdDataGridViewTextBoxColumn
            // 
            this.clientPlanIdDataGridViewTextBoxColumn.DataPropertyName = "ClientPlanId";
            this.clientPlanIdDataGridViewTextBoxColumn.HeaderText = "ClientPlanId";
            this.clientPlanIdDataGridViewTextBoxColumn.Name = "clientPlanIdDataGridViewTextBoxColumn";
            this.clientPlanIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientPlanIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // policyNoDataGridViewTextBoxColumn
            // 
            this.policyNoDataGridViewTextBoxColumn.DataPropertyName = "PolicyNo";
            this.policyNoDataGridViewTextBoxColumn.HeaderText = "PolicyNo";
            this.policyNoDataGridViewTextBoxColumn.Name = "policyNoDataGridViewTextBoxColumn";
            this.policyNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumInsuredDataGridViewTextBoxColumn
            // 
            this.sumInsuredDataGridViewTextBoxColumn.DataPropertyName = "SumInsured";
            this.sumInsuredDataGridViewTextBoxColumn.HeaderText = "SumInsured";
            this.sumInsuredDataGridViewTextBoxColumn.Name = "sumInsuredDataGridViewTextBoxColumn";
            this.sumInsuredDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumInsuredDataGridViewTextBoxColumn.Visible = false;
            // 
            // modeOfPaymentDataGridViewTextBoxColumn
            // 
            this.modeOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "ModeOfPayment";
            this.modeOfPaymentDataGridViewTextBoxColumn.HeaderText = "ModeOfPayment";
            this.modeOfPaymentDataGridViewTextBoxColumn.Name = "modeOfPaymentDataGridViewTextBoxColumn";
            this.modeOfPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeOfPaymentDataGridViewTextBoxColumn.Visible = false;
            // 
            // dueOfPaymentDataGridViewTextBoxColumn
            // 
            this.dueOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "DueOfPayment";
            this.dueOfPaymentDataGridViewTextBoxColumn.HeaderText = "DueOfPayment";
            this.dueOfPaymentDataGridViewTextBoxColumn.Name = "dueOfPaymentDataGridViewTextBoxColumn";
            this.dueOfPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueOfPaymentDataGridViewTextBoxColumn.Visible = false;
            // 
            // planIdDataGridViewTextBoxColumn
            // 
            this.planIdDataGridViewTextBoxColumn.DataPropertyName = "PlanId";
            this.planIdDataGridViewTextBoxColumn.HeaderText = "PlanId";
            this.planIdDataGridViewTextBoxColumn.Name = "planIdDataGridViewTextBoxColumn";
            this.planIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.planIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // planDataGridViewTextBoxColumn
            // 
            this.planDataGridViewTextBoxColumn.DataPropertyName = "Plan";
            this.planDataGridViewTextBoxColumn.HeaderText = "Plan";
            this.planDataGridViewTextBoxColumn.Name = "planDataGridViewTextBoxColumn";
            this.planDataGridViewTextBoxColumn.ReadOnly = true;
            this.planDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientPlanBindingSource
            // 
            this.clientPlanBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.ClientPlan);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_PremiumAmount);
            this.groupBox2.Controls.Add(this.bt_AddPayment);
            this.groupBox2.Controls.Add(this.dateTimePicker_PaidDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(503, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 189);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAYMENT TRANSACTION";
            // 
            // lb_PremiumAmount
            // 
            this.lb_PremiumAmount.AutoSize = true;
            this.lb_PremiumAmount.Location = new System.Drawing.Point(111, 35);
            this.lb_PremiumAmount.Name = "lb_PremiumAmount";
            this.lb_PremiumAmount.Size = new System.Drawing.Size(86, 13);
            this.lb_PremiumAmount.TabIndex = 17;
            this.lb_PremiumAmount.Text = "Premium Amount";
            // 
            // bt_AddPayment
            // 
            this.bt_AddPayment.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_AddPayment.FlatAppearance.BorderSize = 0;
            this.bt_AddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddPayment.ForeColor = System.Drawing.Color.White;
            this.bt_AddPayment.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.Add_Dollar_32px;
            this.bt_AddPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddPayment.Location = new System.Drawing.Point(114, 131);
            this.bt_AddPayment.Name = "bt_AddPayment";
            this.bt_AddPayment.Size = new System.Drawing.Size(183, 43);
            this.bt_AddPayment.TabIndex = 3;
            this.bt_AddPayment.Text = "ADD PAYMENT";
            this.bt_AddPayment.UseVisualStyleBackColor = false;
            this.bt_AddPayment.Click += new System.EventHandler(this.bt_AddPayment_Click);
            // 
            // dateTimePicker_PaidDate
            // 
            this.dateTimePicker_PaidDate.Location = new System.Drawing.Point(113, 78);
            this.dateTimePicker_PaidDate.Name = "dateTimePicker_PaidDate";
            this.dateTimePicker_PaidDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_PaidDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Paid-To-Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Premium Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_totalPaid);
            this.groupBox1.Controls.Add(this.dataGridView_PaymentRecordss);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(503, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 205);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAYMENT RECORDS";
            // 
            // lbl_totalPaid
            // 
            this.lbl_totalPaid.AutoSize = true;
            this.lbl_totalPaid.Location = new System.Drawing.Point(165, 160);
            this.lbl_totalPaid.Name = "lbl_totalPaid";
            this.lbl_totalPaid.Size = new System.Drawing.Size(114, 13);
            this.lbl_totalPaid.TabIndex = 18;
            this.lbl_totalPaid.Text = "Total Payment Amount";
            // 
            // dataGridView_PaymentRecordss
            // 
            this.dataGridView_PaymentRecordss.AllowUserToAddRows = false;
            this.dataGridView_PaymentRecordss.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_PaymentRecordss.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_PaymentRecordss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PaymentRecordss.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_PaymentRecordss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_PaymentRecordss.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_PaymentRecordss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_PaymentRecordss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView_PaymentRecordss.EnableHeadersVisualStyles = false;
            this.dataGridView_PaymentRecordss.Location = new System.Drawing.Point(19, 23);
            this.dataGridView_PaymentRecordss.Name = "dataGridView_PaymentRecordss";
            this.dataGridView_PaymentRecordss.ReadOnly = true;
            this.dataGridView_PaymentRecordss.Size = new System.Drawing.Size(464, 111);
            this.dataGridView_PaymentRecordss.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TOTAL PREMIUM PAID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "CLIENT PAYMENTS MONITORING\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_SumInsurred);
            this.groupBox4.Controls.Add(this.lb_TotalPayment);
            this.groupBox4.Controls.Add(this.lb_PaymentMethod);
            this.groupBox4.Controls.Add(this.lb_PolicyNo);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(33, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 170);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "POLICY DATAILS";
            // 
            // lb_SumInsurred
            // 
            this.lb_SumInsurred.Location = new System.Drawing.Point(312, 27);
            this.lb_SumInsurred.Name = "lb_SumInsurred";
            this.lb_SumInsurred.Size = new System.Drawing.Size(142, 20);
            this.lb_SumInsurred.TabIndex = 17;
            this.lb_SumInsurred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isNumeric);
            // 
            // lb_TotalPayment
            // 
            this.lb_TotalPayment.AutoSize = true;
            this.lb_TotalPayment.Location = new System.Drawing.Point(349, 120);
            this.lb_TotalPayment.Name = "lb_TotalPayment";
            this.lb_TotalPayment.Size = new System.Drawing.Size(114, 13);
            this.lb_TotalPayment.TabIndex = 16;
            this.lb_TotalPayment.Text = "Total Payment Amount";
            // 
            // lb_PaymentMethod
            // 
            this.lb_PaymentMethod.AutoSize = true;
            this.lb_PaymentMethod.Location = new System.Drawing.Point(105, 120);
            this.lb_PaymentMethod.Name = "lb_PaymentMethod";
            this.lb_PaymentMethod.Size = new System.Drawing.Size(87, 13);
            this.lb_PaymentMethod.TabIndex = 14;
            this.lb_PaymentMethod.Text = "Payment Method";
            // 
            // lb_PolicyNo
            // 
            this.lb_PolicyNo.AutoSize = true;
            this.lb_PolicyNo.Location = new System.Drawing.Point(93, 35);
            this.lb_PolicyNo.Name = "lb_PolicyNo";
            this.lb_PolicyNo.Size = new System.Drawing.Size(75, 13);
            this.lb_PolicyNo.TabIndex = 13;
            this.lb_PolicyNo.Text = "Policy Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(229, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Total Payment Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Sum Insured:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Payment Method:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Policy Number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 7;
            // 
            // paymentRecordsBindingSource
            // 
            this.paymentRecordsBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.PaymentRecords);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(1003, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(25, 25);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 86;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bunifuElipse_Form
            // 
            this.bunifuElipse_Form.ElipseRadius = 15;
            this.bunifuElipse_Form.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.find_user_male_32px;
            this.pictureBox1.Location = new System.Drawing.Point(458, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_SearchEmployee
            // 
            this.tb_SearchEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_SearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_SearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchEmployee.Location = new System.Drawing.Point(29, 48);
            this.tb_SearchEmployee.Multiline = true;
            this.tb_SearchEmployee.Name = "tb_SearchEmployee";
            this.tb_SearchEmployee.Size = new System.Drawing.Size(464, 41);
            this.tb_SearchEmployee.TabIndex = 87;
            this.tb_SearchEmployee.Text = "Search Policy Number";
            this.tb_SearchEmployee.Enter += new System.EventHandler(this.tb_SearchEmployee_Enter);
            this.tb_SearchEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SearchEmployee_KeyDown);
            this.tb_SearchEmployee.Leave += new System.EventHandler(this.tb_SearchEmployee_Leave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.bt_SelectClient;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.bt_AddPayment;
            // 
            // ClienrtsPaymentMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 551);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bt_SelectClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_SearchEmployee);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienrtsPaymentMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienrtsPaymentMonitoring";
            this.Load += new System.EventHandler(this.ClienrtsPaymentMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPlanBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PaymentRecordss)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_SelectClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_AddPayment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PaidDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPlanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumInsuredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeOfPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueOfPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientPlanBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_TotalPayment;
        private System.Windows.Forms.Label lb_PaymentMethod;
        private System.Windows.Forms.Label lb_PolicyNo;
        private System.Windows.Forms.Label lb_PremiumAmount;
        private System.Windows.Forms.BindingSource paymentRecordsBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView_PaymentRecordss;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Form;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_SearchEmployee;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label lbl_totalPaid;
        private System.Windows.Forms.TextBox lb_SumInsurred;
    }
}