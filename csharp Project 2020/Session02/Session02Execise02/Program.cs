﻿using System;

namespace Session02Execise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to enter your name y/n?");
            var key = Console.ReadKey();

            if (key.KeyChar == 'n')
                return;

            Console.WriteLine("Hello, enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Hello," + name + "!");
            Console.ReadKey();
        }
    }
}
