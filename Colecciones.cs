using System;
using System.Collections.Generic;

namespace Colecciones
{
    public class Coleccion
    {
        // List
        public void TestearList()
        {
            Console.WriteLine("Introduci elementos en la colección (0 para salir)");

            int elem = 1;

            while (elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos introducidos:");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }

        // LinkedList
        public void TestearLinkedList()
        {
            foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros2.AddFirst(numero);
            }

            Console.WriteLine("Mostrando valores:");

            for(LinkedListNode<int> nodo = numeros2.First; nodo != null; nodo = nodo.Next)
            {
                int numero = nodo.Value;

                Console.WriteLine($"Valor: {numero}");
            }

            //foreach (int num in numeros2)
            //{
            //    Console.WriteLine(num);
            //}
        }

        // Queue (de tipo FIFO)
        public void TestearQueue()
        {
            // Agregando elementos a la cola
            foreach(int numero in new int[] {1, 2, 3, 4, 5 })
            {
                numeros3.Enqueue(numero);
            }

            // Recorriendo elementos
            foreach(int numero in numeros3)
            {
                Console.WriteLine($"Valor de cola: {numero}");
            }

            numeros3.Dequeue();
            Console.WriteLine("\n");

            //Eliminado primer elemento
            foreach (int numero in numeros3)
            {
                Console.WriteLine($"Valor de cola nuevo: {numero}");
            }
        }

        // Stack (de tipo LIFO)
        public void TestearStacks()
        {
            // Agregando elementos a la pila, First in

            foreach(int num in new int[] {1, 2, 3, 4, 5 })
            {
                pila.Push(num);
            }

            // Mostrando elementos
            foreach(int value in pila)
            {
                Console.WriteLine($"Valor de pila inicial: {value}");
            }

            // Elimino el ultimo, Last out
            pila.Pop();

            Console.WriteLine("\n");


            // Mostrando elementos
            foreach(int stackValue in pila)
            {
                Console.WriteLine($"Valor de pila modificada: {stackValue}");
            }
        }

        // Diccionarios
        public void TestearDiccionarios()
        {
            diccionario.Add("Juan", 20);
            diccionario.Add("Roberto", 30);
            diccionario["Juana"] = 25;

            foreach(KeyValuePair<string, int> persona in diccionario)
            {
                Console.WriteLine($"Persona: {persona.Key}, edad: {persona.Value}");
            }
        }


        private List<int> numeros = new List<int>();

        private LinkedList<int> numeros2 = new LinkedList<int>();

        private Queue<int> numeros3 = new Queue<int>();

        private Stack<int> pila = new Stack<int>();

        private Dictionary<string, int> diccionario = new Dictionary<string, int>();
    }
}
