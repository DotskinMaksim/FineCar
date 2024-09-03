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
            db.Fines.Add(
                new Fine
                {
                    CarNumber = "123ABC",
                    Name = "Maksim",
                    Email = "dotskin.maksim@gmail.com",
                    PhoneNumber = "55553605",
                    dateTime = new DateTime(2024, 8, 27, 14, 30, 0),
                    Excess = 15,
                    Amount = 50

                });
            base.Seed(db);
        }

    }
}