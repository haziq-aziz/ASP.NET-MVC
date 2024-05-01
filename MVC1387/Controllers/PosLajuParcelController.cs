using Microsoft.AspNetCore.Mvc;
using MVC1387.Models;

namespace MVC1387.Controllers
{
    public class PosLajuParcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ParcelDelivery()
        {
            PosLajuParcel parcel = new PosLajuParcel();
            parcel.IndexWeight = parcel.IndexZone = -1;
            return View(parcel);
        }

        [HttpPost]
        public IActionResult ParcelDelivery(PosLajuParcel parcel)
        {
            if (ModelState.IsValid)
                return View("ParcelDeliveryInvoice", parcel);
            else
                return View(parcel);
        }
    }
}
