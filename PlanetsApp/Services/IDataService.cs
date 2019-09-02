using PlanetsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetsApp.Services
{
    public interface IDataService
    {
        List<Planet> Get();
    }
}
