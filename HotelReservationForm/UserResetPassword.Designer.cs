namespace HotelReservationForm
{
    partial class UserResetPassword
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
            this.lbl = new System.Windows.Forms.Label();
            this.passwordEntryOne = new System.Windows.Forms.TextBox();
            this.passwordEntryTwo = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(17, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(291, 25);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "You have a default password";
            // 
            // passwordEntryOne
            // 
            this.passwordEntryOne.Location = new System.Drawing.Point(44, 92);
            this.passwordEntryOne.Name = "passwordEntryOne";
            this.passwordEntryOne.PasswordChar = '*';
            this.passwordEntryOne.Size = new System.Drawing.Size(219, 20);
            this.passwordEntryOne.TabIndex = 1;
            // 
            // passwordEntryTwo
            // 
            this.passwordEntryTwo.Location = new System.Drawing.Point(44, 147);
            this.passwordEntryTwo.Name = "passwordEntryTwo";
            this.passwordEntryTwo.PasswordChar = '*';
            this.passwordEntryTwo.Size = new System.Drawing.Size(219, 20);
            this.passwordEntryTwo.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(55, 192);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(191, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirmClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "type new password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "confirm password";
            // 
            // UserResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.passwordEntryTwo);
            this.Controls.Add(this.passwordEntryOne);
            this.Controls.Add(this.lbl);
            this.Name = "UserResetPassword";
            this.Text = "PLEASE CHANGE YOUR PASSWORD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox passwordEntryOne;
        private System.Windows.Forms.TextBox passwordEntryTwo;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}