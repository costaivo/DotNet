using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoApp.Controllers
{
    public class TaskManagerController : Controller
    {
        // GET: TaskManager
        public ActionResult Index()
        {
            return View();
        }
    }
}