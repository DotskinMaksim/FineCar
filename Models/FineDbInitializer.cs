using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FineCar.Models
{
    public class FineDbInitializer : DropCreateDatabaseAlways<FineContext>
    {
        protected override void Seed(FineContext db)
        {
            base.Seed(db);
        }

    }
}