using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using THOUGHTBOX.HR.SERVICES.Interfaces;
using THOUGHTBOX.DOMAIN.Domain;
using System.Data;
using Newtonsoft.Json;



namespace THOUGHTBOX.HUMANRESOURCE.Controllers
{
    public class CountryController : Controller
    {
        DataSet ds = new DataSet();

        private ICountryService _Countryservice;
          
        public CountryController(ICountryService Countryservice)
        {
            this._Countryservice = Countryservice;

        }
        public IActionResult Index()
        {
            Currencyfilling();
            ViewBag.SubmitValue = "Submit";
            return View("~/Views/Country/Country.cshtml");
        }

        public void Currencyfilling()

        {
            try
            {
                ds = this._Countryservice.GetAll1();
                ViewBag.datastore = ds.Tables[0];

                List<SelectListItem> list = new List<SelectListItem>();

                foreach (System.Data.DataRow dr in ViewBag.datastore.Rows)
                {
                    list.Add(new SelectListItem { Text = @dr["name"].ToString(), Value = @dr["Id"].ToString() });

                }

                ViewBag.Currency = list;
            }
            catch(Exception ex)
            {
                
                throw new Exception(ex.Message);

            }
            
        }


        [HttpGet]
        public JsonResult GetTableValues()

        {
            try
            { 
            string resultr = this._Countryservice.GetAll();

                return Json(resultr);
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {


            }
        }

        public int Insertform(Country MCountry)
        {
            try
            { 
            int retval = this._Countryservice.Create(MCountry);
            return retval;
            }
            catch(Exception ex)
            {
                return (0);
            }
            finally
            {

            }
        }
    }
}