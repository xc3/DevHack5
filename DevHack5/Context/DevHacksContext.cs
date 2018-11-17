using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevHack5.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DevHack5.Context
{
    public class DevHacksContext : DbContext
    {
        public DevHacksContext() : base("DevHacksContext")
        {

        }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
