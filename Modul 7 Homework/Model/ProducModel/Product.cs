using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    public abstract class Product
    {
        string _number;
        decimal _price;

        public string Number { get => _number; }
        protected decimal Price { get; set; }

        public abstract void DisplayInfo();

        public Product(string num)
        {
            _number = num;
        }

       
    }
}
