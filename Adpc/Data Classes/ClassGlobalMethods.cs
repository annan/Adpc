using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Adpc
{
    class ClassGlobalMethods
    {

        //##Private Variabls#
        private string _username;
        private string _password;
        static private string _fullname;
        static public int hasUserLogin;


        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        static public string Fullname
        {
            get { return _fullname; }
            set { _fullname = value; }
        }


        // Login Function
        public Boolean userLogin()
        {
            Boolean returnValue = true;
            try
            {
                int QueryReturnValue = 0;
                ClassDatabaseCon con = new ClassDatabaseCon();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users where login_name ='" + Username + "' and password ='" + Password + "'";
                cmd.Connection = new MySqlConnection(con.ConnectionString());
                cmd.Connection.Open();
                QueryReturnValue = cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                // Data Reader      
                if (reader.Read())
                {
                    Fullname = reader.GetString(1);
                    //ClassGeneral.LoginUserFullName = reader.GetString(1);
                    returnValue = true;
                    hasUserLogin = 1;
                }
                else
                {
                    hasUserLogin = 0;
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                returnValue = false;
                throw ex;
            }
           // _userHasLogin = returnValue;
            //userHasLogin();
            return returnValue;
        }
    }
}
