using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    class OrdersCollection<TDelivery, TNumber> where TDelivery : Delivery
        where TNumber : Product
    {
        List<Order<TDelivery, TNumber>> orders;

        public OrdersCollection()
        {
            orders = new List<Order<TDelivery, TNumber>>();
        }


        public Order<TDelivery, TNumber> this[int index]
        {
            get
            {
                if (index < orders.Count)
                    return orders[index];
                else
                {
                    Console.WriteLine("Данный индекс вне диапозона списка");
                    return null;
                }
            }
        }

        public bool AddOrder(Order<TDelivery, TNumber> order)
        {
            orders?.Add(order);
            return true;
        }


        public void Display()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine("Заказ номер: {0}\t Тип доставки: {1} Емкость: {2}", orders[i].Number, orders[i].Delivery.GetType().Name, orders.Capacity);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
