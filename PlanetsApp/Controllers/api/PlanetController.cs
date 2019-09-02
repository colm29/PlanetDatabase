using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanetsApp.Services;

namespace PlanetsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IDataService _dataService;
        public PlanetController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var records = _dataService.Get();
            if (records != null)
                if (records.Count > 0)
                    return Ok(records);
            return NotFound();
        }
    }
}

