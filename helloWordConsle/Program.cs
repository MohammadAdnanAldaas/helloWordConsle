using System;
using System.Collections.Generic;
using System.Linq;
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
            var filledin = Console.ReadLine();
            Console.WriteLine($"hello {filledin}");
            Console.ReadLine();

         


        }
    }
}
