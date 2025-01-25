using System;
using System.Collections;
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
        int position { get; set; } = -1;

        int tail { get; set; } = -1;

        public int Capacity { get; set; } = 10;

        Order<TDelivery, TNumber>[] orders;

        public OrdersCollection()
        {
            orders = new Order<TDelivery, TNumber>[10];
        }

        public Order<TDelivery, TNumber> this[int index]
        {
            get
            {
                if (index < orders.Length)
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
            ++tail;
            if(orders.Length  == tail)
            {
                Order<TDelivery, TNumber>[] temp = new Order<TDelivery, TNumber>[this.Capacity];
                orders.CopyTo(temp, 0);
                orders = new Order<TDelivery, TNumber>[this.Capacity + 10];
                temp.CopyTo(orders, 0);
                Capacity += 10;
            }

            orders[tail] = order;
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < tail; i++)
            {
                Console.WriteLine("Заказ номер: {0}\t Тип доставки: {1} Емкость: {2}", orders[i].Number, orders[i].Delivery.GetType().Name, this.Capacity);
            }
            Console.WriteLine(new string('-', 50));
        }

        public object Current
        {
            get
            {
                return this.orders[position];
            }
        }

        public bool MoveNext()
        {
            if (this.position == this.tail)
            {
                Reset();
                return false;
            }
            ++this.position;
            return true;
        }

        public void Reset()
        {
            this.position = -1;
        }

        public OrdersCollection<TDelivery, TNumber> GetEnumerator()
        {
            return this;
        }

        
    }
}
