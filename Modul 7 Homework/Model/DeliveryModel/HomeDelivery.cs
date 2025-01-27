using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    class HomeDelivery : Delivery
    {
        string phone;// телефон курьера
        string phoneUser;// телефон пользователя
        DateTime DeliveryTime;
        public HomeDelivery(string adr) : base(adr)
        {
            

        }

        public override bool Equals(object? obj)
        {
            return obj is HomeDelivery delivery &&
                   Address == delivery.Address &&
                   Price == delivery.Price &&
                   phone == delivery.phone &&
                   phoneUser == delivery.phoneUser &&
                   DeliveryTime == delivery.DeliveryTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Address, Price, phone, phoneUser, DeliveryTime);
        }

        public static bool operator ==(HomeDelivery t, HomeDelivery q)
        {
            return Equals(t, q);
        }

        public static bool operator !=(HomeDelivery t, HomeDelivery q)
        {
            return !Equals(t, q);
        }
    }

}
