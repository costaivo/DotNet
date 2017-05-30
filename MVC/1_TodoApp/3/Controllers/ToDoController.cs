using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class ToDoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult AddItem(HomeViewModel homeViewModel)
        {
            if (homeViewModel.DeleteKey == 0)
            {
                HomeViewModel.Todos.Add(HomeViewModel.Todos.Keys.Any() ? HomeViewModel.Todos.Keys.Max() + 1 : 1, homeViewModel.Item);
            }
            else
            {
                HomeViewModel.Todos[homeViewModel.DeleteKey] = homeViewModel.Item;
                homeViewModel.DeleteKey = 0;
            }

            //TodoList.Todos.Add(homeViewModel.Item);
            return RedirectToAction("Index");
            //return View("Index");
        }

        public ActionResult RemoveItem(HomeViewModel homeViewModel)
        {
            HomeViewModel.Todos.Remove(homeViewModel.DeleteKey);
            homeViewModel.DeleteKey = 0;
            return View("Index");
        }

        public ActionResult EditItem(HomeViewModel homeViewModel)
        {
            homeViewModel.Item = HomeViewModel.Todos.FirstOrDefault(x => x.Key == homeViewModel.DeleteKey).Value;
            return View("Index");
        }
    }
}