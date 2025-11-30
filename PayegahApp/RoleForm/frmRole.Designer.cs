namespace PayegahApp.RollForm
{
    partial class frmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRole));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShora = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnInsertRoll = new System.Windows.Forms.Button();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRegestration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRoleName = new System.Windows.Forms.ComboBox();
            this.btnInsertMemberRole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNatoinalCode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShora);
            this.groupBox1.Controls.Add(this.btnrefresh);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnInsertRoll);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه ها عملیاتی";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnShora
            // 
            this.btnShora.BackColor = System.Drawing.Color.Teal;
            this.btnShora.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnShora.Location = new System.Drawing.Point(426, 26);
            this.btnShora.Name = "btnShora";
            this.btnShora.Size = new System.Drawing.Size(147, 56);
            this.btnShora.TabIndex = 2;
            this.btnShora.Text = "افزودن وظیفه";
            this.btnShora.UseVisualStyleBackColor = false;
            this.btnShora.Click += new System.EventHandler(this.btnShora_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Teal;
            this.btnrefresh.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnrefresh.Location = new System.Drawing.Point(120, 26);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(147, 56);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "بروزرسانی";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnPrint.Location = new System.Drawing.Point(273, 26);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 56);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnInsertRoll
            // 
            this.btnInsertRoll.BackColor = System.Drawing.Color.Teal;
            this.btnInsertRoll.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnInsertRoll.Location = new System.Drawing.Point(579, 26);
            this.btnInsertRoll.Name = "btnInsertRoll";
            this.btnInsertRoll.Size = new System.Drawing.Size(147, 56);
            this.btnInsertRoll.TabIndex = 1;
            this.btnInsertRoll.Text = "افزودن مقام";
            this.btnInsertRoll.UseVisualStyleBackColor = false;
            this.btnInsertRoll.Click += new System.EventHandler(this.btnInsertRoll_Click);
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.MemID,
            this.RoleTypeID,
            this.Role_ID,
            this.DateRegestration});
            this.dgvRole.Location = new System.Drawing.Point(8, 25);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.Size = new System.Drawing.Size(872, 225);
            this.dgvRole.TabIndex = 1;
            this.dgvRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellClick);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "CULID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // MemID
            // 
            this.MemID.DataPropertyName = "MemID";
            this.MemID.HeaderText = "کدملی";
            this.MemID.Name = "MemID";
            this.MemID.ReadOnly = true;
            // 
            // RoleTypeID
            // 
            this.RoleTypeID.DataPropertyName = "RoleTypeID";
            this.RoleTypeID.HeaderText = "مقام";
            this.RoleTypeID.Name = "RoleTypeID";
            this.RoleTypeID.ReadOnly = true;
            // 
            // Role_ID
            // 
            this.Role_ID.DataPropertyName = "Role_ID";
            this.Role_ID.HeaderText = "وظیفه";
            this.Role_ID.Name = "Role_ID";
            this.Role_ID.ReadOnly = true;
            // 
            // DateRegestration
            // 
            this.DateRegestration.DataPropertyName = "DateRegestration";
            this.DateRegestration.HeaderText = "تاریخ ثبت";
            this.DateRegestration.Name = "DateRegestration";
            this.DateRegestration.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRole);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 257);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عضو های ثبت شده";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNotActive);
            this.groupBox3.Controls.Add(this.chkActive);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbRoleName);
            this.groupBox3.Controls.Add(this.btnInsertMemberRole);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbRoles);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNatoinalCode);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 128);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ثبت مقام برای عضو";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkNotActive
            // 
            this.chkNotActive.AutoSize = true;
            this.chkNotActive.Font = new System.Drawing.Font("Tahoma", 13F);
            this.chkNotActive.Location = new System.Drawing.Point(15, 32);
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Size = new System.Drawing.Size(139, 26);
            this.chkNotActive.TabIndex = 10;
            this.chkNotActive.Text = "غیرفعال سازی";
            this.chkNotActive.UseVisualStyleBackColor = true;
            this.chkNotActive.CheckedChanged += new System.EventHandler(this.chkNotActive_CheckedChanged);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 13F);
            this.chkActive.Location = new System.Drawing.Point(152, 32);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(114, 26);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "فعال سازی";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 19.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(4, 72);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 47);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "ویرایش مقام";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(542, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "وظیفه :";
            // 
            // cmbRoleName
            // 
            this.cmbRoleName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbRoleName.FormattingEnabled = true;
            this.cmbRoleName.ItemHeight = 19;
            this.cmbRoleName.Location = new System.Drawing.Point(319, 93);
            this.cmbRoleName.Name = "cmbRoleName";
            this.cmbRoleName.Size = new System.Drawing.Size(217, 27);
            this.cmbRoleName.TabIndex = 6;
            this.cmbRoleName.SelectedIndexChanged += new System.EventHandler(this.cmbRoleName_SelectedIndexChanged);
            // 
            // btnInsertMemberRole
            // 
            this.btnInsertMemberRole.BackColor = System.Drawing.Color.Teal;
            this.btnInsertMemberRole.Font = new System.Drawing.Font("Times New Roman", 19.25F, System.Drawing.FontStyle.Bold);
            this.btnInsertMemberRole.Location = new System.Drawing.Point(156, 72);
            this.btnInsertMemberRole.Name = "btnInsertMemberRole";
            this.btnInsertMemberRole.Size = new System.Drawing.Size(147, 47);
            this.btnInsertMemberRole.TabIndex = 5;
            this.btnInsertMemberRole.Text = "ثبت مقام";
            this.btnInsertMemberRole.UseVisualStyleBackColor = false;
            this.btnInsertMemberRole.Click += new System.EventHandler(this.btnInsertMemberRole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(542, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "مقام ها :";
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.ItemHeight = 19;
            this.cmbRoles.Location = new System.Drawing.Point(319, 33);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(217, 27);
            this.cmbRoles.TabIndex = 2;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(804, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "کدملی :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNatoinalCode
            // 
            this.txtNatoinalCode.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtNatoinalCode.Location = new System.Drawing.Point(623, 31);
            this.txtNatoinalCode.Name = "txtNatoinalCode";
            this.txtNatoinalCode.Size = new System.Drawing.Size(181, 28);
            this.txtNatoinalCode.TabIndex = 0;
            this.txtNatoinalCode.TextChanged += new System.EventHandler(this.txtNatoinalCode_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Controls.Add(this.cmbFillter);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(6, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(878, 94);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ثبت مقام برای عضو";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label4.Location = new System.Drawing.Point(792, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "جستوجو :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label3.Location = new System.Drawing.Point(500, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "فیلتر جدول :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtSearch.Location = new System.Drawing.Point(611, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 28);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbFillter
            // 
            this.cmbFillter.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(319, 47);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(181, 29);
            this.cmbFillter.TabIndex = 2;
            this.cmbFillter.SelectedIndexChanged += new System.EventHandler(this.cmbFillter_SelectedIndexChanged);
            // 
            // stiReport
            // 
            this.stiReport.CookieContainer = null;
            this.stiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport.ReportAlias = "Report";
            this.stiReport.ReportGuid = "505d0e360d0c4b91ad55b88945bec60f";
            this.stiReport.ReportName = "Report";
            this.stiReport.ReportSource = null;
            this.stiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport.UseProgressInThread = false;
            // 
            // frmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 579);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRole";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعضای شورا";
            this.Load += new System.EventHandler(this.frmRoll_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertRoll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNatoinalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnInsertMemberRole;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRoleName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.CheckBox chkActive;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRegestration;
    }
}