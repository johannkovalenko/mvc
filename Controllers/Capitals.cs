using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class Capitals : Controller
{
    private Contexts.Companies context;

    public Capitals(Contexts.Companies context)
    {
        this.context = context;
    }

    public ActionResult Show()
    {
        List<Models.Capital> list = context.capitals.Where(b => b.country.Equals("Austria")).ToList();
        return View(list);
    }
}