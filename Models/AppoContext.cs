using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Task1_withBd.Models
{
    public class AppoContext:DbContext
    {
        public DbSet<Guest> Guests{ get; set; }
        public AppoContext(DbContextOptions<AppoContext> options)
            : base(options)
        {
            Database.EnsureCreated();   
        }
    }
}
