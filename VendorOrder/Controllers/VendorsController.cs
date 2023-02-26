using OrderTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace VendorOrder.Controllers
{
  public class VendorsControllers : Controller
  {
    [HttpGet("/vendors")]

    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

        [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newCategory = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedCategory = Vendor.Find(id);
      List<Order> categoryItems = selectedCategory.Orders;
      model.Add("category", selectedCategory);
      model.Add("orders", categoryItems);
      return View(model);
    }
  }
}
