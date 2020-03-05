using System;
using System.Collections.Generic;
using System.Linq;

namespace Masha
{
    class Program
    {
        static void Main(string[] arg)
        {
            //PlayWithCollection();
            //PlayWithList();
            PlayWithClasses();
        }
        public static void PlayWithClasses()
        {
            Animal catTom = new Animal("Tom", 3, 20, 3.5);
            catTom.ShowInfo();
            Animal mouseJerry = new Animal("Jerry", 2, 5, 0.1);
            mouseJerry.ShowInfo();
            mouseJerry.GetOlder();
            mouseJerry.ShowInfo();
            mouseJerry.GoOnDiet();
            mouseJerry.ShowInfo();

            catTom.Eat(0.05);
            catTom.ShowInfo();
            catTom.Eat(0.15);
            catTom.ShowInfo();
            catTom.GoToToilet();
            catTom.ShowInfo();
            catTom.Sleep();
            catTom.ShowInfo();
            catTom.ChangeName();
            catTom.ShowInfo();

            Cat yukki = new Cat("Yukki", 0.5, 2.5, 25, 20);
            yukki.ShowInfo();
            Mouse rikky = new Mouse("Rikky", 0.2, 03, 5, 5);
            rikky.ShowInfo();
        }
        public static void PlayWithList()
        {
            int length = ReadInt();
            List<int> numbers = CreateAndShowList(length);
            int sum = Sum(numbers);
            double average = (double)sum / numbers.Count;
            int min = MinNumber(numbers);
            Console.Write("Sum = " + sum + "; average = " + average + "; min = " + min + "; ");
            ShowMaxTwoNumbers(numbers);
            Console.WriteLine("");
            int amountOdd = AmountOfOddNumbers(numbers);

            int amountEven = AmountOfEvenNumbers(numbers);
            int sumOdd = SumOfOddNumbers(numbers);
            int sumEven = SumOfEvenNumbers(numbers);
            Console.WriteLine("Amount (sum) of odd numbers = " + amountOdd + "(" + sumOdd + "); amount (sum) of even numbers = " + amountEven + "(" + sumEven + ")");
            int amountPrimeNumbers = AmountOfPrimeNumbers(numbers);
            int sumPrimeNumbers = SumOfPrimeNumbers(numbers);
            Console.WriteLine("Prime numbers: amount = " + amountPrimeNumbers + "; sum = " + sumPrimeNumbers);
            int maxSumOfTwoNumbers = MaxSumOfTwoNumbers(numbers);
            Console.WriteLine("Maximal sum of two numbers = " + maxSumOfTwoNumbers);
            ShowNumbersDividedByItsIndex(numbers);
            Console.WriteLine("");
            int maxSumOfTwoOpositeNumbers = MaxSumOfTwoOpositeNumbers(numbers);
            Console.WriteLine("Maximal sum of two oposite numbers = " + maxSumOfTwoOpositeNumbers);
            ShowPolindromIndexes(numbers);
            ChangeOddAndEvenNumbers(numbers);
            MoveListLeft(numbers);
        }
        public static void PlayWithCollection()
        {
            //int length = Convert.ToInt32(arg[0]); Do NOT delete
            int length = ReadInt();
            int[] numbers = CreateAndShowArray(length);
            int sum = Sum(numbers);
            double average = (double)sum / numbers.Length;
            int min = MinNumber(numbers);
            Console.Write("Sum = " + sum + "; average = " + average + "; min = " + min + "; ");
            ShowMaxTwoNumbers(numbers);
            Console.WriteLine("");
            int amountOdd = AmountOfOddNumbers(numbers);
            int amountEven = AmountOfEvenNumbers(numbers);
            int sumOdd = SumOfOddNumbers(numbers);
            int sumEven = SumOfEvenNumbers(numbers);
            Console.WriteLine("Amount (sum) of odd numbers = " + amountOdd + "(" + sumOdd + "); amount (sum) of even numbers = " + amountEven + "(" + sumEven + ")");
            //int max = MaxNumber(numbers);
            int amountPrimeNumbers = AmountOfPrimeNumbers(numbers);
            int sumPrimeNumbers = SumOfPrimeNumbers(numbers);
            Console.WriteLine("Prime numbers: amount = " + amountPrimeNumbers + "; sum = " + sumPrimeNumbers);
            int maxSumOfTwoNumbers = MaxSumOfTwoNumbers(numbers);
            Console.WriteLine("Maximal sum of two numbers = " + maxSumOfTwoNumbers);
            ShowNumbersDividedByItsIndex(numbers);
            Console.WriteLine("");
            int maxSumOfTwoOpositeNumbers = MaxSumOfTwoOpositeNumbers(numbers);
            Console.WriteLine("Maximal sum of two oposite numbers = " + maxSumOfTwoOpositeNumbers);
            ShowPolindromIndexes(numbers);
            ChangeOddAndEvenNumbers(numbers);
            MoveArrayLeft(numbers);
        }
        public static int[] CreateAndShowArray(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = new Random().Next(1, 1000);
            }
            ShowArray(numbers, "Initial array");
            return numbers;
        }
        public static void ShowArray(int[] numbers, string description)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("- " + description);
        }
        public static List<int> CreateAndShowList(int length)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < length; i++)
            {
                numbers.Add(new Random().Next(1, 1000));
            }
            ShowList(numbers, "Initial list");
            return numbers;
        }
        public static void ShowList(List<int> numbers, string description)
        {
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("- " + description);
        }
        public static int Sum(List <int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
        public static int MinNumber(List <int> numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        public static int MaxSumOfTwoNumbers(List <int> numbers)
        {
            int max = numbers[0] + numbers[1];
            for (int i = 0; i < numbers.Count - 2; i++)
            {
                int sum = numbers[i + 1] + numbers[i + 2];
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
        public static void ShowMaxTwoNumbers(List <int> numbers)
        {
            int maxFirstNumber = numbers[0];
            int maxSecondNumber = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (maxFirstNumber < numbers[i])
                {
                    maxSecondNumber = maxFirstNumber;
                    maxFirstNumber = numbers[i];
                }
                else if (maxSecondNumber < numbers[i])
                {
                    maxSecondNumber = numbers[i];
                }
            }
            Console.Write("the 1st max = " + maxFirstNumber + ", the 2nd max = " + maxSecondNumber);
        }
        public static int AmountOfOddNumbers(List <int> numbers)
        {
            int amount = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    amount++;
                }
            }
            return amount;
        }
        public static int AmountOfEvenNumbers(List<int> numbers)
        {
            int amount = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    amount++;
                }
            }
            return amount;
        }
        public static int SumOfOddNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum = sum + number;
                }
            }
            return sum;
        }
        public static int SumOfEvenNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum = sum + number;
                }
            }
            return sum;
        }
        public static int AmountOfPrimeNumbers(List<int> numbers)
        {
            int amount = 0;
            foreach (int number in numbers)
            {
                if (CalculateIfProstoe(number))
                {
                    amount++;
                }
            }
            return amount;
        }
        public static int SumOfPrimeNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                if (CalculateIfProstoe(number))
                {
                    sum = sum + number;
                }
            }
            return sum;
        }
        public static void ShowNumbersDividedByItsIndex(List<int> numbers)
        {
            Console.Write("Numbers divided by its index = ");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % (i+1) == 0)
                {
                    Console.Write(numbers[i] + "(" + (i+1) + ") ");
                }
            }
        }
        public static int MaxSumOfTwoOpositeNumbers(List<int> numbers)
        {
            int max = numbers[0] + numbers[numbers.Count - 1];
            for (int i = 0; i < numbers.Count / 2 - 1; i++)
            {
                int sum = numbers[i + 1] + numbers[numbers.Count - i - 2];
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
        public static void ShowPolindromIndexes(List<int> numbers)
        {
            int polindromCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                string number = numbers[i].ToString();
                string reversedNumber = String.Concat(number.Reverse());
                if (number == reversedNumber)
                {
                    polindromCount++;
                    Console.Write(i + "(" + numbers[i] + ") ");
                }
            }
            if (polindromCount > 0)
            {
                Console.Write("- Indexes of polindroms");
            }
            else
            {
                Console.Write("There are no polindroms ");
            }
        }
        public static void ChangeOddAndEvenNumbers(List<int> numbers)
        {
            Console.WriteLine("");
            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                ChangeTwoNumbersPlaces(numbers, i, i + 1);
            }

            ShowList(numbers, "List with changed odd and even numbers");
        }
        public static void ChangeTwoNumbersPlaces(List<int> numbers, int firstIndex, int secondIndex)
        {
            int tempNumber = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = tempNumber;
        }
        public static void MoveListLeft(List <int> numbers)
        {
            int tempNumber = numbers[0];
            for (int i = 1; i <= numbers.Count - 1; i++)
            {
                numbers[i - 1] = numbers[i];
            }
            numbers[numbers.Count - 1] = tempNumber;
            ShowList(numbers, "List with elements moved left");
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
        public static int AmountOfOddNumbers(int[] numbers)
        {
            int amount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    amount++;
                }
            }
            return amount;
        }
        public static int AmountOfOddNumbers2(int[] numbers)
        {
            int amount = 0;
            int i = 0;
            for (;;)
            {
                if (numbers[i] % 2 != 0)
                {
                    amount++;
                }

                i = i + 1;
                if (i < numbers.Length)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return amount;
        }
        public static int AmountOfEvenNumbers(int[] numbers)
        {
            int amount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    amount++;
                }
            }
            return amount;
        }
        public static int SumOfOddNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sum = sum + numbers[i];
                }
            }
            return sum;
        }
        public static int SumOfEvenNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
            }
            return sum;
        }
        public static int MinNumber(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }
        public static int  MaxNumber(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        public static int AmountOfPrimeNumbers(int[] numbers)
        {
            int amount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (CalculateIfProstoe(numbers[i]))
                {
                    amount++;
                }
            }
            return amount;
        }
        public static int SumOfPrimeNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (CalculateIfProstoe(numbers[i]))
                {
                    sum = sum + numbers[i];
                }
            }
            return sum;
        }
        public static int MaxSumOfTwoNumbers(int[] numbers)
        {
            int max = numbers[0] + numbers[1];
            for (int i = 0; i < numbers.Length -2; i++)
            {
                int sum = numbers[i+1] + numbers[i+2];
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
        public static void ShowNumbersDividedByItsIndex(int[] numbers)
        {
            Console.Write("Numbers divided by its index = ");
            for (int i = 1; i <= numbers.Length; i++)
            {
                if (numbers[i-1] % i == 0)
                {
                    Console.Write(numbers[i-1] + "(" + i + ") ");
                }
            }
        }
        public static int MaxSumOfTwoOpositeNumbers(int[] numbers)
        {
            int max = numbers[0] + numbers[numbers.Length - 1];
            for (int i = 0; i < numbers.Length/2 - 1; i++)
            {
                int sum = numbers[i + 1] + numbers[numbers.Length - i - 2];
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
        public static void ShowMaxTwoNumbers(int[] numbers)
        {
            int maxFirstNumber = numbers[0];
            int maxSecondNumber = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (maxFirstNumber < numbers[i])
                {
                    maxSecondNumber = maxFirstNumber;
                    maxFirstNumber = numbers[i];
                }
                else if (maxSecondNumber < numbers[i])
                {
                    maxSecondNumber = numbers[i];
                }
            }
            Console.Write("the 1st max = " + maxFirstNumber + ", the 2nd max = " + maxSecondNumber);
        }
        public static void ShowPolindromIndexes(int[] numbers)
        {
            int polindromCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i].ToString();
                string reversedNumber = String.Concat(number.Reverse());
                if (number == reversedNumber)
                {
                    polindromCount++;
                    Console.Write(i + "(" + numbers[i] + ") ");
                }
            }
            if (polindromCount > 0)
            {
                Console.Write("- Indexes of polindroms");
            }
            else
            {
                Console.Write("There are no polindroms ");
            }
        }
        public static void ChangeOddAndEvenNumbers(int[] numbers)
        {
            Console.WriteLine("");
            for (int i = 0; i < numbers.Length-1; i+=2)
            {
                ChangeTwoNumbersPlaces(numbers, i, i+1);
            }

            ShowArray(numbers, "Array with changed odd and even numbers");
        }
        public static void ChangeTwoNumbersPlaces(int[] numbers, int firstIndex, int secondIndex)
        {
            int tempNumber = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = tempNumber;
        }
        public static void MoveArrayLeft(int[] numbers)
        {
            int tempNumber = numbers[0];
            for (int i = 1; i <= numbers.Length - 1; i++)
            {
                numbers[i-1] = numbers[i];
            }
            numbers[numbers.Length - 1] = tempNumber;
            ShowArray(numbers, "Array with elements moved left");
        }    
        public static void Negatiation()
        {
            int number = ReadInt();
            if (!(number >= 2 && number <= 7))
            {
                Console.Write("It's a cool number");
            }
            else
            {
                Console.Write("It's not a cool number");
            }
        }
        public static void BreakAndContinue()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("The end");
        }
        public static void ArraysAndLists()
        {
            //int[] ages = new int[4];
            //ages[0] = 18;
            //ages[1] = 47;
            //ages[2] = 11;
            //ages[3] = 32;

            List<int> ages = new List<int>();
            ages.Add(18);
            ages.Add(47);
            ages.Add(11);
            ages.Add(33);

            int sum = ages.ElementAt(3);
            Console.WriteLine(sum);
        }
        // Берём число. Если оно чётное - делим на 2, если нечётное - умножаем на 3 и добавляем 1. Делаем так пока не дойдём до 1.
        public static void Game()
        {
            int number;
            do
            {
                Console.Write("Type a positive number: ");
                string answer = Console.ReadLine();
                number = Convert.ToInt32(answer);
                if (number > 0)
                {
                    Playwithnumber(number);
                }
            }
            while (number > 0);
        }
        public static void Playwithnumber(int number)
        {
            while (number > 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
                Console.Write(number);
                if (number > 1)
                {
                    Console.Write(" -> ");
                }
            }

            Console.WriteLine(" ");
        }
        public static void WriteAllPrimes()
        {
            Console.WriteLine(2);
            for (int i = 3; i < 100; i++)
            {
                bool prostoe = CalculateIfProstoe(i);
                if (prostoe)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool CalculateIfProstoe(int i)
        {
            for (int delitel = 2; delitel < i; delitel ++)
            {
                if (i % delitel == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void AskAboutAge()
        {
            string question = "How old are you?";
            Console.WriteLine(question);

            string answer = Console.ReadLine();
            int age = Convert.ToInt32(answer);

            bool isThirty = age == 30;
            if (isThirty)
            {
                Console.WriteLine("You are 30 years old");
            }
            else
            {
                Console.WriteLine("You are not 30 years old");
            }
        }
        public static void TypesConverting()
        {
            int x = 11;
            int y = 3;
            double z = (double)x / y;
            Console.WriteLine(z);

            int ost = x % y;
            Console.WriteLine(ost);

            //string s1 = ost.ToString();
            //string s2 = "ost";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //char a = 'b';
            //Console.WriteLine(a);
            //Console.WriteLine((int)a);
        }
        public static void SeeingArea()
        {
            int x = 5;

            {
                int y = 2;
                x = 7;
            }

            x = 6;
            //y = 3;
        }
        public static int ReadInt()
        {
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            return number;
        }
    }
}
