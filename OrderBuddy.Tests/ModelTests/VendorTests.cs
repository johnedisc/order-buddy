using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderBuddy.Models;
using System;

namespace OrderBuddy.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ContainsInputedName_Vendor()
    {
      string test = "sysco";
      Vendor testVendor = new Vendor(test);
      Assert.AreEqual(test, testVendor.Name);
    }

    [TestMethod]
    public void VendorConstructor_ReturnsDescriptionProperty_Vendor()
    {
      string test = "sysco";
      string sampleDescription = "very big company that brings our peeled garlic";
      Vendor testVendor = new Vendor(test, sampleDescription);
      Assert.AreEqual(sampleDescription, testVendor.Description);
    }

  }
}
