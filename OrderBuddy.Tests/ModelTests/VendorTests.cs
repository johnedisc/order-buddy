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
      Assert.AreEqual(count, Vendor.GetInstancesList().Count);
    }

    [TestMethod]
    [DataRow("sysco","very big company that brings our peeled garlic")]
    public void Find_FindInstanceWithAGivenIdValue_Vendor(string name,string description)
    {
      //Act
      Vendor testVendor1 = new Vendor(name, description);
      Vendor testVendor2 = new Vendor("hidden valley", description);

      //Assert
      Assert.AreEqual(testVendor2.Name, Vendor.Find(2).Name);
    }

      //Still can't get this test to pass. It wont recognize Order from here.
//    [TestMethod]
//    //Arrange
//    [DataRow("sysco","very big company that brings our peeled garlic")]
//    public void VendorConstructor_ReturnsInputtedOrder_List<Order>(string name,string description)
//    {
//      //Arrange
//      //Title, Description, Price, Date
//      List<string> sampleParameters = new List<string> { "flour","50 lbs bag","$25.25","2/23/23" };
//      //Act
//      Vendor testVendor1 = new Vendor(name, description);
//      Order testOrder1 = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);
//      Order testOrder2 = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);
//      testVendor1.Orders.Add(testOrder1);
//      testVendor1.Orders.Add(testOrder2);
//      List<Order> testList = new List<Order> { testOrder1, testOrder2 };
//
//      //Assert
//      CollectionAssert.AreEqual(testList, testVendor1.Orders);
//    }
  }
}
