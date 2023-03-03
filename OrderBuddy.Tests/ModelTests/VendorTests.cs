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
      Vendor testVendor = new Vendor("test","test");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ContainsInputedName_Vendor()
    {
      //Arrange
      string test = "sysco";

      //Act
      Vendor testVendor = new Vendor(test,"more test");

      //Assert
      Assert.AreEqual(test, testVendor.Name);
    }

    [TestMethod]
    public void VendorConstructor_ReturnsDescriptionProperty_Vendor()
    {
      //Arrange
      string test = "sysco";
      string sampleDescription = "very big company that brings our peeled garlic";

      //Act
      Vendor testVendor = new Vendor(test, sampleDescription);

      //Assert
      Assert.AreEqual(sampleDescription, testVendor.Description);
    }


    [TestMethod]
    public void VendorConstructor_InstanceIdCorrespondsWithTotalNumberOfInstancesCreated_Vendor()
    {
      //Arrange
      string test = "sysco";
      string sampleDescription = "very big company that brings our peeled garlic";

      //Act
      Vendor testVendor = new Vendor(test, sampleDescription);
      Vendor testVendor2 = new Vendor(test, sampleDescription);
      int count = 2;

      //Assert
      Assert.AreEqual(count, testVendor2.Id);
    }

  }
}
