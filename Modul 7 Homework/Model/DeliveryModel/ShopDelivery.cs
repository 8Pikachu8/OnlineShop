using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    class ShopDelivery : Delivery
    {
        string phone;// телефон магазина
        DateTime DeliveryTime;

        public ShopDelivery(string adr) : base(adr)
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is ShopDelivery delivery &&
                   Address == delivery.Address &&
                   Price == delivery.Price &&
                   phone == delivery.phone &&
                   DeliveryTime == delivery.DeliveryTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Address, Price, phone, DeliveryTime);
        }

        public static bool operator ==(ShopDelivery t, ShopDelivery q)
        {
            return Equals(t, q);
        }

        public static bool operator !=(ShopDelivery t, ShopDelivery q)
        {
            return !Equals(t, q);
        }
    }
}
