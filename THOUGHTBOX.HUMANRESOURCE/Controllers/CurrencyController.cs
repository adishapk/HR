using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using THOUGHTBOX.HR.SERVICES.Interfaces;
using THOUGHTBOX.DOMAIN.Domain;
using System.Data;
using System.Web;
using Newtonsoft.Json;


namespace THOUGHTBOX.HUMANRESOURCE.Controllers
{
    public class CurrencyController : Controller
    {

        private ICurrencyService _CurrencyService;
       // DataSet ds = null;
        
        public CurrencyController(ICurrencyService CurrencyService)
        {
            this._CurrencyService = CurrencyService;
        }

        public IActionResult Index()
        {
            //return View();

            ViewBag.SubmitValue = "Submit";
            return View("~/Views/Currency/Currency.cshtml");
        }


        [HttpGet]
        public JsonResult GetTableValues()
        {
            try
            {
                var myCurrency = this._CurrencyService.GetAll(); 


                return Json(myCurrency);
            }
            catch (Exception ex)
            {
                return Json(ex.Message.ToString().Trim());
            }
            finally
            {
                //
            }
        }



        [HttpPost]
        public JsonResult GetById()
        {
            try
            {
                var myCurrency = this._CurrencyService.GetById(1);

                return Json(myCurrency);
            }
            catch (Exception ex)
            {
                return Json(ex.Message.ToString().Trim());
            }
            finally
            {
                //
            }
        }


        [HttpGet]
        public ActionResult Currency(int id, string methode)
        {
           try
            { 
            if (methode == "Edit")
            {
                    
                    var myCurrency = this._CurrencyService.GetById(id);
                    ViewBag.SubmitValue = "Update";
                    return View(myCurrency);
            }

            else
            {
                    var myCurrency = this._CurrencyService.Delete(id);
                    return RedirectToAction("Index");
                   // return View(myCurrency);

                }
            }

            catch(Exception Ex)
            {
                return Json(Ex.Message.ToString().Trim());

            }
            finally
            {
                //
            }
        }

        [HttpPost]
        public ActionResult Currency(int id,string methode, Currency currency)
        {
            try
            {
                if (methode == "Edit")
                {
                    currency.Id = id;
                    this._CurrencyService.Update(currency);
                    return View();
                }

                else
                {
                    return View();
                }
             
        }
            catch(Exception ex)
            {

                return View();
            }
            finally
            {
                //
            }

        }

        [HttpPost]
        public string GetCurrency(Currency currency)
        {
            try
            {
                int retv = this._CurrencyService.Create(currency);
                return ("1");
            }
            catch (Exception ex)
            {
                return ("0");
            }
            finally
            {
                //
            }
        }



        [HttpPost]
        public string UpdateCurrency(Currency currency)
        {
            try
            {
                int retv = this._CurrencyService.Update(currency);
                return ("1");
            }
            catch (Exception ex)
            {
                return ("0");
            }
            finally
            {
                //
            }
        }





    }
}