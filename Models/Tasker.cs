using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Models
{
    public class Tasker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }
        [Required, StringLength(10)]
        public string TaskName { get; set; }
        [Required, StringLength(20)]

        public string TaskDescription { get; set; }
        public int ObjectiveID { get; set; }
        [Display(Name = "Task Due Date"), DataType(DataType.Date)]
        public DateTime TaskDueDate { get; set; }
        public User User { get; }
        

    }
}
