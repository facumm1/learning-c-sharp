using System;
namespace PrimeraAppCsharp
{
    public class UsoArrays
    {
        public static void UsoDeArrays()
        {
            //int[] numeros = new int[4];

            //numeros[0] = 14;
            //numeros[1] = 30;
            //numeros[2] = 40;
            //numeros[3] = 23;

            //ProcesaDatos(numeros);

            int[] arr = LeerDatos();

            Console.WriteLine("Invocando a procesa datos method...");

            ProcesaDatos(arr);
        }

        static void ProcesaDatos(int[] datos)
        {
            foreach(int item in datos)
            {
                Console.WriteLine(item);
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuantos elementos tiene q tener el array?");

            string res = Console.ReadLine();

            int numElementos = int.Parse(res);

            int[] datos = new int[numElementos];


            for(int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce un valor para la posicion {i}");

                res = Console.ReadLine();

                int elemento = int.Parse(res);

                datos[i] = elemento;
            }

            return datos;
        }
    }
}
