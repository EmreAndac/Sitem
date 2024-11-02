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
    public class SkillsConfig : BaseConfig<Skills>
    {
        public override void Configure(EntityTypeBuilder<Skills> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.WorkFlow).HasMaxLength(50);
        }
    }
}
