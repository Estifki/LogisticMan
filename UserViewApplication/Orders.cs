using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserViewApplication
{
    public partial class OrdersContent : Form
    {
        public OrdersContent()
        {
            InitializeComponent();
        }
        string constring = "Data Source=DESKTOP-H1NQPN2\\SQLEXPRESS01; database=LogisticMan;integrated security=SSPI";
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
        private static string _userName;
        public string setUsername   // property
        {
            get { return _userName; }   // get method
            set { _userName = value; }  // set method
        }

        public void refreshAllOrders()
        {
            SqlConnection sqlCon = new SqlConnection(constring);
            string requestShipment = "select request_id,fromCountry,fromCity,toCountry,toCity,phoneNum,Delivery_Date,Request_detail from requestShipment where username= '" + _userName + "'";
            SqlCommand sqlCommand = new SqlCommand(requestShipment, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        public void refreshAccepted()
        {

            SqlConnection sqlCon = new SqlConnection(constring);
            string acceptedOrders = "select orderid,fromCountry,fromCity,toCountry,toCity,phoneNum,Delivery_Date,Request_detail from AcceptedOrders where username= '" + _userName + "'";
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
            string canceledOrders = "select orderid,fromCountry,fromCity,toCountry,toCity,phoneNum,Delivery_Date,Request_detail from CanceledOrders where username= '" + _userName + "'";
            SqlCommand sqlCommand = new SqlCommand(canceledOrders, sqlCon);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

 

        



       

        private void OrdersContent_Load(object sender, EventArgs e)
        {

            refreshAllOrders();
            refreshAccepted();
            refreshCanceled();
        
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

    

        
    }
}
