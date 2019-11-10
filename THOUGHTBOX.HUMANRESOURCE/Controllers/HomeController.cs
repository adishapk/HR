using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using THOUGHTBOX.DOMAIN.Domain;
using THOUGHTBOX.HR.SERVICES.Interfaces;
using THOUGHTBOX.HUMANRESOURCE.Models;

namespace THOUGHTBOX.HUMANRESOURCE.Controllers
{
    public class HomeController : Controller
    {
        private ISampleService _SampleService;
        private IEmployeeService _EmployeeService;

        protected Employee MyEmployee { get; set; }

        public HomeController(ISampleService SampleService,
                            IEmployeeService EmployeeService)
        {
            this._SampleService = SampleService;
            this._EmployeeService = EmployeeService;
        }

        public IActionResult Index()
        {
            if (this._SampleService.Create())
            {
                return View();
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult About()
        {
            
            try
            {
               

                if (this._EmployeeService.GetAll())
                {
                    ViewData["Message"] = "GetAll Function Called Successfully!";
                }
               else if (this._EmployeeService.Update())
                {
                    ViewData["Message"] = "Update Function Called Successfully!";

                }

                return View();
            }
            catch(Exception ex)
            {
                return View("Error");
            }
            finally
            {
                //
            }



        
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSample()
        {
            try
            {
                Employee mEmployee = new Employee();

                if (this._EmployeeService.Create(mEmployee))
                {
                    ViewData["Message"] = "Employee Created Successfully!";
                }
                else
                {
                    ViewData["Message"] = "Your application description page.";
                }

                return View();
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            finally
            {
                //
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
