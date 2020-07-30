namespace RecordManagementSystemInAxaNSamar.Tabpages.View
{
    partial class AxaForms
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
            this.ListDataGridView = new System.Windows.Forms.DataGridView();
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse_AxaForms = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl_AxaForms = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // ListDataGridView
            // 
            this.ListDataGridView.AllowUserToAddRows = false;
            this.ListDataGridView.AllowUserToDeleteRows = false;
            this.ListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListDataGridView.Location = new System.Drawing.Point(13, 51);
            this.ListDataGridView.MultiSelect = false;
            this.ListDataGridView.Name = "ListDataGridView";
            this.ListDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListDataGridView.Size = new System.Drawing.Size(975, 490);
            this.ListDataGridView.TabIndex = 15;
            this.ListDataGridView.Tag = "CLIENTS";
            this.ListDataGridView.DataSourceChanged += new System.EventHandler(this.ListDataGridView_DataSourceChanged);
            this.ListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDataGridView_CellContentClick);
            this.ListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListDataGridView_CellDoubleClick);
            this.ListDataGridView.Click += new System.EventHandler(this.ListDataGridView_Click);
            this.ListDataGridView.DoubleClick += new System.EventHandler(this.ListDataGridView_DoubleClick);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(952, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(48, 48);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 25;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bunifuElipse_AxaForms
            // 
            this.bunifuElipse_AxaForms.ElipseRadius = 15;
            this.bunifuElipse_AxaForms.TargetControl = this;
            // 
            // bunifuDragControl_AxaForms
            // 
            this.bunifuDragControl_AxaForms.Fixed = true;
            this.bunifuDragControl_AxaForms.Horizontal = true;
            this.bunifuDragControl_AxaForms.TargetControl = this;
            this.bunifuDragControl_AxaForms.Vertical = true;
            // 
            // AxaForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 553);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.ListDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AxaForms";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AxaForms";
            this.Load += new System.EventHandler(this.AxaForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListDataGridView;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_AxaForms;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl_AxaForms;
    }
}