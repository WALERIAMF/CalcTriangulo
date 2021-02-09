using System;
using System.Globalization;

namespace calc_Triangulo
{
    class Program
    {

        static void Main(string[] args)

        {
            area_Triangulo x, y;
            

            x = new area_Triangulo();
            y = new area_Triangulo();


            Console.WriteLine("Entre com as medidas dos lados do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas dos lados do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double px = (x.A + x.B + x.C);
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            double py = (y.A + y.B + y.C);
            double pe = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(pe * (pe - y.A) * (pe - y.B) * (pe - y.C));

            Console.WriteLine("Area de X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.WriteLine("Perimetro de X: " + px.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro de Y:  " + py.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
