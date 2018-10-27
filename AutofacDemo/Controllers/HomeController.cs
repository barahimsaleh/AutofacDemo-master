using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacDemo.Controllers
{
    public class HomeController : Controller
    {
        //public HomeController()
        //{ }
        private readonly ICalculatorService _calcService;
        public HomeController(ICalculatorService calcService)
        {
            this._calcService = calcService;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddNumbers(int x, int y)
        {
            var result = _calcService.calculate(x, y);
            return Content(result.ToString());
        }
    }
}