using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Sales
    {
        public int Id { get; set; }
        public DateTime Date { get; set;}
        public Customers customer { get; set; }
        public Products product { get; set; }
        public Stores store { get; set; }



    }
}
