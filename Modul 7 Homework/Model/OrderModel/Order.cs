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

        TDelivery _delivery;
        public TDelivery Delivery { get => _delivery; }

        int _number;

        public int Number { get => _number; }

        string Description;

        ProductsCollection<TProduct> _products;

        public ProductsCollection<TProduct> Products { get => _products; }

        public Order()
        {

        }

        public Order(int n, TDelivery d)
        {
            _number = n;
            _delivery = d;

        }

        public Order(int n, TDelivery d, ProductsCollection<TProduct> P)
        {
            _number = n;

            _delivery = d;
            _products = P;
        }

        public Order(int n, string d, TDelivery delivery, ProductsCollection<TProduct> pColl)
        {
            _number = n;
            Description = d;
            _products = pColl;
            _delivery = delivery;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public override string ToString()
        {
            return string.Format("Заказ номер: {0}\t Тип доставки: {1} \t Комментарий: {2}", this.Number, this.Delivery.GetType().Name, Description);
        }
    }
}
