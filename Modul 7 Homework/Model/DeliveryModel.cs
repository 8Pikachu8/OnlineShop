using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    abstract class Delivery
    {
        public string Address {  get; set; }
        public decimal Price {  get; set; }
    }

    class HomeDelivery : Delivery
    {
        string phone;// телефон курьера
        string phoneUser;// телефон пользователя
        DateTime DeliveryTime;
    }

    class PickPointDelivery : Delivery
    {
        string phone;// телефон пункта выдачи
        string phoneUser;// телефон пользователя
        DateTime DeliveryTime;
    }

    class ShopDelivery : Delivery
    {
        string phone;// телефон магазина
        DateTime DeliveryTime;
    }
}
