using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(string username, string password)
        {
            if (username == "Admin" && password == "1234")
                return RedirectToAction("Index", "Home");
            else
                return View("Login");
        }
    }
}
