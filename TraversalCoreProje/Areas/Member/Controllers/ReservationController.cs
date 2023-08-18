using Business.Concrete;
using DataAccess.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new DestinationDal());
        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        public IActionResult MyOldReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text=x.Name,
                                          }).ToList() ;
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }
    }
}
