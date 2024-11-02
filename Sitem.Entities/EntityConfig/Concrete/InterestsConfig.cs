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
    public class InterestsConfig : BaseConfig<Interests>
    {
        public override void Configure(EntityTypeBuilder<Interests> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Metin).HasMaxLength(500);
        }
    }
}
