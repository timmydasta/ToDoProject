using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoListProject.Models
{
    public class ToDoViewModel
    {
        public ToDoTask TheTask { get; set; }
        public IEnumerable<ToDoTask> Tasks { get; set; }
    }

    public class ToDoTask
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Priority { get; set; }
        public string? Status { get; set; }
    }
}
