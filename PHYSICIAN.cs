using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Hospital_dbms
{
    class PHYSICIAN
    {
        CONNECT conn = new CONNECT();

        public bool insertPhysician(string id, string name,string speciality,string workhrs,string workdays, string number)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `physician`(`Physician_id`, `Physician Name`, `Speciality`, `Working Hours`, `Working Days`, `Contact Number`) VALUES (@id,@nm,@speclty,@wrkhrs,@wrkdays,@num)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@speclty", MySqlDbType.VarChar).Value = speciality;
            command.Parameters.Add("@wrkhrs", MySqlDbType.VarChar).Value = workhrs;
            command.Parameters.Add("@wrkdays", MySqlDbType.VarChar).Value = workdays;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
           
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
            //return true;
        }
        public bool editPhysician(int id, string name, string speciality, string workhrs, string workdays, string number)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `physician` SET `Physician Name`=@nm,`Speciality`=@speclty,`Working Hours`=@wrkhrs,`Working Days`=@wrkdays,`Contact Number`=@num WHERE `Physician_id`=@id";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@speclty", MySqlDbType.VarChar).Value = speciality;
            command.Parameters.Add("@wrkhrs", MySqlDbType.VarChar).Value = workhrs;
            command.Parameters.Add("@wrkdays", MySqlDbType.VarChar).Value = workdays;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
            //return true;
        }
          public bool removePhysician(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `physician` WHERE `Physician_id`=@id";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public DataTable getPhysician()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `physician` ", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }
    }
}
