using System;

namespace Arrays
{
    public class Arrays
    {
        public static void LearningArrays()
        {
            // array implicito

            //var datos = new[] {"Juan", "Diaz, 15};

            var valores = new[] { 15, 28, 35, 75.5, 30.3 };

            // arrays de objetos

            Empleados Ana = new Empleados("Roberto", 45);

            Empleados[] arrayEmpleados = new Empleados[3]; // establezco el tamaño de mi array

            arrayEmpleados[0] = new Empleados("Sara", 20); // se crea obj y se asigna

            arrayEmpleados[1] = Ana; // se asigna objeto ya creado

            arrayEmpleados[2] = new Empleados("Alberto", 60);


            // array de tipos o clases anonimas

            var personas = new[]
            {
                new {Nombre="Juan", Edad = 19},
                new {Nombre="Maria", Edad= 49},
                new {Nombre="Penelope", Edad= 60}
            };

            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());           
            }

            foreach(Empleados nombre in arrayEmpleados)
            {
                Console.WriteLine(nombre.getInfo());
            }

            foreach(var obj in personas)
            {
                Console.WriteLine(obj);
            }
        }
    }

    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return nombre;
        }

        String nombre;
        int edad;
    }
}
