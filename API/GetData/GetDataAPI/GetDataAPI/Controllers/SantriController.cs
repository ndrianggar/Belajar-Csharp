using GetDataAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SantriController : ControllerBase
    {
        private List<Santri> santries = new List<Santri>()
        {
            new Santri() {IdSantri = 0, NamaSantri = "Muhammad", Kelas = "Tahfiz" },
            new Santri() {IdSantri = 1, NamaSantri = "Rudi", Kelas = "Tahsin" },

        };

        [HttpGet]
        public IEnumerable<Santri> GET()
        {
            return santries;
        }

        [HttpPost]
        public void Post([FromBody] Santri santri)
        {
            santries.Add(santri);

        }

        [HttpPut("{IdSantri}")]
        public void PUT(int IdSantri, [FromBody] Santri santri)
        {
            santries[IdSantri] = santri;
        }

        [HttpDelete]
        public void Delete(int IdSantri)
        {
            santries.RemoveAt(IdSantri);
        }

    }
}
