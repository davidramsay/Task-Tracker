using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskTrackerPrototype.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID {get; set;}
        public int UserID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryAbbreviation { get; set; }
        public User User { get; }
    }
}
