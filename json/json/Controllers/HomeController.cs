using json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace json.Controllers
{
    public class HomeController : Controller
    {
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

        public string CarMaker(car myCar)
        {
            var result = "";
            var message = "";

            var newCar = new car();
            newCar.make = myCar.make;
            newCar.model = myCar.model;
            newCar.year = myCar.year;
            newCar.vin = myCar.vin;

            result = new JavaScriptSerializer().Serialize(newCar);
            message = result;

            if (myCar == null)
            {
                return "this was null";
            }
            else
            {
                return result;
            }
   
        }
    }
}

