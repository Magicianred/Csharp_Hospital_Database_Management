using MySql.Data.MySqlClient;
using System.Data;


namespace Hospital_dbms
{
    class STAFFS
    {
        CONNECT conn = new CONNECT();
        public DataTable getStaffs()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `staffs` ", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }
    }
}
