using System;

namespace T2Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, total;
            Console.Write("Introduzca las horas laboradas de la semana: ");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (horas <= 40)
            {
                total = horas * 16;
                Console.Write("Usted trabajo " + horas + "horas. Y su salario semanal es de: " + total);
                Console.WriteLine("");
            }
            else if (horas > 40)
            {
                total = ((horas - 40) * 20) + (40 * 16);
                Console.WriteLine("Su salario es de: " + total);
            }
        }
    }
}
