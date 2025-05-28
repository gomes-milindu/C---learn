using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Question 01

            /* int num1 = 10;
             int num2 = 15;

             if (num1 == num2)
             {
                 Console.WriteLine("Numbers are Equal");
             }
             else
             {

                 Console.WriteLine("Not Equal");
             }

             // Question 02
             int sum = 0;
             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine("Enter Value: ");
                 int num3 = int.Parse(Console.ReadLine());
                 sum += num3;

             }
             Console.WriteLine("Sum: " + sum);
             int avg = sum/10;
             Console.WriteLine("Average = "+ avg);

             // Question 03

             for (int i = 1; i < 5; i++)
             {
                 for (int j = i; j < 5; j++)
                 {
                     Console.Write("*");
                 }
                 Console.Write("\n");
             }

             // Question 04

             Console.Write("Enter the number of rows: ");
             int rows = int.Parse(Console.ReadLine());

             for (int i = 1; i <= rows; i++)
             {
                 // Print spaces
                 for (int j = 1; j <= rows - i; j++)
                 {
                     Console.Write(" ");
                 }

                 // Print stars
                 for (int k = 1; k <= (2 * i - 1); k++)
                 {
                     Console.Write("*");
                 }

                 Console.WriteLine(); // Move to the next line
             }

             // Question 05

             Console.WriteLine("Enter Your Height" );
             int height = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Your Width");
             int width = int.Parse(Console.ReadLine());

             if(height > width)
             {
                 Console.WriteLine("This is Potrait");
             }
             else
             {
                 Console.WriteLine("This is Landscape");
             }

             // Question 06

             int count = 0;
             for (int i = 1; i <= 100; i++) 
             { 
                     if(i%3 != 0)
                 {
                     count++;
                 }
             }

             Console.WriteLine("Count :" + count);

            // Question 07

            int sum = 1;
            Console.WriteLine("Enter Value");
            int value = int.Parse(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                sum *= i;
            }

            Console.WriteLine("Value: " + sum);*/

            // Question 08

            int count = 0;
            int[] arr = { 1, 2, 2, 5, 5,6,6};

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = (i+1); j<=arr.Length-1; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                } 
            }

            Console.WriteLine("Count" + (count-5));
        }
    }
}
