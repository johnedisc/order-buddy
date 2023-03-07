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


    // This one creates new Items within a given Category, not new Categories:

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(string vendorId,string orderTitle,string orderDescription, string orderPrice,string orderDate)
    {
      int id = Int32.Parse(vendorId);
      Order newVendorOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      Vendor currentVendor = Vendor.Find(id);
      currentVendor.Orders.Add(newVendorOrder);
      return View("Show",currentVendor);
    }


  }
}
