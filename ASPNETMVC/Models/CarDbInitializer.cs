using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASPNETMVC.Models
{
    public class CarDbInitializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            context.Cars.Add(new Car { Name = "Audi A1", Producer = "Deuchland", Price = 964735 });
            context.Cars.Add(new Car { Name = "Audi A3", Producer = "Deuchland", Price = 1865543 });
            context.Cars.Add(new Car { Name = "Audi A4", Producer = "Deuchland", Price = 1540225 });
            context.Cars.Add(new Car { Name = "Audi A5", Producer = "Deuchland", Price = 1357314 });
            context.Cars.Add(new Car { Name = "Audi A6", Producer = "Deuchland", Price = 1458934 });
            context.Cars.Add(new Car { Name = "Audi A7", Producer = "Deuchland", Price = 2068572 });
            context.Cars.Add(new Car { Name = "Audi A8", Producer = "Deuchland", Price = 2367837 });
            context.Cars.Add(new Car { Name = "Audi Q2", Producer = "Deuchland", Price = 853337 });
            context.Cars.Add(new Car { Name = "Audi Q3", Producer = "Deuchland", Price = 1054050 });
            context.Cars.Add(new Car { Name = "Audi Q5", Producer = "Deuchland", Price = 1397802 });
            context.Cars.Add(new Car { Name = "Audi Q7", Producer = "Deuchland", Price = 1846533 });
            context.Cars.Add(new Car { Name = "Audi Q8", Producer = "Deuchland", Price = 1717064 });
            base.Seed(context);
        }
    }
}