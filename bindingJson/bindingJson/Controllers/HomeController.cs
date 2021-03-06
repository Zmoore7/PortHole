﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bindingJson.Models;

namespace bindingJson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Initial View
            return View();
        }

        [HttpPost]
        public JsonResult PostSquirrel(Squirrel incomingSquirrel)
        {
            string status = null;
            try
            {
                saveSquirrel(incomingSquirrel);
                status = "If you don't see this, something went wrong.";
            }
            catch (Exception e)
            {
                status = e;
            }
            return Json(status);
        }

        #region privateHelpers
        private Boolean saveSquirrel(Squirrel incomingSquirrel)
        {
            return false;
        }
        #endregion
    }
}
