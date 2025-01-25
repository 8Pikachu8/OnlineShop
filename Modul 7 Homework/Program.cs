

using Modul_7_Homework.Model;
using Modul_7_Homework.Model.ProducModel;


ProductsClollection<Product> productsClollection = new ProductsClollection<Product>();
productsClollection.AddProduct(new Jewelry("1", 2500, "Серебро", "Фианит"));
productsClollection.AddProduct(new Jewelry("2", 150000, "Золото", "Брилиант"));
productsClollection.AddProduct(new Clothing("3", 150000,"L","Хлопок","Муж"));

OrdersCollection<Delivery, Product> ordersCollection = new OrdersCollection<Delivery, Product>();

ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина"}, Number = 1});
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 2 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 3 });


ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 4 });

//ordersCollection.Display();
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 5 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 6 });

//ordersCollection.Display();
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 7 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 8 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 9 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 10 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 11 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 12 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 13 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 14 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 15, Products = productsClollection });


foreach(Order<Delivery, Product> order in ordersCollection)
{
    Console.WriteLine(order.ToString());
    if(order.Products != null)
    {
        foreach(Product product in order.Products)
        {
            Console.WriteLine(product.ToString());
        }
    }
}

