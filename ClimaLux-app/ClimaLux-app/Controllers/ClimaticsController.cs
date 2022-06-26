using ClimaLux_Services.Climatics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaLux_app.Controllers
{
    public class ClimaticsController : Controller
    {
        private readonly IClimaticsService _climatics;
        public ClimaticsController(IClimaticsService climatics)
        {
            _climatics = climatics;
        }

        public async Task<IActionResult> Index()
        {
            var allClimas = await _climatics.GetAllAsync();
            return View(allClimas);
        }
    }
}
