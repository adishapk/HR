using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using THOUGHTBOX.REPOSITORIES.Interfaces;
using System.Data;

namespace THOUGHTBOX.REPOSITORIES.Classes
{
    public class CountryRepository: ICountryRepository
    {
        ConnectionRepository CR = new ConnectionRepository();
        private Country country = new Country();

        public int Create(Country mCountry)
        {
            try
            {
                //DB Persistent Login Here
                String mQuery = "Insert into country(name_eng,name_arb,code,currencyid)values('" + mCountry.Name_Eng + "','" + mCountry.Name_Arb + "','" + mCountry.Code + "','" + mCountry.Currencyid + "')";
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
            String mQuery = "Select * from country order by Name_Eng";
            // Define a query
            DataSet ds = new DataSet();
            ds = CR.Getfunctions(mQuery);


            return ds;
        }


        public Country GetById(Int64 Id)
        {
            string sqlqry = "select Id,name,code,decimal from currency where id=" + Id + "";
            DataSet ds = new DataSet();
            ds = CR.Getfunctions(sqlqry);

            country.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
            country.Name_Eng = ds.Tables[0].Rows[0]["name"].ToString();
            country.Code = ds.Tables[0].Rows[0]["code"].ToString();
            country.Currency.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["decimal"].ToString());

            return country;
        }

        public int Update(Country country)
        {
            try
            {
                string sqlupdate = "update currency set name='" + country.Name_Eng.Trim().Replace("`", "'") + "', code='" + country.Code.Trim().Replace("`", "'") + "', decimal=" + country.Currency.Id + " where Id=" + country.Id + "";
                int retval = CR.Postfunctions(sqlupdate);
                return retval;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {

            }

        }
    }
}
