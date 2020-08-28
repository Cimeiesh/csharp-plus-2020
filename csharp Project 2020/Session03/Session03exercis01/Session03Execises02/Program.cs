using System;
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

            for (int i = 0; i < inputArray.Length; i++)

            {
                try
                {
                    numberArray[i] = Convert.ToDouble(inputArray[i]);
                }
                catch (Exception)
                {
                    numberArray[1] = 0;
                }

                foreach (var number in inputArray)
                {
                    Console.WriteLine("Värdet" + number.ToString());
                }
                
                int max = Int32.MinValue; 
                int min = Int32.MaxValue;

                foreach (string number in inputArray)
                {
                    int currentNumber = int.Parse(number); 

                    if (currentNumber > max)  
                        max = currentNumber;

                    if (currentNumber < min)
                        min = currentNumber;

              
                }
                Console.WriteLine(string.Format("Minsta värdet: {0} Högsta värdet: {1}", min, max));
                

                Console.ReadKey();
            }

        }
    }
    
}
