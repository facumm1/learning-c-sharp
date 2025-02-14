using System;
namespace Enums
{
    public enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000 };

    public class Empleaduki
    {
        private double salario;
        private Bonus bonusEmpleado;

        public Empleaduki(Bonus bonusEmpleado, double salario)
        {
            this.salario = salario;
            this.bonusEmpleado = bonusEmpleado;
        }

        public double GetSalario()
        {
            return salario + (double)bonusEmpleado;
        }
    }
}
