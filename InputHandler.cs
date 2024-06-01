using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class InputHandler
    {
        public string GetMainMenuChoice()
        {
            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1 - Göra en beräkning");
                Console.WriteLine("2 - Se historik");
                Console.WriteLine("3 - Avsluta programmet");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                        Console.Clear();
                        return choice;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
        }

        public string GetOperation()
        {
            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("Välj ett räknesätt:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraktion");
                Console.WriteLine("3 - Multiplikation");
                Console.WriteLine("4 - Division");
                var operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        Console.Clear(); 
                        return operation;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
        }

        public (double, double) GetNumbers()
        {
            double num1, num2;

            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("Mata in första talet:");
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                Console.WriteLine("Ogiltigt tal. Försök igen.");
            }

            while (true)
            {
                Console.Clear(); 
                Console.WriteLine("Mata in andra talet:");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                Console.WriteLine("Ogiltigt tal. Försök igen.");
            }

            Console.Clear(); 
            return (num1, num2);
        }
    }
}
