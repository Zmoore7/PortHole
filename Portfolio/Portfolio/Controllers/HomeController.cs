using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "My Bootstrap Site";
            MyInfo info = new MyInfo();
            info.Age = 21;
            info.Name = "zach"; 
            return View(info); 

           
        }
    }
}