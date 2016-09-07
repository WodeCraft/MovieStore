using MbmStore.Models;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            Customer john = new Customer("John", "Wayne", "OK Corral", "83", "Tombestone");
            Customer maz = new Customer("Maz", "Jobrani", "31st street", "9384", "New York");
            Customer liz = new Customer("Lizzy", "Hale", "Upper Crest", "1342", "Oklahoma");

            ViewBag.John = john;
            ViewBag.Maz = maz;
            ViewBag.Liz = liz;

            return View();
        }
    }
}