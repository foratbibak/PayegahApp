namespace PayegahApp.OperationsForm
{
    partial class OperationMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationMember));
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnInsertMem = new System.Windows.Forms.Button();
            this.cmbOperations = new System.Windows.Forms.ComboBox();
            this.btnEditMem = new System.Windows.Forms.Button();
            this.dgvOpM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDgree = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNatoinalCode = new System.Windows.Forms.TextBox();
            this.btnInsertOp = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDescriptionOP = new System.Windows.Forms.Button();
            this.btnDgree = new System.Windows.Forms.Button();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpM)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFillter
            // 
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(83, 26);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(172, 27);
            this.cmbFillter.TabIndex = 13;
            this.cmbFillter.SelectedIndexChanged += new System.EventHandler(this.cmbFillter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(477, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 27);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label4.Location = new System.Drawing.Point(657, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "جستوجو :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFillter);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(891, 66);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات جستوجو :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label3.Location = new System.Drawing.Point(257, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "فیلتر جدول :";
            // 
            // chkNotActive
            // 
            this.chkNotActive.AutoSize = true;
            this.chkNotActive.Font = new System.Drawing.Font("Tahoma", 14F);
            this.chkNotActive.Location = new System.Drawing.Point(6, 26);
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Size = new System.Drawing.Size(145, 27);
            this.chkNotActive.TabIndex = 11;
            this.chkNotActive.Text = "غیرفعال سازی";
            this.chkNotActive.UseVisualStyleBackColor = true;
            this.chkNotActive.CheckedChanged += new System.EventHandler(this.chkNotActive_CheckedChanged);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 14F);
            this.chkActive.Location = new System.Drawing.Point(153, 26);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(119, 27);
            this.chkActive.TabIndex = 10;
            this.chkActive.Text = "فعال سازی";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // btnInsertMem
            // 
            this.btnInsertMem.BackColor = System.Drawing.Color.Teal;
            this.btnInsertMem.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnInsertMem.Location = new System.Drawing.Point(144, 73);
            this.btnInsertMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertMem.Name = "btnInsertMem";
            this.btnInsertMem.Size = new System.Drawing.Size(132, 53);
            this.btnInsertMem.TabIndex = 6;
            this.btnInsertMem.Text = "ثبت ";
            this.btnInsertMem.UseVisualStyleBackColor = false;
            this.btnInsertMem.Click += new System.EventHandler(this.btnInsertMem_Click);
            // 
            // cmbOperations
            // 
            this.cmbOperations.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbOperations.FormattingEnabled = true;
            this.cmbOperations.Location = new System.Drawing.Point(301, 31);
            this.cmbOperations.Name = "cmbOperations";
            this.cmbOperations.Size = new System.Drawing.Size(248, 26);
            this.cmbOperations.TabIndex = 8;
            // 
            // btnEditMem
            // 
            this.btnEditMem.BackColor = System.Drawing.Color.Teal;
            this.btnEditMem.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnEditMem.Location = new System.Drawing.Point(6, 73);
            this.btnEditMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMem.Name = "btnEditMem";
            this.btnEditMem.Size = new System.Drawing.Size(130, 53);
            this.btnEditMem.TabIndex = 7;
            this.btnEditMem.Text = "ویرایش ";
            this.btnEditMem.UseVisualStyleBackColor = false;
            this.btnEditMem.Click += new System.EventHandler(this.btnEditMem_Click);
            // 
            // dgvOpM
            // 
            this.dgvOpM.AllowUserToAddRows = false;
            this.dgvOpM.AllowUserToDeleteRows = false;
            this.dgvOpM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOpM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.PersonFullName,
            this.NationalCode,
            this.OperationTitle,
            this.DgTitle,
            this.Date,
            this.IsActive});
            this.dgvOpM.Location = new System.Drawing.Point(6, 25);
            this.dgvOpM.Name = "dgvOpM";
            this.dgvOpM.ReadOnly = true;
            this.dgvOpM.Size = new System.Drawing.Size(879, 246);
            this.dgvOpM.TabIndex = 0;
            this.dgvOpM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpM_CellClick);
            this.dgvOpM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOpM_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label2.Location = new System.Drawing.Point(546, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "عملیات :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label1.Location = new System.Drawing.Point(802, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "کدملی :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDgree);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkNotActive);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Controls.Add(this.btnInsertMem);
            this.groupBox2.Controls.Add(this.btnEditMem);
            this.groupBox2.Controls.Add(this.cmbOperations);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNatoinalCode);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 130);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات ثبت مراسم";
            // 
            // cmbDgree
            // 
            this.cmbDgree.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbDgree.FormattingEnabled = true;
            this.cmbDgree.Location = new System.Drawing.Point(301, 88);
            this.cmbDgree.Name = "cmbDgree";
            this.cmbDgree.Size = new System.Drawing.Size(248, 26);
            this.cmbDgree.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label5.Location = new System.Drawing.Point(547, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "مسئولیت :";
            // 
            // txtNatoinalCode
            // 
            this.txtNatoinalCode.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtNatoinalCode.Location = new System.Drawing.Point(626, 32);
            this.txtNatoinalCode.Name = "txtNatoinalCode";
            this.txtNatoinalCode.Size = new System.Drawing.Size(176, 28);
            this.txtNatoinalCode.TabIndex = 5;
            // 
            // btnInsertOp
            // 
            this.btnInsertOp.BackColor = System.Drawing.Color.Teal;
            this.btnInsertOp.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnInsertOp.Location = new System.Drawing.Point(597, 27);
            this.btnInsertOp.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertOp.Name = "btnInsertOp";
            this.btnInsertOp.Size = new System.Drawing.Size(140, 53);
            this.btnInsertOp.TabIndex = 1;
            this.btnInsertOp.Text = "افزودن عملیات";
            this.btnInsertOp.UseVisualStyleBackColor = false;
            this.btnInsertOp.Click += new System.EventHandler(this.btnInsertOp_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnPrint.Location = new System.Drawing.Point(153, 27);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 53);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnRefresh.Location = new System.Drawing.Point(5, 27);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 53);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvOpM);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(8, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(891, 277);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "نمایش اطلاعات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDescriptionOP);
            this.groupBox1.Controls.Add(this.btnDgree);
            this.groupBox1.Controls.Add(this.btnInsertOp);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه های عملیاتی";
            // 
            // btnDescriptionOP
            // 
            this.btnDescriptionOP.BackColor = System.Drawing.Color.Teal;
            this.btnDescriptionOP.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnDescriptionOP.Location = new System.Drawing.Point(301, 27);
            this.btnDescriptionOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescriptionOP.Name = "btnDescriptionOP";
            this.btnDescriptionOP.Size = new System.Drawing.Size(140, 53);
            this.btnDescriptionOP.TabIndex = 3;
            this.btnDescriptionOP.Text = "گزارش عملیات";
            this.btnDescriptionOP.UseVisualStyleBackColor = false;
            this.btnDescriptionOP.Click += new System.EventHandler(this.btnDescriptionOP_Click);
            // 
            // btnDgree
            // 
            this.btnDgree.BackColor = System.Drawing.Color.Teal;
            this.btnDgree.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnDgree.Location = new System.Drawing.Point(449, 27);
            this.btnDgree.Margin = new System.Windows.Forms.Padding(4);
            this.btnDgree.Name = "btnDgree";
            this.btnDgree.Size = new System.Drawing.Size(140, 53);
            this.btnDgree.TabIndex = 2;
            this.btnDgree.Text = "افزودن مسئولیت";
            this.btnDgree.UseVisualStyleBackColor = false;
            this.btnDgree.Click += new System.EventHandler(this.btnDgree_Click);
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
            this.colID.DataPropertyName = "OperationMemberID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // PersonFullName
            // 
            this.PersonFullName.DataPropertyName = "PersonFullName";
            this.PersonFullName.HeaderText = "نام و نام خانوادگی";
            this.PersonFullName.Name = "PersonFullName";
            this.PersonFullName.ReadOnly = true;
            this.PersonFullName.Width = 200;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "کدملی";
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            this.NationalCode.Width = 200;
            // 
            // OperationTitle
            // 
            this.OperationTitle.DataPropertyName = "OPFullName";
            this.OperationTitle.HeaderText = "عملیات";
            this.OperationTitle.Name = "OperationTitle";
            this.OperationTitle.ReadOnly = true;
            this.OperationTitle.Width = 200;
            // 
            // DgTitle
            // 
            this.DgTitle.DataPropertyName = "DgTitle";
            this.DgTitle.HeaderText = "مسئولیت عضو";
            this.DgTitle.Name = "DgTitle";
            this.DgTitle.ReadOnly = true;
            this.DgTitle.Width = 200;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
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
            // OperationMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(909, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperationMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملیات ";
            this.Load += new System.EventHandler(this.OperationMember_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnInsertMem;
        private System.Windows.Forms.ComboBox cmbOperations;
        private System.Windows.Forms.Button btnEditMem;
        private System.Windows.Forms.DataGridView dgvOpM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNatoinalCode;
        private System.Windows.Forms.Button btnInsertOp;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDgree;
        private System.Windows.Forms.ComboBox cmbDgree;
        private System.Windows.Forms.Label label5;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.Button btnDescriptionOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}