using System;

namespace Session02Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange vattentemperatur i grader C:");

            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            string waterLabel = integer >= 27 ? "Går att bada" : "Går inte att bada";

            //Samma sak som
            //if (integer > 27)
            //{
            //    waterLabel = "Det går att bada!"
           // }
           // else
            //{
             //   waterLabel = "Nej! BADA FÖR FAN INTE!!"
            //}

            switch (integer)
            {
                //Det går bra att radbyta, men är fular och svårare att läsa
                case 1: waterLabel = "går inte att bada alls"; break;
                case -3: waterLabel = "Det är 3 minusgrader"; break;
                default: /* Här kan man göra något om inget träffar */ break;


            }
        }
    }
}
