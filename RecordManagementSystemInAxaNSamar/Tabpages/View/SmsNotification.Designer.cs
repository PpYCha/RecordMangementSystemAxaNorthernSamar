namespace RecordManagementSystemInAxaNSamar
{
    partial class SmsNotification
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
            this.tb_message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Connect = new System.Windows.Forms.Button();
            this.bt_Send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ClientList = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Birthday = new System.Windows.Forms.Button();
            this.tb_PaidClients = new System.Windows.Forms.Button();
            this.tb_DueClients = new System.Windows.Forms.Button();
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse_InfoForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cb_PortNumber = new System.Windows.Forms.ComboBox();
            this.bt_BatchSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.SkyBlue;
            this.tb_message.Location = new System.Drawing.Point(683, 208);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(255, 151);
            this.tb_message.TabIndex = 1;
            this.tb_message.Text = "";
            this.tb_message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(426, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMATION NOTIFICATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(680, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBox1.Location = new System.Drawing.Point(683, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(229, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Confirmation/Payment Accepted";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBox2.Location = new System.Drawing.Point(683, 124);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(163, 19);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Due Date Notification";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.White;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkBox3.Location = new System.Drawing.Point(683, 156);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 19);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Greetings";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(680, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type of Messages:";
            // 
            // tb_Connect
            // 
            this.tb_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.tb_Connect.FlatAppearance.BorderSize = 0;
            this.tb_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Connect.ForeColor = System.Drawing.Color.White;
            this.tb_Connect.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.usb_connector_32px;
            this.tb_Connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_Connect.Location = new System.Drawing.Point(967, 254);
            this.tb_Connect.Name = "tb_Connect";
            this.tb_Connect.Size = new System.Drawing.Size(153, 37);
            this.tb_Connect.TabIndex = 11;
            this.tb_Connect.Text = "Connect";
            this.tb_Connect.UseVisualStyleBackColor = false;
            this.tb_Connect.Click += new System.EventHandler(this.tb_Connect_Click);
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(208)))));
            this.bt_Send.FlatAppearance.BorderSize = 0;
            this.bt_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send.ForeColor = System.Drawing.Color.White;
            this.bt_Send.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.send_32px;
            this.bt_Send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Send.Location = new System.Drawing.Point(967, 297);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(153, 32);
            this.bt_Send.TabIndex = 12;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = false;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_ClientList);
            this.groupBox1.Controls.Add(this.tb_Birthday);
            this.groupBox1.Controls.Add(this.tb_PaidClients);
            this.groupBox1.Controls.Add(this.tb_DueClients);
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 336);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Message";
            // 
            // dataGridView_ClientList
            // 
            this.dataGridView_ClientList.AllowUserToAddRows = false;
            this.dataGridView_ClientList.AllowUserToDeleteRows = false;
            this.dataGridView_ClientList.AutoGenerateColumns = false;
            this.dataGridView_ClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.cFirstNameDataGridViewTextBoxColumn,
            this.cMiddleNameDataGridViewTextBoxColumn,
            this.cLastNameDataGridViewTextBoxColumn,
            this.cellphoneNoDataGridViewTextBoxColumn});
            this.dataGridView_ClientList.DataSource = this.clientBindingSource;
            this.dataGridView_ClientList.Location = new System.Drawing.Point(6, 60);
            this.dataGridView_ClientList.Name = "dataGridView_ClientList";
            this.dataGridView_ClientList.ReadOnly = true;
            this.dataGridView_ClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ClientList.Size = new System.Drawing.Size(613, 270);
            this.dataGridView_ClientList.TabIndex = 3;
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
            this.cFirstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.cFirstNameDataGridViewTextBoxColumn.Name = "cFirstNameDataGridViewTextBoxColumn";
            this.cFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cMiddleNameDataGridViewTextBoxColumn
            // 
            this.cMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "CMiddleName";
            this.cMiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle name";
            this.cMiddleNameDataGridViewTextBoxColumn.Name = "cMiddleNameDataGridViewTextBoxColumn";
            this.cMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLastNameDataGridViewTextBoxColumn
            // 
            this.cLastNameDataGridViewTextBoxColumn.DataPropertyName = "CLastName";
            this.cLastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.cLastNameDataGridViewTextBoxColumn.Name = "cLastNameDataGridViewTextBoxColumn";
            this.cLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellphoneNoDataGridViewTextBoxColumn
            // 
            this.cellphoneNoDataGridViewTextBoxColumn.DataPropertyName = "CellphoneNo";
            this.cellphoneNoDataGridViewTextBoxColumn.HeaderText = "Cellphone number";
            this.cellphoneNoDataGridViewTextBoxColumn.Name = "cellphoneNoDataGridViewTextBoxColumn";
            this.cellphoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.Client);
            // 
            // tb_Birthday
            // 
            this.tb_Birthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(192)))), ((int)(((byte)(61)))));
            this.tb_Birthday.FlatAppearance.BorderSize = 0;
            this.tb_Birthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_Birthday.ForeColor = System.Drawing.Color.White;
            this.tb_Birthday.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.birthday_32px;
            this.tb_Birthday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_Birthday.Location = new System.Drawing.Point(400, 20);
            this.tb_Birthday.Name = "tb_Birthday";
            this.tb_Birthday.Size = new System.Drawing.Size(178, 35);
            this.tb_Birthday.TabIndex = 2;
            this.tb_Birthday.Text = "Birthday Celebrants";
            this.tb_Birthday.UseVisualStyleBackColor = false;
            this.tb_Birthday.Click += new System.EventHandler(this.tb_Birthday_Click);
            // 
            // tb_PaidClients
            // 
            this.tb_PaidClients.BackColor = System.Drawing.Color.SeaGreen;
            this.tb_PaidClients.FlatAppearance.BorderSize = 0;
            this.tb_PaidClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_PaidClients.ForeColor = System.Drawing.Color.White;
            this.tb_PaidClients.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.paycheque_32px;
            this.tb_PaidClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_PaidClients.Location = new System.Drawing.Point(215, 19);
            this.tb_PaidClients.Name = "tb_PaidClients";
            this.tb_PaidClients.Size = new System.Drawing.Size(145, 35);
            this.tb_PaidClients.TabIndex = 1;
            this.tb_PaidClients.Text = "Paid Clients";
            this.tb_PaidClients.UseVisualStyleBackColor = false;
            this.tb_PaidClients.Click += new System.EventHandler(this.tb_PaidClients_Click);
            // 
            // tb_DueClients
            // 
            this.tb_DueClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tb_DueClients.FlatAppearance.BorderSize = 0;
            this.tb_DueClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_DueClients.ForeColor = System.Drawing.Color.White;
            this.tb_DueClients.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.expired_32px;
            this.tb_DueClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_DueClients.Location = new System.Drawing.Point(29, 20);
            this.tb_DueClients.Name = "tb_DueClients";
            this.tb_DueClients.Size = new System.Drawing.Size(145, 34);
            this.tb_DueClients.TabIndex = 0;
            this.tb_DueClients.Text = "Due Clients";
            this.tb_DueClients.UseVisualStyleBackColor = false;
            this.tb_DueClients.Click += new System.EventHandler(this.tb_DueClients_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(1157, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(25, 25);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 16;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bunifuElipse_InfoForm
            // 
            this.bunifuElipse_InfoForm.ElipseRadius = 15;
            this.bunifuElipse_InfoForm.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.tb_Birthday;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.tb_Connect;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.bt_Send;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.tb_PaidClients;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.tb_DueClients;
            // 
            // cb_PortNumber
            // 
            this.cb_PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PortNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_PortNumber.FormattingEnabled = true;
            this.cb_PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.cb_PortNumber.Location = new System.Drawing.Point(967, 208);
            this.cb_PortNumber.Name = "cb_PortNumber";
            this.cb_PortNumber.Size = new System.Drawing.Size(153, 21);
            this.cb_PortNumber.TabIndex = 34;
            // 
            // bt_BatchSend
            // 
            this.bt_BatchSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(208)))));
            this.bt_BatchSend.FlatAppearance.BorderSize = 0;
            this.bt_BatchSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_BatchSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BatchSend.ForeColor = System.Drawing.Color.White;
            this.bt_BatchSend.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.send_32px;
            this.bt_BatchSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_BatchSend.Location = new System.Drawing.Point(967, 335);
            this.bt_BatchSend.Name = "bt_BatchSend";
            this.bt_BatchSend.Size = new System.Drawing.Size(148, 32);
            this.bt_BatchSend.TabIndex = 35;
            this.bt_BatchSend.Text = "Bulk Send";
            this.bt_BatchSend.UseVisualStyleBackColor = false;
            this.bt_BatchSend.Click += new System.EventHandler(this.bt_BatchSend_Click);
            // 
            // SmsNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 472);
            this.Controls.Add(this.bt_BatchSend);
            this.Controls.Add(this.cb_PortNumber);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.tb_Connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SmsNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORMATION_NOTIFICATION";
            this.Load += new System.EventHandler(this.SmsNotification_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tb_Connect;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tb_Birthday;
        private System.Windows.Forms.Button tb_PaidClients;
        private System.Windows.Forms.Button tb_DueClients;
        private System.Windows.Forms.DataGridView dataGridView_ClientList;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_InfoForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cb_PortNumber;
        private System.Windows.Forms.Button bt_BatchSend;
    }
}