using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Controllers
{
    public class Home : Controller
    {
        private Contexts.Companies companies;

        public Home(Contexts.Companies companies)
        {
            this.companies = companies;
        }

        public ActionResult Index()
        {
            var set = companies.companies.ToList();
            return View(set.ToList());
        }

        public ActionResult Details(int id)
        {
            List<Models.Company> set = companies.companies.Where(b => b.id.Equals(id)).ToList();
            return View(new Models.Data(set, 0));
        }
    }
}
