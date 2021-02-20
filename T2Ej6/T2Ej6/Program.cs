using System;

namespace T2Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
			int a, num;
			Console.Write("Ingrese un n\u00FAmero:");
			num = int.Parse(Console.ReadLine());
			for (a = 2; a < num && num % a != 0; a++) ;
			if (a == num)
				Console.WriteLine("\nW1 n\u00FAmero " + num + " s\u00ED es primo.");
			else
				Console.WriteLine("\nW1 n\u00FAmero " + num + " s\u00ED no es primo.");
			Console.WriteLine("\nPresione una tecla para terminar . . . ");
			Console.ReadKey();
		}
    }
}
