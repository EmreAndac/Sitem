using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sitem.Entities.Entities.Concrete;
using Sitem.Entities.EntityConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitem.Entities.EntityConfig.Concrete
{
    public class AboutConfig:BaseConfig<About>
    {
        public override void Configure(EntityTypeBuilder<About> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.AdSoyad).HasMaxLength(25);
            builder.Property(p => p.Adres).HasMaxLength(100);
            builder.Property(p => p.Phone).HasMaxLength(12);
            builder.Property(p => p.Email).HasMaxLength(25);
            builder.Property(p => p.Metin).HasMaxLength(500);
            builder.Property(p => p.In).HasMaxLength(25);
            builder.Property(p => p.Git).HasMaxLength(25);
            builder.Property(p => p.Facebook).HasMaxLength(25);
            builder.Property(p => p.Twitter).HasMaxLength(25);
        }
    }
}
