using System;

namespace EjemploArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos elementos quieres que tenga el Array?");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];

            for (int i=0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la pocision {i}");
                respuesta = Console.ReadLine();
                int datosElementos = int.Parse(respuesta);
                datos[i] = datosElementos;
            }

            Console.WriteLine("Datos");
            foreach (int elementos in datos)
                Console.WriteLine(elementos);
        }
    }
}
