using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public static class TodoList
    {
        public static List<string> Todos { get; set; }

        static TodoList()
        {
            Todos = new List<string>();
        }
    }
}