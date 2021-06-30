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
                status = "To_Do"
            };
            ts.Add(task_1);
            TaskModel task_2 = new TaskModel
            {
                id = "T0002",
                name = "Design App",
                status = "To_Do"
            };
            ts.Add(task_2);
            TaskModel task_3 = new TaskModel
            {
                id = "T0003",
                name = "Design Database",
                status = "To_Do"
            };
            ts.Add(task_3);
            return ts;
        }

        [HttpGet]
        public JsonResult SetTasks()
        {
            tasks = GetTaskModels();
            return Json(tasks);
        }

        [HttpGet]
        public JsonResult GetTasks()
        {
            return Json(tasks);
        }

        [HttpPost]
        public JsonResult SetTaskToDo(string id_task)
        {
            foreach(var task in tasks)
            {
                if (task.id == id_task)
                    task.status = "To_Do";
            }
            return Json(id_task + " Successfully Updated");
        }

        [HttpPost]
        public JsonResult SetTaskInProgress(string id_task)
        {
            foreach (var task in tasks)
            {
                if (task.id == id_task)
                    task.status = "In_Progress";
            }
            return Json(id_task + " Successfully Updated");
        }

        [HttpPost]
        public JsonResult SetTaskDone(string id_task)
        {
            foreach (var task in tasks)
            {
                if (task.id == id_task)
                    task.status = "Done";
            }
            return Json(id_task + " Successfully Updated");
        }
    }
}
