using System;
namespace Practicando1
{
    public class Salarios
    {
        // Constructor
        public Salarios()
        {
            salario1 = 100;
            salario2 = 0;
        }

        // IF
        private int evaluaSalario(int salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("Salario no puede ser menor a 0. Asignando salario cero.");
                return 0;
            }

            Console.WriteLine("Salario positivo! Asignando nuevo salario.");
            return salario;
        }

        // Properties con arrow
        public int SALARIO
        {
            get => this.salario1;
            set => this.salario1 = evaluaSalario(value);
        }

        private int salario1;
        private int salario2;
    }
}
