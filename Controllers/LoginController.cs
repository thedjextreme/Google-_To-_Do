using Google_To_Do.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google_To_Do.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            zadanie _empoyeeModel = new zadanie();
            return View(_empoyeeModel);
        }
       // [HttpPost]
       // public IActionResult Index(zadanie _empoyeeModel)
        //{
            zadanie _employeeContext = new zadanie();
            //var status = _employeeContext.EmployeeLogin.Where(m => m.LoginId == _empoyeeModel.LoginId && m.Password == _empoyeeModel.Password).FirstOrDefault();
            //if (status == null)
            //{
            //    ViewBag.LoginStatus = 0;
            //}
            //else
           // {
            //    return RedirectToAction("SuccessPage", "Home");
            //}
           // return View(_empoyeeModel);
       // }
        public IActionResult SuccessPage()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
