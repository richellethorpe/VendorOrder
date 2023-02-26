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
  }
}
