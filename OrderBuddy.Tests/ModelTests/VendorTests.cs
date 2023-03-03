using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderBuddy.Models;
using System;

namespace OrderBuddy.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose() 
    {
      Vendor.EmptyInstancesList();
    }

    [TestMethod]
    //Arrange
    [DataRow("sysco","very big company that brings our peeled garlic")]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor(string name,string description)
    {
      Vendor testVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    //Arrange
    [DataRow("sysco","very big company that brings our peeled garlic")]
    public void VendorConstructor_ReturnsInputedName_Vendor(string name,string description)
    {
      //Act
      Vendor testVendor = new Vendor(name, description);

      //Assert
      Assert.AreEqual(name, testVendor.Name);
    }

    [TestMethod]
    //Arrange
    [DataRow("sysco","very big company that brings our peeled garlic")]
    public void VendorConstructor_ReturnsInputtedDescription_Vendor(string name,string description)
    {
      //Act
      Vendor testVendor = new Vendor(name, description);

      //Assert
      Assert.AreEqual(description, testVendor.Description);
    }


    [TestMethod]
    //Arrange
    [DataRow("sysco","very big company that brings our peeled garlic")]
    public void VendorConstructor_InstanceIdCorrespondsWithTotalNumberOfInstancesCreated_Vendor(string name,string description)
    {
      //Act
      Vendor testVendor1 = new Vendor(name, description);
      Vendor testVendor2 = new Vendor(name, description);
      int count = 2;

      //Assert
      Assert.AreEqual(count, GetInstancesList().Count);
    }

  }
}
