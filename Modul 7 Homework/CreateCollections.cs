using Modul_7_Homework.Model.ProducModel;
using Modul_7_Homework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework
{
    internal class CreateCollections
    {

        public static ProductsCollection<Product> GetProducts()
        {

            ProductsCollection<Product> productsClollection = new ProductsCollection<Product>();
            productsClollection.AddProduct(new Jewelry("1", 2500, "Серебро", "Фианит") as Product);
            productsClollection.AddProduct(new Jewelry("2", 150000, "Золото", "Брилиант"));
            productsClollection.AddProduct(new Clothing("3", 150000, "L", "Хлопок", "Муж"));
            return productsClollection;
        }

        public static OrdersCollection<Delivery, Product> GetOrders()
        {
            OrdersCollection<Delivery, Product> ordersCollection = new OrdersCollection<Delivery, Product>();

            ordersCollection.AddOrder(new Order<Delivery, Product>(1, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(2, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(3, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));


            ordersCollection.AddOrder(new Order<Delivery, Product>(4, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));

            //ordersCollection.Display();
            ordersCollection.AddOrder(new Order<Delivery, Product>(5, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(6, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));

            //ordersCollection.Display();
            ordersCollection.AddOrder(new Order<Delivery, Product>(7, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(8, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(9, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(10, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(11, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(12, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(13, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(14, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина")));
            ordersCollection.AddOrder(new Order<Delivery, Product>(15, new ShopDelivery("г. Самара ул. Пушкина д. Колотушкина"), GetProducts()));


            return ordersCollection;
        }
    }
}
