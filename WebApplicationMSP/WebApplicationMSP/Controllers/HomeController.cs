using System;
using System.Web.Mvc;

namespace WebApplicationMSP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            DBContext.DBContext db = new DBContext.DBContext();
            db.LogsCollection.Add(new Entities.Log() {Ip = Request.UserHostAddress, Date = DateTime.Now});
            db.SaveChanges();
            return View();
        }
    }
}
