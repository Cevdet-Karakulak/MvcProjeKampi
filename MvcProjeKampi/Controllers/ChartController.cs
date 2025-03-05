using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoyChart()
        {
            return Json(BlogList(),JsonRequestBehavior.AllowGet);
        }
        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName="Film",
                CategoryCount=8
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Tiyatro",
                CategoryCount = 4
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Kitap",
                CategoryCount = 1
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 7
            });
            return ct;
        }
    }
}