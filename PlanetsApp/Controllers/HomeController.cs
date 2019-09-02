using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanetsApp.Models;

namespace PlanetsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Planet> planets = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44391/api/");
                //HTTP GET
                var responseTask = client.GetAsync("planet");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Planet>>();
                    readTask.Wait();

                    planets = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    planets = Enumerable.Empty<Planet>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(planets);
        }
    }
}
