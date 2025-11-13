namespace PayegahApp.Pesrsons
{
    partial class frmPersons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersons));
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNotActive = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatherJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatherPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(797, 23);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(171, 56);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "افزودن عضو جدید";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(642, 23);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 56);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "ویرایش عضو\r\n";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(177, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 56);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.txtSearch.Location = new System.Drawing.Point(522, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotActive);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnActive);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(976, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه های عملیاتی";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNotActive
            // 
            this.btnNotActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotActive.Location = new System.Drawing.Point(332, 23);
            this.btnNotActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNotActive.Name = "btnNotActive";
            this.btnNotActive.Size = new System.Drawing.Size(147, 56);
            this.btnNotActive.TabIndex = 5;
            this.btnNotActive.Text = "غیر فعال سازی";
            this.btnNotActive.UseVisualStyleBackColor = true;
            this.btnNotActive.Click += new System.EventHandler(this.btnNotActive_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(22, 23);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(147, 56);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnActive
            // 
            this.btnActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.Location = new System.Drawing.Point(487, 23);
            this.btnActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(147, 56);
            this.btnActive.TabIndex = 3;
            this.btnActive.Text = "فعال سازی";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbFillter);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(976, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات جستوجو ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(871, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "جستو جو :";
            // 
            // cmbFillter
            // 
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(22, 25);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(241, 26);
            this.cmbFillter.TabIndex = 8;
            this.cmbFillter.SelectedIndexChanged += new System.EventHandler(this.cmbFillter_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPerson);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 168);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(976, 377);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اطلاعات اعضای پایگاه";
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.NationalCod,
            this.PersonName,
            this.PersonFamily,
            this.PersonAddress,
            this.PostalCode,
            this.PhoneNumber,
            this.DateBirth,
            this.FatherJob,
            this.MatherJob,
            this.FatherPhoneNumber,
            this.MatherPhoneNumber,
            this.RegistrationDate});
            this.dgvPerson.Location = new System.Drawing.Point(9, 24);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.Size = new System.Drawing.Size(959, 347);
            this.dgvPerson.TabIndex = 5;
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
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonID";
            this.PersonId.HeaderText = "کد کاربر";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            this.PersonId.Visible = false;
            // 
            // NationalCod
            // 
            this.NationalCod.DataPropertyName = "NationalCode";
            this.NationalCod.FillWeight = 112.1801F;
            this.NationalCod.HeaderText = "کدملی";
            this.NationalCod.Name = "NationalCod";
            this.NationalCod.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.FillWeight = 109.1005F;
            this.PersonName.HeaderText = "نام عضو";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // PersonFamily
            // 
            this.PersonFamily.DataPropertyName = "PersonFamily";
            this.PersonFamily.FillWeight = 100.3754F;
            this.PersonFamily.HeaderText = "نام خانوادگی عضو";
            this.PersonFamily.Name = "PersonFamily";
            this.PersonFamily.ReadOnly = true;
            this.PersonFamily.Width = 160;
            // 
            // PersonAddress
            // 
            this.PersonAddress.DataPropertyName = "PersonAddress";
            this.PersonAddress.FillWeight = 100.2989F;
            this.PersonAddress.HeaderText = "آدرس عضو";
            this.PersonAddress.Name = "PersonAddress";
            this.PersonAddress.ReadOnly = true;
            this.PersonAddress.Width = 130;
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.FillWeight = 99.4603F;
            this.PostalCode.HeaderText = "کدپستی";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.FillWeight = 95.4987F;
            this.PhoneNumber.HeaderText = "شماره تماس عضو";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 165;
            // 
            // DateBirth
            // 
            this.DateBirth.DataPropertyName = "Birthday";
            this.DateBirth.FillWeight = 94.49576F;
            this.DateBirth.HeaderText = "تاریخ تولد";
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.ReadOnly = true;
            this.DateBirth.Width = 120;
            // 
            // FatherJob
            // 
            this.FatherJob.DataPropertyName = "FotherJob";
            this.FatherJob.FillWeight = 96.74873F;
            this.FatherJob.HeaderText = "شغل پدر";
            this.FatherJob.Name = "FatherJob";
            this.FatherJob.ReadOnly = true;
            this.FatherJob.Width = 130;
            // 
            // MatherJob
            // 
            this.MatherJob.DataPropertyName = "MotherJob";
            this.MatherJob.FillWeight = 98.20277F;
            this.MatherJob.HeaderText = "شغل مادر";
            this.MatherJob.Name = "MatherJob";
            this.MatherJob.ReadOnly = true;
            this.MatherJob.Width = 130;
            // 
            // FatherPhoneNumber
            // 
            this.FatherPhoneNumber.DataPropertyName = "FotherPhoneNumber";
            this.FatherPhoneNumber.FillWeight = 97.37F;
            this.FatherPhoneNumber.HeaderText = "شماره تماس پدر";
            this.FatherPhoneNumber.Name = "FatherPhoneNumber";
            this.FatherPhoneNumber.ReadOnly = true;
            this.FatherPhoneNumber.Width = 160;
            // 
            // MatherPhoneNumber
            // 
            this.MatherPhoneNumber.DataPropertyName = "MotherPhoneNumber";
            this.MatherPhoneNumber.FillWeight = 95.9256F;
            this.MatherPhoneNumber.HeaderText = "شماره تماس مادر";
            this.MatherPhoneNumber.Name = "MatherPhoneNumber";
            this.MatherPhoneNumber.ReadOnly = true;
            this.MatherPhoneNumber.Width = 160;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.FillWeight = 100.3437F;
            this.RegistrationDate.HeaderText = "تاریخ ثبت";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            this.RegistrationDate.Width = 150;
            // 
            // frmPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(994, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPersons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعضای پایگاه";
            this.Load += new System.EventHandler(this.frmPersons_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btnPrint;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.Button btnNotActive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatherJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatherPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
    }
}