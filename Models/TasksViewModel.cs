using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Models
{
    public class TasksViewModel
    {
        public List<Tasker> Tasks { get; set; }
        public string TaskDueDate { get; set; }
        public string UserID { get; set; }
        
    }
}
