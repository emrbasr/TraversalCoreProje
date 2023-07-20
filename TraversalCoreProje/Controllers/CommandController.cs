using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    public class CommandController : Controller
    {
        CommandManager commandManager = new CommandManager(new CommandDal());

        [HttpGet]
        public PartialViewResult AddCommand()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddCommand(Command p)
        {
            p.CommandDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommandState = true;
            p.DestinationId = 1;
            commandManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
