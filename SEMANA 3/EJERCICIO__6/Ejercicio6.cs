using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AplicationBase
{
    class program
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Digite numero par entre 100 y 200: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i <= 200; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}