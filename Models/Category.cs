using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskTrackerPrototype.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None), Key]        
        public int CategoryID {get; set;}
        public int UserID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryAbbreviation { get; set; }

    }
}
