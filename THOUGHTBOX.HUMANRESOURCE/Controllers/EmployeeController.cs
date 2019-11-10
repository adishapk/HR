using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using THOUGHTBOX.HR.SERVICES.Interfaces;

namespace THOUGHTBOX.HUMANRESOURCE.Controllers
{
    public class EmployeeController : Controller
    {

        private IEmployeeService _EmployeeService;

        public EmployeeController(IEmployeeService EmployeeService)
        {
            this._EmployeeService = EmployeeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetById()
        {
            try
            {
                var myEmployee = this._EmployeeService.GetById(1);

                return Json(myEmployee);
            }
            catch(Exception ex)
            {
                return Json(ex.Message.ToString().Trim());
            }
            finally
            {
                //
            }
        }
    }
}