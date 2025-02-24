using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment.ITIDbContext
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AssignmentITI; Trusted_Connection = true; TrustServerCertificate=True");
        }
    }
}
