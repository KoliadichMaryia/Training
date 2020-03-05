using System;
using System.Collections.Generic;
using System.Text;

namespace Masha
{
    class Man : Person
    {
        double BeardLength { get; set; }
        public Man(string name, double age, double height, double weight, string hairColor, string race, double beardLength)
            : base(name, age, height, weight, hairColor, race)
        {
            BeardLength = beardLength;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Hair Color: " + HairColor);
            Console.WriteLine("Race:" + Race);
            Console.WriteLine("");
        }
    }
}
