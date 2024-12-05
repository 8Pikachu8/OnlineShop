using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    class Order<TDelivery,
    TNumber> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public TNumber Number;

        public string Description;

        public ProductsClollection[] Product;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }
}
