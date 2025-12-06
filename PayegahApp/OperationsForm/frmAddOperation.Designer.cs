namespace PayegahApp.OperationsForm
{
    partial class frmAddOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOperation));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertOp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnOpType = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperationTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
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
            // cmbOperation
            // 
            this.cmbOperation.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(10, 160);
            this.cmbOperation.Margin = new System.Windows.Forms.Padding(5);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(257, 29);
            this.cmbOperation.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(271, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "نوع عملیات :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbOperation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.chkNotActive);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(482, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(395, 413);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات ذخیره سازی";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFillter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 305);
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
            this.chkActive.Location = new System.Drawing.Point(256, 231);
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
            this.chkNotActive.Location = new System.Drawing.Point(100, 231);
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
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "عنوان عملیات :";
            // 
            // btnInsertOp
            // 
            this.btnInsertOp.BackColor = System.Drawing.Color.Teal;
            this.btnInsertOp.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnInsertOp.ForeColor = System.Drawing.Color.White;
            this.btnInsertOp.Location = new System.Drawing.Point(547, 23);
            this.btnInsertOp.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertOp.Name = "btnInsertOp";
            this.btnInsertOp.Size = new System.Drawing.Size(161, 60);
            this.btnInsertOp.TabIndex = 1;
            this.btnInsertOp.Text = "ثبت عملیات";
            this.btnInsertOp.UseVisualStyleBackColor = false;
            this.btnInsertOp.Click += new System.EventHandler(this.btnInsertOp_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInsertOp);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnOpType);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 3);
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
            this.btnRefresh.Location = new System.Drawing.Point(40, 23);
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
            this.btnEdit.Location = new System.Drawing.Point(209, 23);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 60);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnOpType
            // 
            this.btnOpType.BackColor = System.Drawing.Color.Teal;
            this.btnOpType.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnOpType.ForeColor = System.Drawing.Color.White;
            this.btnOpType.Location = new System.Drawing.Point(378, 23);
            this.btnOpType.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpType.Name = "btnOpType";
            this.btnOpType.Size = new System.Drawing.Size(161, 60);
            this.btnOpType.TabIndex = 2;
            this.btnOpType.Text = "افزودن نوع عملیات";
            this.btnOpType.UseVisualStyleBackColor = false;
            this.btnOpType.Click += new System.EventHandler(this.btnOpType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOperation);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(461, 413);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمایش عملیات";
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            this.dgvOperation.AllowUserToDeleteRows = false;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colOperationTitle,
            this.colOperationType,
            this.colOperationDate,
            this.IsActive});
            this.dgvOperation.Location = new System.Drawing.Point(9, 30);
            this.dgvOperation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.ReadOnly = true;
            this.dgvOperation.Size = new System.Drawing.Size(443, 369);
            this.dgvOperation.TabIndex = 0;
            this.dgvOperation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperation_CellClick);
            this.dgvOperation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOperation_CellFormatting);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtTitle;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام شورا را وارد فرمایید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
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
            this.colID.DataPropertyName = "OperationID";
            this.colID.HeaderText = "Column1";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colOperationTitle
            // 
            this.colOperationTitle.DataPropertyName = "OperationTitle";
            this.colOperationTitle.HeaderText = "عنوان عملیات";
            this.colOperationTitle.Name = "colOperationTitle";
            this.colOperationTitle.ReadOnly = true;
            this.colOperationTitle.Width = 135;
            // 
            // colOperationType
            // 
            this.colOperationType.DataPropertyName = "OperationTypeTitle";
            this.colOperationType.FillWeight = 78.17259F;
            this.colOperationType.HeaderText = "نوع عملیات";
            this.colOperationType.Name = "colOperationType";
            this.colOperationType.ReadOnly = true;
            this.colOperationType.Width = 135;
            // 
            // colOperationDate
            // 
            this.colOperationDate.DataPropertyName = "Date";
            this.colOperationDate.FillWeight = 121.8274F;
            this.colOperationDate.HeaderText = "تایخ ثبت شده";
            this.colOperationDate.Name = "colOperationDate";
            this.colOperationDate.ReadOnly = true;
            this.colOperationDate.Width = 200;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "فعال/غیرفعال";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // frmAddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(886, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddOperation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن عملیات";
            this.Load += new System.EventHandler(this.frmAddOperation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertOp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOpType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOperation;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}