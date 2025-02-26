using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    [PrimaryKey("Inst_ID", "Course_ID")]
    class Course_Inst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int Evaluation { get; set; }

    }
}
