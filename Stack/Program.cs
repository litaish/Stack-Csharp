using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void fillStack(Stack<string> stack)
        {
            Console.WriteLine("Enter amount of elements to add: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter element {0}", i + 1);
                string input = Console.ReadLine();
                stack.Push(input);
            }
        }
        static void displayStack(Stack<string> stack)
        {
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
        static void stackToArray(Stack<string> stack)
        {
            int stackCount = stack.Count; //saves count of stack in int, to make a 1d array
            string[] arr = new string[stackCount];
            Console.WriteLine("Converting stack to array..");
            Console.WriteLine("Enter index to start copying from: ");
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                stack.CopyTo(arr, index);
                Console.WriteLine("Displaying array: ");
                foreach (string item in arr)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Index is out of range!!");
            }
        }
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            Console.WriteLine("MENU");
            Console.WriteLine("=====================");
            int choice = 0;
            do
            {
                Console.WriteLine("Choose your action: \n\n[1] Add elements to Stack\n[2] Display Stack\n[3] Convert stack to array and display array\n[4] Clear stack\n[6] Exit");
                Console.WriteLine("");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                switch (userInput)
                {
                    case 1:
                        fillStack(myStack);
                        break;
                    case 2:
                        displayStack(myStack);
                        break;
                    case 3:
                        stackToArray(myStack);
                        break;
                    case 4:
                        myStack.Clear();
                        Console.WriteLine("Stack cleared.");
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Theres no such choice");
                        Console.ReadLine();
                        break;
                }
            } while (choice != 6);
        }
    }
}
