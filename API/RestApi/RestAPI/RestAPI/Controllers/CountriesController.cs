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
        private List<Country> countries = new List<Country>() {
        new Country(){IdCountry = 0, NameCountry="Indonesian", Language = "Indonesia" },
        new Country(){IdCountry=0, NameCountry="Saudi Arabia", Language ="Arabic"}
      };
        [HttpGet]
        public IEnumerable<Country> GET()
        {
            return countries;
        }
    }
}
