using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            var o = 0;
            var x = 1;
            string hello = "hello \n";
            string yolo = "yolo \n ";
            string fancyYolo = "\u13BD \u13C5 \u13DD \u13C5 \n";
            string goodbye = @"goodbye";
            string nice = "nice " + 1 + "\n";
            string ok = o + "k \n";
            string valor = $"valor de o eh {o} \n";
            string soma = $"{o} mais {x} eh igual a {o + x}";
            string vars = String.Format("x eh {1}, o eh {0} \n", o, x);
            Console.WriteLine("{0}{1}{2}{3}", hello, yolo, fancyYolo, goodbye);
            Console.WriteLine("{0}{1}{2}{3}{4}", nice, ok, valor, vars, soma);
            Console.WriteLine(@"Verbatim o = {0}", o);
            Console.Read();
        }
    }
}