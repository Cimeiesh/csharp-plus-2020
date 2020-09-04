using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Session03Execises02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken!");
            var input = Console.ReadLine();

            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[inputArray.Length];
            double total = 0;
            double count = inputArray.Length;
            double middle = 0;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool test;
        
                try
                {
                    numberArray[i] = Convert.ToDouble(inputArray[i]);
                    test = true;
                }
                catch (Exception)
                {
                    numberArray[1] = 0;
                    test = false;
                }

                if (test == false)
                {
                    continue;
                    
                }

                foreach (var number in inputArray)
                {
                    int currentNumber = int.Parse(number);
                    if (currentNumber > max)
                        max = currentNumber;

                    if (currentNumber < min)
                        min = currentNumber;

                    total += currentNumber;
                    middle = total / count;

                    Console.WriteLine("Värdet: " + number.ToString());
                }
                    Console.WriteLine(string.Format("Minsta värdet: {0} Högsta värdet: {1} Medelvärdet: {2}", min, max, middle));

                    Console.ReadKey();
            } 
        }
    }  
} 
