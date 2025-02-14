using System;
using System.IO;

namespace ManejoArchivo
{
    public class ManejoArchivo
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivo()
        {
            archivo = new StreamReader(@"/Users/facu/hola.txt");

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void Mensaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }

        ~ManejoArchivo()
        {
            archivo.Close();
        }
    }
}
