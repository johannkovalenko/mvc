using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class MembersController : Controller
    {
        public ActionResult Index()
        {
            return View(Data.members);
        }

        public ActionResult Detailed()
        {
            return View("Detailed");
        }

        public ActionResult Confirmed(mvc.Models.Member member)
        {
            Data.members.Add(member);

            return View("Index", Data.members);
        }
    }
}
