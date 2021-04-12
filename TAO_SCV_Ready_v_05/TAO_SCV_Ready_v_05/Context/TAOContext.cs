using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TAO_SCV_Ready_v_05.Models;

namespace TAO_SCV_Ready_v_05.Context
{
    public class TAOContext : DbContext
    {
        public TAOContext() : base("TAOContext")
        {
        }

        public DbSet<HourlyRead> HourlyReadings { get; set; }
        public DbSet<DailyRead> DailyReads { get; set; }
        //public System.Data.Entity.DbSet<TAO_SCV_Ready.Models.DailyRead> DailyReads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}