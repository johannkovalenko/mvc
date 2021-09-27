using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace mvc.Controllers
{
    public class Members : Controller
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

        public ActionResult Filtered(string filter)
        {
            return View("Index", context.members.Where(b => b.lastName.Contains(filter)).ToList());

        }
    }
}
