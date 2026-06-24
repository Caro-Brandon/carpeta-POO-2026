using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("---punto 1-----");

        int[] notas = { 8, 6, 9, 7, 10 };

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine(notas[i]);
        }


        Console.WriteLine("---punto 2-----");

        int suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

                  double promedio = (double) suma / notas.Length;

        Console.WriteLine("Promedio: " + promedio);


        Console.WriteLine("---punto 3-----");

        int mayor = notas[0];
        int menor = notas[0];

        for (int i = 1; i < notas.Length; i++)
        {
            if (notas[i] > mayor)
            {
                mayor = notas[i];
            }

            if (notas[i] < menor)
            {
                menor = notas[i];
            }
        }

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);


        Console.WriteLine("---punto 4-----");

        int[] invertido = new int[notas.Length];

        int j = notas.Length - 1;

        for (int i = 0; i < notas.Length; i++)
        {
            invertido[i] = notas[j];
            j--;
        }

        for (int i = 0; i < invertido.Length; i++)
        {
            Console.WriteLine(invertido[i]);
        }


        Console.WriteLine("---punto 5-----");

        int contador = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > 7)
            {
                contador++;
            }
        }

        Console.WriteLine("Mayores a 7: " + contador);


        Console.WriteLine("---punto 6-----");

        List<string> tareas = new List<string>();

        tareas.Add("tarea");
        tareas.Add("examen");
        tareas.Add("Dormir");

        Console.WriteLine("Tareas agregadas.");


        Console.WriteLine("---punto 7-----");

        tareas.Remove("examen");

        Console.WriteLine("Cantidad de tareas: " + tareas.Count);


        Console.WriteLine("---punto 8-----");

        foreach (string tarea in tareas)
        {
            Console.WriteLine(tarea);
        }


        Console.WriteLine("---punto 9-----");

        int[,] diagonal =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(diagonal[i, i]);
        }


        Console.WriteLine("---punto 10-----");

        int buscar = 9;
        bool encontrado = false;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] == buscar)
            {
                encontrado = true;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("El número existe");
        }
        else
        {
            Console.WriteLine("El número no existe");
        }
    }
}