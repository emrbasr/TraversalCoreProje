using BusinessLayer.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager TestimonialManager = new TestimonialManager(new TestimonialDal());
        public IViewComponentResult Invoke()
        {
            var value = TestimonialManager.TGetList();
            return View(value);
        }
    }
}
