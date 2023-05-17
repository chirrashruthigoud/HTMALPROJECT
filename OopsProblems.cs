using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlProjectProgram
{
    internal class UniqueElementInArray
    {
        public void PrintElement()
        {
            int[] arr = { 1, 2, 3, 3, 4, 5, 5 };
            Console.WriteLine("The unique elements in the array are:");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                    }
                }
                if (!isDuplicate)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
    internal class SumofAllDigits
    {
        public void sumofdigits()
        {
            Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }

    public class RowofMatrix
    {
        public void MatrixRow()
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
              };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    rowSum += matrix[i, j];
                }
                Console.WriteLine("Sum of row " + i + ": " + rowSum);
            }
        }

    }

    public class ReverseWord
    {
        public void PrintReverse()
        {
            Console.WriteLine("Enter the string to reverse : ");
            string name = Console.ReadLine();
            string type = "";
            int length = name.Length;
            int i = 0;
            for (i = length - 1; i >= 0; i--)
            {
                type = type + name[i];
            }
            Console.WriteLine($"The Reverse of String is :  {type}");
        }
    }

    internal class PrintStar
    {
        public void PrintPattern()
        {
            int rows = 7;
            int columns = 7;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == columns)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }

    internal class PrintPattern
    {
        public void Pattern()
        {
            int rows = 8;

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }

    internal class MaxMinArray
    {
        public void Maxminarray()
        {
            int[] arr = { 10, 5, 20, 8, 7 };
            int n = arr.Length;

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        }
    }

    internal class DuplicateElement
    {
        public void elements()
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("The total number of duplicate elements in the array is: " + count);
        }

    }

    internal class Countsfrequency
    {
        public void Frequency()
        {
            // Create an array of integers
            int[] a = { 1, 2, 3, 4, 1, 2, 2, 3, 3, 3 };

            // Create a second array to store the frequency of each element
            int[] b = new int[a.Length];

            // Loop through each element in the array
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;

                // Compare the current element with every other element in the array
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        b[j] = -1; // Mark the second element as visited
                    }
                }

                // If the current element has not been visited, store its frequency
                if (b[i] != -1)
                {
                    b[i] = count;
                }
            }

            // Display the frequency of each element
            Console.WriteLine("Element    Frequency");
            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] != -1)
                {
                    Console.WriteLine(a[i] + "        " + b[i]);
                }
            }

            // Wait for user input to close the console
            Console.ReadLine();
        }
    }
}
