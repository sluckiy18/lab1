using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб1
{
    class Program
    {
        static void Main(string[] args)
        {
            traffic tr1 = new traffic();
            Console.WriteLine(tr1);
            Console.WriteLine("Процентрая выручка составляет {0}\n",tr1.procvir());
            if (tr1.padrent() == true)
                Console.WriteLine("Падение рентабельности надлюдается\n");
            else Console.WriteLine("Падение рентабельности  не надлюдается\n");
            traffic tr2 = new traffic("Стройсити");
            Console.WriteLine(tr2);
            Console.WriteLine("Процентрая выручка составляет {0}\n", tr2.procvir());
            if (tr2.padrent() == true)
                Console.WriteLine("Падение рентабельности надлюдается\n");
            else Console.WriteLine("Падение рентабельности  не надлюдается\n");
            
            traffic tr3 = new traffic("Е-строй", 50, 300, 1, 2, 3, 4, 5);
            Console.WriteLine(tr3);
            Console.WriteLine("Процентрая выручка составляет {0}\n", tr3.procvir());
            if (tr3.padrent() == true)
                Console.WriteLine("Падение рентабельности надлюдается\n");
            else Console.WriteLine("Падение рентабельности  не надлюдается\n");
            traffic tr4 = tr3;
            Console.WriteLine(tr4);
            Console.WriteLine("Процентрая выручка составляет {0}\n", tr4.procvir());
            if (tr4.padrent() == true)
                Console.WriteLine("Падение рентабельности надлюдается\n");
            else Console.WriteLine("Падение рентабельности  не надлюдается\n");
            if (tr2.rent(tr3))
                Console.WriteLine("Фирма более рентабельна\n");
            else Console.WriteLine("Фирма менее рентабельна\n");
            traffic tr5 = traffic.sr3(tr1, tr2, tr4);
            Console.WriteLine("Самая ренабельная фирма {0}\n", tr5);
            Console.ReadKey();
        }
    }
}
