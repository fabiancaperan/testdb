using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testvue.data.model;

namespace testvue.data.context
{
    public class DataService:DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {            
            options.UseOracle(@"User Id=dummy;Password=dummy;Data Source=localhost:1521/ORCLCDB.localdomain");
        }
    }
}
