using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Adpc
{
    class ClassCountries
    {
        #region PrivateVariables
        private long _country_id;
        private string _country_code;
        private string _country_name;
        private int _active;
        #endregion

        #region PublicVariables
        public long CountryID
        {
            get { return _country_id; }
            set { _country_id = value; }
        }

        public string CountryCode
        {
            get { return _country_code; }
            set { _country_code = value; }
        }

        public string CountryName
        {
            get { return _country_name; }
            set { _country_name = value; }
        }

        public int Active
        {
            get { return _active; }
            set { _active = value; }
        }
        #endregion

        public Boolean SaveCountry() 
        {
            ClassDatabaseCon dbcon = new ClassDatabaseCon();
            Boolean returnValue = true;
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(dbcon.ConnectionString());
            string SQL = "insert into Countries(country_name,country_code,active,created_date) values('{0}','{1}',{2},sysdate())";
            cmd.CommandText = string.Format(SQL,CountryName,CountryCode,Active);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try { con.Open();
            if (cmd.ExecuteNonQuery() > 0) { returnValue = true; } else { returnValue = false; }
            }
            catch (Exception ex) { }
            return returnValue;
        }

        public Boolean EditCountry()
        {
            ClassDatabaseCon dbcon = new ClassDatabaseCon();
            Boolean returnValue = true;
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(dbcon.ConnectionString());
            string SQL = "update countries set country_name = '{0}', country_code = '{1}', active = '{2}' where country_id = {3};";
            cmd.CommandText = string.Format(SQL, CountryName, CountryCode, Active,CountryID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0) { returnValue = true; } else { returnValue = false; }
            }
            catch (Exception ex) { }
            return returnValue;
        }
        public DataTable retrieveAllData() 
        {
                DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                ClassDatabaseCon dbcon = new ClassDatabaseCon();
                cmd.CommandType = CommandType.Text;
                MySqlConnection con = new MySqlConnection(dbcon.ConnectionString());
                // cmd.Connection.Open();
                string sql = "select * from countries ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                //dt = new DataTable();
                con.Open();
                da.Fill(dt);
            } catch(Exception ex){}
                return dt;
        }
    }
}
