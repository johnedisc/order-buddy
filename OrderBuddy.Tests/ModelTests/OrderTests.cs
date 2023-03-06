using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderBuddy.Models;
using System;

namespace OrderBuddy.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.EmptyInstancesList();
    }

    //Arrange
    //Title, Description, Price, Date
    List<string> sampleParameters = new List<string> { "flour","50 lbs bag","$25.25","2/23/23" };

    [TestMethod]
    public void OrderConstruct_MakesInstanceOfOrder_Order()
    {
      Order testOrder = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void OrderConstruct_ReturnsInputTitle_Order()
    {
      //Act
      Order testOrder = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);

      //Assert
      Assert.AreEqual(sampleParameters[0], testOrder.Title);
    }

    [TestMethod]
    public void OrderConstruct_ReturnsInputDescription_Order()
    {
      //Act
      Order testOrder = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);

      //Assert
      Assert.AreEqual(sampleParameters[1], testOrder.Description);
    }

    [TestMethod]
    public void OrderConstruct_ReturnsInputPrice_Order()
    {
      //Act
      Order testOrder = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);

      //Assert
      Assert.AreEqual(sampleParameters[2], testOrder.Price);
    }

    [TestMethod]
    public void OrderConstruct_ReturnsInputDate_Order()
    {
      //Act
      Order testOrder = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);

      //Assert
      Assert.AreEqual(sampleParameters[3], testOrder.Date);
    }

    [TestMethod]
    public void OrderConstruct_InstanceIdCorrespondsWithTotalInstancesCreated_Order()
    {
      //Act
      Order testOrder = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);
      int count = 1;

      //Assert
      Assert.AreEqual(count, testOrder.Id);
    }

    [TestMethod]
    public void GetItems_InstanceListReturnsInstances_List()
    {
      //Act
      Order testOrder1 = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);
      Order testOrder2 = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);
      List<Order> test = Order.GetInstancesList();

      //Assert
      Assert.AreEqual(test, Order.GetInstancesList());
    }

    [TestMethod]
    public void Find_FindInstanceWithAGivenIdValue_Object()
    {
      //Act
      Order testOrder1 = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);
      Order testOrder2 = new Order(sampleParameters[0],sampleParameters[1],sampleParameters[2],sampleParameters[3]);

      //Assert
      Assert.AreEqual(testOrder2.Price, Order.Find(2).Price);
    }
  }
}
