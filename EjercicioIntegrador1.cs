using System;
namespace EjercicioIntegrador1
{
    interface IReparable
    {
        void Reparar();
    }

    class Concesionaria<T> where T : Vehiculo
    {
        public Concesionaria()
        {
            vehiculos = new T[10];
        }

        public void AgregarVehiculo(T vehiculo)
        {
            try
            {
                if (index > 9)
                {
                    throw new Exception("Limite de vehiculos excedido");
                }

                this.vehiculos[index] = vehiculo;
                index++;
            } catch(Exception err)
            {
                Console.WriteLine($"Error: {err}");
            }

        }

        public void MostrarInventario()
        {
            for (int i = 0; i < vehiculos.Length; i++)
            {

                if(vehiculos[i] != null)
                {
                    Console.WriteLine($"Vehiculo numero {i + 1}");

                    vehiculos[i].MostrarInformacion();

                    Console.WriteLine('\n');
                }
            }
        }

        private T[] vehiculos;
        private int index = 0;
    }

    struct Cliente
    {
        public Cliente(String nombre, String apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public String NOMBRE
        {
            get => this.nombre;
            set => this.nombre = value;
        }

        public String APELLIDO
        {
            get => this.apellido;
            set => this.apellido = value;
        }

        public int DNI
        {
            get => this.dni;
            set => this.dni = value;
        }

        private String nombre;
        private String apellido;
        private int dni;
    }

    public class Vehiculo
    {
        public Vehiculo(String marca, String modelo, int año, double precioBase)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;

            if(precioBase < 0)
            {
                throw new ArgumentException("El precio base no puede ser negativo.");
            }
            else
            {
                this.precioBase = precioBase;
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine(string.Format("Los datos del vehiculo son: {0}, marca {1}, año {2}, valor {3}", modelo, marca, año, precioBase));
        }

        public virtual double CalcularPrecioFinal()
        {
            return precioBase;
        }

        private String marca;
        private String modelo;
        private int año;
        protected double precioBase;
    }

    public class Auto : Vehiculo, IReparable
    {
        public Auto(String marca, String modelo, int año, double precioBase) : base(marca, modelo, año, precioBase)
        {
            cantidadPuertas = 4;
        }

        public override double CalcularPrecioFinal()
        {
            if(this.cantidadPuertas > 4)
            {
                Console.WriteLine("El auto tiene mas de 4 puertas, se agregara un 10% mas al precio final.");
                return precioBase * 1.1;
            }

            Console.WriteLine("El auto no tiene mas de 4 puertas, se mantendra el precio base como final.");
            return precioBase;
        }

        public void Reparar() { }

        public int CANTIDADPUERTAS {
            get => cantidadPuertas;
            set => cantidadPuertas = value;
        }

        private int cantidadPuertas;
    }

    public class Moto : Vehiculo, IReparable
    {
        public Moto(String marca, String modelo, int año, double precioBase) : base(marca, modelo, año, precioBase)
        {
            cilindrada = 250;
        }

        public override double CalcularPrecioFinal()
        {
            if (this.cilindrada > 500)
            {
                Console.WriteLine("La moto es de mas de 500cc, se agregara un 15% mas al precio final.");
                return precioBase * 1.15;
            }

            Console.WriteLine("La moto es de menos de 500cc, se mantendra el precio base como final.");
            return precioBase;
        }

        public void Reparar() { }

        public int CILINDRADA
        {
            get => cilindrada;
            set => cilindrada = value;
        }

        private int cilindrada;
    }

    abstract class VehiculoMotorizado : Vehiculo
    {
        public VehiculoMotorizado(String marca, String modelo, int año, double precioBase) : base(marca, modelo, año, precioBase) {}

        public abstract void EncenderMotor();
    }   
}
