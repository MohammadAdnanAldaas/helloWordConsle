using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace helloWordConsle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Hello Class");
            Console.Write("what is your name?");
            var nameFilledIn = Console.ReadLine();                        
            Console.WriteLine($"hello {nameFilledIn}");
            if ( nameFilledIn  == "Mohammad Aldaas")
            {
                Console.Write("what is your age?");
                var ageFilledIn = Console.ReadLine();
                Console.WriteLine($"WOW, you are {ageFilledIn}");
            }

            Console.ReadLine();
             


         


        }
    }
}
