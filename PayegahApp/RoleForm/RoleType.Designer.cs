namespace PayegahApp.RollForm
{
    partial class RoleType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsertRoll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNotActive = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbFillter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRollType = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRollType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnInsertRoll);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(636, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه های عملیاتی";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnRefresh.Location = new System.Drawing.Point(95, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 56);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnEdit.Location = new System.Drawing.Point(247, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 56);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertRoll
            // 
            this.btnInsertRoll.BackColor = System.Drawing.Color.Teal;
            this.btnInsertRoll.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnInsertRoll.Location = new System.Drawing.Point(380, 26);
            this.btnInsertRoll.Name = "btnInsertRoll";
            this.btnInsertRoll.Size = new System.Drawing.Size(153, 56);
            this.btnInsertRoll.TabIndex = 1;
            this.btnInsertRoll.Text = "افزودن";
            this.btnInsertRoll.UseVisualStyleBackColor = false;
            this.btnInsertRoll.Click += new System.EventHandler(this.btnInsertRoll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNotActive);
            this.groupBox3.Controls.Add(this.chkActive);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCode);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtRoll);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 101);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(636, 386);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات مقام";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkNotActive
            // 
            this.chkNotActive.AutoSize = true;
            this.chkNotActive.Font = new System.Drawing.Font("Tahoma", 13F);
            this.chkNotActive.Location = new System.Drawing.Point(358, 197);
            this.chkNotActive.Name = "chkNotActive";
            this.chkNotActive.Size = new System.Drawing.Size(139, 26);
            this.chkNotActive.TabIndex = 17;
            this.chkNotActive.Text = "غیرفعال سازی";
            this.chkNotActive.UseVisualStyleBackColor = true;
            this.chkNotActive.CheckedChanged += new System.EventHandler(this.chkNotActive_CheckedChanged);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Tahoma", 13F);
            this.chkActive.Location = new System.Drawing.Point(509, 197);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(114, 26);
            this.chkActive.TabIndex = 16;
            this.chkActive.Text = "فعال سازی";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbFillter);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(261, 287);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(340, 82);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "عملیات جستوجو";
            // 
            // cmbFillter
            // 
            this.cmbFillter.Font = new System.Drawing.Font("Tahoma", 13F);
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Location = new System.Drawing.Point(7, 38);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.Size = new System.Drawing.Size(221, 29);
            this.cmbFillter.TabIndex = 12;
            this.cmbFillter.SelectedIndexChanged += new System.EventHandler(this.cmbFillter_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.Location = new System.Drawing.Point(230, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "فیلتر جدول:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label4.Location = new System.Drawing.Point(542, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "کد مقام :";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtCode.Location = new System.Drawing.Point(286, 136);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(250, 28);
            this.txtCode.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRollType);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(245, 360);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مقام ها";
            // 
            // dgvRollType
            // 
            this.dgvRollType.AllowUserToAddRows = false;
            this.dgvRollType.AllowUserToDeleteRows = false;
            this.dgvRollType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRollType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRollType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCode,
            this.TypeTitle});
            this.dgvRollType.Location = new System.Drawing.Point(8, 23);
            this.dgvRollType.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRollType.Name = "dgvRollType";
            this.dgvRollType.ReadOnly = true;
            this.dgvRollType.Size = new System.Drawing.Size(226, 329);
            this.dgvRollType.TabIndex = 1;
            this.dgvRollType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRollType_CellClick);
            this.dgvRollType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRollType_CellContentClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "RoleType_ID";
            this.colID.HeaderText = "Column1";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "کد مقام";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // TypeTitle
            // 
            this.TypeTitle.DataPropertyName = "TypeTitle";
            this.TypeTitle.HeaderText = "نام مقام";
            this.TypeTitle.Name = "TypeTitle";
            this.TypeTitle.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(542, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام مقام :";
            // 
            // txtRoll
            // 
            this.txtRoll.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtRoll.Location = new System.Drawing.Point(286, 34);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(250, 28);
            this.txtRoll.TabIndex = 0;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtRoll;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام مقام را وارد فرمایید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtCode;
            this.requiredFieldValidator2.ErrorMessage = "لطفا کد مقام را وارد فرمایید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // RoleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(650, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoleType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن مقام";
            this.Load += new System.EventHandler(this.RollType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRollType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsertRoll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoll;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRollType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNotActive;
        private System.Windows.Forms.CheckBox chkActive;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.ComboBox cmbFillter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeTitle;
    }
}