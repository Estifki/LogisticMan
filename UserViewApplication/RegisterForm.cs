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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Users addUser = new Users();
            if (addUser.userNameCheck(RegTbUsername.Text) == 1)
            {
                
                MessageBox.Show("Username " + RegTbUsername.Text + " Already exist");
            }
            else
            {
                addUser.Username = RegTbUsername.Text;
                addUser.Password = RegTbPassword.Text;
                addUser.Fullname = RegTbFullname.Text;
                addUser.Phoneno = RegTbPhoneno.Text;
                addUser.Date =  DateTime.Parse(RegTbDate.Text);

                if (RegTbUsername.Text == "" || RegTbPassword.Text == "" || RegTbFullname.Text == "" || RegTbPhoneno.Text == "")
                {
                    MessageBox.Show("Empty Fields Detected! Please Fill Them And Try Again.");
                }
                else if (RegTbPassword.Text != RegTbconfirmPassword.Text)
                {
                    MessageBox.Show("Password Don't Match");

                }
                else
                {
                    addUser.addNewUser(addUser);
                    MessageBox.Show("User Registered Successfully! Back To login Page and Enjoy!!");


                }
            }
            
        }

        
    }
}
