using System;
namespace Genericos
{
    public class Genericos<T>
    {
        public Genericos(int z)
        {
            datosElemento = new T[z];
        }

        public void Agregar(T obj)
        {
            datosElemento[i] = obj;

            i++;
        }

        public T GetElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;
        private int i = 0;
    }

    class Empleardo
    {
        public Empleardo(double salario)
        {
            this.salario = salario;
        }
            
        public double GetSalario()
        {
            return salario;
        }

        private double salario;
    }
}
