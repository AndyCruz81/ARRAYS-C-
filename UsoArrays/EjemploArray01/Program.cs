using System;

namespace EjemploArray01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[5];
            int[] edades = new int[5];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("INGRESE NOMBRE : ");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("INGRESE EDAD : ");
                edades[1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("PERSONAS MAYORES DE EDAD : ");
                for(int i=0; i < nombre.Length; i++)
            {
                if (edades[i] >= 18) ;
                Console.WriteLine(nombre[i]);
            }
        }
    }
}
