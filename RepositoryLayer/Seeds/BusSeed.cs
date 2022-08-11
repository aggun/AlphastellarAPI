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
    internal class BusSeed : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasData(
                new Bus { Id = 1, Model = "20 Person", ColorId = 1 },
                new Bus { Id = 2, Model = "40 Person", ColorId = 2 },
                new Bus { Id = 3, Model = "50 Person", ColorId = 3 });
        }
    }
}