

using Modul_7_Homework.Model;

OrdersCollection<Delivery, int> ordersCollection = new OrdersCollection<Delivery, int>();

ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина"}, Number = 1});
ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 2 });
ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 3 });


ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 4 });

ordersCollection.Display();
ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 5 });
ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 6 });

ordersCollection.Display();
ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new ShopDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 7 });
ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new PickPointDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 8 });
ordersCollection.AddOrder(new Order<Delivery, int>() { Delivery = new HomeDelivery() { Address = "г. Самара ул. Пушкина д. Колотушкина" }, Number = 9 });

ordersCollection.Display();