using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirveli ricxbi: ");

            double number1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Meore ricxbi: ");

            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            bool isEven;

            if(sum % 2 == 0)
            {
                isEven = true;
                Console.WriteLine($"{sum} is even -> {isEven}");
            }
            else
            {
                isEven = false;
                Console.WriteLine($"{sum} is even -> {isEven}");
            }

        }
    }
}
