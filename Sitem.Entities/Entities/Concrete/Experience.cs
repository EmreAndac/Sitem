using Sitem.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitem.Entities.Entities.Concrete
{
    public class Experience: BaseEntity
    {
        public string Baslik { get; set; }
        public string Bolum { get; set; }
        public string Metin { get; set; }
        public string DateBtw { get; set; }
    }
}
