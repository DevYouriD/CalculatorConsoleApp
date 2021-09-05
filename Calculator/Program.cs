using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            calculate.choiceMenu();
        }
    }
}


/*
 string key = Console.ReadKey().Key.ToString();

                switch (key)
                {
                    case "D1":
                        Add();
                        break;
                    case "D2":
                        Subtract();
                        break;
                    case "D3":
                        Multiply();
                        break;
                    case "D4":
                        Divide();
                        break;
                }
            }
        }
        public void Add()
        {
            Console.WriteLine("First number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int add = Calculate.Add(userInput1, userInput2);
            Console.WriteLine();
        }
*/

/* 
 string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Option Menu");
                Console.WriteLine();
                Console.WriteLine("To add press 1");
                Console.WriteLine("To subtract press 2");
                Console.WriteLine("To multiply: press 3");
                Console.WriteLine("To divide: press 4");
                Console.WriteLine();
                Console.WriteLine("To quit press q");

                switch (choice)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Subtract();
                        break;
                    case "3":
                        Multiply();
                        break;
                    case "4":
                        Divide();
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Druk op een knop");
                Console.ReadKey();
            }
        }
            public void Add()
            {
                Console.WriteLine("First number: ");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number: ");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                int add = Calculate.Add(userInput1, userInput2);
            }
            public void Subtract()
            {
                Console.WriteLine("First number: ");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number: ");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                int subtract = Calculate.Subtract(userInput1, userInput2);
            }
            public void Multiply()
            {
                Console.WriteLine("First number: ");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number: ");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                int multiply = Calculate.Multiply(userInput1, userInput2);
            }
            public void Divide()
            {
                Console.WriteLine("First number: ");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number: ");
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                int divide = Calculate.Divide(userInput1, userInput2);
            }
     */
