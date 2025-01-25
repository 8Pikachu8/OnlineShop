using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model.ProducModel
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }
        public string Gender { get; set; }

        public Clothing(string number, decimal price, string size, string material, string gender)
        {
            Number = number;
            Price = price;
            Size = size;
            Material = material;
            Gender = gender;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Размер: {Size}, Материал: {Material}, Пол: {Gender}");
        }

        public override string ToString()
        {
            return $"Размер: {Size}, Материал: {Material}, Пол: {Gender}";
        }
    }
}
