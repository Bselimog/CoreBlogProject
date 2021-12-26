using DotNetCoreCamp.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname="İndirim",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Gelecek İndirim",
                categorycount = 14
            });
            list.Add(new CategoryClass
            {
                categoryname = "Fiyat Performans",
                categorycount = 5
            });
            return Json(new { jsonlist = list });
        }
    }
}
