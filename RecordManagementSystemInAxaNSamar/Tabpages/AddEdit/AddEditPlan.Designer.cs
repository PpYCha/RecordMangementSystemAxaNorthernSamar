namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    partial class AddEditPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPlan));
            this.cb_PlanCategory = new System.Windows.Forms.ComboBox();
            this.cb_PlanType = new System.Windows.Forms.ComboBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.bt_SavePlan = new System.Windows.Forms.Button();
            this.dataGridView_Plan = new System.Windows.Forms.DataGridView();
            this.planIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPlansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse_SaveUser = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl_FormPlan = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.clientBeneficiariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBeneficiariesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_PlanCategory
            // 
            this.cb_PlanCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PlanCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PlanCategory.FormattingEnabled = true;
            this.cb_PlanCategory.Items.AddRange(new object[] {
            "Education",
            "Health Insurance",
            "Income Protection",
            "Income Protection with Investment",
            "Investment",
            "Non/Life General Insurance",
            "Retirement"});
            this.cb_PlanCategory.Location = new System.Drawing.Point(662, 44);
            this.cb_PlanCategory.Margin = new System.Windows.Forms.Padding(5);
            this.cb_PlanCategory.Name = "cb_PlanCategory";
            this.cb_PlanCategory.Size = new System.Drawing.Size(253, 29);
            this.cb_PlanCategory.TabIndex = 31;
            // 
            // cb_PlanType
            // 
            this.cb_PlanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PlanType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PlanType.FormattingEnabled = true;
            this.cb_PlanType.Items.AddRange(new object[] {
            "Other",
            "Traditional",
            "Variable"});
            this.cb_PlanType.Location = new System.Drawing.Point(202, 75);
            this.cb_PlanType.Margin = new System.Windows.Forms.Padding(5);
            this.cb_PlanType.Name = "cb_PlanType";
            this.cb_PlanType.Size = new System.Drawing.Size(327, 29);
            this.cb_PlanType.TabIndex = 30;
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(202, 38);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(327, 27);
            this.tb_Description.TabIndex = 29;
            // 
            // bt_SavePlan
            // 
            this.bt_SavePlan.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_SavePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SavePlan.ForeColor = System.Drawing.Color.White;
            this.bt_SavePlan.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.add_32px;
            this.bt_SavePlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SavePlan.Location = new System.Drawing.Point(730, 386);
            this.bt_SavePlan.Margin = new System.Windows.Forms.Padding(5);
            this.bt_SavePlan.Name = "bt_SavePlan";
            this.bt_SavePlan.Size = new System.Drawing.Size(166, 65);
            this.bt_SavePlan.TabIndex = 32;
            this.bt_SavePlan.Text = "SAVE";
            this.bt_SavePlan.UseVisualStyleBackColor = false;
            this.bt_SavePlan.Click += new System.EventHandler(this.bt_SavePlan_Click);
            // 
            // dataGridView_Plan
            // 
            this.dataGridView_Plan.AutoGenerateColumns = false;
            this.dataGridView_Plan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Plan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.planTypeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.planNameDataGridViewTextBoxColumn,
            this.clientPlansDataGridViewTextBoxColumn});
            this.dataGridView_Plan.DataSource = this.planBindingSource;
            this.dataGridView_Plan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Plan.Location = new System.Drawing.Point(101, 115);
            this.dataGridView_Plan.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_Plan.MultiSelect = false;
            this.dataGridView_Plan.Name = "dataGridView_Plan";
            this.dataGridView_Plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Plan.Size = new System.Drawing.Size(814, 252);
            this.dataGridView_Plan.TabIndex = 33;
            this.dataGridView_Plan.DoubleClick += new System.EventHandler(this.dataGridView_Plan_DoubleClick);
            // 
            // planIdDataGridViewTextBoxColumn
            // 
            this.planIdDataGridViewTextBoxColumn.DataPropertyName = "PlanId";
            this.planIdDataGridViewTextBoxColumn.HeaderText = "PlanId";
            this.planIdDataGridViewTextBoxColumn.Name = "planIdDataGridViewTextBoxColumn";
            this.planIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.planIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // planTypeDataGridViewTextBoxColumn
            // 
            this.planTypeDataGridViewTextBoxColumn.DataPropertyName = "PlanType";
            this.planTypeDataGridViewTextBoxColumn.HeaderText = "PlanType";
            this.planTypeDataGridViewTextBoxColumn.Name = "planTypeDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // planNameDataGridViewTextBoxColumn
            // 
            this.planNameDataGridViewTextBoxColumn.DataPropertyName = "PlanName";
            this.planNameDataGridViewTextBoxColumn.HeaderText = "PlanName";
            this.planNameDataGridViewTextBoxColumn.Name = "planNameDataGridViewTextBoxColumn";
            this.planNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientPlansDataGridViewTextBoxColumn
            // 
            this.clientPlansDataGridViewTextBoxColumn.DataPropertyName = "ClientPlans";
            this.clientPlansDataGridViewTextBoxColumn.HeaderText = "ClientPlans";
            this.clientPlansDataGridViewTextBoxColumn.Name = "clientPlansDataGridViewTextBoxColumn";
            this.clientPlansDataGridViewTextBoxColumn.Visible = false;
            // 
            // planBindingSource
            // 
            this.planBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.Plan);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Plan type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Category:";
            // 
            // bunifuElipse_Form
            // 
            this.bunifuElipse_Form.ElipseRadius = 15;
            this.bunifuElipse_Form.TargetControl = this;
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(919, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(48, 48);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 38;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bunifuElipse_SaveUser
            // 
            this.bunifuElipse_SaveUser.ElipseRadius = 15;
            this.bunifuElipse_SaveUser.TargetControl = this.bt_SavePlan;
            // 
            // bunifuDragControl_FormPlan
            // 
            this.bunifuDragControl_FormPlan.Fixed = true;
            this.bunifuDragControl_FormPlan.Horizontal = true;
            this.bunifuDragControl_FormPlan.TargetControl = this;
            this.bunifuDragControl_FormPlan.Vertical = true;
            // 
            // clientBeneficiariesBindingSource
            // 
            this.clientBeneficiariesBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.ClientBeneficiaries);
            // 
            // AddEditPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 482);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Plan);
            this.Controls.Add(this.bt_SavePlan);
            this.Controls.Add(this.cb_PlanCategory);
            this.Controls.Add(this.cb_PlanType);
            this.Controls.Add(this.tb_Description);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditPlan";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditPlan";
            this.Load += new System.EventHandler(this.AddEditPlan_Load);
            this.Click += new System.EventHandler(this.AddEditPlan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBeneficiariesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_PlanCategory;
        private System.Windows.Forms.ComboBox cb_PlanType;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Button bt_SavePlan;
        private System.Windows.Forms.DataGridView dataGridView_Plan;
        private System.Windows.Forms.BindingSource planBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPlansDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBeneficiariesBindingSource;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Form;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_SaveUser;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl_FormPlan;
    }
}