using System;

namespace Session02Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ålder:");


            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            if (integer >= 18)
            {
                Console.WriteLine("Du får köpa tobakprodukter");


            }
            else
            {
                Console.WriteLine("Du får inte köpa tobaksprodukter");

            }
   
            if (integer >= 40)
            {
                Console.WriteLine("Du är också väldigt gammal!");
            }
            
      
        }
    }
}
