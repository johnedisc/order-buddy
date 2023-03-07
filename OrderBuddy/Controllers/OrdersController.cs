using OrderBuddy.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace OrderBuddy.Controllers
{
    public class OrdersController : Controller
    {

      [HttpGet("/vendors/{id}/orders/new")]
      public ActionResult New(int id)
      {
        Vendor currentVendor = Vendor.Find(id);
        return View(currentVendor);
      }

    }
}
