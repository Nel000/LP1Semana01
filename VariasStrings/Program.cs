using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string s = "coiso";
            string t = "coisa";
            string r = @"""coiso entre aspas""";
            string i = @"\coiso sem aspas\";
            string n = "\u00A9 \u2665";
            string g = @"\u0010 not UTF";

            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(r);
            Console.WriteLine(i);
            Console.WriteLine(n);
            Console.WriteLine(g);
            
        }
    }
}
