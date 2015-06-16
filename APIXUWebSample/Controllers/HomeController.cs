using APIXULib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIXUWebSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string key = "eb2a0633229b456ba6093557151106";
            IRepository repo = new Repository();
            var GetCityForecastWeatherResult = repo.GetWeatherData(key, GetBy.CityName, "paris", Days.Three);
            return View(GetCityForecastWeatherResult);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}