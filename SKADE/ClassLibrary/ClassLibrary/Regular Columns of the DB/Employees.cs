using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //public object Position()
    //{
      //  return ashset();
    //}

    class Employees
    {
        public int ID { get; set;  }

        public string empFirstName { get; set; }

        public string empLastName { get; set;  }

        public ICollection<Positions> post { get; set; }

        public Positions postID { get; set; }
    }
}
