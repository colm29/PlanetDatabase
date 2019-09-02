using PlanetsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetsApp.Services
{
    public class DataService : IDataService
    {
        private readonly List<Planet> lstPlanet = new List<Planet>();
        public DataService()
        {
            Planet p1 = new Planet();
            p1.Id = 1;
            p1.Name = "Mercury";
            p1.Distance = 57000000;
            lstPlanet.Add(p1);

            Planet p2 = new Planet();
            p2.Id = 2;
            p2.Name = "Venus";
            p2.Distance = 108000000;
            lstPlanet.Add(p2);

            Planet p3 = new Planet();
            p3.Id = 3;
            p3.Name = "Earth";
            p3.Distance = 149000000;
            lstPlanet.Add(p3);

            Planet p4 = new Planet();
            p4.Id = 4;
            p4.Name = "Mars";
            p4.Distance = 227000000;
            lstPlanet.Add(p4);

            Planet p5 = new Planet();
            p5.Id = 5;
            p5.Name = "Jupiter";
            p5.Distance = 778000000;
            lstPlanet.Add(p5);

            Planet p6 = new Planet();
            p6.Id = 6;
            p6.Name = "Saturn";
            p6.Distance = 1427000000;
            lstPlanet.Add(p6);

            Planet p7 = new Planet();
            p7.Id = 7;
            p7.Name = "Uranus";
            p7.Distance = 2871000000;
            lstPlanet.Add(p7);

            Planet p8 = new Planet();
            p8.Id = 8;
            p8.Name = "Neptune";
            p8.Distance = 3497000000;
            lstPlanet.Add(p8);
        }

        public List<Planet> Get()
        {
            if (lstPlanet.Count > 0)
                return lstPlanet;
            return null;
        }
    }
}
