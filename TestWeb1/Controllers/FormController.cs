using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb1.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
