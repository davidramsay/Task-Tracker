using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Models
{
    public class Objective
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None),Key]
        public int ObjectiveID { get; set; }
        public int GoalID { get; set; }
        public string MetricName { get; set; }
        [Display(Name = "Objective Due Date"), DataType(DataType.Date)]
        public DateTime ObjectiveDueDate { get; set; }
    }
}
