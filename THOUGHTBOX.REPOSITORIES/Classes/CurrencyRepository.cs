using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using THOUGHTBOX.REPOSITORIES.Interfaces;
using THOUGHTBOX.DOMAIN.Domain;
using Npgsql;



namespace THOUGHTBOX.REPOSITORIES.Classes
{
    public class CurrencyRepository: ICurrencyRepository
    {

        ConnectionRepository CR = new ConnectionRepository();
        private Currency curr = new Currency();     

        public int Create(Currency mCurrency)
        {
            try
            {
                //DB Persistent Login Here
                String mQuery = "Insert into currency(name,code,decimal)values('" + mCurrency.Name + "','" + mCurrency.Code + "','" + mCurrency.Decimals + "')";
                // Define a query
                int retv = CR.Postfunctions(mQuery);

                return retv;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //
            }
        }

        public int Delete(Int64 Id)
        {
            string mQuery = "delete from currency where Id=" + Id + "";
            int retv = CR.Postfunctions(mQuery);
            return retv;
        }

        public DataSet GetAll()
        {
          
            //DB Persistent Login Here
            String mQuery = "Select * from currency order by name";
            // Define a query
            DataSet ds = new DataSet();
            ds = CR.Getfunctions(mQuery);


            return ds;
        }


        public Currency GetById(Int64 Id)
        {
            string sqlqry = "select Id,name,code,decimal from currency where id=" + Id + "";
            DataSet ds = new DataSet();
            ds = CR.Getfunctions(sqlqry);

            curr.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
            curr.Name = ds.Tables[0].Rows[0]["name"].ToString();
            curr.Code = ds.Tables[0].Rows[0]["code"].ToString();
            curr.Decimals = Convert.ToInt32(ds.Tables[0].Rows[0]["decimal"].ToString());

            return curr;
        }

        public int Update(Currency currency)
        {
            try
            {
                string sqlupdate = "update currency set name='" + currency.Name.Trim().Replace("`", "'") + "', code='" + currency.Code.Trim().Replace("`", "'") + "', decimal=" + currency.Decimals + " where Id=" + currency.Id + "";
                int retval = CR.Postfunctions(sqlupdate);
                return retval;
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {

            }
           
        }
    }
}
