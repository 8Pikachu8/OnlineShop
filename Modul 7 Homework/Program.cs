

using Modul_7_Homework.Model;

OrdersCollection<Delivery, Product> ordersCollection = new OrdersCollection<Delivery, Product>();

ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина"}, Number = 1});
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 2 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 3 });


ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 4 });

ordersCollection.Display();
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 5 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 6 });

ordersCollection.Display();
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 7 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 8 });
ordersCollection.AddOrder(new Order<Delivery, Product>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 9 });

ordersCollection.Display();