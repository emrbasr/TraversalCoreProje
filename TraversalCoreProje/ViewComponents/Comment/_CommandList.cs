using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommandList:ViewComponent
    {
        CommandManager commandManager=new CommandManager(new CommandDal());

      
        public IViewComponentResult Invoke(int id)
        {
            var values = commandManager.TGetDestinationById(id);
            return View(values);
        }


    }
}
