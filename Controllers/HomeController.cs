﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAuthApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //GET: Login
        public ActionResult Login()
        {
            return View();
        }
        
        //GET: Auth
        public ActionResult Auth()
        {
            return View();
        }
    }
}