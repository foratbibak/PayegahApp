namespace PayegahApp.Amat
{
    partial class frmAmatType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmatType));
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAmatType = new System.Windows.Forms.DataGridView();
            this.colAmadTypeIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsertAmatType = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmatType)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtTitle;
            this.requiredFieldValidator2.ErrorMessage = "لطفا نوع مراسم را وارد کنید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtTitle.Location = new System.Drawing.Point(10, 41);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(269, 28);
            this.txtTitle.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(279, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "نوع تجهیزات :";
            // 
            // dgvAmatType
            // 
            this.dgvAmatType.AllowUserToAddRows = false;
            this.dgvAmatType.AllowUserToDeleteRows = false;
            this.dgvAmatType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmatType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAmadTypeIID,
            this.colTitle,
            this.colDate});
            this.dgvAmatType.Location = new System.Drawing.Point(9, 27);
            this.dgvAmatType.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAmatType.Name = "dgvAmatType";
            this.dgvAmatType.ReadOnly = true;
            this.dgvAmatType.Size = new System.Drawing.Size(325, 304);
            this.dgvAmatType.TabIndex = 0;
            this.dgvAmatType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmatType_CellClick);
            // 
            // colAmadTypeIID
            // 
            this.colAmadTypeIID.DataPropertyName = "AmadTypeIID";
            this.colAmadTypeIID.FillWeight = 78.17259F;
            this.colAmadTypeIID.HeaderText = "ایدی";
            this.colAmadTypeIID.Name = "colAmadTypeIID";
            this.colAmadTypeIID.ReadOnly = true;
            this.colAmadTypeIID.Visible = false;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "AmadTitle";
            this.colTitle.HeaderText = "نوع تجهیزات";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 200;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "DateRegistration";
            this.colDate.FillWeight = 121.8274F;
            this.colDate.HeaderText = "تاریخ ثبت";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAmatType);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(10, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(343, 340);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمایش وظایف";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFillter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(13, 235);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(374, 82);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات جستوجو";
            // 
            // cmbFillter
            // 
            this.cmbFillter.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(10, 34);
            this.cmbFillter.Margin = new System.Windows.Forms.Padding(5);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(221, 29);
            this.cmbFillter.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label3.Location = new System.Drawing.Point(241, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "فیلتر جدول :";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(262, 106);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(119, 27);
            this.chkActive.TabIndex = 17;
            this.chkActive.Text = "فعال سازی";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // chkNotActive
            // 
            this.chkNotActive.AutoSize = true;
            this.chkNotActive.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotActive.Location = new System.Drawing.Point(103, 106);
            this.chkNotActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Size = new System.Drawing.Size(151, 27);
            this.chkNotActive.TabIndex = 16;
            this.chkNotActive.Text = "غیر فعال سازی";
            this.chkNotActive.UseVisualStyleBackColor = true;
            this.chkNotActive.CheckedChanged += new System.EventHandler(this.chkNotActive_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(86, 22);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 60);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(255, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 60);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsertAmatType
            // 
            this.btnInsertAmatType.BackColor = System.Drawing.Color.Teal;
            this.btnInsertAmatType.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnInsertAmatType.ForeColor = System.Drawing.Color.White;
            this.btnInsertAmatType.Location = new System.Drawing.Point(424, 22);
            this.btnInsertAmatType.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertAmatType.Name = "btnInsertAmatType";
            this.btnInsertAmatType.Size = new System.Drawing.Size(161, 60);
            this.btnInsertAmatType.TabIndex = 1;
            this.btnInsertAmatType.Text = "افزودن نوع تجهیزات";
            this.btnInsertAmatType.UseVisualStyleBackColor = false;
            this.btnInsertAmatType.Click += new System.EventHandler(this.btnInsertAmatType_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtTitle;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام شورا را وارد فرمایید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnInsertAmatType);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(10, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(750, 95);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "دکمه های عملیاتی ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.chkNotActive);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(363, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(397, 340);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات ذخیره سازی";
            // 
            // frmAmatType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAmatType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوع تجهیزات";
            this.Load += new System.EventHandler(this.frmAmatType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmatType)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAmatType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsertAmatType;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmadTypeIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}