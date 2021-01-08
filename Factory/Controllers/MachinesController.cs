using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
    public class MachinesController : Controller
    {
        private readonly FactoryContext _db;
        public MachinesController(FactoryContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Machine> model = _db.Machines.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Machine machine, int EngineerId)
        {
            _db.Machines.Add(machine);
            if (EngineerId != 0)
            {
                _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisMachine = _db.Machines
            .Include(machine => machine.Engineers)
            .ThenInclude(join => join.Engineer)
            .FirstOrDefault(machine => machine.MachineId == id);
            return View(thisMachine);
        }

        public ActionResult Edit(int id)
        {
            var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
            return View(thisMachine);
        }

        [HttpPost]
        public ActionResult Edit(Machine machine, int EngineerId)
        {
            if (EngineerId != 0)
            {
                _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
            }
            _db.Entry(machine).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddEngineer(int id)
        {
            var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
            ViewBar.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
            return View(thisMachine);
        }

        [HttpPost]
        public ActionResult AddEngineer(Machine machine, int EngineerId)
        {
            if (EngineerId != 0)
            {
                var returnedJoin = _db.EngineerMachine
                .Any(join => join.MachineId == machine.MachineId && join.EngineerId == EngineerId);
                if (!returnedJoin)
                {
                    _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.MachineId });
                }
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}