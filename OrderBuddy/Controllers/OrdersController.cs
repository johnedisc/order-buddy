using OrderBuddy.Models;
using Microsoft.AspNetCore.Mvc;

namespace OrderBuddy.Controllers
{
    public class OrdersController : Controller
    {

      [HttpGet("/vendors/{id}/orders/new")]
      public ActionResult New(int id)
      {
        Vendor passedVendor = Vendor.Find(id);
        return View(passedVendor);
      }

    }
}
