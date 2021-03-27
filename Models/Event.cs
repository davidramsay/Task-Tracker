using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Models
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None),Key]
        public int EventID { get; set; }
        public int CategoryID { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        [Display(Name = "Event Date"), DataType(DataType.Date)]
        public DateTime ObjectiveDueDate { get; set; }
    }
}
