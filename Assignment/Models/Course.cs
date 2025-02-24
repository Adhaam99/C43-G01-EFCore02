using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    [Table("Courses")]
    class Course
    {
        [Key]
        public int ID { get; set; }

        [Column("Duration", TypeName = "int")]
        public int Duration { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Length(3 , 50)]
        public string? Name { get; set; }

        [Column("Description", TypeName = "nvarchar(Max)")]
        public string? Description { get; set; }

        [ForeignKey(nameof(Topic.ID))]
        public int Top_ID { get; set; }


    }
}
