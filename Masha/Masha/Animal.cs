using System;
namespace Masha
{
    class Animal
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public Animal() { }
        public Animal(string name, double age, double height, double weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public void ShowInfo()
        {
            ShowProperties();
            Console.WriteLine("");
        }
        public void ShowProperties()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Weight: " + Weight);
        }
        public void Eat(double foodWeight)
        {
            Weight = Weight + foodWeight;
        }
        public void GoToToilet()
        {
            Weight = Weight - Weight * 0.05;
        }
        public void Sleep()
        {
            Weight = Weight - Weight * 0.01;
        }
        public void ChangeName()
        {
            Name = "Bob";
        }
        public void GetOlder()
        {
            Age = Age + 1;
            Height = Height + 3;
        }
        public void GoOnDiet()
        {
            Weight = Weight - Weight * 0.10;
        }
    }
}
