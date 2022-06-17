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
     
    public partial class Booking_ManagerPage : Form
    {
        string constring = "Data Source=DESKTOP-H1NQPN2\\SQLEXPRESS01; database=LogisticMan;integrated security=SSPI";
        public Booking_ManagerPage()
        {
            InitializeComponent();
        }

        private string _adminName;
        public string setAdminName {
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

        public int getTotlaOrders()
        {

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
            string requestShipment = "select count(*) from requestShipment";
          
            SqlCommand sqlCommandrequestShipment = new SqlCommand(requestShipment, sqlCon);
    
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
            return (int)sqlCommandcanceledOrders.ExecuteScalar();
        }

        public void refreshAllOrders() {
            SqlConnection sqlCon = new SqlConnection(constring);
            string requestShipment = "select * from requestShipment";
            SqlCommand sqlCommand = new SqlCommand(requestShipment, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            labelTotal.Text = getTotlaOrders().ToString();
            labelPending.Text = getPendingOrders().ToString();
            labelDelivered.Text = getAcceptedOrders().ToString();
            labelCancled.Text = getCancledOrders().ToString();
            sqlDataAdapter.Fill(dataTable);
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

        

        private void Booking_ManagerPage_Load(object sender, EventArgs e)
        {
            labelAdminname.Text = _adminName;
            refreshAllOrders();
            refreshAccepted();
            refreshCanceled();
           

        }

       

        private void btmAcceptOrder_Click(object sender, EventArgs e)
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
                string AcceptedOrders = "INSERT INTO AcceptedOrders(orderId,username, fromCountry, fromCity,toCountry,toCity,phoneNum,Delivery_Date,Request_detail) SELECT request_id,username, fromCountry, fromCity, toCountry, toCity, phoneNum, Delivery_Date,Request_detail FROM requestShipment Where request_id = " + acceptOrdertb.Text + " ";
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
                string canceledOrders = "INSERT INTO CanceledOrders(orderId,username, fromCountry, fromCity,toCountry,toCity,phoneNum,Delivery_Date,Request_detail) SELECT request_id,username, fromCountry, fromCity, toCountry, toCity, phoneNum, Delivery_Date,Request_detail FROM requestShipment Where request_id = " + acceptOrdertb.Text + " ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin logout = new AdminLogin();
            logout.Show();
            this.Hide();
        }

        

 
        
 

       
    }
}
