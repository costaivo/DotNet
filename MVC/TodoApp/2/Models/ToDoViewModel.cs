using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class ToDoViewModel
    {
        public string Item { get; set; }
        public int DeleteKey { get; set; }

        //public static List<string> Todos { get; set; }
        public static  Dictionary<int, string> Todos { get; set; }

        static ToDoViewModel()
        {
            //Todos = new List<string>();
            Todos = new Dictionary<int, string>();
        }
    }
}
