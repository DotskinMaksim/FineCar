using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FineCar.Models
{
    public class FineContext : DbContext
    {

        public DbSet<Fine> Fines { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
    }
}