using System;
using System.Threading;

namespace texto_vertical
{
    internal class Program // internal is opcional
    {
        static void Main(string[] args)
        {
            String frase;
            int cont = 0; // contador

            Console.WriteLine("Ingrese una frase o palabra");
            frase = Console.ReadLine();

            Console.WriteLine("Procesando...\n");
            Thread.Sleep(2000);
            while (cont < frase.Length)
            {
                Console.WriteLine(frase.Substring(cont, 1));
                cont++;
            }


            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
