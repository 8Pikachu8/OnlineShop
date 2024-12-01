using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    class Product
    {
        public string Number { get; set; }
        public decimal Price { get; set; }
    }


    class ProductsClollection
    {
        Product[] products;

        int count;

        public int Tail { get { return count; } set { count = value; } }

        public ProductsClollection()
        {
            products = new Product[5];
            Tail = -1;
        }

        public Product this[int index]
        {
            get
            {
                if (index < Tail)
                    return products[index];
                else
                    return null;
            }
            set
            {
                if (index == products.Length)
                {
                    products = ExtendedCollection(products);
                    products[Tail++] = value;
                }
            }
        }

        public bool AddProduct(Product prod)
        {
            if (products.Length == Tail + 1)
            {
                products = ExtendedCollection(products);
                products[++Tail] = prod;
                return true;
            }
            else
            {
                products[++Tail] = prod;
                return true;
            }
        }

        Product[] ExtendedCollection(Product[] prod)
        {
            int Capacitance = prod.Length + 25;
            Product[] extendedOrders = new Product[Capacitance];
            Array.Copy(prod, extendedOrders, prod.Length);
            return extendedOrders;
        }

        public void Display()
        {
            for (int i = 0; i < Tail + 1; i++)
            {
                Console.WriteLine("Заказ номер: {0}\t Стоимость: {1}", products[i].Number, products[i].Price);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
