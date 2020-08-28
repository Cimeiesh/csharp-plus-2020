using System;

namespace Session02Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary operation
            var additionResult = 1 * 2;

            Console.WriteLine("additionResult " + additionResult.ToString());

            var incrementResult = ++additionResult;

            Console.WriteLine("IncrementResult " + incrementResult.ToString());

            var trueValue = true;

            var falseValue = false;

            var andResult = 0b0010 & 0b0100; //0b110;
            var orResult = trueValue | falseValue;
            var xorResult = trueValue ^ falseValue;

            Console.WriteLine("andResult " + andResult);
            Console.WriteLine("orResult " + orResult);
            Console.WriteLine("xorResult " + xorResult);

            var moduloResult = 3 % 2;

            Console.WriteLine("ModuloResult " + moduloResult);

            var highInterger = 1000;
            var intergerDivisionResult = highInterger / 3;

            // Implicit värdekonvertering till double
            var doubleDivisionResult = highInterger / 3.0;

            Console.WriteLine("integerDivisionResult " + intergerDivisionResult);
            Console.WriteLine("doubleDivisionResult " + doubleDivisionResult);

            int castIntDivisionResult = (int)(highInterger / 3.0);

            Console.WriteLine("castIntDivisionResult " + castIntDivisionResult);

            var conversionResult = Convert.ToInt32(doubleDivisionResult);

            Console.WriteLine("conversionResult " + doubleDivisionResult);


            var midpointDivisionResult = 10.0 / 3.0;

            Console.WriteLine("midpointDivisionResult " + midpointDivisionResult);
            Console.WriteLine("castToInt " + ((int)midpointDivisionResult).ToString());
            Console.WriteLine("ceiling " + Math.Ceiling(midpointDivisionResult));
            Console.WriteLine("floor " + Math.Floor(midpointDivisionResult));
            Console.WriteLine("round " + Math.Round(midpointDivisionResult, 3));

            //Det går även att använda sammanslagna operatorer likt följande
            additionResult += 2;
            additionResult -= 2;
            additionResult /= 2;
            additionResult *= 2;

            var greaterResult = 5 > 3;
            var lesstThanResult = 5 < 3;
            var greaterOrEqual = 5 >= 5;
            var lessOrEqual = 3 <= 5;

            Console.WriteLine("greaterResult" + greaterResult);
            Console.WriteLine("lessThanResult" + lesstThanResult);
            Console.WriteLine("greaterOrEqual" + greaterOrEqual);
            Console.WriteLine("lessOrEqual" + lessOrEqual);

            var andOperationResult = true && false;
            var orOperationResult = true || false;

            Console.WriteLine("andOperationResult" + greaterResult);
            Console.WriteLine("orOperationResult" + lesstThanResult);

          

            Console.ReadKey();
        }
    }
}
