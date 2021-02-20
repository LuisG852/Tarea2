using System;

namespace T2Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            char Letra;
            Console.Write("Introduzca una Letra: ");
            Letra = Convert.ToChar(Console.ReadLine());
            if (char.IsUpper(Letra))
            {
                Console.WriteLine("La letra ingresada es Mayuscula");


            }
            else
            {
                Console.WriteLine("La letra ingresada es Minuscula");
            } 
        }
    }
}
