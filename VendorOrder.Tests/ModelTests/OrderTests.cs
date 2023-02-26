using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;


namespace OrderTracker.Tests
{
  [TestClass]

  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("order1", "test", 2, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]

    public void GetTitle_ReturnsTitle_Title()
    {
      string title = "order1";
      string description = "a dozen muffins";
      double price= 12.50;
      string date = "March 5th";
      Order newOrder = new Order (title, description, price, date);
      Assert.AreEqual(newOrder.Title, title);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      string title = "order1";
      string title2 = "order2";
      string description = "a dozen muffins";
      double price= 12.50;
      string date = "March 5th";
      Order newOrder = new Order (title, description, price, date);
      Order newOrder2 = new Order (title2, description, price, date);
      List<Order> newList  = new List<Order> { newOrder, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
      
    }
  }

}