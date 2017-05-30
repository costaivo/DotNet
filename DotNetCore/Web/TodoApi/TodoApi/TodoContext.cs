using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi
{
    public class TodoContext :DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            :base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }

}
