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

        public ProductsClollection<TProduct> Products;

        public Order()
        {

        }

        public Order(int n, string d, TDelivery delivery, ProductsClollection<TProduct> pColl)
        {
            Number = n;
            Description = d;
            Products = pColl;
            Delivery = delivery;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public override string ToString()
        {
            return string.Format("Заказ номер: {0}\t Тип доставки: {1} ", this.Number, this.Delivery.GetType().Name);
        }
    }
}
