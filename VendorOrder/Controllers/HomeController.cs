using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}