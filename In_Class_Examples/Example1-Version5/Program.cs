using System;

namespace Example1_Version5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello! Welcome to my application.  What is your name? >>");

            string name = Console.ReadLine();

            //Console.WriteLine(name + ", what is your total monthly income? >>");
            Console.WriteLine($"{name}, what is your total monthly income? >>");
            string totalMonthlyIncomeAsString = Console.ReadLine();
            double income = Convert.ToDouble(totalMonthlyIncomeAsString);

            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine($"{name}, what is your total monthly expenses? >>");
            double expenses = Convert.ToDouble(Console.ReadLine());

            double amountSaved = income - expenses;

            Console.WriteLine($"{name}, you saved {amountSaved.ToString("C3")} this month!");
            //Console.Beep(5000, 500);
        }
    }
}
