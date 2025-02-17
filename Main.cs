using System;
//using System.Math; Import en C#, importa todos sus metodos static (* en js)
using Colecciones;

namespace PrimeraAppCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coleccion miColeccion = new Coleccion();

            //miColeccion.TestearList();
            //miColeccion.TestearLinkedList();
            //miColeccion.TestearQueue();
            //miColeccion.TestearStacks();

            miColeccion.TestearDiccionarios();
        }
    }
}
