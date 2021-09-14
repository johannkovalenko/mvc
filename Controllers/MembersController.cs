using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace mvc.Controllers
{
    public class MembersController : Controller
    {
        private List<mvc.Models.Member> members = new List<mvc.Models.Member>
        { 
            new mvc.Models.Member {firstName="Mieszko", middleName="Jan", lastName="Kovalenko"},
            new mvc.Models.Member {firstName="Karolina", middleName="Agnieszka", lastName="Kovalenko"},
            new mvc.Models.Member {firstName="Johann", middleName="", lastName="Kovalenko"},
        };

        public ActionResult Index()
        {
            return View(members);
        }

        public ActionResult Detailed()
        {
            return View("Detailed");
        }

        public string Confirmed(mvc.Models.Member member)
        {
            return "The following data was received: " + member.firstName 
            + " " + member.middleName + " " + member.lastName;
        }
    }
}
