using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        string constring = "Data Source=DESKTOP-H1NQPN2\\SQLEXPRESS01; database=LogisticMan;integrated security=SSPI";

        private string _adminName;
        public string setAdminName
        {
            set { _adminName = value; }
            get { return _adminName; }

        }
        public int CheckAcceptedOrdersID(String id)
        {
            SqlConnection sqlCon = new SqlConnection(constring);
            String checkid = "Select * from AcceptedOrders where orderId= '" + id + "'";
            try
            {

                SqlCommand sqlCommand = new SqlCommand(checkid, sqlCon);
                sqlCon.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    return 1;

                }
                else { return -1; }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
        

        public int CheckCanceledOrdersID(String id)
        {
            SqlConnection sqlCon = new SqlConnection(constring);
            String checkid = "Select * from CanceledOrders where orderId= '" + id + "'";
            try
            {

                SqlCommand sqlCommand = new SqlCommand(checkid, sqlCon);
                sqlCon.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    return 1;

                }
                else { return -1; }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }

        //public int CheckremovedAdmin(String username,String selectedtable)
        //{

        //    SqlConnection sqlCon = new SqlConnection(constring);
        //    String checkUserName = "Select  from" +selectedtable+"where username='" + username + "'";
        //    try
        //    {

        //        SqlCommand sqlCommand = new SqlCommand(checkUserName, sqlCon);
        //        sqlCon.Open();
        //        SqlDataReader dataReader = sqlCommand.ExecuteReader();
        //        if (dataReader.Read())
        //        {
        //            return 1;

        //        }
        //        else { return -1; }

        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        return 0;
        //    }
        //}

        public int getTotlaOrders() {
            
            SqlConnection sqlCon = new SqlConnection(constring);
            string requestShipment = "select count(*) from requestShipment";
            string acceptedOrders = "select count(*) from AcceptedOrders";
            string canceledOrders = "select  count(*) from CanceledOrders";
            SqlCommand sqlCommandrequestShipment = new SqlCommand(requestShipment, sqlCon);
            SqlCommand sqlCommandacceptedOrders = new SqlCommand(acceptedOrders, sqlCon);
            SqlCommand sqlCommandcanceledOrders = new SqlCommand(canceledOrders, sqlCon);
            sqlCon.Open();
            return (int)sqlCommandrequestShipment.ExecuteScalar() + (int)sqlCommandacceptedOrders.ExecuteScalar() + (int)sqlCommandcanceledOrders.ExecuteScalar();
        }
        public int getPendingOrders()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
            string pending = "select count(*) from requestShipment";

            SqlCommand sqlCommandrequestShipment = new SqlCommand(pending, sqlCon);

            sqlCon.Open();
            return (int)sqlCommandrequestShipment.ExecuteScalar();
        }
        public int getAcceptedOrders()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
           
            string acceptedOrders = "select count(*) from AcceptedOrders";
         
       
            SqlCommand sqlCommandacceptedOrders = new SqlCommand(acceptedOrders, sqlCon);
            
            sqlCon.Open();
            return (int)sqlCommandacceptedOrders.ExecuteScalar();
        }
        public int getCancledOrders()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
          
            string canceledOrders = "select  count(*) from CanceledOrders";
         
            SqlCommand sqlCommandcanceledOrders = new SqlCommand(canceledOrders, sqlCon);
            sqlCon.Open();
            return  (int)sqlCommandcanceledOrders.ExecuteScalar();
        }
        public int gettotalCustomer()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
            string totalCustomer = "select count(*) from users";

            SqlCommand sqlCommandrequestShipment = new SqlCommand(totalCustomer, sqlCon);

            sqlCon.Open();
            return (int)sqlCommandrequestShipment.ExecuteScalar();
        }
        public int getTotalEmployee()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
            string supAdmin = "select count(*) from supadmin";
            string bookingAdmin = "select count(*) from bookingmanager";

            SqlCommand sqlCommendSupAdmin = new SqlCommand(supAdmin, sqlCon);
            SqlCommand sqlCommendSupBookingAdmin = new SqlCommand(bookingAdmin, sqlCon);

            sqlCon.Open();
            return (int)sqlCommendSupAdmin.ExecuteScalar() + (int)sqlCommendSupBookingAdmin.ExecuteScalar(); 
        }


        public void BookingManagers()
        {
            SqlConnection sqlCon = new SqlConnection(constring);
            string requestShipment = "select full_name,username,phoneNum from bookingmanager";
            SqlCommand sqlCommand = new SqlCommand(requestShipment, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
        
            getTotalEmployee();
            totalEmployee.Text = getTotalEmployee().ToString();
            dataGridView5.DataSource = dataTable;

        }
        public void SuperAdmins()
        {
            SqlConnection sqlCon = new SqlConnection(constring);
            string requestShipment = "select full_name,username,phoneNum from supadmin";
            SqlCommand sqlCommand = new SqlCommand(requestShipment, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            getTotalEmployee();
            totalEmployee.Text = getTotalEmployee().ToString();
            dataGridView4.DataSource = dataTable;
        }

        public void refreshAllOrders()
        {
            SqlConnection sqlCon = new SqlConnection(constring);
            string requestShipment = "select * from requestShipment";
            SqlCommand sqlCommand = new SqlCommand(requestShipment, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            labelTotal.Text = getTotlaOrders().ToString();
            labelPending.Text = getPendingOrders().ToString();
            labelDelivered.Text = getAcceptedOrders().ToString();
            labelCancled.Text = getCancledOrders().ToString();
            dataGridView1.DataSource = dataTable;
        }
        public void refreshAccepted()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
            string acceptedOrders = "select * from AcceptedOrders";
            SqlCommand sqlCommand = new SqlCommand(acceptedOrders, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
        public void refreshCanceled()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
            string canceledOrders = "select * from CanceledOrders";
            SqlCommand sqlCommand = new SqlCommand(canceledOrders, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }


        

        private void AdminPage_Load(object sender, EventArgs e)
        {

            label13.Text = _adminName;
            refreshAllOrders();
            refreshAccepted();
            refreshCanceled();
            BookingManagers();
            SuperAdmins();
            gettotalCustomer();
            getTotalEmployee();
            totalCustomer.Text = gettotalCustomer().ToString();
        }

        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            if (acceptOrdertb.Text == "")
            {
                MessageBox.Show("Empty Field");
            }
            else if (CheckAcceptedOrdersID(acceptOrdertb.Text) == 1)
            {

                MessageBox.Show("Requested Order " + acceptOrdertb.Text + " Already Accepted");
            }
            else
            {



                SqlConnection sqlCon = new SqlConnection(constring);
                string AcceptedOrders = "INSERT INTO AcceptedOrders(orderId,username, fromCountry, fromCity,toCountry,toCity,phoneNum,Delivery_Date,Request_detail) SELECT request_id,username, fromCountry, fromCity, toCountry, toCity, phoneNum, Delivery_Date, Request_detail FROM requestShipment Where request_id = " + acceptOrdertb.Text + " ";
                string deleteCancledOrders = "Delete from requestShipment where request_id=" + acceptOrdertb.Text + "";

                SqlCommand sqlCommandAdd = new SqlCommand(AcceptedOrders, sqlCon);
                SqlCommand sqlCommandDelete = new SqlCommand(deleteCancledOrders, sqlCon);
                sqlCon.Open();
                sqlCommandAdd.ExecuteNonQuery();
                sqlCommandDelete.ExecuteNonQuery();
                refreshAllOrders();
                refreshAccepted();
                sqlCon.Close();





            }

        }

        private void btnCancelOrders_Click(object sender, EventArgs e)
        {
            if (acceptOrdertb.Text == "")
            {
                MessageBox.Show("Empty Field");
            }
            else if (CheckCanceledOrdersID(acceptOrdertb.Text) == 1)
            {

                MessageBox.Show("Requested Order " + acceptOrdertb.Text + " Already Canceled");
            }
            else
            {



                SqlConnection sqlCon = new SqlConnection(constring);
                string canceledOrders = "INSERT INTO CanceledOrders(orderId,username, fromCountry, fromCity,toCountry,toCity,phoneNum,Delivery_Date,Request_detail) SELECT request_id,username, fromCountry, fromCity, toCountry, toCity, phoneNum, Delivery_Date, Request_detail FROM requestShipment Where request_id = " + acceptOrdertb.Text + " ";
                string deleteCancledOrders = "Delete from requestShipment where request_id=" + acceptOrdertb.Text + "";
                SqlCommand sqlCommandAdd = new SqlCommand(canceledOrders, sqlCon);
                SqlCommand sqlCommandDelete = new SqlCommand(deleteCancledOrders, sqlCon);
                sqlCon.Open();
                sqlCommandAdd.ExecuteNonQuery();
                sqlCommandDelete.ExecuteNonQuery();
                refreshAllOrders();
                refreshCanceled();
                sqlCon.Close();





            }

        }

        
        private void btnAddBookingManager_Click(object sender, EventArgs e)
        {
            if (Addas.Text == "Admin") {

                adminClass addAdmin = new adminClass();
                if (addAdmin.userNameCheck(tbusername.Text) == 1)
                {

                    MessageBox.Show("Username " + tbusername.Text + " Already exist");
                }
                else
                {
                    addAdmin.Username = tbusername.Text;
                    addAdmin.Password = tbpassword.Text;
                    addAdmin.Fullname = tbfullname.Text;
                    addAdmin.Phoneno = tbphone.Text;


                    if (tbusername.Text == "" || tbpassword.Text == "" || tbfullname.Text == "" || tbphone.Text == "")
                    {
                        MessageBox.Show("Empty Fields Detected! Please Fill Them And Try Again.");
                    }
                    
                    else
                    {
                        addAdmin.addNewAdmin(addAdmin);
                        MessageBox.Show("Admin Registered Successfully!");
                        BookingManagers();
                        SuperAdmins();


                    }
                }
            
            
            
            
            
            } else {

                bookingAdmin bookingAdmin = new bookingAdmin();
                if (bookingAdmin.userNameCheck(tbusername.Text) == 1)
                {

                    MessageBox.Show("Username " + tbusername.Text + " Already exist");
                }
                else
                {
                    bookingAdmin.Username = tbusername.Text;
                    bookingAdmin.Password = tbpassword.Text;
                    bookingAdmin.Fullname = tbfullname.Text;
                    bookingAdmin.Phoneno = tbphone.Text;


                    if (tbusername.Text == "" || tbpassword.Text == "" || tbfullname.Text == "" || tbphone.Text == "")
                    {
                        MessageBox.Show("Empty Fields Detected! Please Fill Them And Try Again.");
                    }

                    else
                    {
                        bookingAdmin.addNewAdmin(bookingAdmin);
                        MessageBox.Show("Admin Registered Successfully!");
                        BookingManagers();
                        SuperAdmins();


                    }
                }
            
            
            
            
            
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (removewho.Text == "Admin")
            {
                if (tbremoveusername.Text == "")
                {
                    MessageBox.Show("Empty Field");
                }
                //else if (CheckremovedAdmin((tbremoveusername.Text), "supadmin") == -1)
                //{

                //    MessageBox.Show(tbremoveusername.Text + " is Not Admin");
                //}
                else
                {



                    SqlConnection sqlCon = new SqlConnection(constring);
                    string removeAdmin = "Delete from supadmin where username='" + tbremoveusername.Text + "'";
                    SqlCommand sqlCommandremove = new SqlCommand(removeAdmin, sqlCon);
                    sqlCon.Open();
                    sqlCommandremove.ExecuteNonQuery();
                    //MessageBox.Show("Admin Removed Successfully!");
                    SuperAdmins();
                    sqlCon.Close();
                }

            }
            else
            if (tbremoveusername.Text == "")
                {
                    MessageBox.Show("Empty Field");
                }
                //else if (checkremovedadmin((tbremoveusername.text), "bookingmanager") != 1)
                //{

                //    messagebox.show(tbremoveusername.text + " is not admin");
                //}
                else
                {



                    SqlConnection sqlCon = new SqlConnection(constring);
                    string removeAdmin = "Delete from bookingmanager where username='" + tbremoveusername.Text + "'";
                 
                    SqlCommand sqlCommandremove = new SqlCommand(removeAdmin, sqlCon);
                    sqlCon.Open();
                    sqlCommandremove.ExecuteNonQuery();
                    //MessageBox.Show("Admin Removed Successfully!");
                    BookingManagers();  
                    sqlCon.Close();





                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin logOut = new AdminLogin();
            logOut.Show();
            this.Hide();
        }

        private void reportAccepted_Click(object sender, EventArgs e)
        {
            AcceptedReport a = new AcceptedReport();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcceptedReport acc = new AcceptedReport();
            acc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancledReport Can = new CancledReport();
            Can.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerReport c = new CustomerReport();
            c.Show();
        }

       

        

       

        }
    
}
