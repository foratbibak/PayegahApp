namespace PayegahApp
{
    partial class FormAsli
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
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnEntrance_Exit = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerson
            // 
            this.btnPerson.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnPerson.Location = new System.Drawing.Point(641, 12);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(147, 56);
            this.btnPerson.TabIndex = 0;
            this.btnPerson.Text = "اعضا";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnEntrance_Exit
            // 
            this.btnEntrance_Exit.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnEntrance_Exit.Location = new System.Drawing.Point(488, 12);
            this.btnEntrance_Exit.Name = "btnEntrance_Exit";
            this.btnEntrance_Exit.Size = new System.Drawing.Size(147, 56);
            this.btnEntrance_Exit.TabIndex = 1;
            this.btnEntrance_Exit.Text = "حضور و غیاب";
            this.btnEntrance_Exit.UseVisualStyleBackColor = true;
            this.btnEntrance_Exit.Click += new System.EventHandler(this.btnEntrance_Exit_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.btnRoll.Location = new System.Drawing.Point(335, 12);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(147, 56);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "اعضای شورا";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // FormAsli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnEntrance_Exit);
            this.Controls.Add(this.btnPerson);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAsli";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAsli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnEntrance_Exit;
        private System.Windows.Forms.Button btnRoll;
    }
}

