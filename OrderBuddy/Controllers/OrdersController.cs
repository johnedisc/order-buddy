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

      [HttpPost("/vendors/{id}/orders/create")]
      public ActionResult Create(string orderTitle,string orderDescription, string orderPrice,string orderDate)
      {
        Order newVendorOrder = new Order(string orderTitle,string orderDescription, string orderPrice,string orderDate);
        Vendor passedVendor = Vendor.Find(id);
        return ResultToAction(passedVendor);
      }
      [HttpPost("/vendors")]
      public ActionResult Create(string vendorName, string vendorDescription)
      {
        Vendor newVendor = new Vendor(vendorName, vendorDescription);
        return RedirectToAction("Index");
      }
    }
}
