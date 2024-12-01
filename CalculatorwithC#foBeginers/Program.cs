using System;
using System.Text;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Insert the first number:");
            string firstInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);

            Console.WriteLine("Insert the second number:");
            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);

            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Sum of numbers = {sum}");
        }
    }
}
