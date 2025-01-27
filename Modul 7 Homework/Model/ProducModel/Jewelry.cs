using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul_7_Homework.Model
{
    internal class Jewelry : Product
    {

        public string Material { get; set; }

        public string Gemstone { get; set; }

        public Jewelry(string number, decimal price, string material, string gemstone) : base(number)
           
        {
            Material = material;
            Gemstone = gemstone;
            this.Price = price;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Материал: {Material}, Драгоценный камень: {Gemstone}");
        }

        public override string ToString()
        {
            return $"Материал: {Material}, Драгоценный камень: {Gemstone}";
        }
    }
}
