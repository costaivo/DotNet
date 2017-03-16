using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class ToDoAppController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult AddItem(ToDoViewModel homeViewModel)
        {
            if (homeViewModel.DeleteKey == 0)
            {
                ToDoViewModel.Todos.Add(ToDoViewModel.Todos.Keys.Any() ? ToDoViewModel.Todos.Keys.Max() + 1 : 1, homeViewModel.Item);
            }
            else
            {
                ToDoViewModel.Todos[homeViewModel.DeleteKey] = homeViewModel.Item;
                homeViewModel.DeleteKey = 0;
            }

            //TodoList.Todos.Add(homeViewModel.Item);
            return RedirectToAction("Index");
            //return View("Index");
        }

        public ActionResult RemoveItem(ToDoViewModel homeViewModel)
        {
            ToDoViewModel.Todos.Remove(homeViewModel.DeleteKey);
            homeViewModel.DeleteKey = 0;
            return View("Index");
        }

        public ActionResult EditItem(ToDoViewModel homeViewModel)
        {
            homeViewModel.Item = ToDoViewModel.Todos.FirstOrDefault(x => x.Key == homeViewModel.DeleteKey).Value;
            return View("Index");
        }
    }
}