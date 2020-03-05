using System;
using System.Collections.Generic;
using System.Text;

namespace Masha
{
    class Person : Animal
    {
        public string HairColor { get; set; }
        public string Race { get; }
        public Person() { }
        public Person(string name, double age, double height, double weight, string hairColor, string race)
            : base(name, age, height, weight)
        {
            HairColor = hairColor;
            Race = race;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Hair Color: " + HairColor);
            Console.WriteLine("Race:" + Race);
            Console.WriteLine("");
        }
    }
}
