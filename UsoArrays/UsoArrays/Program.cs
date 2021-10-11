using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] edades = { 15, 27, 19, 80, 21, 14, 11 };
            //2
            int[] edades1;
            edades1 = new[] { 15, 27, 19, 80, 21, 14, 11 };
            //3
            int[] edades2;
            edades2 = new int[5];
            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;
            edades[4] = 21;
            //ARRAY EXPLICITO
            var dato1 = new[] { 15, 23, 25, 25.36, 3.80 };
            var dato2 = new[] { "Juan", "Francisco", "5" };

            Empleados Ana = new Empleados("Ana", 27);

            //ARRAYS DE OBJETOS
            Empleados[] arrayEmpleados = new Empleados[3];
            arrayEmpleados[0] = new Empleados("Sara", 38);
            arrayEmpleados[1] = Ana;
            arrayEmpleados[2] = new Empleados("Rafael", 51);

            //ARRAYS DE TIPOS DE CLASES ANONIMAS
            var personas = new[]
            {
                (Nombre: "Juan", edad : 19);
                (Nombre: "Maria", edad: 49);
                (Nombre: "Diana", edad: 35);
            }

           foreach(int variable in edades)

        }
    }
    class Empleados
    {
        private string nombre;
        private string edad;

        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getInfo()
        {
            return "Nombre del Empleado: " + nombre +
                "Edad: " + edad;
        }
    }
}
