using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    abstract class Delivery
    {
        string _address;

        public string Address { get; }
        protected decimal Price { get; set; }

        public Delivery(string ard)
        {
            _address = ard;
        }
    }
}
