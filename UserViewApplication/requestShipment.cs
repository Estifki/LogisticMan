using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace UserViewApplication
{
    class requestShipment
    {
        public int request_id;
        public String username;
        public String fromCountry;
        public String fromCity;
        public String toCountry;
        public String toCity;
        public String phoneNum;
        public DateTime Destination;
        public String RequestDetails;

        static string constring = "Data Source=DESKTOP-H1NQPN2\\SQLEXPRESS01; database=LogisticMan;integrated security=SSPI";
        public int getRequestedShipmetTotal()
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

        public int setID() { 
             if (getRequestedShipmetTotal() >= 1) {

                 return request_id = getRequestedShipmetTotal() + 1;
            
            }else {
                return request_id=1;
        }
        
        
        
        }

        public void addOrder(requestShipment requestShipment)
        {


            setID();
            SqlConnection sqlCon = new SqlConnection(constring);
            try
            {
                String addorder = "insert into RequestShipment values(" + request_id + ",'" + requestShipment.username + "','" + requestShipment.fromCountry + "','" + requestShipment.fromCity + "','" + requestShipment.toCountry + "','" + requestShipment.toCity + "','" + requestShipment.phoneNum + "','" + requestShipment.Destination + "','" + requestShipment.RequestDetails + "')";
                SqlCommand sqlCommand = new SqlCommand(addorder, sqlCon);
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        
        }
    }
}
