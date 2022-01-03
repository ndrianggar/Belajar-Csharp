using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        // error tidak mau masuk data pada list karena method tidak pakai keyword static
        private static List<Country> countries = new List<Country>() {
        new Country(){Id = 0, Name="Indonesian", Language = "Indonesia" },
        new Country(){Id =1, Name="England", Language ="Inggris"}
      };
        [HttpGet]
        public IEnumerable<Country> GET()
        {
            return countries;
        }

        [HttpPost]
        public void Post([FromBody] Country country)
        {
            countries.Add(country);
        }

        [HttpPut]
        public void Put(int id, [FromBody] Country country)
        {
            countries[id] = country;
        }

        [HttpDelete]
        public void Delete(int Id)
        {
            countries.RemoveAt(Id);
        }
    }
}
