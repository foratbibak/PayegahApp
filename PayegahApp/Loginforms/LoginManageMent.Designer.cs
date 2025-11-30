namespace PayegahApp.Loginforms
{
    partial class LoginManageMent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginManageMent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertP = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassUser = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNatnioalCode = new System.Windows.Forms.TextBox();
            this.btnInsertM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertM);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnInsertP);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه های عملیات";
            // 
            // btnInsertP
            // 
            this.btnInsertP.BackColor = System.Drawing.Color.Teal;
            this.btnInsertP.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnInsertP.Location = new System.Drawing.Point(622, 22);
            this.btnInsertP.Name = "btnInsertP";
            this.btnInsertP.Size = new System.Drawing.Size(147, 56);
            this.btnInsertP.TabIndex = 2;
            this.btnInsertP.Text = "ثبت کاربر";
            this.btnInsertP.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnEdit.Location = new System.Drawing.Point(322, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 56);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnDelete.Location = new System.Drawing.Point(169, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 56);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnRefresh.Location = new System.Drawing.Point(16, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 56);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPassUser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات ثبت";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(372, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 27);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(580, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(273, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "رمز ورود :";
            // 
            // txtPassUser
            // 
            this.txtPassUser.Location = new System.Drawing.Point(60, 26);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.Size = new System.Drawing.Size(209, 27);
            this.txtPassUser.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvUsers);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(9, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 214);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اطلاعات ";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colPersonID,
            this.colUserName,
            this.colPassword});
            this.dgvUsers.Location = new System.Drawing.Point(6, 28);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(763, 176);
            this.dgvUsers.TabIndex = 0;
            // 
            // colUserID
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "ID";
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Visible = false;
            // 
            // colPersonID
            // 
            this.colPersonID.DataPropertyName = "PersonID";
            this.colPersonID.HeaderText = "کدملی";
            this.colPersonID.Name = "colPersonID";
            this.colPersonID.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "نام کاربری";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "Password";
            this.colPassword.HeaderText = "کلمه عبور";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtPass);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNatnioalCode);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(9, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 70);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "عملیات ثبت بر اساس اعضای پایگاه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(222, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "رمز ورود :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(9, 31);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(209, 25);
            this.txtPass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(529, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "کدملی :";
            // 
            // txtNatnioalCode
            // 
            this.txtNatnioalCode.Location = new System.Drawing.Point(321, 30);
            this.txtNatnioalCode.Name = "txtNatnioalCode";
            this.txtNatnioalCode.Size = new System.Drawing.Size(209, 25);
            this.txtNatnioalCode.TabIndex = 0;
            // 
            // btnInsertM
            // 
            this.btnInsertM.BackColor = System.Drawing.Color.Teal;
            this.btnInsertM.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnInsertM.Location = new System.Drawing.Point(472, 22);
            this.btnInsertM.Name = "btnInsertM";
            this.btnInsertM.Size = new System.Drawing.Size(147, 56);
            this.btnInsertM.TabIndex = 6;
            this.btnInsertM.Text = "افزودن عضو";
            this.btnInsertM.UseVisualStyleBackColor = false;
            // 
            // LoginManageMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(799, 472);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginManageMent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsertP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNatnioalCode;
        private System.Windows.Forms.Button btnInsertM;
    }
}