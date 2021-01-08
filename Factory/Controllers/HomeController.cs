using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
        private readonly FactoryContext _db;

        public HomeController(FactoryContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            Dictionary<object, object> model = new Dictionary<object, object>();
            List<Engineer> engineers = _db.Engineers.ToList();
            List<Machine> machines = _db.Machines.ToList();
            model.Add("engineers", engineers);
            model.Add("machines", machines);
            return View(model);
        }
    }
}