using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    class OrdersCollection<TDelivery, TNumber> where TDelivery : Delivery
    {

        Order<TDelivery, TNumber>[] orders;

        int count;

        public int Tail { get { return count; } set { count = value; } }

        public OrdersCollection()
        {
            orders = new Order<TDelivery, TNumber>[5]; 
            Tail = -1;
        }

        public Order<TDelivery, TNumber> this[int index]
        {
            get
            {
                if (index < Tail)
                    return orders[index];
                else
                    return null;
            }
            set
            {
                if (index == orders.Length)
                {
                    orders = ExtendedCollection(orders);
                    orders[Tail++] = value;
                }
            }
        }

        public bool AddOrder(Order<TDelivery, TNumber> order)
        {
            if (orders.Length == Tail+1)
            {
                orders = ExtendedCollection(orders);
                orders[++Tail] = order;
                return true;
            }
            else
            {
                orders[++Tail] = order;
                return true;
            }
        }

        Order<TDelivery, TNumber>[] ExtendedCollection(Order<TDelivery, TNumber>[] ord)
        {
            int Capacitance = ord.Length + 25;
            Order<TDelivery, TNumber>[] extendedOrders = new Order<TDelivery, TNumber>[Capacitance];
            Array.Copy(ord, extendedOrders, ord.Length);
            return extendedOrders;
        }

        public void Display()
        {
            for (int i = 0; i < Tail+1; i++)
            {
                Console.WriteLine("Заказ номер: {0}\t Тип доставки: {1} Емкость: {2}", orders[i].Number, orders[i].Delivery.GetType().Name, orders.Length);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
