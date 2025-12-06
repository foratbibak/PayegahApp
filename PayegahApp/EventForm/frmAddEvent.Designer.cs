namespace PayegahApp.EventForm
{
    partial class frmAddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEvent));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.colEventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEventType = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInsertEvent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtTitle.Location = new System.Drawing.Point(10, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(257, 28);
            this.txtTitle.TabIndex = 12;
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            this.dgvEvent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEventID,
            this.colEventTitle,
            this.colEventType,
            this.colDescription,
            this.colEventDate,
            this.IsActive});
            this.dgvEvent.Location = new System.Drawing.Point(9, 30);
            this.dgvEvent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.Size = new System.Drawing.Size(443, 369);
            this.dgvEvent.TabIndex = 0;
            this.dgvEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvent_CellClick);
            this.dgvEvent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEvent_CellFormatting);
            // 
            // colEventID
            // 
            this.colEventID.DataPropertyName = "EventID";
            this.colEventID.HeaderText = "Column1";
            this.colEventID.Name = "colEventID";
            this.colEventID.ReadOnly = true;
            this.colEventID.Visible = false;
            // 
            // colEventTitle
            // 
            this.colEventTitle.DataPropertyName = "EventTitle";
            this.colEventTitle.HeaderText = "عنوان مراسم";
            this.colEventTitle.Name = "colEventTitle";
            this.colEventTitle.ReadOnly = true;
            this.colEventTitle.Width = 135;
            // 
            // colEventType
            // 
            this.colEventType.DataPropertyName = "Title";
            this.colEventType.FillWeight = 78.17259F;
            this.colEventType.HeaderText = "نوع مراسم";
            this.colEventType.Name = "colEventType";
            this.colEventType.ReadOnly = true;
            this.colEventType.Width = 135;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.FillWeight = 121.8274F;
            this.colDescription.HeaderText = "توضیحات";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 134;
            // 
            // colEventDate
            // 
            this.colEventDate.DataPropertyName = "Date";
            this.colEventDate.HeaderText = "تاریخ ثبت شده";
            this.colEventDate.Name = "colEventDate";
            this.colEventDate.ReadOnly = true;
            this.colEventDate.Width = 200;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "فعال/غیرفعال";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEvent);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(461, 413);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمایش وظایف";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFillter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(18, 323);
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
            this.cmbFillter.Location = new System.Drawing.Point(10, 33);
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
            this.label3.Location = new System.Drawing.Point(241, 36);
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
            this.chkActive.Location = new System.Drawing.Point(256, 281);
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
            this.chkNotActive.Location = new System.Drawing.Point(100, 281);
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
            this.label4.Location = new System.Drawing.Point(271, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "عنوان مراسم :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(40, 25);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 60);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(209, 25);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 60);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEventType
            // 
            this.btnEventType.BackColor = System.Drawing.Color.Teal;
            this.btnEventType.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnEventType.ForeColor = System.Drawing.Color.White;
            this.btnEventType.Location = new System.Drawing.Point(378, 25);
            this.btnEventType.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventType.Name = "btnEventType";
            this.btnEventType.Size = new System.Drawing.Size(161, 60);
            this.btnEventType.TabIndex = 4;
            this.btnEventType.Text = "افزودن نوع مراسم";
            this.btnEventType.UseVisualStyleBackColor = false;
            this.btnEventType.Click += new System.EventHandler(this.btnEventType_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInsertEvent);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnEventType);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(8, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(866, 95);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "دکمه های عملیاتی ";
            // 
            // btnInsertEvent
            // 
            this.btnInsertEvent.BackColor = System.Drawing.Color.Teal;
            this.btnInsertEvent.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnInsertEvent.ForeColor = System.Drawing.Color.White;
            this.btnInsertEvent.Location = new System.Drawing.Point(547, 25);
            this.btnInsertEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertEvent.Name = "btnInsertEvent";
            this.btnInsertEvent.Size = new System.Drawing.Size(161, 60);
            this.btnInsertEvent.TabIndex = 8;
            this.btnInsertEvent.Text = "ثبت مراسم";
            this.btnInsertEvent.UseVisualStyleBackColor = false;
            this.btnInsertEvent.Click += new System.EventHandler(this.btnInsertEvent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.cmbEvent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.chkNotActive);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(479, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(395, 413);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات ذخیره سازی";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtDescription.Location = new System.Drawing.Point(10, 170);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(257, 89);
            this.txtDescription.TabIndex = 20;
            // 
            // cmbEvent
            // 
            this.cmbEvent.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(10, 96);
            this.cmbEvent.Margin = new System.Windows.Forms.Padding(5);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(257, 29);
            this.cmbEvent.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(271, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "نوع مراسم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(271, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "توضیحات :";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtTitle;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام شورا را وارد فرمایید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(877, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEvent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن مراسم";
            this.Load += new System.EventHandler(this.frmAddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEventType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}