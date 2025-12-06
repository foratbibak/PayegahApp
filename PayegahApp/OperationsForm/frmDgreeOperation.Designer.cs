namespace PayegahApp.OperationsForm
{
    partial class frmDgreeOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDgreeOperation));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dgvDgree = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInsertDg = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.colDgreeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDgTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegestrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDgree)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtTitle.Location = new System.Drawing.Point(10, 30);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(215, 28);
            this.txtTitle.TabIndex = 12;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // dgvDgree
            // 
            this.dgvDgree.AllowUserToAddRows = false;
            this.dgvDgree.AllowUserToDeleteRows = false;
            this.dgvDgree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDgree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDgreeID,
            this.colDgTitle,
            this.colRegestrationDate,
            this.IsActive});
            this.dgvDgree.Location = new System.Drawing.Point(9, 30);
            this.dgvDgree.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDgree.Name = "dgvDgree";
            this.dgvDgree.ReadOnly = true;
            this.dgvDgree.Size = new System.Drawing.Size(330, 291);
            this.dgvDgree.TabIndex = 0;
            this.dgvDgree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDgree_CellClick);
            this.dgvDgree.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDgree_CellContentClick);
            this.dgvDgree.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDgree_CellFormatting);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInsertDg);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(10, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(725, 95);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "دکمه های عملیاتی ";
            // 
            // btnInsertDg
            // 
            this.btnInsertDg.BackColor = System.Drawing.Color.Teal;
            this.btnInsertDg.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnInsertDg.ForeColor = System.Drawing.Color.White;
            this.btnInsertDg.Location = new System.Drawing.Point(380, 24);
            this.btnInsertDg.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertDg.Name = "btnInsertDg";
            this.btnInsertDg.Size = new System.Drawing.Size(161, 60);
            this.btnInsertDg.TabIndex = 1;
            this.btnInsertDg.Text = "ثبت مسئولیت";
            this.btnInsertDg.UseVisualStyleBackColor = false;
            this.btnInsertDg.Click += new System.EventHandler(this.btnInsertDg_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(32, 24);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 60);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 13.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(201, 24);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(161, 60);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDgree);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(10, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(351, 330);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نمایش مسئولیت ها";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(228, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "نام مسئولیت :";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(166, 87);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(122, 28);
            this.chkActive.TabIndex = 17;
            this.chkActive.Text = "فعال سازی";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbFillter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 238);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(339, 82);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات جستوجو";
            // 
            // chkNotActive
            // 
            this.chkNotActive.AutoSize = true;
            this.chkNotActive.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotActive.Location = new System.Drawing.Point(10, 87);
            this.chkNotActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Size = new System.Drawing.Size(149, 28);
            this.chkNotActive.TabIndex = 16;
            this.chkNotActive.Text = "غیرفعال سازی";
            this.chkNotActive.UseVisualStyleBackColor = true;
            this.chkNotActive.CheckedChanged += new System.EventHandler(this.chkNotActive_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.chkNotActive);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(371, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(364, 331);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات ذخیره سازی";
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
            // colDgreeID
            // 
            this.colDgreeID.DataPropertyName = "DgreeID";
            this.colDgreeID.HeaderText = "Column1";
            this.colDgreeID.Name = "colDgreeID";
            this.colDgreeID.ReadOnly = true;
            this.colDgreeID.Visible = false;
            // 
            // colDgTitle
            // 
            this.colDgTitle.DataPropertyName = "DgTitle";
            this.colDgTitle.HeaderText = " نام درجه";
            this.colDgTitle.Name = "colDgTitle";
            this.colDgTitle.ReadOnly = true;
            this.colDgTitle.Width = 135;
            // 
            // colRegestrationDate
            // 
            this.colRegestrationDate.DataPropertyName = "RegestrationDate";
            this.colRegestrationDate.FillWeight = 121.8274F;
            this.colRegestrationDate.HeaderText = "تایخ ثبت شده";
            this.colRegestrationDate.Name = "colRegestrationDate";
            this.colRegestrationDate.ReadOnly = true;
            this.colRegestrationDate.Width = 200;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "فعال/غیرفعال";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Width = 150;
            // 
            // frmDgreeOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(747, 443);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDgreeOperation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دجه عضو در عملیات";
            this.Load += new System.EventHandler(this.frmDgreeOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDgree)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dgvDgree;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInsertDg;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDgreeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDgTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegestrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}