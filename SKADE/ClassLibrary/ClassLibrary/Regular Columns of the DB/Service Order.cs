using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Service_Order
    {
        public int ID { get; set; }

        public DateTime serordDateIn { get; set; }
        
        public DateTime? serordDateOut { get; set; }

        public string serordIssue { get; set; }

        public int receiptID { get; set; }

        public Services serviceID { get; set; }

        public Equipments equipID { get; set; }

        public Employees empID { get; set; }


    }
}
