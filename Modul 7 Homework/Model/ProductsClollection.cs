using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    
    internal class ProductsClollection<TProduct> where TProduct : Product
    {
        List<TProduct> products;

        public ProductsClollection()
        {
            products = new List<TProduct>();
        }


        public TProduct this[int index]
        {
            get
            {
                if (index < products.Count)
                    return products[index];
                else
                {
                    Console.WriteLine("Данный индекс вне диапозона списка");
                    return null;
                }
            }
        }

        public bool AddOrder(TProduct prod)
        {
            products?.Add(prod);
            return true;
        }



        public void Display()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("Заказ номер: {0}\t Стоимость: {1}", products[i].Number, products[i].Price);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}

