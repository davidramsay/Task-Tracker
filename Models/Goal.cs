using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Models
{
    public class Goal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None),Key]
        public int GoalID { get; set; }
        public int CategoryID { get; set; }
        public string GoalName { get; set; }
        [Display(Name = "Goal Due Date"), DataType(DataType.Date)]
        public DateTime GoalDueDate { get; set; }
    }
}
