namespace PayegahApp.PesrsonsForms
{
    partial class IsAcitve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsAcitve));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIsActivefalse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIsActive = new System.Windows.Forms.Button();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIsActivefalse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIsActive);
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(522, 232);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات فعال و غیر فعال سازی عضو";
            // 
            // btnIsActivefalse
            // 
            this.btnIsActivefalse.BackColor = System.Drawing.Color.Teal;
            this.btnIsActivefalse.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnIsActivefalse.Location = new System.Drawing.Point(9, 161);
            this.btnIsActivefalse.Margin = new System.Windows.Forms.Padding(4);
            this.btnIsActivefalse.Name = "btnIsActivefalse";
            this.btnIsActivefalse.Size = new System.Drawing.Size(173, 68);
            this.btnIsActivefalse.TabIndex = 3;
            this.btnIsActivefalse.Text = "غیرفعال سازی";
            this.btnIsActivefalse.UseVisualStyleBackColor = false;
            this.btnIsActivefalse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(386, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "کدملی عضو :\r\n";
            // 
            // btnIsActive
            // 
            this.btnIsActive.BackColor = System.Drawing.Color.Teal;
            this.btnIsActive.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnIsActive.Location = new System.Drawing.Point(190, 161);
            this.btnIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnIsActive.Name = "btnIsActive";
            this.btnIsActive.Size = new System.Drawing.Size(173, 68);
            this.btnIsActive.TabIndex = 0;
            this.btnIsActive.Text = "فعال سازی";
            this.btnIsActive.UseVisualStyleBackColor = false;
            this.btnIsActive.Click += new System.EventHandler(this.btnIsActive_Click);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.txtNationalCode.Location = new System.Drawing.Point(29, 52);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(347, 32);
            this.txtNationalCode.TabIndex = 1;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtNationalCode;
            this.requiredFieldValidator1.ErrorMessage = "لطفا کدملی عضو را برای عملیات وارد فرمایید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // IsAcitve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(540, 247);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "IsAcitve";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملیات فعال و غیر فعال سازی عضو";
            this.Load += new System.EventHandler(this.IsAcitve_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIsActive;
        private System.Windows.Forms.TextBox txtNationalCode;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.Button btnIsActivefalse;
    }
}