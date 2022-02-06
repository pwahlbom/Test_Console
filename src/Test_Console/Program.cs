using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime? test = DateTime.Parse("February 28, 1968");

            if (test == null) { Console.WriteLine("Is Null"); }
            else
            {
                Console.WriteLine("1 :" + test.Value);
                Console.WriteLine("2 :" + test.GetValueOrDefault());
            }
            Console.ReadLine();

            test = null;
            Console.WriteLine("1 :" + test.Value);
            Console.WriteLine("2 :" + test.GetValueOrDefault());
            Console.ReadLine();
        }
    }
}