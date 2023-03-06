using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using OrderBuddy.Models;

namespace OrderBuddy.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetInstancesList();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }


//    // This one creates new Items within a given Category, not new Categories:
//
//    [HttpPost("/vendors/{vendorId}/items")]
//    public ActionResult Create(int vendorId, string itemDescription)
//    {
//      Dictionary<string, object> model = new Dictionary<string, object>();
//      Category foundCategory = Category.Find(vendorId);
//      Item newItem = new Item(itemDescription);
//      foundCategory.AddItem(newItem);
//      List<Item> vendorItems = foundCategory.Items;
//      model.Add("items", vendorItems);
//      model.Add("vendor", foundCategory);
//      return View("Show", model);
//    }


  }
}
