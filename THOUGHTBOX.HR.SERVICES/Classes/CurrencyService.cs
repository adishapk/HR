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
    public class CurrencyService : ICurrencyService
    {
        private ICurrencyRepository _CurrencyRepository;
        private Currency curr = new Currency();

        public CurrencyService(ICurrencyRepository CurrencyRepository)
        {
            this._CurrencyRepository = CurrencyRepository;

        }


        public int Create(Currency mCurrency)
        {
            try
            {
                return this._CurrencyRepository.Create(mCurrency);
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
                int ret = this._CurrencyRepository.Delete(Id);
                return ret;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string GetAll()
        {
            try
            {
                DataSet ds = null;
                ds = this._CurrencyRepository.GetAll();

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
                //
            }
        }

        public Currency GetById(Int64 Id)
        {
            curr = this._CurrencyRepository.GetById(Id);
            return curr;
        }

        public int Update(Currency currency)
        {
            try
            {
                return _CurrencyRepository.Update(currency);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
