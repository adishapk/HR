using System;
using System.Collections.Generic;
using System.Text;
using THOUGHTBOX.DOMAIN.Domain;
using THOUGHTBOX.HR.SERVICES.Interfaces;
using THOUGHTBOX.REPOSITORIES.Interfaces;
using System.Data;
using Newtonsoft.Json;



namespace THOUGHTBOX.HR.SERVICES.Classes
{
    public class CountryService: ICountryService
    {
        private ICountryRepository _CountryRepository;
        private ICurrencyRepository _CurrencyRepository;

        public CountryService(ICountryRepository CountryRepository,ICurrencyRepository CurrencyRepository)
        {
            this._CountryRepository = CountryRepository;
            this._CurrencyRepository = CurrencyRepository;
        }

        public string GetAll()
        {
            try
            { 
            DataSet ds = null;
                ds = this._CountryRepository.GetAll();

                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                Dictionary<string, object> row;


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in ds.Tables[0].Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }


                return JsonConvert.SerializeObject(rows);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            
            finally
            {

            }
        }




        public DataSet GetAll1()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = this._CurrencyRepository.GetAll();

                return ds;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

            finally
            {

            }
        }


        public int Create(Country mCountry)
        {
            try
            {
                int retval = this._CountryRepository.Create(mCountry);   
                return (retval);
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
            try
            {
                int ret = 0;
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public Country GetById(Int64 Id)
        {
            Country cnt = new Country();
            return (cnt);
        }

        public int Update(Country country)
        {
            try
            {
                return (1);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
