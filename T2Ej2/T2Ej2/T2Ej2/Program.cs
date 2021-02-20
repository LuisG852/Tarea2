using System;

namespace T2Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            double desc, total;
            Console.Write("Ingrese el Total de la compra para un descuento: ");
            total = Convert.ToInt32(Console.ReadLine());
            desc = total * 0.20;
            if (total >= 300)
            {
                Console.WriteLine("Su descuento es de: " + desc);

            }
            else
            {
                Console.WriteLine("Usted no tiene ningun descuento");
            }
        }
    }
}
