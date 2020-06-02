using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hospital_dbms
{
    class PATIENT
    {
        CONNECT conn = new CONNECT();

        public bool insertPatient(string id,string name,string age,string sex,string number,string address,string testsdone,string testres,string medicalhist,string reasonofassess,string allergies,string dob,string bloodgroup,string physician_id,string date,string ward_num,string time)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `patients`(Patient_id, Patient_Name, Age, Sex, Contact_Number, Address, Tests_Done, Tests_Results, Medical_History, Reason_for_Assessment, Allergies, Date_Of_Birth, Blood_Group, Physician_id_fk, Date_Of_Visit, Ward_Numer, Time) VALUES( @id,@nm, @age,@sex, @num, @address, @tests, @res, @hist, @rsn, @alrg, @dob, @bldgrp, @doc, @date, @wrdnum, @time)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();
            
            command.Parameters.Add("@id",MySqlDbType.VarChar).Value=id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value =name;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value =sex;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@tests", MySqlDbType.VarChar).Value = testsdone;
            command.Parameters.Add("@res", MySqlDbType.VarChar).Value = testres;
            command.Parameters.Add("@hist", MySqlDbType.VarChar).Value = medicalhist;
            command.Parameters.Add("@rsn", MySqlDbType.VarChar).Value = reasonofassess;
            command.Parameters.Add("@alrg", MySqlDbType.VarChar).Value = allergies;
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = dob;
            command.Parameters.Add("@bldgrp", MySqlDbType.VarChar).Value = bloodgroup;
            command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = physician_id;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value =date;
            command.Parameters.Add("@wrdnum", MySqlDbType.VarChar).Value = ward_num;
            command.Parameters.Add("@time", MySqlDbType.VarChar).Value = time;

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

        public DataTable getPatients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `patients` ",conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }

        public bool editPatient(int id, string name, string age, string sex, string number, string address, string testsdone, string testres, string medicalhist, string reasonofassess, string allergies, string dob, string bloodgroup, string physician_id, string date, string ward_num,string time)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `patients` SET Patient_Name=@nm,Age= @age,Sex=@sex,Contact_Number= @num,Address= @address,Tests_Done=@tests,Tests_Results= @res,Medical_History=@hist,Reason_for_Assessment= @rsn,Allergies=@alrg,Date_Of_Birth=@dob,Blood_Group=@bldgrp,Physician_id_fk=@doc,Date_Of_Visit=@date,Ward_Number=@wrdnum,Time=@time WHERE Patient_id=@id";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age;
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@tests", MySqlDbType.VarChar).Value = testsdone;
            command.Parameters.Add("@res", MySqlDbType.VarChar).Value = testres;
            command.Parameters.Add("@hist", MySqlDbType.VarChar).Value = medicalhist;
            command.Parameters.Add("@rsn", MySqlDbType.VarChar).Value = reasonofassess;
            command.Parameters.Add("@alrg", MySqlDbType.VarChar).Value = allergies;
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = dob;
            command.Parameters.Add("@bldgrp", MySqlDbType.VarChar).Value = bloodgroup;
            command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = physician_id;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@wrdnum", MySqlDbType.VarChar).Value = ward_num;
            command.Parameters.Add("@time", MySqlDbType.VarChar).Value = time;


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
        public bool removePatient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `patients` WHERE `Patient_id` =@id";
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
    }
}