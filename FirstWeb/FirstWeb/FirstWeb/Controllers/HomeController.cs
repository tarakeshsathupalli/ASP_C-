using System.Collections.Generic;
using System.Web.Mvc;

namespace FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        public List<string> Index()
        {
            ViewBag.Countries= new List<string>{
            "INDIA",
            "UK",
            "USA",
            "CANADA"
            };

            return View();
        }
        
    }
}