using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace mvc.Controllers
{
    public class MembersController : Controller
    {
        private MvcMembersContext context = new MvcMembersContext();

        public ActionResult Index()
        {
            return View(context.members.ToList());
        }

        public ActionResult Detailed()
        {
            return View("Detailed");
        }

        public ActionResult Confirmed(mvc.Models.Member member)
        {   
            context.members.Add(member);
            context.SaveChanges();

            return View("Index", context.members.ToList());
        }
    }
}
