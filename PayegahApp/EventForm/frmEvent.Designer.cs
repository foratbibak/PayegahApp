namespace PayegahApp.EventForm
{
    partial class frmEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvent));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertEvent = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtNatoinalCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnInsertMem = new System.Windows.Forms.Button();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.btnEditMem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnRefresh.Location = new System.Drawing.Point(178, 27);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 53);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertEvent);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه های عملیاتی";
            // 
            // btnInsertEvent
            // 
            this.btnInsertEvent.BackColor = System.Drawing.Color.Teal;
            this.btnInsertEvent.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnInsertEvent.Location = new System.Drawing.Point(473, 27);
            this.btnInsertEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertEvent.Name = "btnInsertEvent";
            this.btnInsertEvent.Size = new System.Drawing.Size(140, 53);
            this.btnInsertEvent.TabIndex = 7;
            this.btnInsertEvent.Text = "افزودن مراسم";
            this.btnInsertEvent.UseVisualStyleBackColor = false;
            this.btnInsertEvent.Click += new System.EventHandler(this.btnInsertEvent_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnPrint.Location = new System.Drawing.Point(326, 27);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 53);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtNatoinalCode
            // 
            this.txtNatoinalCode.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtNatoinalCode.Location = new System.Drawing.Point(507, 25);
            this.txtNatoinalCode.Name = "txtNatoinalCode";
            this.txtNatoinalCode.Size = new System.Drawing.Size(178, 28);
            this.txtNatoinalCode.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNotActive);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Controls.Add(this.btnInsertMem);
            this.groupBox2.Controls.Add(this.cmbEvents);
            this.groupBox2.Controls.Add(this.btnEditMem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNatoinalCode);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 130);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات ثبت مراسم";
            // 
            // chkNotActive
            // 
            this.chkNotActive.AutoSize = true;
            this.chkNotActive.Font = new System.Drawing.Font("Tahoma", 13F);
            this.chkNotActive.Location = new System.Drawing.Point(495, 88);
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Size = new System.Drawing.Size(139, 26);
            this.chkNotActive.TabIndex = 11;
            this.chkNotActive.Text = "غیرفعال سازی";
            this.chkNotActive.UseVisualStyleBackColor = true;
            this.chkNotActive.CheckedChanged += new System.EventHandler(this.chkNotActive_CheckedChanged);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 13F);
            this.chkActive.Location = new System.Drawing.Point(640, 88);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(114, 26);
            this.chkActive.TabIndex = 10;
            this.chkActive.Text = "فعال سازی";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnInsertMem
            // 
            this.btnInsertMem.BackColor = System.Drawing.Color.Teal;
            this.btnInsertMem.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnInsertMem.Location = new System.Drawing.Point(155, 70);
            this.btnInsertMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertMem.Name = "btnInsertMem";
            this.btnInsertMem.Size = new System.Drawing.Size(132, 53);
            this.btnInsertMem.TabIndex = 9;
            this.btnInsertMem.Text = "ثبت ";
            this.btnInsertMem.UseVisualStyleBackColor = false;
            this.btnInsertMem.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbEvents
            // 
            this.cmbEvents.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Location = new System.Drawing.Point(141, 27);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(252, 29);
            this.cmbEvents.TabIndex = 8;
            this.cmbEvents.SelectedIndexChanged += new System.EventHandler(this.cmbEvents_SelectedIndexChanged);
            // 
            // btnEditMem
            // 
            this.btnEditMem.BackColor = System.Drawing.Color.Teal;
            this.btnEditMem.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnEditMem.Location = new System.Drawing.Point(17, 70);
            this.btnEditMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMem.Name = "btnEditMem";
            this.btnEditMem.Size = new System.Drawing.Size(130, 53);
            this.btnEditMem.TabIndex = 8;
            this.btnEditMem.Text = "ویرایش ";
            this.btnEditMem.UseVisualStyleBackColor = false;
            this.btnEditMem.Click += new System.EventHandler(this.btnEditMem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label2.Location = new System.Drawing.Point(399, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "مراسم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label1.Location = new System.Drawing.Point(691, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "کدملی :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvEvent);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(8, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 226);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "نمایش اطلاعات";
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            this.dgvEvent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.PersonFullName,
            this.PersonID,
            this.EventTitle,
            this.Date,
            this.IsActive});
            this.dgvEvent.Location = new System.Drawing.Point(9, 25);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.Size = new System.Drawing.Size(752, 195);
            this.dgvEvent.TabIndex = 0;
            this.dgvEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvent_CellClick);
            this.dgvEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvent_CellContentClick);
            this.dgvEvent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEvent_CellFormatting);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFillter);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 66);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات جستوجو :";
            // 
            // cmbFillter
            // 
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(17, 25);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(172, 27);
            this.cmbFillter.TabIndex = 13;
            this.cmbFillter.SelectedIndexChanged += new System.EventHandler(this.cmbFillter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(399, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 27);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label3.Location = new System.Drawing.Point(191, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "فیلتر جدول :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label4.Location = new System.Drawing.Point(579, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "جستوجو :";
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
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // PersonFullName
            // 
            this.PersonFullName.DataPropertyName = "PersonFullName";
            this.PersonFullName.FillWeight = 369.5432F;
            this.PersonFullName.HeaderText = "نام و نام خانوادگی";
            this.PersonFullName.Name = "PersonFullName";
            this.PersonFullName.ReadOnly = true;
            this.PersonFullName.Width = 200;
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "NationalCode";
            this.PersonID.FillWeight = 10.15228F;
            this.PersonID.HeaderText = "کدملی";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Width = 200;
            // 
            // EventTitle
            // 
            this.EventTitle.DataPropertyName = "EventTitle";
            this.EventTitle.FillWeight = 10.15228F;
            this.EventTitle.HeaderText = "مراسم";
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.ReadOnly = true;
            this.EventTitle.Width = 200;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 10.15228F;
            this.Date.HeaderText = "تاریخ ثبت شده";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 200;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "فعال/غیرفعال";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Width = 150;
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(783, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEvent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت مراسم";
            this.Load += new System.EventHandler(this.frmEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNatoinalCode;
        private System.Windows.Forms.Button btnInsertEvent;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsertMem;
        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Button btnEditMem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkNotActive;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}