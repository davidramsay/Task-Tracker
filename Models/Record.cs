using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Models
{
    public class Record
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None),Key]
        public int RecordID { get; set; }
        public Objective ObjectiveID { get; set; }
        [Display(Name = "Objective Due Date"), DataType(DataType.Date)]
        public DateTime RecordDate { get; set; }
        public string RecordData { get; set; }
    }
}
