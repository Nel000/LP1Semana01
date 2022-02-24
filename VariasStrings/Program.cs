using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double xx = 0.12345;
            int ii = 18;

            int x = 10;
            char c = 'a';

            string s = "coiso";
            string t = "coisa";
            string r = @"""coiso entre aspas""";
            string i = @"\coiso sem aspas\";
            string n = "\u00A9 \u2665";
            string g = @"\u0010 not UTF";

            string cs = "Coiso" + "Coisa" + 2;
            string cr = s + t + x;

            string si = $"{s} interpolado";
            string ri = $@"{s} + {c} = {t} verbatim {x}";

            string sf = String.Format("{0} e {1}", s, t);
            string rf = String.Format("{0} + {1} = {2}", 4, 6, x);

            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(r);
            Console.WriteLine(i);
            Console.WriteLine(n);
            Console.WriteLine(g);

            Console.WriteLine();

            Console.WriteLine(cs);
            Console.WriteLine(cr);
            
            Console.WriteLine(si);
            Console.WriteLine(ri);

            Console.WriteLine();

            Console.WriteLine(sf);
            Console.WriteLine(rf);

            Console.WriteLine();

            Console.WriteLine($"Valor de x é {x}");
            Console.WriteLine(@"Verbatim com x = {0}", x);

            Console.WriteLine();

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");
            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");
        }
    }
}
