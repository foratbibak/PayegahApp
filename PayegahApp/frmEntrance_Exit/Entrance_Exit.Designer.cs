namespace PayegahApp.frmEntrance_Exit
{
    partial class Entrance_Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrance_Exit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAtb = new System.Windows.Forms.DataGridView();
            this.IDd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntranceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtb)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.Controls.Add(this.btnEntrance);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(992, 112);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات ورود و خروج";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(9, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 68);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(807, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "کدملی عضو :\r\n";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.txtNationalCode.Location = new System.Drawing.Point(425, 37);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(372, 32);
            this.txtNationalCode.TabIndex = 1;
            // 
            // btnEntrance
            // 
            this.btnEntrance.BackColor = System.Drawing.Color.Teal;
            this.btnEntrance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEntrance.Location = new System.Drawing.Point(190, 23);
            this.btnEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(173, 68);
            this.btnEntrance.TabIndex = 1;
            this.btnEntrance.Text = "ورود";
            this.btnEntrance.UseVisualStyleBackColor = false;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(992, 119);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "دکمه های عملیاتی";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(213, 36);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 68);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(395, 36);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 68);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(576, 36);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 68);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arabic Typesetting", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(434, 709);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 23);
            this.label13.TabIndex = 74;
            this.label13.Text = "SharpIT Group";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAtb);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(9, 323);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Size = new System.Drawing.Size(992, 393);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اطلاعات ورود و خروج";
            // 
            // dgvAtb
            // 
            this.dgvAtb.AllowUserToAddRows = false;
            this.dgvAtb.AllowUserToDeleteRows = false;
            this.dgvAtb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDd,
            this.colPersonID,
            this.colName,
            this.colFamily,
            this.colEntranceDate,
            this.colExitDate,
            this.Locked});
            this.dgvAtb.Location = new System.Drawing.Point(9, 28);
            this.dgvAtb.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAtb.Name = "dgvAtb";
            this.dgvAtb.ReadOnly = true;
            this.dgvAtb.Size = new System.Drawing.Size(973, 354);
            this.dgvAtb.TabIndex = 0;
            // 
            // IDd
            // 
            this.IDd.DataPropertyName = "ID";
            this.IDd.HeaderText = "IDd";
            this.IDd.Name = "IDd";
            this.IDd.ReadOnly = true;
            this.IDd.Visible = false;
            // 
            // colPersonID
            // 
            this.colPersonID.DataPropertyName = "PersonID";
            this.colPersonID.FillWeight = 52.25809F;
            this.colPersonID.HeaderText = "کدملی";
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            this.colPersonID.Width = 155;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.FillWeight = 31.30015F;
            this.colName.HeaderText = "نام";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 155;
            // 
            // colFamily
            // 
            this.colFamily.DataPropertyName = "Family";
            this.colFamily.FillWeight = 68.13844F;
            this.colFamily.HeaderText = "نام خانوادگی";
            this.colFamily.Name = "colFamily";
            this.colFamily.ReadOnly = true;
            this.colFamily.Width = 155;
            // 
            // colEntranceDate
            // 
            this.colEntranceDate.DataPropertyName = "EntranceDate";
            this.colEntranceDate.FillWeight = 49.65804F;
            this.colEntranceDate.HeaderText = "تاریخ ورود";
            this.colEntranceDate.Name = "colEntranceDate";
            this.colEntranceDate.ReadOnly = true;
            this.colEntranceDate.Width = 200;
            // 
            // colExitDate
            // 
            this.colExitDate.DataPropertyName = "ExitDate";
            this.colExitDate.FillWeight = 247.0833F;
            this.colExitDate.HeaderText = "تاریخ خروج";
            this.colExitDate.Name = "colExitDate";
            this.colExitDate.ReadOnly = true;
            this.colExitDate.Width = 200;
            // 
            // Locked
            // 
            this.Locked.DataPropertyName = "Locked";
            this.Locked.FillWeight = 151.5622F;
            this.Locked.HeaderText = "قفل";
            this.Locked.Name = "Locked";
            this.Locked.ReadOnly = true;
            this.Locked.Width = 155;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkShowAll);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(9, 236);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Size = new System.Drawing.Size(992, 86);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "عملیات جستوجو";
            // 
            // chkShowAll
            // 
            this.chkShowAll.AutoSize = true;
            this.chkShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.chkShowAll.Location = new System.Drawing.Point(275, 40);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(111, 29);
            this.chkShowAll.TabIndex = 18;
            this.chkShowAll.Text = "نمایش همه";
            this.chkShowAll.UseVisualStyleBackColor = true;
            this.chkShowAll.CheckedChanged += new System.EventHandler(this.chkShowAll_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(807, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "جستوجو :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.txtSearch.Location = new System.Drawing.Point(425, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(372, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "c9a26ba173004a64beee960bac49f12f";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtNationalCode;
            this.requiredFieldValidator1.ErrorMessage = "لطفا کدملی کاربر را برای عملیات وارد فرمایید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // Entrance_Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1012, 731);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Entrance_Exit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حضور و غیاب";
            this.Load += new System.EventHandler(this.Entrance_Exit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtb)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.DataGridView dgvAtb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private Stimulsoft.Report.StiReport stiReport1;
        private System.Windows.Forms.CheckBox chkShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntranceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locked;
    }
}