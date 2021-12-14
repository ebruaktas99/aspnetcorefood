using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreAndFood.Data.Models
{
    public class Context: DbContext //unutma
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-81USL0I\\SQLEXPRESS; database = CoreFood; integrated security = true"); //
        }

        public DbSet <Food> Foods { get; set; }
        public DbSet <Category> Categories { get; set; }
    }
}
