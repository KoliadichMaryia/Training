using System;
using System.Collections.Generic;
using System.Text;

namespace Masha
{
    class Mouse : Animal
    {
        public double TailLength { get; set; }
        public Mouse(string name, double age, double height, double weight, double tailLength)
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
