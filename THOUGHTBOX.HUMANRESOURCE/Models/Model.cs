using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace THOUGHTBOX.HUMANRESOURCE.Models
{
    public class Model
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                    "Password=1972Snape;Database=HRDB;");
        //DataSet ds = null;
        
        public DataSet SP_Master(string SQLvalstring1)
        {

            NpgsqlCommand cmd = null;
            NpgsqlDataReader dr = null;
            NpgsqlDataAdapter objAdapter = new NpgsqlDataAdapter();
            //string procName = master.para_N45;
            DataSet ds = new DataSet();


            try
            {

                cmd = new NpgsqlCommand(SQLvalstring1, conn);
                objAdapter = new NpgsqlDataAdapter(cmd);
                // Execute a query
                DataTable dt = new DataTable();
                objAdapter.Fill(dt);
                ds.Tables.Add(dt);
                
                // Close connection
                conn.Close();

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();

                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }

            
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                
            }

            return ds;
        }

    }
}
