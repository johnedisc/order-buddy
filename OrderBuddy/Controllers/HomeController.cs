using Microsoft.AspNetCore.Mvc;

namespace OrderBuddy.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}