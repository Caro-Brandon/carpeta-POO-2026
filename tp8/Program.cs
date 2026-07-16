using System;

class Program
{
    static void Saludar(string nombre)
    {
        Console.WriteLine("Hola " + nombre);
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static bool EsPar(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int Mayor(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static int CalcularFactorial(int n)
    {
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        return factorial;
    }

    static void SaludoDefecto(string nombre = "Invitado")
    {
        Console.WriteLine("Hola " + nombre);
    }

    static void MostrarScope()
    {
        int numero = 10;

        Console.WriteLine("Variable dentro del metodo: " + numero);
    }

    static void ImprimirArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static int ContarPares(int[] arr)
    {
        int contador = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                contador++;
            }
        }

        return contador;
    }

     static int[] CargarArray()
    {
        int[] numeros = { 3, 8, 10, 15, 20 };

        return numeros;
    }

     static int ContarPares2(int[] arr)
    {
        int contador = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                contador++;
            }
        }

        return contador;
    }

     static void MostrarResultado(int cantidad)
    {
        Console.WriteLine("Cantidad de pares: " + cantidad);
    }

     static void Main(string[] args)
        {
            Console.WriteLine("-----Punto 1-----");
            Saludar("Brandon");

            Console.WriteLine("-----Punto 2-----");
            Console.WriteLine("Suma: " + Sumar(5, 8));

            Console.WriteLine("-----Punto 3-----");
            Console.WriteLine("Es par: " + EsPar(10));

            Console.WriteLine("-----Punto 4-----");
            Console.WriteLine("Mayor: " + Mayor(12, 7));

            Console.WriteLine("-----Punto 5-----");
            Console.WriteLine("Factorial: " + CalcularFactorial(5));

            Console.WriteLine("-----Punto 6-----");
            SaludoDefecto();
            SaludoDefecto("Brandon");

            Console.WriteLine("-----Punto 7-----");
            MostrarScope();
            // Console.WriteLine(numero); // La variable solo existe dentro del método.

            Console.WriteLine("-----Punto 8-----");
            int[] arreglo = { 3, 8, 10, 15, 20 };

            Console.WriteLine("Elementos del arreglo:");
            ImprimirArray(arreglo);

            Console.WriteLine("-----Punto 9-----");
            int cantidad = ContarPares(arreglo);
            Console.WriteLine("Cantidad de pares: " + cantidad);

            Console.WriteLine("-----Punto 10-----");
            int[] numeros = CargarArray();
            int pares = ContarPares2(numeros);
            MostrarResultado(pares);
        }
}