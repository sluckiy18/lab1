using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var a1 = (a1: 5, a2: 10, a3: "sdfsdf");
            var a2 = (a1: 5, a2: 10, a3: "sdfsdf");
            var a3 = a1.a1 + a2.a2;
            string str = "asdads";
            Console.WriteLine(str[1]);
            Console.WriteLine(a1.a3[1]);
            Console.ReadKey();
        }
    }
}
