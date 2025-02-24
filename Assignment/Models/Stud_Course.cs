using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    [PrimaryKey("Stud_ID" , "Course_ID")]
    class Stud_Course
    {
        [ForeignKey(nameof(Student.ID))]
        public int Stud_ID { get; set; }

        [ForeignKey(nameof(Course.ID))]
        public int Course_ID { get; set; }
        public int Grade { get; set; }
    }
}
