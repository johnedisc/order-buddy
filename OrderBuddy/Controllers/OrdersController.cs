using OrderBuddy.Models;
using Microsoft.AspNetCore.Mvc;

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

      [HttpGet("/vendors/{VendorId}/orders/{Id}")]
      public ActionResult Show(int VendorId, int Id)
      {
        Order currentOrder = Order.Find(Id);
        currentOrder.VendorId = VendorId;
        return View(currentOrder);
      }

      [HttpGet("/vendors/{VendorId}/orders/{Id}/delete")]
      public ActionResult Delete(int VendorId, int Id)
      {
        Vendor currentVendor = Vendor.Find(VendorId);
        currentVendor.DeleteOrder(Id);
        return RedirectToAction("Show","Vendors");
      }

    }
}
