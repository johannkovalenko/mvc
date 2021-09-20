using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    public class Home : Controller
    {
        private Contexts.Companies context;

        public Home(Contexts.Companies context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {
            var set = context.companies.ToList();
            return View(set.ToList());
        }

        public ActionResult AddRecord(Models.Company company)
        {
            context.companies.Add(company);
            context.SaveChanges();

            return View("Index", context.companies.ToList());
        }

        public ActionResult LinkRecord(Models.Owner owner)
        {
            context.owners.Add(owner);
            context.SaveChanges();

            return View("Index", context.companies.ToList());
        }

        public ActionResult Details(int id)
        {
            var query = context.owners
                .Join(
                    context.companies,
                    owners => owners.companyId,
                    companies => companies.id,
                    (owners, companies) => new Models.Query1
                    {
                        id = companies.id,
                        name = companies.name,
                        ownerID = owners.ownerID,
                        percent = owners.percent,
                        confirmed = owners.confirmed, 
                        sourceOwner = owners.sourceOwner
                    }
                )
                .Where(b => b.id.Equals(id));

            var query2 = query
                .Join(
                    context.companies,
                    query => query.ownerID,
                    companies => companies.id,
                    (query, companies) => new Models.Query2
                    {
                        companyId           = query.id,
                        companyName         = query.name,
                        ownerId             = query.ownerID,         
                        ownerName           = companies.name,
                        percent             = query.percent,
                        confirmed           = query.confirmed,
                        legalForm           = companies.legalForm,
                        label               = companies.label,
                        physical    = companies.physical,
                        address        = companies.address,
                        branch              = companies.branch,
                        chair               = companies.chair,
                        sourceChair         = companies.sourceChair,
                        ubo                 = companies.ubo,
                        capital                 = companies.capital,
                        currency            = companies.currency,
                        sourceOwner         = query.sourceOwner
                    }
                );


            return View(query2.ToList());
        }
    }
}
