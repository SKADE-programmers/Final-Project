using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Regular_Columns_of_the_DB
{
    class On_Orders
    {
        public int ID { get; set; }

        public int ordInvoiceNums { get; set; }

        public DateTime onordArriveDates { get; set; }


        public int onordNumInOrders { get; set; }

        public decimal onordPrices { get; set; }

        public Inventorys inventorysID { get; set; }

        public Product_Orders prodorderID { get; set; }




    }
}
