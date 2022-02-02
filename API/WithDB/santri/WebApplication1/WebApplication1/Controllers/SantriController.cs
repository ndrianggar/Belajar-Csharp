using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SantriController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public SantriController(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                            select Id_santri,  Nama_Santri from
                            santri
            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SantriAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand=new SqlCommand (query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }
    }
}
