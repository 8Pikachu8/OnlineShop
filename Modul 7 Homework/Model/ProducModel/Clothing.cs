using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model.ProducModel
{
    public class Clothing : Product
    {
        protected string Size { get; set; }
        protected string Material { get; set; }
        protected string Gender { get; set; }

        public Clothing(string number, decimal price, string size, string material, string gender) : base(number)
        {
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
