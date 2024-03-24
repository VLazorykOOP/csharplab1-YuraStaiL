// See https://aka.ms/new-console-template for more information
using System;
namespace Lab1
{
    public class Lab1Program
    {
        public static double findAvgModule(double x, double y)
        {
            return (Math.Abs(x) + Math.Abs(y)) / 2;
        }

        static double task1Var5()
        {
            Console.Write("Enter x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y = ");
            double y = double.Parse(Console.ReadLine());
            double avgModule = findAvgModule(x, y);
            Console.WriteLine("Середнє арифметичне модулів двох чисел: " + avgModule);

            return avgModule;
        }

        public static bool isEndOnSeven(int number)
        {
            return number % 10 == 7;
        }

        public static bool task2Var5()
        {
            Console.Write("Enter integer number = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Чи закінчується на 7: " + isEndOnSeven(x));

            return isEndOnSeven(x);
        }

        public static string isPointIncluded(float x, float y)
        {
            if (x > 3 && x < 7 && y > 3 && y < 7) return "Так";
            else if (x < 3 || x > 7 || y < 3 || y > 7) return "Ні";
            else return "На межi";
        }

        public static string task3Var5()
        {
            Console.Write("Enter x = ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter y = ");
            float y = float.Parse(Console.ReadLine());
            x = Math.Abs(x);
            y = Math.Abs(y);
            string isInclude = isPointIncluded(x, y);
            Console.WriteLine("Дана точка на площинi з координатами: " + isInclude);

            return isInclude;
        }

        public static string getFullCardName(int suit, int card)
        {
            string suitName = suit switch
            {
                1 => "жир",
                2 => "вино",
                3 => "дзвінка",
                4 => "чирва",
                _ => "",
            };

            string cardName = card switch
            {
                6 => "шістка",
                7 => "сімка",
                8 => "вісімка",
                9 => "дев'ятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => "",
            };

            return cardName + " " + suitName;
        }

        public static string task4Var5()
        {
            Console.Write("Enter suit (1...4) = ");
            int suit = int.Parse(Console.ReadLine());
            Console.Write("Enter number (6...14) = ");
            int number = int.Parse(Console.ReadLine());
            string fullName = getFullCardName(suit, number);
            Console.WriteLine("Result: " + fullName);

            return fullName;
        }

        public static double task5Var5()
        {
            Console.Write("Enter real number x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter real number y = ");
            double y = double.Parse(Console.ReadLine());
            double sum = x + y;
            Console.WriteLine("Sum: " + sum);

            return sum;
        }

        public static double task6Var5()
        {
            Console.Write("Enter integer n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter integer m = ");
            int m = int.Parse(Console.ReadLine());

            double result = (n + m) * (((n + 1) / (m + 1)) + (5 / m));
            Console.WriteLine("Result: " + result);

            return result;
        }


        public static void Main()
        {
            Console.WriteLine("student: Faryna Yurii 341b");
            Console.WriteLine("Task 1");
            task1Var5();
            Console.WriteLine("Task 2");
            task2Var5();
            Console.WriteLine("Task 3");
            task3Var5();
            Console.WriteLine("Task 4");
            task4Var5();
            Console.WriteLine("Task 5");
            task5Var5();
            Console.WriteLine("Task 6");
            task6Var5();
        }
    }
}