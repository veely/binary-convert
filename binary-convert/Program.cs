/* Simple 2-byte Binary Converter
 * Author: Vincent Ly
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("VINCENT'S BINARY CALCULATOR");
                Console.WriteLine("1. Convert binary to integer");
                Console.WriteLine("2. Convert integer to binary (COMING SOON!)");
                Console.WriteLine("3. Exit\n");
                Console.Write("Enter your selection followed by the <Enter> key: ");
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        string input;
                        int result;
                        Console.Write("Enter a 2-byte binary value to convert: ");
                        input = Console.ReadLine();

                        // Check if user input is too big before converting
                        if (input.Length <= 16)
                        {

                            // Calls a mathod to check if user input is a valid binary value
                            if (CheckValue.IsBin(input))
                            {
                                // Converts binary to integer
                                result = NumberConvert.BinToInt(input);
                                Console.WriteLine("The integer value of " + input + " is " + result + ".");
                            }
                            else
                                Console.WriteLine("That is not a binary value!");
                        }
                        else
                            Console.WriteLine("Error: You must enter a 2-byte (maximum 16 bits) binary value!");
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("This feature is currently unavailable!");
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid selection!  Please try again.");
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
