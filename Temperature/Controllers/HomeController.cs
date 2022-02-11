using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// using Temperature.Models;

namespace Temperature.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }
    [HttpPost]
    public IActionResult Index(IFormCollection iFormCollection) {
        Conversion con = new Conversion();
        if ((iFormCollection["temperature"] == "Fahrenheit") && (iFormCollection["temperature2"] == "Celsius")) {
            Console.Write("heyyy");
            ViewData["ans"] = con.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, Convert.ToDouble(iFormCollection["ans"]));
        }
        else if (iFormCollection["temperature"] == "Kelvin" & iFormCollection["temperature2"] == "Fahrenheit")
        {
            ViewData["ans"] = con.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, Convert.ToDouble(iFormCollection["ans"]));
        }
        else if (iFormCollection["temperature"] == "Celsius" & iFormCollection["temperature2"] == "Kelvin")
        {
            ViewData["ans"] = con.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, Convert.ToDouble(iFormCollection["ans"]));
        }
        else if (iFormCollection["temperature"] == "Kelvin" & iFormCollection["temperature2"] == "Celsius")
        {
            ViewData["ans"] = con.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, Convert.ToDouble(iFormCollection["ans"]));
        }
        else if (iFormCollection["temperature"] == "Fahrenheit" & iFormCollection["temperature2"] == "Kelvin")
        {
            ViewData["ans"] = con.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, Convert.ToDouble(iFormCollection["ans"]));
        }
        else if (iFormCollection["temperature"] == "Celsius" & iFormCollection["temperature2"] == "Fahrenheit")
        {
            ViewData["ans"] = con.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, Convert.ToDouble(iFormCollection["ans"]));
        }
        else
        {
            ViewData["ans"] = iFormCollection["ans"];
        }
        return View();
    }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error() {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
