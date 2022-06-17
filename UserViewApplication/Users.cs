using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace UserViewApplication
{
    class Users
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
           String verifyUserName = "Select * from Users where Username= '" + username + "'";
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

        public void addNewUser(Users user) {
           
            SqlConnection sqlCon = new SqlConnection(constring);

            String addUser = "insert into Users values('" + user.Fullname + "','" + user.Username + "','" + user.Password + "','" + user.Phoneno + "','" + user.Date + "')";
                SqlCommand sqlCommand = new SqlCommand(addUser, sqlCon);
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery(); 
                sqlCon.Close();  
            }
        public int Login(Users user)
        {
               SqlConnection sqlCon = new SqlConnection(constring);
            try {
            string loginUser = "select * from Users where Username ='" + user.Username + "' and Password='" + user.Password + "'";
            SqlCommand sqlCommand = new SqlCommand(loginUser, sqlCon);
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
