using System;
namespace EjercicioHerencia
{
    public class Vehiculo
    {
        public Vehiculo()
        {
        }

        public void ArrancarMotor()
        {
            Console.WriteLine("Arrancando motor");
        }

        public void FrenarMotor()
        {
            Console.WriteLine("Frenando motor");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Conduciendo!");
        }

        public void Acciones()
        {
            ArrancarMotor();
            Conducir();
            FrenarMotor();
        }
    }

    class Avion : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Despegando un AVION");
        }
    }

    class Coche : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Manejando un AUTO");
        }
    }
}
