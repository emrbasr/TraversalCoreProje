using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager SubAboutManager = new SubAboutManager(new SubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = SubAboutManager.TGetList();
            return View(values);
        }
         
    }
}
