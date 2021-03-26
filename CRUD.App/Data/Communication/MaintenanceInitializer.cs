using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.App.Data.Communication
{
    public class MaintenanceInitializer
    {
        public static void Initialize(MaintenanceContext context)
        {
            context.Database.EnsureCreated();
            if (context.Product.Any())
            {
                return;
            }

            context.Product.Add(new Entities.ProductBE()
            {
                Name = "PC Core I5 9900",
                Description = "Migration origin",
                Stock = 20,
                UnitPrice = 1200.90m,
                Category = "Home"
            });

            context.Product.Add(new Entities.ProductBE()
            {
                Name = "Keyword Microsoft English mode",
                Description = "Migration origin",
                Stock = 280,
                UnitPrice = 35.00m,
                Category = "Home"
            });
            context.SaveChanges();
        }
    }
}
