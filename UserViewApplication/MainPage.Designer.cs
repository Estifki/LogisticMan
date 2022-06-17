namespace UserViewApplication
{
    partial class MainPage
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogedinUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainContent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.mainTopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.mainPanel.Controls.Add(this.btnLogOut);
            this.mainPanel.Controls.Add(this.btnOrder);
            this.mainPanel.Controls.Add(this.btnRequest);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(170, 667);
            this.mainPanel.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 617);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogOut.Size = new System.Drawing.Size(170, 50);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 250);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOrder.Size = new System.Drawing.Size(170, 50);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRequest.Location = new System.Drawing.Point(0, 180);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRequest.Size = new System.Drawing.Size(170, 50);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request Shipment";
            this.btnRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLogedinUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 149);
            this.panel2.TabIndex = 0;
            // 
            // lblLogedinUsername
            // 
            this.lblLogedinUsername.AutoSize = true;
            this.lblLogedinUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblLogedinUsername.Font = new System.Drawing.Font("Times New Roman", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedinUsername.ForeColor = System.Drawing.Color.Lime;
            this.lblLogedinUsername.Location = new System.Drawing.Point(57, 122);
            this.lblLogedinUsername.Name = "lblLogedinUsername";
            this.lblLogedinUsername.Size = new System.Drawing.Size(0, 20);
            this.lblLogedinUsername.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "FutureLog";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserViewApplication.Properties.Resources.drawer_pic_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainContent
            // 
            this.mainContent.Controls.Add(this.pictureBox2);
            this.mainContent.Controls.Add(this.label3);
            this.mainContent.Controls.Add(this.listBox3);
            this.mainContent.Controls.Add(this.mainTopPanel);
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(170, 0);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(758, 667);
            this.mainContent.TabIndex = 2;
            this.mainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.mainContent_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserViewApplication.Properties.Resources.Future_log;
            this.pictureBox2.Location = new System.Drawing.Point(138, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(482, 364);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(579, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Available solutions to drive your digital transformation";
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "Future Log Distribution ERP handles everything you need to accelerate the growth " +
                "of your",
            "consumergoods import or distribution business. With a single source of truth andi" +
                "mproved ",
            "efficiency, you can increase profits and get ahead of the competition."});
            this.listBox3.Location = new System.Drawing.Point(36, 144);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(687, 60);
            this.listBox3.TabIndex = 16;
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(74)))));
            this.mainTopPanel.Controls.Add(this.label2);
            this.mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.Size = new System.Drawing.Size(758, 80);
            this.mainTopPanel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "WellCome To Future Log";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 667);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Log";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainContent.ResumeLayout(false);
            this.mainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mainTopPanel.ResumeLayout(false);
            this.mainTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Label lblLogedinUsername;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel mainTopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox3;
    }
}