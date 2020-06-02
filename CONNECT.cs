using System;
using System.Data;
using MySql.Data.MySqlClient;
using Hospital_dbms;  


namespace Hospital_dbms

{
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=hospital_db;Uid=root;Pwd=Amogha@123");
        //MySqlCommand cmd;
        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}



