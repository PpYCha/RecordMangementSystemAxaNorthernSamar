namespace RecordManagementSystemInAxaNSamar.Tabpages.AddEdit
{
    partial class AddEditAxaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_AxaForms = new System.Windows.Forms.ComboBox();
            this.listBoxAXAFiles = new System.Windows.Forms.ListBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_Delete = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_SaveElipes = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bt_Add = new System.Windows.Forms.Button();
            this.bunifuElipse_AddFile = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bt_AddFile = new System.Windows.Forms.Button();
            this.bunifuElipse_DeleteFile = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bt_DelelteFile = new System.Windows.Forms.Button();
            this.bt_Close = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Axa Forms:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_AxaForms
            // 
            this.cb_AxaForms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AxaForms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_AxaForms.FormattingEnabled = true;
            this.cb_AxaForms.Location = new System.Drawing.Point(43, 85);
            this.cb_AxaForms.Margin = new System.Windows.Forms.Padding(5);
            this.cb_AxaForms.Name = "cb_AxaForms";
            this.cb_AxaForms.Size = new System.Drawing.Size(327, 29);
            this.cb_AxaForms.TabIndex = 77;
            this.cb_AxaForms.SelectedValueChanged += new System.EventHandler(this.cb_AxaForms_SelectedValueChanged);
            // 
            // listBoxAXAFiles
            // 
            this.listBoxAXAFiles.FormattingEnabled = true;
            this.listBoxAXAFiles.ItemHeight = 21;
            this.listBoxAXAFiles.Location = new System.Drawing.Point(59, 167);
            this.listBoxAXAFiles.Name = "listBoxAXAFiles";
            this.listBoxAXAFiles.Size = new System.Drawing.Size(881, 193);
            this.listBoxAXAFiles.TabIndex = 81;
            this.listBoxAXAFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxAXAFiles_SelectedIndexChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse_Form
            // 
            this.bunifuElipse_Form.ElipseRadius = 10;
            this.bunifuElipse_Form.TargetControl = this;
            // 
            // bunifuElipse_Delete
            // 
            this.bunifuElipse_Delete.ElipseRadius = 15;
            this.bunifuElipse_Delete.TargetControl = this.bt_Delete;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(9)))), ((int)(((byte)(40)))));
            this.bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete.ForeColor = System.Drawing.Color.White;
            this.bt_Delete.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_32px;
            this.bt_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Delete.Location = new System.Drawing.Point(752, 71);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(156, 54);
            this.bt_Delete.TabIndex = 80;
            this.bt_Delete.Text = "DELETE";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_SaveElipes
            // 
            this.bt_SaveElipes.ElipseRadius = 15;
            this.bt_SaveElipes.TargetControl = this.bt_Add;
            // 
            // bt_Add
            // 
            this.bt_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.ForeColor = System.Drawing.Color.White;
            this.bt_Add.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.add_32px;
            this.bt_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Add.Location = new System.Drawing.Point(596, 71);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(156, 54);
            this.bt_Add.TabIndex = 78;
            this.bt_Add.Text = "SAVE";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bunifuElipse_AddFile
            // 
            this.bunifuElipse_AddFile.ElipseRadius = 15;
            this.bunifuElipse_AddFile.TargetControl = this.bt_AddFile;
            // 
            // bt_AddFile
            // 
            this.bt_AddFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_AddFile.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_AddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddFile.ForeColor = System.Drawing.Color.White;
            this.bt_AddFile.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.add_file_32px;
            this.bt_AddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_AddFile.Location = new System.Drawing.Point(65, 376);
            this.bt_AddFile.Margin = new System.Windows.Forms.Padding(0);
            this.bt_AddFile.Name = "bt_AddFile";
            this.bt_AddFile.Size = new System.Drawing.Size(156, 54);
            this.bt_AddFile.TabIndex = 82;
            this.bt_AddFile.Text = "ADD FILE";
            this.bt_AddFile.UseVisualStyleBackColor = false;
            this.bt_AddFile.Click += new System.EventHandler(this.bt_AddFile_Click);
            // 
            // bunifuElipse_DeleteFile
            // 
            this.bunifuElipse_DeleteFile.ElipseRadius = 15;
            this.bunifuElipse_DeleteFile.TargetControl = this.bt_DelelteFile;
            // 
            // bt_DelelteFile
            // 
            this.bt_DelelteFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_DelelteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(9)))), ((int)(((byte)(40)))));
            this.bt_DelelteFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_DelelteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DelelteFile.ForeColor = System.Drawing.Color.White;
            this.bt_DelelteFile.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.add_file_32px;
            this.bt_DelelteFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_DelelteFile.Location = new System.Drawing.Point(221, 376);
            this.bt_DelelteFile.Margin = new System.Windows.Forms.Padding(0);
            this.bt_DelelteFile.Name = "bt_DelelteFile";
            this.bt_DelelteFile.Size = new System.Drawing.Size(156, 54);
            this.bt_DelelteFile.TabIndex = 83;
            this.bt_DelelteFile.Text = "DELETE FILE";
            this.bt_DelelteFile.UseVisualStyleBackColor = false;
            this.bt_DelelteFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.BackColor = System.Drawing.Color.White;
            this.bt_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Close.Image = global::RecordManagementSystemInAxaNSamar.Properties.Resources.delete_sign_48px;
            this.bt_Close.ImageActive = null;
            this.bt_Close.Location = new System.Drawing.Point(910, 0);
            this.bt_Close.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(48, 48);
            this.bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_Close.TabIndex = 84;
            this.bt_Close.TabStop = false;
            this.bt_Close.Zoom = 10;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // AddEditAxaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 469);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_DelelteFile);
            this.Controls.Add(this.bt_AddFile);
            this.Controls.Add(this.listBoxAXAFiles);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.cb_AxaForms);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditAxaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditAxaForm";
            this.Load += new System.EventHandler(this.AddEditAxaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_AxaForms;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.ListBox listBoxAXAFiles;
        private System.Windows.Forms.Button bt_AddFile;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Form;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Delete;
        private Bunifu.Framework.UI.BunifuElipse bt_SaveElipes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_AddFile;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_DeleteFile;
        private Bunifu.Framework.UI.BunifuImageButton bt_Close;
        private System.Windows.Forms.Button bt_DelelteFile;
    }
}