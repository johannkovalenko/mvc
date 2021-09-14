using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace mvc.Controllers
{
    public class MembersController : Controller
    {
        private List<mvc.Models.Member> members = new List<mvc.Models.Member>
        { 
            new mvc.Models.Member("Mieszko", "Jan", "Kovalenko", 123.45),
            new mvc.Models.Member("Karolina", "Agnieszka", "Kovalenko", 234.56),
            new mvc.Models.Member("Johann", "", "Kovalenko", 345.67)
        };

        public ActionResult Index()
        {
            return View(members);
        }

        public ActionResult Detailed()
        {
            return View("Detailed");
        }

        public string Confirmed()
        {
            return "The data was submitted";
        }
    }
}
