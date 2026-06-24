using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("---punto 1-----");
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("---punto 2-----");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine("---punto 3-----");
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma es: " + suma);


        Console.WriteLine("---punto 4-----");
        int contador = 10;

        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--;
        }


        Console.WriteLine("---punto 5-----");
       int numero;
       string dato;

        do
        {
            Console.Write("Ingrese un número positivo: ");
            dato = Console.ReadLine()!;

            if (dato.Trim() == "")
            {
                numero = -1;
            }
            else
            {
                numero = int.Parse(dato);
            }

        } while (numero <= 0);

        Console.WriteLine("Número correcto.");


        Console.WriteLine("---punto 6-----");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
        }


        Console.WriteLine("---punto 7-----");

        string palabra = "Hola";

        foreach (char letra in palabra)
        {
            Console.WriteLine(letra);
        }


        Console.WriteLine("---punto 8-----");

        for (int i = 1; i <= 20; i++)
        {
            if (i == 13)
            {
                break;
            }

            Console.WriteLine(i);
        }


        Console.WriteLine("---punto 9-----");

        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }

            Console.WriteLine(i);
        }


        Console.WriteLine("---punto 10-----");

        for (int fila = 1; fila <= 5; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}