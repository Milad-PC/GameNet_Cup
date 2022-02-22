using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BijBijCup
{
    public class MyContext : DbContext
    {
        public DbSet<Models.GameNet> GameNets { get; set; }
        public DbSet<Models.RegisterUsers> Users { get; set; }
        public DbSet<Models.SMSHis> SMS { get; set; }
    }
}