namespace PayegahApp.Amat
{
    partial class frmAmat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmat));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cmbAmadType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertAmad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAmadType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAmad = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmadTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmadTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmadCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtTitle.Location = new System.Drawing.Point(5, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(257, 28);
            this.txtTitle.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtCode.Location = new System.Drawing.Point(5, 159);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(257, 28);
            this.txtCode.TabIndex = 20;
            // 
            // cmbAmadType
            // 
            this.cmbAmadType.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbAmadType.FormattingEnabled = true;
            this.cmbAmadType.Location = new System.Drawing.Point(5, 96);
            this.cmbAmadType.Margin = new System.Windows.Forms.Padding(5);
            this.cmbAmadType.Name = "cmbAmadType";
            this.cmbAmadType.Size = new System.Drawing.Size(257, 29);
            this.cmbAmadType.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(266, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "نوع تجهیزات :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.cmbAmadType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.chkNotActive);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(480, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(395, 413);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات ذخیره سازی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(271, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "کد:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFillter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(26, 320);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(339, 82);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات جستوجو";
            // 
            // cmbFillter
            // 
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(14, 33);
            this.cmbFillter.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(221, 30);
            this.cmbFillter.TabIndex = 10;
            this.cmbFillter.SelectedIndexChanged += new System.EventHandler(this.cmbFillter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label3.Location = new System.Drawing.Point(236, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "فیلتر جدول :";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(255, 256);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(122, 28);
            this.chkActive.TabIndex = 17;
            this.chkActive.Text = "فعال سازی";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // chkNotActive
            // 
            this.chkNotActive.AutoSize = true;
            this.chkNotActive.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotActive.Location = new System.Drawing.Point(99, 256);
            this.chkNotActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Size = new System.Drawing.Size(149, 28);
            this.chkNotActive.TabIndex = 16;
            this.chkNotActive.Text = "غیرفعال سازی";
            this.chkNotActive.UseVisualStyleBackColor = true;
            this.chkNotActive.CheckedChanged += new System.EventHandler(this.chkNotActive_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(261, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "عنوان تجهیزات :";
            // 
            // btnInsertAmad
            // 
            this.btnInsertAmad.BackColor = System.Drawing.Color.Teal;
            this.btnInsertAmad.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnInsertAmad.ForeColor = System.Drawing.Color.White;
            this.btnInsertAmad.Location = new System.Drawing.Point(542, 22);
            this.btnInsertAmad.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertAmad.Name = "btnInsertAmad";
            this.btnInsertAmad.Size = new System.Drawing.Size(161, 60);
            this.btnInsertAmad.TabIndex = 1;
            this.btnInsertAmad.Text = "ثبت تجهیزات";
            this.btnInsertAmad.UseVisualStyleBackColor = false;
            this.btnInsertAmad.Click += new System.EventHandler(this.btnInsertAmad_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInsertAmad);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnAmadType);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(9, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(866, 95);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "دکمه های عملیاتی ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(35, 22);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 60);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(204, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 60);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAmadType
            // 
            this.btnAmadType.BackColor = System.Drawing.Color.Teal;
            this.btnAmadType.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnAmadType.ForeColor = System.Drawing.Color.White;
            this.btnAmadType.Location = new System.Drawing.Point(373, 22);
            this.btnAmadType.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmadType.Name = "btnAmadType";
            this.btnAmadType.Size = new System.Drawing.Size(161, 60);
            this.btnAmadType.TabIndex = 2;
            this.btnAmadType.Text = "افزودن نوع تجهیزات";
            this.btnAmadType.UseVisualStyleBackColor = false;
            this.btnAmadType.Click += new System.EventHandler(this.btnAmadType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAmad);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(461, 410);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمایش تجهیزات";
            // 
            // dgvAmad
            // 
            this.dgvAmad.AllowUserToAddRows = false;
            this.dgvAmad.AllowUserToDeleteRows = false;
            this.dgvAmad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colAmadTitle,
            this.colAmadTypeId,
            this.colAmadCode});
            this.dgvAmad.Location = new System.Drawing.Point(11, 30);
            this.dgvAmad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAmad.Name = "dgvAmad";
            this.dgvAmad.ReadOnly = true;
            this.dgvAmad.Size = new System.Drawing.Size(443, 369);
            this.dgvAmad.TabIndex = 0;
            this.dgvAmad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmad_CellClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "AmatID";
            this.colID.HeaderText = "Column1";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colAmadTitle
            // 
            this.colAmadTitle.DataPropertyName = "AmadTitle";
            this.colAmadTitle.HeaderText = "عنوان مراسم";
            this.colAmadTitle.Name = "colAmadTitle";
            this.colAmadTitle.ReadOnly = true;
            this.colAmadTitle.Width = 170;
            // 
            // colAmadTypeId
            // 
            this.colAmadTypeId.DataPropertyName = "AmadTypeId";
            this.colAmadTypeId.HeaderText = "نوع تجهیزات";
            this.colAmadTypeId.Name = "colAmadTypeId";
            this.colAmadTypeId.ReadOnly = true;
            this.colAmadTypeId.Width = 170;
            // 
            // colAmadCode
            // 
            this.colAmadCode.DataPropertyName = "AmadCode";
            this.colAmadCode.FillWeight = 121.8274F;
            this.colAmadCode.HeaderText = "کد تجهیزات";
            this.colAmadCode.Name = "colAmadCode";
            this.colAmadCode.ReadOnly = true;
            this.colAmadCode.Width = 170;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtTitle;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام شورا را وارد فرمایید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // frmAmat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(883, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAmat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تجهیزات";
            this.Load += new System.EventHandler(this.frmAmat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cmbAmadType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertAmad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAmadType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAmad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmadTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmadTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmadCode;
    }
}