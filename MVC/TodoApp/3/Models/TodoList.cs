using System;
using System.Collections.Generic;

namespace TodoApp.Models
{
    public  class TodoList
    {
        public static List<ToDoItem> Todos { get; set; }

        static TodoList()
        {
            Todos = new List<ToDoItem>()
            {
                 new ToDoItem() {Id = Guid.NewGuid(),TaskName="Pay Credit Card Bills",Description ="Pay Credit Card Bill Before 19th of every month" },
                 new ToDoItem() {Id= Guid.NewGuid(),TaskName="Recharge mobile talktime",Description="Recharge with 500 INR to get full talk time" }
            };
        }
    }

    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
    }
}