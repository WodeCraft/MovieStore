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
            john.addPhone("555-928374");
            john.addPhone("233-293844");
            john.BirthDate = new System.DateTime(1907, 5, 26);
            Customer maz = new Customer("Maz", "Jobrani", "31st street", "9384", "New York");
            maz.addPhone("515-394851");
            maz.BirthDate = new System.DateTime(1972, 2, 26);
            Customer liz = new Customer("Lizzy", "Hale", "Upper Crest", "1342", "Oklahoma");
            liz.addPhone("442-930285");

            ViewBag.John = john;
            ViewBag.Maz = maz;
            ViewBag.Liz = liz;

            return View();
        }
    }
}