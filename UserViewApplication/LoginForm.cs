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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RequestShipmentContent requestShipmentContent = new RequestShipmentContent();
            OrdersContent orderContent = new OrdersContent();
            MainPage mainPage = new MainPage();
           
            Users user = new Users();
            user.Username = LgntbUsername.Text;
            user.Password = LgntbPassword.Text;
            int response = user.Login(user);
            if (LgntbUsername.Text == "" || LgntbPassword.Text == "")
            {
                MessageBox.Show("Empty Fields Detected\nPlease add Username or Password!");
            }
            else if (response == 1)
            {
                requestShipmentContent.setUsername = user.Username;
                orderContent.setUsername = user.Username;
                mainPage.setUsername = user.Username;
                mainPage.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Incorrect UserName or Password");
            
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
