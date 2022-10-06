using System;
using System.IO;

namespace Lab3Review
{
    class Program
    {
        static void Main(String[] args)
        {
            StartLab();
            FourNumbers();
            BuildDiamond();

        }

        // -------------------------------Challenge 1--------------------------
        static void StartLab()
        {
            Console.WriteLine("-----------------------------------------Challenge 1-------------------------------------");

            Console.WriteLine("Please enter 3 numbers: ");
            string pickedNum = Console.ReadLine();
            string[] numStringArray = pickedNum.Split(" ").ToArray();
            int[] numIntArray = Array.ConvertAll(numStringArray, Int32.Parse);

            // foreach (var number in numIntArray)
            // {
            //     Console.WriteLine($"StartLab {number}");
            // }
            int[] finalProduct = GetProduct(numIntArray);
            Console.WriteLine($"Product: {finalProduct[0]}");
        }

        static int[] GetProduct(int[] numIntArray)
        {
            int newProduct = 1;
            for (int i = 0; i < numIntArray.Length; i++)
            {
                newProduct *= numIntArray[i];
                Console.WriteLine(newProduct);
            }
            int[] productArray = { newProduct };
            return productArray;

        }
        static void FourNumbers()
        {
            Console.WriteLine("-----------------------------------------Challenge 2-------------------------------------");

            Console.WriteLine("Enter a number between 2-10");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());
            int[] fourNumbers = new int[pickedNumber];
            fourNumbers = FourNumbersWork(pickedNumber, fourNumbers);
            int[] finalAverage = FourNumbersAverage(pickedNumber, fourNumbers);
            Console.WriteLine($"Average: {finalAverage[0]}");

        }

        static int[] FourNumbersWork(int pickedNumber, int[] fourNumbers)
        {

            for (int i = 0; i < pickedNumber; i++)
            {
                Console.WriteLine($"Enter a number {i + 1}/{pickedNumber}: ");
                fourNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return fourNumbers;
        }

        static int[] FourNumbersAverage(int pickedNumber, int[] fourNumbers)
        {
            int sum = fourNumbers.Sum();

            int fourNumbersAverage = sum / pickedNumber;

            int[] finalAverage = { fourNumbersAverage };
            return finalAverage;
        }

        static void BuildDiamond()
        {
            Console.WriteLine("-----------------------------------------Challenge 3-------------------------------------");

            Console.WriteLine($@"    
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *"
    );
        }



    }
}