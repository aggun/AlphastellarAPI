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
    //Proje ilk oluşturulurken test için oluşturulan fake datalar ilk migration ile SQL'e yazılır.
    internal class ColorSeed : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color { Id = 1, ColorName = "Black"},
                new Color { Id = 2, ColorName = "Blue" },
                new Color { Id = 3, ColorName = "White" },
                new Color { Id = 4, ColorName = "Red" });
        }
    }
}
