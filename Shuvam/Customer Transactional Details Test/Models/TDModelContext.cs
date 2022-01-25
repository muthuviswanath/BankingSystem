using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Customer_Transactional_Details_Test.Models
{
    public class TDModelContext : DbContext
    {
        public TDModelContext() : base("TDModelContext") { }
        public DbSet<TDModel> TDModel { get; set; }
    }
}