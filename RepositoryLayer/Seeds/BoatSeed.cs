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
    public class BoatSeed : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.HasData(
                new Boat { Id = 1, Model = "Small" ,ColorId=1},
                new Boat { Id = 2, Model = "Medium", ColorId = 2 },
                new Boat { Id = 3, Model = "Large",ColorId = 3 });
        }
    }
}

