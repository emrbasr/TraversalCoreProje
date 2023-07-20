using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _AddCommand : ViewComponent
    {
        //sCommandManager commandManager = new CommandManager(new CommandDal());
        //
        //[HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke(Entity.Concrete.Command p)
        //{
        //    p.CommandDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.CommandState = true;
        //    commandManager.TAdd(p);
        //    return View();
        //}
    }
}
