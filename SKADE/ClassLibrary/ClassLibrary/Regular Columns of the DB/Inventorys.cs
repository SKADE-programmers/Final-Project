using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Inventorys
    {
        public int ID { get; set; }

        public int invQuantity { get; set; }

        public int invSize { get; set; }

        public decimal invMeasures { get; set; }

        public Products productID { get; set; }
    }
}
