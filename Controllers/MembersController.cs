﻿using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class MembersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detailed()
        {
            return View();
        }

        public string Confirmed()
        {
            return "The data was submitted";
        }
    }
}
