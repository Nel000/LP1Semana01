using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int i = 5;
            uint ui = 7U;
            long l = 142L;

            char copyrightSymbol = '\u00A9';
            char heart = '\u2665';

            float f = 15.27f;
            double d = 2.75;
            decimal z = 53.213m;

            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);

            Console.WriteLine();

            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(heart);

            Console.WriteLine();

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(z);
        }
    }
}
