using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoByValue_ByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            AddOne(ref number);
            Console.WriteLine(number);

            Console.ReadLine();
        }
        private static void AddOne(ref int var)
        {
            var++;
        }

    }

   
}
