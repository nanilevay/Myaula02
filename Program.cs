using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {

            // ask user for input
            Console.WriteLine("please input a height!");
            // define height
            string height = Console.ReadLine();
            // turn into double 
            float h = Convert.ToSingle(height);

            // ask user for input
            Console.WriteLine("please input a radius!");
            //define radius
            string radius = Console.ReadLine();
            // turn into double
            float r = Convert.ToSingle(radius);

            // calculate the volume
            double vol = Math.PI*Math.Pow(r, 2)*h;
            // calculate the surface area
            double surface = 2*Math.PI*r*(r+h);

            // write the results
            Console.WriteLine("volume do cilindro = {0} \narea da superficie do cilindro= {1}", vol, surface);

        }
    }
}
