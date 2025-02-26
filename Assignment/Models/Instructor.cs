using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    [Table("Instructors")]
    class Instructor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Bouns { get; set; }
        [Column("Salary" , TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }

        [Required]
        public string? Address { get; set; }
        [Column("HourRate", TypeName = "decimal(10,2)")]
        public decimal HourRate { get; set; }
        public int Dep_ID { get; set; }


    }
}
