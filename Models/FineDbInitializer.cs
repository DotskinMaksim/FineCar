using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FineCar.Models
{
    public class FineDbInitializer : DropCreateDatabaseAlways<FineContext> //DropCreateDatabaseIfModelChanges
    {
        protected override void Seed(FineContext db)
        {
            var owners = new List<CarOwner>
            {
                new CarOwner { PersonalCode = "50601040241", CarNumber = "ABC-123" },
                new CarOwner { PersonalCode = "50207030345", CarNumber = "XYZ-456" },
                new CarOwner { PersonalCode = "61001010567", CarNumber = "QWE-789" }
            };

            owners.ForEach(owner => db.CarOwners.Add(owner));

            db.SaveChanges();

            base.Seed(db);
        }
    }
}