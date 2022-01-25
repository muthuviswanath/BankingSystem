using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace komalibank.Models
{
    public class KomaliBankContext:DbContext
    {
        public  KomaliBankContext() : base("KomaliBankContext") { }

        public DbSet<KomaliBank> KomaliBank{ get; set; }

     //   public System.Data.Entity.DbSet<komalibank.Models.DashboardViewModel> DashboardViewModels { get; set; }
    }
}