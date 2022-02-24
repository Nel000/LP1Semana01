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

            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);

            Console.WriteLine();

            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(heart);
        }
    }
}
