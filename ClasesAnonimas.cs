using System;
namespace ClasesAnonimasArrays
{
    public class ClasesAnonimas
    {
        public ClasesAnonimas() {
            //realizarTarea();

            //Clases anonimas

            var miVariable = new { Nombre = "Juan", Edad = 19 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);

            var miOtraVariable = new { Nombre = "Roberto", Edad = 20 };

            miVariable = miOtraVariable;

            //Clases Anonimas: Requisitos
            /* 
             * Solo pueden contener campos publicos
             * Todos los campos deben estar iniciados
             * Los campos no pueden ser static
             * No se pueden definir metodos
            */

            //Arrays.LearningArrays();

            //UsoArrays.UsoDeArrays();

            //Humano roberto = new Humano("Roberto");

            //Caballo galopeador = new Caballo("Galopeador");


            //galopeador.GetNombre();

            //roberto.GetNombre();

            //--

            //Caballo miBabieca = new Caballo("Babieca");

            //Humano miJuan = new Humano("Juan");

            //Gorila miCopito = new Gorila("Copito");

            //Mamiferos[] almacenAnimales = new Mamiferos[3];
            ////Los valores a continuacion se pueden almacenar debido a que heredan de Mamiferos.

            //almacenAnimales[0] = miBabieca;
            //almacenAnimales[1] = miJuan;
            //almacenAnimales[2] = miCopito;

            //foreach(Mamiferos instancia in almacenAnimales)
            //{
            //    instancia.Pensar();
            //}

            //miCopito.PensarComoMamifero();
        }
    }
}
