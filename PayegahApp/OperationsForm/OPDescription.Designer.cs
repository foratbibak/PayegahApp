namespace PayegahApp.OperationsForm
{
    partial class OPDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPDescription));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.btnInsertDe = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvOPReports = new System.Windows.Forms.DataGridView();
            this.cmbOPeration = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descreption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegestrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPReports)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbOPeration);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(401, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(359, 368);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "شرح عملیات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.Edit);
            this.groupBox1.Controls.Add(this.btnInsertDe);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(752, 114);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه های عملیاتی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label2.Location = new System.Drawing.Point(266, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "توضیحات :";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDescription.Location = new System.Drawing.Point(9, 74);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 286);
            this.txtDescription.TabIndex = 16;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Teal;
            this.Edit.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Edit.Location = new System.Drawing.Point(454, 38);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(140, 53);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "ویرایش";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // btnInsertDe
            // 
            this.btnInsertDe.BackColor = System.Drawing.Color.Teal;
            this.btnInsertDe.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnInsertDe.Location = new System.Drawing.Point(602, 38);
            this.btnInsertDe.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertDe.Name = "btnInsertDe";
            this.btnInsertDe.Size = new System.Drawing.Size(140, 53);
            this.btnInsertDe.TabIndex = 3;
            this.btnInsertDe.Text = "ثبت گزارش";
            this.btnInsertDe.UseVisualStyleBackColor = false;
            this.btnInsertDe.Click += new System.EventHandler(this.btnInsertDe_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOPReports);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(385, 368);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "نمایش اطلاعات";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnDelete.Location = new System.Drawing.Point(306, 38);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 53);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnRefresh.Location = new System.Drawing.Point(10, 38);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 53);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvOPReports
            // 
            this.dgvOPReports.AllowUserToAddRows = false;
            this.dgvOPReports.AllowUserToDeleteRows = false;
            this.dgvOPReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.OperationID,
            this.Descreption,
            this.RegestrationDate});
            this.dgvOPReports.Location = new System.Drawing.Point(10, 27);
            this.dgvOPReports.Name = "dgvOPReports";
            this.dgvOPReports.ReadOnly = true;
            this.dgvOPReports.Size = new System.Drawing.Size(368, 333);
            this.dgvOPReports.TabIndex = 0;
            this.dgvOPReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOPReports_CellClick);
            // 
            // cmbOPeration
            // 
            this.cmbOPeration.FormattingEnabled = true;
            this.cmbOPeration.Location = new System.Drawing.Point(8, 27);
            this.cmbOPeration.Name = "cmbOPeration";
            this.cmbOPeration.Size = new System.Drawing.Size(251, 27);
            this.cmbOPeration.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.label1.Location = new System.Drawing.Point(266, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "عملیات :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnPrint.Location = new System.Drawing.Point(158, 38);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 53);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "پرینت";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // OperationID
            // 
            this.OperationID.DataPropertyName = "OperationID";
            this.OperationID.HeaderText = "عملیات";
            this.OperationID.Name = "OperationID";
            this.OperationID.ReadOnly = true;
            // 
            // Descreption
            // 
            this.Descreption.DataPropertyName = "Descreption";
            this.Descreption.HeaderText = "توضیحات";
            this.Descreption.Name = "Descreption";
            this.Descreption.ReadOnly = true;
            this.Descreption.Width = 200;
            // 
            // RegestrationDate
            // 
            this.RegestrationDate.DataPropertyName = "RegestrationDate";
            this.RegestrationDate.HeaderText = "تاریخ ثبت شده";
            this.RegestrationDate.Name = "RegestrationDate";
            this.RegestrationDate.ReadOnly = true;
            this.RegestrationDate.Width = 200;
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
            // OPDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(764, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OPDescription";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارشات";
            this.Load += new System.EventHandler(this.OPDescription_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button btnInsertDe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOPReports;
        private System.Windows.Forms.ComboBox cmbOPeration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descreption;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegestrationDate;
        private Stimulsoft.Report.StiReport stiReport;
    }
}