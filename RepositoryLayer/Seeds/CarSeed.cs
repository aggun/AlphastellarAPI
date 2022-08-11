using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Seeds
{
    internal class CarSeed : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
                new Car { Id = 1, Model = "Ford", ColorId = 1 },
                new Car { Id = 2, Model = "Toyota", ColorId = 2 },
                new Car { Id = 3, Model = "Opel", ColorId = 3 });
        }
    }
}
