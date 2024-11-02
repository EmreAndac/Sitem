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
    public class EducationConfig : BaseConfig<Education>
    {
        public override void Configure(EntityTypeBuilder<Education> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Okul).HasMaxLength(50);
            builder.Property(p => p.Bolum).HasMaxLength(50);
            builder.Property(p => p.Tarih).HasMaxLength(50);
            builder.Property(p => p.Metin).HasMaxLength(50);
        }
    }
}
