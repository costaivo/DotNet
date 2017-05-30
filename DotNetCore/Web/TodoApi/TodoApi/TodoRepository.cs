﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;

            if(_context.TodoItems.Count()==0)
            {
                Add(new TodoItem { Name = "Add your first Todo Item" });
            }
        }
        public void Add(TodoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public TodoItem Find(long key)
        {
            return _context.TodoItems.FirstOrDefault(x => x.Key == key);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        public void Remove(long key)
        {
            var entity = _context.TodoItems.First(x => x.Key == key);
            _context.TodoItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TodoItem item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
