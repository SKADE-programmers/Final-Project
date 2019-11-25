using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Order_Lines
    {
        public int ID { get; set; }

        public decimal orlPrices { get; set; }

        public int orlQuantity { get; set; }

        public string orlOrderReqs { get; set; }

        public string orlNote { get; set; }

        public Inventorys inventorysID { get; set; }

        public Receipts receiptsID { get; set; }
    }
}
