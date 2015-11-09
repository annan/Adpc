using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Adpc
{
    class ClassDatabaseCon
    {

        // private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public String ConnectionString()
        {
            server = "localhost";
            database = "adpc";
            uid = "root";
            password = "database";
            string connectionStr;
            connectionStr = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return connectionStr;
        }

    }
}
