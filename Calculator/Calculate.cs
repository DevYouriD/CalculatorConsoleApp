using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        string choice = " ";

        public void choiceMenu()
        {
            while (choice.ToLower() != "")
            {
                Console.WriteLine();
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine();
                Console.WriteLine("Add      (+) - Enter 1 or +");
                Console.WriteLine("Subtract (-) - Enter 2 or -");
                Console.WriteLine("Multiply (*) - Enter 3 or *");
                Console.WriteLine("Devide   (/) - Enter 4 or /");
                Console.WriteLine();
                Console.WriteLine("Press Enter to exit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Add();
                        Console.WriteLine();
                        break;
                    case "+":
                        Add();
                        Console.WriteLine();
                        break;
                    case "2":
                        Subtract();
                        Console.WriteLine();
                        break;
                    case "-":
                        Subtract();
                        Console.WriteLine();
                        break;
                    case "3":
                        Multiply();
                        Console.WriteLine();
                        break;
                    case "*":
                        Multiply();
                        Console.WriteLine();
                        break;
                    case "4":
                        Divide();
                        Console.WriteLine();
                        break;
                    case "/":
                        Divide();
                        Console.WriteLine();
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
            Console.WriteLine();
            int add = Calculate.Add(userInput1, userInput2);
            Console.WriteLine();
            Console.WriteLine("Result: " + userInput1 +" + "+ userInput2 +" = "+ add);
        }
        public void Subtract()
        {
            Console.WriteLine("First number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int subtract = Calculate.Subtract(userInput1, userInput2);
            Console.WriteLine();
            Console.WriteLine("Result: " + userInput1 + " - " + userInput2 + " = " + subtract);
        }
        public void Multiply()
        {
            Console.WriteLine("First number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int multiply = Calculate.Multiply(userInput1, userInput2);
            Console.WriteLine();
            Console.WriteLine("Result: " + userInput1 + " x " + userInput2 + " = " + multiply);
        }
        public void Divide()
        {
            Console.WriteLine("First number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int divide = Calculate.Divide(userInput1, userInput2);
            Console.WriteLine();
            Console.WriteLine("Result: " + userInput1 + " / " + userInput2 + " = " + divide);
        }
        public static int Add(int firstNumber, int secondNumber)
        {
            return (firstNumber + secondNumber);
        }
        public static int Subtract(int firstNumber, int secondNumber)
        {
            return (firstNumber - secondNumber);
        }
        public static int Multiply(int firstNumber, int secondNumber)
        {
            return (firstNumber * secondNumber);
        }
        public static int Divide(int firstNumber, int secondNumber)
        {
            return (firstNumber / secondNumber);
        }
    }
}

