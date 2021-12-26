using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        AdminManager am = new AdminManager(new EfAdminRepository());
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            var adminname = c.Admins.Where(x => x.UserName == usermail).Select(y => y.UserName).FirstOrDefault();
            ViewBag.v2 = adminname;
          
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
    }
}
