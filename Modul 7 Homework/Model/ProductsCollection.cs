using Modul_7_Homework.Model.ProducModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    
    internal class ProductsCollection<TProduct> where TProduct : Product
    {
        int position { get; set; } = -1;

        int tail { get; set; } = -1;

        int Capacity { get; set; } = 10;

        TProduct[] products;

        public ProductsCollection()
        {
            products = new TProduct[10];
        }

        public TProduct this[int index]
        {
            get
            {
                if (index < products.Length)
                    return products[index];
                else
                {
                    Console.WriteLine("Данный индекс вне диапозона списка");
                    return null;
                }
            }
        }

        public bool AddProduct(TProduct order)
        {
            ++tail;
            if (products.Length == tail)
            {
                TProduct[] temp = new TProduct[this.Capacity];
                products.CopyTo(temp, 0);
                products = new TProduct[this.Capacity + 10];
                temp.CopyTo(products, 0);
                Capacity += 10;
            }

            products[tail] = order;
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < tail; i++)
            {
                Console.WriteLine("Продукт номер: {0}\t Тип продукта: {1} ", products[i].Number, products[i].GetType().Name);
            }
            Console.WriteLine(new string('-', 50));
        }

        public object Current
        {
            get
            {
                return this.products[position];
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

        public ProductsCollection<TProduct> GetEnumerator()
        {
            return this;
        }

    }
}

