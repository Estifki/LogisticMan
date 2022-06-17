using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserViewApplication
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void selectForm(object selectedItem)
        {
            if (this.mainContent.Controls.Count > 0)
                this.mainContent.Controls.Clear();
            Form sF = selectedItem as Form;
            sF.TopLevel = false;
            sF.Dock = DockStyle.Fill;
            this.mainContent.Controls.Add(sF);
            this.mainContent.Tag = sF;
            sF.Show();
        }

        private static string _userName;
        public string setUsername   // property
        {
            get { return _userName; }   // get method
            set { _userName = value; }  // set method
        }

        private void mainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            selectForm(new RequestShipmentContent());
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            selectForm(new OrdersContent());
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lblLogedinUsername.Text = _userName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        
    }
}
