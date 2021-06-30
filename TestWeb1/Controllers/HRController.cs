using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb1.Models;

namespace TestWeb1.Controllers
{
    public class HRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<EmpModel> GetEmpsModel()
        {
            List<EmpModel> emps = new List<EmpModel>();

            EmpModel emp = new EmpModel()
            {
                name = "TEST",
                position = "Technician",
                arrived = DateTime.Parse("2005-05-05 08:30 AM"),
                depart_time = DateTime.Parse("2005-05-05 05:30 PM"),
                absent = 1,
                late = 2,
            };
            emps.Add(emp);

            EmpModel emp2 = new EmpModel();
            emp2.name = "TEST2";
            emp2.position = "Technician";
            emp2.arrived = DateTime.Parse("2005-05-05 08:30 AM");
            emp2.depart_time = DateTime.Parse("2005-05-05 05:30 PM");
            emp2.absent = 1;
            emp2.late = 2;
            emps.Add(emp2);

            return emps;
        }

        [HttpGet]
        public JsonResult GetData()
        {
            List<EmpModel> emps = new List<EmpModel>();
            emps = GetEmpsModel();
            return Json(emps);
        }


    }
}
