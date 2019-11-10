using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using Npgsql;

namespace THOUGHTBOX.REPOSITORIES.Classes
{
    public class ConnectionRepository
    {
        NpgsqlConnection Conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                      "Password=hrapp$$23;Database=HRAPPDB;");
        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        
        NpgsqlCommand cmd = null;
        NpgsqlDataReader dr = null;

        public DataSet  Getfunctions(string sqlstring)
            {

            Conn.Open();
            cmd = new NpgsqlCommand(sqlstring, Conn);

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);

            if (dt != null)
            {
                ds.Tables.Add(dt);
            }


            Conn.Close();

                if (Conn != null)
            {
                Conn.Close();
                Conn.Dispose();
            }

                if (cmd != null)
            {
                cmd.Dispose();
            }

                return ds;

 }



        public int Postfunctions(string sqlstring)
        {
           
            Conn.Open();
            cmd = new NpgsqlCommand(sqlstring, Conn);
            int retVal = cmd.ExecuteNonQuery();
           

            Conn.Close();

            if (Conn != null)
            {
                Conn.Close();
                Conn.Dispose();
            }

            if (cmd != null)
            {
                cmd.Dispose();
            }

            return retVal;

        }


    }
}
