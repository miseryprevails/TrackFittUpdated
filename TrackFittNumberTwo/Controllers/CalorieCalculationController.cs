using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackFittNumberTwo.Controllers
{
    public class CalorieCalculationController : Controller
    {
        public IActionResult CalorieCalculation()
        {
            
            return View();
        }
    }
}
