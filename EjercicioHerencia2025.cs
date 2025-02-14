using System;
namespace EjercicioHerencia2025
{
    class Vehiculo
    {
        public Vehiculo() {
            inicio = "Arrancando";
            fin = "Frenando";
            conducir = "Conduciendo";
        }

        public void ArrancarMotor()
        {
            Console.WriteLine($"{inicio} motor!");
        }

        public void FrenarMotor()
        {
            Console.WriteLine($"{fin} motor!");
        }

        public virtual void Conducir()
        {
            Console.WriteLine($"{conducir} motor!");
        }

        private String inicio;
        private String fin;
        private String conducir;
    }

    class Avion : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo un avion!");
        }
    }

    class Coche : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo un coche!");
        }
    }
}
