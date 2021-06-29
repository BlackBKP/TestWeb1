using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb1.Models;

namespace TestWeb1.Controllers
{
    public class KanbanController : Controller
    {
        public static List<TaskModel> tasks = new List<TaskModel>();

        public IActionResult Index()
        {
            return View();
        }

        public List<TaskModel> GetTaskModels()
        {
            List<TaskModel> ts = new List<TaskModel>();
            TaskModel task_1 = new TaskModel
            {
                id = "T0001",
                name = "Design Website",
                status = "Todo"
            };
            ts.Add(task_1);
            TaskModel task_2 = new TaskModel
            {
                id = "T0002",
                name = "Design App",
                status = "Todo"
            };
            ts.Add(task_2);
            TaskModel task_3 = new TaskModel
            {
                id = "T0003",
                name = "Design Database",
                status = "Todo"
            };
            ts.Add(task_3);
            return ts;
        }

        [HttpGet]
        public JsonResult GetTasks()
        {
            tasks = GetTaskModels();
            return Json(tasks);
        }
    }
}
