using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Receipts
    {
        public int ID { get; set; }

        public int ordNumbers { get; set; }

        public DateTime ordDate { get; set; }
        
        public Payments paymentID { get; set; }

        public Customers custID { get; set; }

        public Employees empID { get; set; }

    }
}
