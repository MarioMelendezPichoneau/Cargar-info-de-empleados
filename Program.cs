using System;

namespace proyecto_final_Mario
{
    // Con la siguiente información:
   //  Nombres de 5 empleados.
  // Salario, cobrado por cada empleado, en los últimos 3 meses.

    //Crear el programa para:

    // a) Cargar la información de los empleados y sus respectivos sueldos.
   // b) Generar un vector que contenga el ingreso acumulado en salarios en los últimos 3 meses para cada empleado.
   // c) Mostrar por pantalla el total pagado en salario a todos los empleados en los últimos 3 meses
   // d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado

    class Program
    {
        static void Main(string[] args)
        {
            Program mario = new Program();
            mario.Cargar();
            mario.CalcularSuma_ingreso_de_Salario();
            mario.ImprimirTotal_Pagado();
            mario.EmpleadoMayor_Sueldo();

            Console.ReadKey();
        }

        private string[] empleados;
        private int[,] sueldos;
        private int[] sueldoTotal;

        public void Cargar()
        {
            empleados = new String[5];
            sueldos = new int[5, 3];
            string ana;

            for (int i = 0; i < empleados.Length; i++)
            {
                Console.Write($"Ingrese el nombre del empleado {i+1}: ");
                empleados[i] = Console.ReadLine();

                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    Console.Write($"Ingrese sueldo {j+1}: ");
                    ana = Console.ReadLine();
                    sueldos[i, j] = int.Parse(ana);
                }
            }
        }

        public void CalcularSuma_ingreso_de_Salario()
        {
            sueldoTotal = new int[5];
            

            for (int i = 0; i < sueldos.GetLength(0); i++)
            {
                int suma = 0;
                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    suma += sueldos[i, j];
                }
                sueldoTotal[i] = suma;
            }
        }

        public void ImprimirTotal_Pagado()
        {
            Console.WriteLine($"\n El total de sueldos pagados por empleado es: ");

            for (int i = 0; i < sueldoTotal.Length; i++)
            {
                Console.WriteLine($"{empleados[i]} = {sueldoTotal[i]} ");
            }

        }

        public void EmpleadoMayor_Sueldo()
        {
            int mayor = sueldoTotal[0];
            string nombre = empleados[0];

            for (int i = 0; i < sueldoTotal.Length; i++)
            {
                if (sueldoTotal[i] > mayor)
                {
                    mayor = sueldoTotal[i];
                    nombre = empleados[i];
                }
            }
            Console.WriteLine($"El empleado con mayor sueldo es {nombre} con un sueldo de {mayor} ");
        }





    }
}
