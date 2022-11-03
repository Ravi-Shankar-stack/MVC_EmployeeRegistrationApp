using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeRegistrationApp.Models;

namespace EmployeeRegistrationApp.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return View("Acknowledgement", emp);
            }
            return View();
        }
    }
}