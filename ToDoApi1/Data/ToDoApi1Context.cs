using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApi1.Models;

namespace ToDoApi1.Data
{
    public class ToDoApi1Context : DbContext
    {
        public ToDoApi1Context (DbContextOptions<ToDoApi1Context> options)
            : base(options)
        {
        }

        public DbSet<ToDoApi1.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
