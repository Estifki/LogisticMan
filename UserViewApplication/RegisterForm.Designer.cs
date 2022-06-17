namespace UserViewApplication
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RegTbUsername = new System.Windows.Forms.TextBox();
            this.RegTbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegTbconfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegTbPhoneno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.RegTbDate = new System.Windows.Forms.DateTimePicker();
            this.RegTbFullname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Future Log";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(167, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(202, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Login";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName:";
            // 
            // RegTbUsername
            // 
            this.RegTbUsername.Location = new System.Drawing.Point(190, 143);
            this.RegTbUsername.Name = "RegTbUsername";
            this.RegTbUsername.Size = new System.Drawing.Size(179, 20);
            this.RegTbUsername.TabIndex = 8;
            // 
            // RegTbPassword
            // 
            this.RegTbPassword.Location = new System.Drawing.Point(190, 216);
            this.RegTbPassword.Name = "RegTbPassword";
            this.RegTbPassword.PasswordChar = '*';
            this.RegTbPassword.Size = new System.Drawing.Size(179, 20);
            this.RegTbPassword.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // RegTbconfirmPassword
            // 
            this.RegTbconfirmPassword.Location = new System.Drawing.Point(190, 256);
            this.RegTbconfirmPassword.Name = "RegTbconfirmPassword";
            this.RegTbconfirmPassword.PasswordChar = '*';
            this.RegTbconfirmPassword.Size = new System.Drawing.Size(179, 20);
            this.RegTbconfirmPassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RegTbPhoneno
            // 
            this.RegTbPhoneno.Location = new System.Drawing.Point(190, 297);
            this.RegTbPhoneno.Name = "RegTbPhoneno";
            this.RegTbPhoneno.Size = new System.Drawing.Size(179, 20);
            this.RegTbPhoneno.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone no:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date of Birth:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Lime;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(167, 409);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(202, 41);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegTbDate
            // 
            this.RegTbDate.Location = new System.Drawing.Point(190, 337);
            this.RegTbDate.Name = "RegTbDate";
            this.RegTbDate.Size = new System.Drawing.Size(179, 20);
            this.RegTbDate.TabIndex = 20;
            // 
            // RegTbFullname
            // 
            this.RegTbFullname.Location = new System.Drawing.Point(190, 179);
            this.RegTbFullname.Name = "RegTbFullname";
            this.RegTbFullname.Size = new System.Drawing.Size(179, 20);
            this.RegTbFullname.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Full Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Register And Become A Member";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 565);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RegTbFullname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RegTbDate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegTbPhoneno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegTbconfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegTbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegTbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegTbUsername;
        private System.Windows.Forms.TextBox RegTbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegTbconfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegTbPhoneno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker RegTbDate;
        private System.Windows.Forms.TextBox RegTbFullname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

    }
}