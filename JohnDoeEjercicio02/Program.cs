using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnDoeEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la medida del lado 1:");
            var lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la medida del lado 2:");
            var lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la medida del lado 3:");
            var lado3 = int.Parse(Console.ReadLine());
            if (EsTriangulo(lado1, lado2, lado3))
            {
                if (lado1==lado2 && lado2==lado3 )
                {
                    Console.WriteLine("El triángulo es Equilátero");
                }else if (lado1!=lado2 && lado2!=lado3 && lado1!=lado3)
                {
                    Console.WriteLine("El triángulo es Escaleno");
                }
                else
                {
                    Console.WriteLine("El triángulo es Isósceles");
                }
            }
            else
            {
                Console.WriteLine("Los lados ingresados no conforman un triángulo");
            }
            
            Console.ReadLine();

        }

        private static bool EsTriangulo(int lado1, int lado2, int lado3)
        {
            return lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2;
        }
    }
}
