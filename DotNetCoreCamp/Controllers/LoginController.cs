using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DotNetCoreCamp.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;

namespace DotNetCoreCamp.Controllers
{
    [AllowAnonymous]
   

    public class LoginController : Controller
    {
        private readonly IHtmlLocalizer<LoginController> _localizer;
        public LoginController(IHtmlLocalizer<LoginController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return Redirect(Request.Headers["Referer"].ToString());
            //return RedirectToAction(nameof(Index));
        }




        [HttpPost]
        public async Task<IActionResult> Index(Writer writer, Admin admin)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }



        }

        public IActionResult IndexAdmin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAdmin(Admin admin)
        {
            Context c = new Context();
            var datavalue2 = c.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (datavalue2 != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.UserName)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Widget", new { area = "Admin" });
            }
            else
            {
                return View();
            }
        }
    }
}
