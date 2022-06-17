using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
             
              if (Loginas.Text == "Admin")
              {
                    adminClass admin = new adminClass();
                    AdminPage adminPage = new AdminPage();

                  admin.Username = LgntbUsername.Text;
                  admin.Password = LgntbPassword.Text;
                  int response = admin.Login(admin);
                  if (LgntbUsername.Text == "" || LgntbPassword.Text == "")
                  {
                      MessageBox.Show("Empty Fields Detected\nPlease add Username or Password!");
                  }
                  else if (response == 1)
                  {

                      adminPage.setAdminName = admin.Username;
                      adminPage.Show();
                      this.Hide();

                  }
                  else
                  {
                      MessageBox.Show("Incorrect UserName or Password");

                  }

              }
              else
              {
                   bookingAdmin bAdmin = new bookingAdmin();
                   Booking_ManagerPage booking_Manager = new Booking_ManagerPage();
                   bAdmin.Username = LgntbUsername.Text;
                  bAdmin.Password = LgntbPassword.Text;
                  int response = bAdmin.Login(bAdmin);
                  if (LgntbUsername.Text == "" || LgntbPassword.Text == "")
                  {
                      MessageBox.Show("Empty Fields Detected\nPlease add Username or Password!");
                  }
                  else if (response == 1)
                  {
                      booking_Manager.setAdminName = bAdmin.Username;
                  
                  booking_Manager.Show();
                      this.Hide();

                  }
                  else
                  {
                      MessageBox.Show("Incorrect UserName or Password");

                  }

              }
                 


              }

        

    
        

    }
}
