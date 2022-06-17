namespace UserViewApplication
{
    partial class RequestShipmentContent
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
            this.RequestTopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sbmPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sbmdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.sbmToCity = new System.Windows.Forms.ComboBox();
            this.sbmToCountry = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sbmFromCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sbmFromCountry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.sbmRequestDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RequestTopPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestTopPanel
            // 
            this.RequestTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.RequestTopPanel.Controls.Add(this.label2);
            this.RequestTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestTopPanel.Location = new System.Drawing.Point(0, 0);
            this.RequestTopPanel.Name = "RequestTopPanel";
            this.RequestTopPanel.Size = new System.Drawing.Size(758, 80);
            this.RequestTopPanel.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Request Shipment";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sbmRequestDetail);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.sbmPhone);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.sbmdateTimePicker1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.sbmToCity);
            this.panel3.Controls.Add(this.sbmToCountry);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.sbmFromCity);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.sbmFromCountry);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(51, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 449);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label8.Location = new System.Drawing.Point(336, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Select City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label10.Location = new System.Drawing.Point(22, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Select Country";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label16.Location = new System.Drawing.Point(23, 278);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Phone Number";
            // 
            // sbmPhone
            // 
            this.sbmPhone.Location = new System.Drawing.Point(27, 300);
            this.sbmPhone.Name = "sbmPhone";
            this.sbmPhone.Size = new System.Drawing.Size(167, 20);
            this.sbmPhone.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label14.Location = new System.Drawing.Point(336, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.label15.Location = new System.Drawing.Point(336, 258);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Destination:";
            // 
            // sbmdateTimePicker1
            // 
            this.sbmdateTimePicker1.Location = new System.Drawing.Point(340, 299);
            this.sbmdateTimePicker1.Name = "sbmdateTimePicker1";
            this.sbmdateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.sbmdateTimePicker1.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.label12.Location = new System.Drawing.Point(22, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Personal Info:";
            // 
            // sbmToCity
            // 
            this.sbmToCity.DisplayMember = "Russia";
            this.sbmToCity.FormattingEnabled = true;
            this.sbmToCity.Items.AddRange(new object[] {
            "1. Addis Ababa\t",
            "2. Mekelle\t",
            "3. Gondar",
            "4. Adama\t",
            "5. Awassa\t",
            "6. Bahir Dar\t",
            "7. Dire Dawa\t",
            "8. Sodo\t",
            "9. Dessie\t",
            "10. Jimma",
            "11. Jijiga\t",
            "12. Shashamane\t",
            "13. Bishoftu\t",
            "14. Arba Minch\t",
            "15. Hosaena\t",
            "16. Harar\t",
            "17. Dilla",
            "18. Nekemte\t",
            "19. Debre Birhan\t",
            "20. Asella"});
            this.sbmToCity.Location = new System.Drawing.Point(340, 200);
            this.sbmToCity.Name = "sbmToCity";
            this.sbmToCity.Size = new System.Drawing.Size(247, 21);
            this.sbmToCity.TabIndex = 15;
            this.sbmToCity.Tag = "";
            // 
            // sbmToCountry
            // 
            this.sbmToCountry.DisplayMember = "Ethiopia";
            this.sbmToCountry.FormattingEnabled = true;
            this.sbmToCountry.Items.AddRange(new object[] {
            "1. Ethiopia"});
            this.sbmToCountry.Location = new System.Drawing.Point(26, 200);
            this.sbmToCountry.Name = "sbmToCountry";
            this.sbmToCountry.Size = new System.Drawing.Size(247, 21);
            this.sbmToCountry.TabIndex = 11;
            this.sbmToCountry.Tag = "";
            this.sbmToCountry.Text = "Ethiopia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.label11.Location = new System.Drawing.Point(22, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ship To:";
            // 
            // sbmFromCity
            // 
            this.sbmFromCity.FormattingEnabled = true;
            this.sbmFromCity.Items.AddRange(new object[] {
            "1. Addis Ababa\t",
            "2. Mekelle\t",
            "3. Gondar",
            "4. Adama\t",
            "5. Awassa\t",
            "6. Bahir Dar\t",
            "7. Dire Dawa\t",
            "8. Sodo\t",
            "9. Dessie\t",
            "10. Jimma",
            "11. Jijiga\t",
            "12. Shashamane\t",
            "13. Bishoftu\t",
            "14. Arba Minch\t",
            "15. Hosaena\t",
            "16. Harar\t",
            "17. Dilla",
            "18. Nekemte\t",
            "19. Debre Birhan\t",
            "20. Asella"});
            this.sbmFromCity.Location = new System.Drawing.Point(340, 104);
            this.sbmFromCity.Name = "sbmFromCity";
            this.sbmFromCity.Size = new System.Drawing.Size(247, 21);
            this.sbmFromCity.TabIndex = 8;
            this.sbmFromCity.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label7.Location = new System.Drawing.Point(336, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Select City";
            // 
            // sbmFromCountry
            // 
            this.sbmFromCountry.DisplayMember = "Ethiopia";
            this.sbmFromCountry.FormattingEnabled = true;
            this.sbmFromCountry.Items.AddRange(new object[] {
            "Ethiopia"});
            this.sbmFromCountry.Location = new System.Drawing.Point(26, 104);
            this.sbmFromCountry.Name = "sbmFromCountry";
            this.sbmFromCountry.Size = new System.Drawing.Size(247, 21);
            this.sbmFromCountry.TabIndex = 4;
            this.sbmFromCountry.Tag = "";
            this.sbmFromCountry.Text = "Ethiopia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(22, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ship From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(226, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where and When?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubmit.Location = new System.Drawing.Point(297, 590);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(170, 50);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // sbmRequestDetail
            // 
            this.sbmRequestDetail.Location = new System.Drawing.Point(27, 355);
            this.sbmRequestDetail.Multiline = true;
            this.sbmRequestDetail.Name = "sbmRequestDetail";
            this.sbmRequestDetail.Size = new System.Drawing.Size(246, 75);
            this.sbmRequestDetail.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(23, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Request Details:";
            // 
            // RequestShipmentContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 667);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.RequestTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestShipmentContent";
            this.Text = "RequestShipment";
            this.Load += new System.EventHandler(this.RequestShipmentContent_Load);
            this.RequestTopPanel.ResumeLayout(false);
            this.RequestTopPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RequestTopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox sbmPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker sbmdateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox sbmToCity;
        private System.Windows.Forms.ComboBox sbmToCountry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sbmFromCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sbmFromCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox sbmRequestDetail;
        private System.Windows.Forms.Label label3;
    }
}