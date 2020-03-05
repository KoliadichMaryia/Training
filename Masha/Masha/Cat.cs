using System;
using System.Collections.Generic;
using System.Text;

namespace Masha
{
    class Cat : Animal
    {
        public double TailLength { get; set; }
        public Cat(string name, double age, double height, double weight, double tailLength)
            : base(name, age, height, weight)
        {
            TailLength = tailLength;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Tail length: " + TailLength);
            Console.WriteLine("");
        }
    }
}
