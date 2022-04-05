using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_.Net_Framework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string Doa()
        {
            return "ini page doa";
        } 

        public string AddParamString(string param)
        {
            string isi = HttpUtility.HtmlEncode($"ini akan diisi dengan parameter atau dinamic string, =  {param}");

            return isi;
        }

        public string AddParamInt(int id)
        {
            string isiInt = HttpUtility.HtmlEncode($"ini akan diisi dengan parameter dynamic tanpa menulis query id, = {id}");
            return isiInt;
        }
    }
}