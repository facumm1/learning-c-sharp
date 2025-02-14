using System;
//using System.Math; Import en C#, importa todos sus metodos static (* en js)
using EjercicioIntegrador1;

namespace PrimeraAppCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente persona1 = new Cliente("Facundo", "Mamani", 40500500); // Struct

            Vehiculo vehiculo = new Vehiculo("Avion", "Hydra", 2025, 15000000);
            Moto primeraMoto = new Moto("Zanella", "ZB", 2025, 900000);
            Auto primerAuto = new Auto("Toyota", "Corolla", 2018, 9500500);

            Concesionaria<Vehiculo> miConcesionaria = new Concesionaria<Vehiculo>();

            miConcesionaria.AgregarVehiculo(vehiculo);
            miConcesionaria.AgregarVehiculo(primeraMoto);
            miConcesionaria.AgregarVehiculo(primerAuto);

            miConcesionaria.MostrarInventario(); // Prints in console all vehicles
        }
    }
}
