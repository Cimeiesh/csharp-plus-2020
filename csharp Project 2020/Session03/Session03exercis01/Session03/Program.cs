using System;

namespace Session03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerValues = new[] { 1, 2, 3 };

            for (var i = 0; i < integerValues.Length; i++)
            {
                var name = nameof(integerValues);
                var value = integerValues[i];

                Console.WriteLine($"Index {i} i arrayen {integerValues} har värdet: {value}");

            }
            var doWhileIndex = 0;

            do
            {
                var value = integerValues[doWhileIndex];

                Console.WriteLine($"Index {doWhileIndex} i arrayen {integerValueName}");
                doWhileIndex++;
            }
            while (doWhileIndex < integerValues.Length);

            var whileIndex = 0;

            while (whileIndex < integerValues.Length)
            {
                var value = integerValues[whileIndex];

                Console.WriteLine($"While Index {whileIndex} i arrayen {integerValuesName} har värdet {value}");

                whileIndex++;
            }
        }
    }
}
