using Sitem.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitem.Entities.Entities.Concrete
{
    public class About : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Metin { get; set; }
        public string? In { get; set; }
        public string? Git { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }

    }
}
