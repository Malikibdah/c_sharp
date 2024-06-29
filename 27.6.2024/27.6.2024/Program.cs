using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _27._6._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 - Correct the syntax error:

            //string[] ARR = [1, 7  9  45,]
            //int arr2 = ["Str" "alex","moh"
            //string arr3= 'the','fox' 'over' lazy, 'dog',  ]

            //solution
            //string[] ARR = { "1", "7", "9", "45" };
            //string[] arr2 = { "Str", "alex", "moh" };
            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            //2 - What the index of "Banana","Tomato" ?
            //String[ ]  fruits = ["Tomato", "Banana", "Watermelon"]

            //solution
            //the index is : 1 , 0
            //String[] fruits = { "Tomato", "Banana", "Watermelon" };
            //Console.WriteLine("The index of Banana is :" + Array.IndexOf(fruits, "Banana"));
            //Console.WriteLine("The index of Tomato is :" + Array.IndexOf(fruits, "Tomato"));

            //3 - Create an multiple arrays that represents your:
            //Favorite Food(5 item)
            //Favorite Sport(3 item)
            //Favorite Movie(4 item)
            //Then, print each array using foreach, and Loop Through an Array

            //solution
            //string[] favoritefood = { "mansaf ", "shawerma ", "magloba ", "frenshfrize ", "burger" };
            //string[] favoritesport = { "football ", "tenes ", "card "};
            //string[] favoritemovie = { "johnwike ", "jason ", "lacasadebabel ", "dark"};

            //foreach (string food in favoritefood)
            //{
            //    Console.WriteLine(food);
            //};
            //foreach (string sport in favoritesport)
            //{ 
            //    Console.WriteLine(sport); 
            //};
            //foreach(string movie in favoritemovie)
            //{
            //    Console.WriteLine(movie);
            //}



            //4 - Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            //Expected Output:
            //Input three numbers separated by comma: 5,10,15
            //The sum of three numbers: 30.

            //solution

            //1
            //int[] sumnumber = { 5, 10, 15 };
            //int thesum = 0;
            //for (int i = 0; i < sumnumber.Length; i++)
            //{ 
            //    thesum += sumnumber[i];
            //}
            //Console.WriteLine(thesum);

            //2
            //Console.WriteLine("Enter integer numbers to sum up, separating them by comma : ");
            //int result = Console.ReadLine().Split(',').Select(item => int.Parse(item)).Sum();
            //Console.Write(result);
            //Console.WriteLine();

            //3
            //Console.Write("Input three numbers separated by comma: ");
            //string input = Console.ReadLine();
            //string[] numbers = input.Split(',');
            //int num1 = int.Parse(numbers[0]);
            //int num2 = int.Parse(numbers[1]);
            //int num3 = int.Parse(numbers[2]);
            //int sum = num1 + num2 + num3;
            //Console.WriteLine("The sum of three numbers: " + sum);

            //4
            //Console.Write("Input three numbers separated by comma: ");
            //string input = Console.ReadLine();
            //string[] numbers = input.Replace(" ", "").Split(',');

            //double sum = 0;
            //foreach (var item in numbers)
            //{
            //    sum += Convert.ToDouble(item);
            //}
            //Console.WriteLine("The sum of three numbers: " + sum);

            //5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            //Test Data
            //The odd numbers are1 3 5 7 9 11 13 15 17 19……
            //The Sum of odd Numbers is: …...

            //solution
            //int[] numberonehandred= new int[100];
            //int sumForOddNumber = 0;
            //for (int i = 0;i < 100;i++)
            //{
            //    if(i%2 != 0)
            //    {
            //        Console.WriteLine(i + " ");
            //        sumForOddNumber += i;
            //    }
            //};
            //Console.WriteLine(sumForOddNumber);


            //6 - Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor The pattern like:

            //   *
            //  **
            // ***
            //****

            //solution
            //for (int i = 0; i <= 4; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine();
            //for (int m = 4; m >= 0; m--)
            //{
            //    for (int r = 0; r < m; r++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //7 - Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor The pattern like :

            //     1
            //   2 3
            //  4 5 6
            //7 8 9 10

            //solution

            //1
            //int number = 1;
            //int maxNumber = 10;

            //for (int i = 1; number <= maxNumber; i++)
            //{
            //    // Print leading spaces
            //    for (int j = 1; j <= maxNumber / 2 + 1 - i; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    // Print numbers
            //    for (int k = 1; k <= i; k++)
            //    {
            //        if (number > maxNumber) break;
            //        Console.Write(number + " ");
            //        number++;
            //    }

            //    // Move to the next line
            //    Console.WriteLine();
            //}

            //2
            //int rows = 4;

            //int number = 1;

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(number + " ");
            //        number++;
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
