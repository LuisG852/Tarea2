using System;

namespace T2Ej._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio, dia, dias, mes;
            Console.Write("Ingrese el valor de anno: ");
            anio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de mes: ");
            mes = int.Parse(Console.ReadLine());
            dias = 0;
            if (mes == 2 && (((anio % 4 == 0) && (anio % 100 != 0)) || anio % 400 == 0))
                dias = 29;
            if (mes == 2 && (((anio % 4 != 0) || (anio % 100 == 0)) && anio % 400 != 0))
                dias = 28;
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                dias = 31;
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                dias = 30;
            Console.WriteLine("Valor de dias del mes: " + dias);
            Console.WriteLine();
            Console.Write("Presione una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
