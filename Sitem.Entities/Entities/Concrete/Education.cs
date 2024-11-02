using Sitem.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitem.Entities.Entities.Concrete
{
    public class Education : BaseEntity
    {
        public string Okul { get; set; }
        public string Bolum { get; set; }
        public string Tarih { get; set; }
        public string? Metin { get; set; }

    }
}
