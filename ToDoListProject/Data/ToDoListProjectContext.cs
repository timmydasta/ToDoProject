using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoListProject.Models;

namespace ToDoListProject.Data
{
    public class ToDoListProjectContext : DbContext
    {
        public ToDoListProjectContext (DbContextOptions<ToDoListProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoListProject.Models.ToDoTask> ToDoTask { get; set; }
    }
}
