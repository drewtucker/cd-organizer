using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;
namespace CdOrganizer.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/cds/new")]
        public ActionResult CdForm()
        {
          return View();
        }


      [HttpPost("/cds/list")]
      public ActionResult AddCd()
      {
        Cd newCd = new Cd(Request.Form["cdTitle"], Request.Form["cdArtist"], int.Parse(Request.Form["releaseYear"]));
        return View("CdList", Cd.AllCds());
      }

    }
}
