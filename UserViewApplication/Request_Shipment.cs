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
    public partial class RequestShipmentContent : Form
    {
        public RequestShipmentContent()
        {
            InitializeComponent();
        }

        private static string _userName;
         public string setUsername   // property
  {
      get { return _userName; }   // get method
      set { _userName = value; }  // set method
  }


        

        private void btnSumbit_Click(object sender, EventArgs e)
        {

            requestShipment requestShipment = new requestShipment();
            

          

            if (sbmFromCountry.Text == "" || sbmFromCity.Text == "" || sbmToCountry.Text == "" || sbmToCity.Text == "" || sbmPhone.Text == "" || sbmRequestDetail.Text == "")
            {
                MessageBox.Show("Empty Fields Detected! Please Fill Them And Try Again.");
            }
            else
            {
              
                requestShipment.username = setUsername;
                requestShipment.fromCountry = sbmFromCountry.Text;
                requestShipment.fromCity = sbmFromCity.Text;
                requestShipment.toCountry = sbmToCountry.Text;
                requestShipment.toCity = sbmToCity.Text;
                requestShipment.phoneNum = sbmPhone.Text;
                requestShipment.Destination = DateTime.Parse(sbmdateTimePicker1.Text);
                requestShipment.RequestDetails = sbmRequestDetail.Text;
                requestShipment.addOrder(requestShipment);
                MessageBox.Show("Request Sent, It Will take Some-time to analize.\nWe will Respond within the next 10 minute.\nPlease Check Orders Menu.");
            }
        }

        private void RequestShipmentContent_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
