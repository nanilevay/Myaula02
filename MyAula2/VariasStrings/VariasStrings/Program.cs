using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            string hello = "hello \n";
            string yolo = "yolo \n ";
            string fancyYolo = "\u13BD \u13C5 \u13DD \u13C5 \n";
            string goodbye = @"goodbye";
            Console.WriteLine("{0}{1}{2}{3}", hello, yolo, fancyYolo, goodbye);
            Console.Read();
        }
    }
}
