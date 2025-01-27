

using Modul_7_Homework;
using Modul_7_Homework.Model;
using Modul_7_Homework.Model.ProducModel;


OrdersCollection<Delivery, Product> ordersCollection = CreateCollections.GetOrders();

foreach(Order<Delivery, Product> order in ordersCollection)
{
    Console.WriteLine(order.ToString());
    Console.WriteLine(order.Delivery == ordersCollection[10].Delivery);
    if (order.Products != null)
    {

        
        foreach(Product product in order.Products)
        {
            Console.WriteLine(product.ToString());
        }
    }
}

