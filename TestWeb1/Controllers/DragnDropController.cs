using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb1.Models;

namespace TestWeb1.Controllers
{
    public class DragnDropController : Controller
    {
        public static List<TaskModel> tasks = new List<TaskModel>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetTasks()
        {
            TaskModel task1 = new TaskModel()
            {
                id = "T0001",
                name = "Meeting",
                status = "TODO"
            };
            tasks.Add(task1);

            TaskModel task2 = new TaskModel()
            {
                id = "T0002",
                name = "Design Application Demo",
                status = "TODO"
            };
            tasks.Add(task2);

            return Json(tasks);
        }
    }
}
