using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    public abstract class Product
    {
        public string Number { get; set; }
        public decimal Price { get; set; }

        public abstract void DisplayInfo();

       
    }
}
