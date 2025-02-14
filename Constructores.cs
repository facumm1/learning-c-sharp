using System;

namespace Constructores
{
    class Objetos
    {
        static void Cuarto(string[] args)
        {
            Coche coche1 = new Coche();

            Console.WriteLine(coche1.GetInfoCoche());

            Coche coche2 = new Coche(4000, 32.0); 

            Console.WriteLine(coche2.GetInfoCoche());

            coche2.SetExtras(true, "Cuero");
            Console.WriteLine(coche2.GetExtras());
        }
    }

    //Clases parciales para dividir una clase grande en partes (comodidad)
    partial class Coche //Clases con constructores
    {
        //Da igual si no existe un constructor Coche(), implicitamente ya existe
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }

        //Sobrecarga de constructores
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }
    }

    partial class Coche
    {
        public String GetInfoCoche()
        {
            return "Info del coche\n" + "Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho;
        }

        public String GetExtras()
        {
            return "Extras\n" + "Tapiceria: " + tapizado + " Climatizador: " + climatizador;
        }

        public void SetExtras(bool climatizador, String tapizado)
        {
            this.climatizador = climatizador;
            this.tapizado = tapizado;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapizado;
    }
}
