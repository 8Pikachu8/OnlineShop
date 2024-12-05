using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    abstract class Delivery
    {
        public string Address { get; set; }
        public decimal Price { get; set; }
    }
}
