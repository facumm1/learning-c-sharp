using System;
namespace Empleado
{
    //public struct Empleado: es otra estructura que se usa para mejorar rendimiento (cantidad elevada de datos en memoria), cuando las instancias no deban cambiar (inmutables) y sean menores a 16 bytes, cuando no necesites convertir a objeto (boxed), etc
    public class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        //public double GetSalario()
        //{
        //    return this.salario;
        //}

        //public void SetSalario(double salario)
        //{
        //    if(salario > 0)
        //    {
        //        Console.WriteLine("Imposible asignar un salario negativo, asignandole 0 como valor...");

        //        this.salario = 0;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}

        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }

        private double salario;

        private string nombre;

        //CREACION DE PROPIEDAD
        //public double SALARIO
        //{
        //    get { return this.salario; }
        //    set { this.salario = evaluaSalario(value); }
        //}

        public double SALARIO
        {
            get => this.salario;
            set => this.salario = evaluaSalario(value);
                 
            //Nomenclatura para diferenciar variables q se manejan con properties
            //get => this._salario;
            //set => this._salario = evaluaSalario(value);
        }
    }

}