using System;
using System.Collections.Generic;
using System.Text;

namespace Masha
{
    class Woman : Person
    {
        double BreastSize { get; set; }
        public Woman(string name, double age, double height, double weight, string hairColor, string race, double breastSize)
            : base(name, age, height, weight, hairColor, race)
        {
            BreastSize = breastSize;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Hair Color: " + HairColor);
            Console.WriteLine("Race:" + Race);
            Console.WriteLine("Breast Size" + BreastSize);
            Console.WriteLine("");
        }
    }
}
