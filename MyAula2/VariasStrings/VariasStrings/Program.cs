﻿using System;
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
            Console.WriteLine("Ex. 1");
            Console.WriteLine("{0}{1}{2}{3}", hello, yolo, fancyYolo, goodbye);
            Console.WriteLine("Ex. 2");
            Console.WriteLine("{0}{1}{2}{3}{4}", nice, ok, valor, vars, soma);
            Console.WriteLine(@"Verbatim o = {0}", o);
            Console.WriteLine("Ex. 3");
            Console.WriteLine("{0:f2} {0:p1} {1:x} {1:c}", xx, ii);
            Console.Read();
        }
    }
}