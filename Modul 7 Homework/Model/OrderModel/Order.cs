using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    class Order<TDelivery,
    TProduct> where TDelivery : Delivery
        where TProduct : Product
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public ProductsClollection<TProduct> Product;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }
}
