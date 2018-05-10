using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frazione
{
    class Program
    {
        static void Main()
        {
            frazione f = new frazione();
            frazione f1 = new frazione(5,2);
            frazione f2 = new frazione(3);
            frazione f3 = new frazione(10,6);

            f = f3;

            Console.WriteLine("Dimensione della classe in byte: {0}", sizeof(frazione));
            Console.WriteLine("Frazione 1: {0}", f1.Get());
            Console.WriteLine("Frazione 2: {0}", f2.Get());
            Console.WriteLine("Frazione 3: {0}", f3.Get());

            //f = f1 + f2;
            //Console.WriteLine("{0} + {1} =
        }
    }
}
