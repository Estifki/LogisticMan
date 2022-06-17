using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Admin
{
    class adminClass
    {

        public String Fullname;
        public String Username;
        public String Password;
        public String Phoneno;
        public DateTime Date;

       static string constring = "Data Source=DESKTOP-H1NQPN2\\SQLEXPRESS01; database=LogisticMan;integrated security=SSPI";

       public int userNameCheck(String username)
       {
           SqlConnection sqlCon = new SqlConnection(constring);
           String verifyUserName = "Select * from SupAdmin where Username= '" + username + "'";
           try
           {
              
               SqlCommand sqlCommand = new SqlCommand(verifyUserName, sqlCon);
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

       public void addNewAdmin(adminClass admin)
       {
           
            SqlConnection sqlCon = new SqlConnection(constring);

            String addUser = "insert into SupAdmin values('" + admin.Fullname + "','" + admin.Username + "','" + admin.Password + "','" + admin.Phoneno + "')";
                SqlCommand sqlCommand = new SqlCommand(addUser, sqlCon);
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery(); 
                sqlCon.Close();  
            }
       public int Login(adminClass admin)
        {
               SqlConnection sqlCon = new SqlConnection(constring);
            try {
                string loginAdmin = "select * from SupAdmin where Username ='" + admin.Username + "' and Password='" + admin.Password + "'";
                SqlCommand sqlCommand = new SqlCommand(loginAdmin, sqlCon);
            sqlCon.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read()) {
                return 1;
            }
            else { return -1; }
        }catch (Exception e){
            Console.WriteLine(e.ToString());
            return 0;
        
        }
        }

        
        
    }
}
