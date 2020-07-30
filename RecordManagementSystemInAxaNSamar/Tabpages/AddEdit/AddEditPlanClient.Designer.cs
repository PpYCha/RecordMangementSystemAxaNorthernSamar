namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    partial class AddEditPlanClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditPlanClient));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.cb_ModeOfPayment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Due = new System.Windows.Forms.Label();
            this.tb_DuePayment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_PolicyNo = new System.Windows.Forms.TextBox();
            this.dataGridView_LoadPlans = new System.Windows.Forms.DataGridView();
            this.tb_PlanType = new System.Windows.Forms.TextBox();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_SumInsured = new System.Windows.Forms.TextBox();
            this.bt_AddPlan = new System.Windows.Forms.Button();
            this.planIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoadPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Plan type:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(534, 347);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 21);
            this.label.TabIndex = 40;
            this.label.Text = "Description:";
            // 
            // cb_ModeOfPayment
            // 
            this.cb_ModeOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ModeOfPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ModeOfPayment.FormattingEnabled = true;
            this.cb_ModeOfPayment.Items.AddRange(new object[] {
            "Monthly Premiun",
            "Quarterly Premium",
            "Semi Anual Premium",
            "Anual Premium"});
            this.cb_ModeOfPayment.Location = new System.Drawing.Point(175, 365);
            this.cb_ModeOfPayment.Margin = new System.Windows.Forms.Padding(5);
            this.cb_ModeOfPayment.Name = "cb_ModeOfPayment";
            this.cb_ModeOfPayment.Size = new System.Drawing.Size(327, 29);
            this.cb_ModeOfPayment.TabIndex = 45;
            this.cb_ModeOfPayment.SelectedIndexChanged += new System.EventHandler(this.cb_ModeOfPayment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mode of Payment:";
            // 
            // label_Due
            // 
            this.label_Due.AutoSize = true;
            this.label_Due.BackColor = System.Drawing.Color.White;
            this.label_Due.Location = new System.Drawing.Point(23, 410);
            this.label_Due.Name = "label_Due";
            this.label_Due.Size = new System.Drawing.Size(46, 21);
            this.label_Due.TabIndex = 47;
            this.label_Due.Text = "Due:";
            // 
            // tb_DuePayment
            // 
            this.tb_DuePayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DuePayment.Location = new System.Drawing.Point(171, 404);
            this.tb_DuePayment.Margin = new System.Windows.Forms.Padding(5);
            this.tb_DuePayment.Name = "tb_DuePayment";
            this.tb_DuePayment.Size = new System.Drawing.Size(327, 27);
            this.tb_DuePayment.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(88, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Policy No:";
            // 
            // tb_PolicyNo
            // 
            this.tb_PolicyNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PolicyNo.Location = new System.Drawing.Point(179, 292);
            this.tb_PolicyNo.Margin = new System.Windows.Forms.Padding(5);
            this.tb_PolicyNo.Name = "tb_PolicyNo";
            this.tb_PolicyNo.Size = new System.Drawing.Size(327, 27);
            this.tb_PolicyNo.TabIndex = 50;
            // 
            // dataGridView_LoadPlans
            // 
            this.dataGridView_LoadPlans.AutoGenerateColumns = false;
            this.dataGridView_LoadPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoadPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoadPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planIdDataGridViewTextBoxColumn,
            this.planTypeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView_LoadPlans.DataSource = this.planBindingSource;
            this.dataGridView_LoadPlans.Location = new System.Drawing.Point(106, 32);
            this.dataGridView_LoadPlans.Name = "dataGridView_LoadPlans";
            this.dataGridView_LoadPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LoadPlans.Size = new System.Drawing.Size(856, 232);
            this.dataGridView_LoadPlans.TabIndex = 52;
            this.dataGridView_LoadPlans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LoadPlans_CellContentClick);
            this.dataGridView_LoadPlans.Click += new System.EventHandler(this.dataGridView_LoadPlans_Click);
            // 
            // tb_PlanType
            // 
            this.tb_PlanType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PlanType.Location = new System.Drawing.Point(649, 274);
            this.tb_PlanType.Margin = new System.Windows.Forms.Padding(5);
            this.tb_PlanType.Name = "tb_PlanType";
            this.tb_PlanType.ReadOnly = true;
            this.tb_PlanType.Size = new System.Drawing.Size(327, 27);
            this.tb_PlanType.TabIndex = 53;
            // 
            // tb_Category
            // 
            this.tb_Category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.Location = new System.Drawing.Point(649, 307);
            this.tb_Category.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.ReadOnly = true;
            this.tb_Category.Size = new System.Drawing.Size(327, 27);
            this.tb_Category.TabIndex = 54;
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(649, 344);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.ReadOnly = true;
            this.tb_Description.Size = new System.Drawing.Size(327, 27);
            this.tb_Description.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Sum Insured:";
            // 
            // tb_SumInsured
            // 
            this.tb_SumInsured.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SumInsured.Location = new System.Drawing.Point(175, 328);
            this.tb_SumInsured.Margin = new System.Windows.Forms.Padding(5);
            this.tb_SumInsured.Name = "tb_SumInsured";
            this.tb_SumInsured.Size = new System.Drawing.Size(327, 27);
            this.tb_SumInsured.TabIndex = 56;
            // 
            // bt_AddPlan
            // 
            this.bt_AddPlan.Location = new System.Drawing.Point(567, 396);
            this.bt_AddPlan.Name = "bt_AddPlan";
            this.bt_AddPlan.Size = new System.Drawing.Size(199, 42);
            this.bt_AddPlan.TabIndex = 58;
            this.bt_AddPlan.Text = "Add Plan";
            this.bt_AddPlan.UseVisualStyleBackColor = true;
            this.bt_AddPlan.Click += new System.EventHandler(this.bt_AddPlan_Click);
            // 
            // planIdDataGridViewTextBoxColumn
            // 
            this.planIdDataGridViewTextBoxColumn.DataPropertyName = "PlanId";
            this.planIdDataGridViewTextBoxColumn.HeaderText = "PlanId";
            this.planIdDataGridViewTextBoxColumn.Name = "planIdDataGridViewTextBoxColumn";
            this.planIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.planIdDataGridViewTextBoxColumn.Visible = false;
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
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // planBindingSource
            // 
            this.planBindingSource.DataSource = typeof(RecordManagementSystemInAxaNSamar.Model.Plan);
            // 
            // AddEditPlanClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 486);
            this.Controls.Add(this.bt_AddPlan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_SumInsured);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Category);
            this.Controls.Add(this.tb_PlanType);
            this.Controls.Add(this.dataGridView_LoadPlans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_PolicyNo);
            this.Controls.Add(this.label_Due);
            this.Controls.Add(this.tb_DuePayment);
            this.Controls.Add(this.cb_ModeOfPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditPlanClient";
            this.Text = "AddPlan";
            this.Load += new System.EventHandler(this.AddEditPlanClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoadPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cb_ModeOfPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Due;
        private System.Windows.Forms.TextBox tb_DuePayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_PolicyNo;
        private System.Windows.Forms.DataGridView dataGridView_LoadPlans;
        private System.Windows.Forms.BindingSource planBindingSource;
        private System.Windows.Forms.TextBox tb_PlanType;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_SumInsured;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_AddPlan;
    }
}