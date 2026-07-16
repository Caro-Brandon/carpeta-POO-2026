using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Punto 1-----");

        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine();

        Console.WriteLine("Nombre completo: " + nombre + " " + apellido);

        Console.WriteLine("-----Punto 2-----");

        Console.Write("Ingrese una oración: ");
        string oracion = Console.ReadLine();

        string sinEspacios = oracion.Replace(" ", "");

        Console.WriteLine("Cantidad de letras: " + sinEspacios.Length);

        Console.WriteLine("-----Punto 3-----");

        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine("Mayúsculas: " + texto.ToUpper());
        Console.WriteLine("Minúsculas: " + texto.ToLower());

        Console.WriteLine("-----Punto 4-----");

        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        if (palabra.ToLower().Contains("a"))
        {
            Console.WriteLine("La palabra contiene la letra 'a'.");
        }
        else
        {
            Console.WriteLine("La palabra NO contiene la letra 'a'.");
        }

        Console.WriteLine("-----Punto 5-----");

        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        Console.WriteLine(frase.Replace(" ", "-"));

        Console.WriteLine("-----Punto 6-----");

        Console.Write("Ingrese una frase: ");
        string frase2 = Console.ReadLine();

        string[] palabras = frase2.Split(' ');

        Console.WriteLine("Palabras:");

        for (int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine(palabras[i]);
        }

        Console.WriteLine("-----Punto 7-----");

        Console.Write("Ingrese el primer texto: ");
        string texto1 = Console.ReadLine();

        Console.Write("Ingrese el segundo texto: ");
        string texto2 = Console.ReadLine();

        if (texto1.ToLower() == texto2.ToLower())
        {
            Console.WriteLine("Son iguales.");
        }
        else
        {
            Console.WriteLine("Son diferentes.");
        }

        Console.WriteLine("----Punto 8----");

        Console.Write("Ingrese un número: ");
        string numeroTexto = Console.ReadLine();

        int numero = int.Parse(numeroTexto);

        Console.WriteLine("Número convertido: " + numero);

        Console.WriteLine("-----Punto 9-----");

        Console.Write("Nombre: ");
        string nom = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ciudad: ");
        string ciudad = Console.ReadLine();

        Console.WriteLine("Datos ingresados:");
        Console.WriteLine("Nombre: " + nom);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Ciudad: " + ciudad);

        Console.WriteLine("-----Punto 10-----");

        Console.Write("Ingrese una palabra: ");
        string original = Console.ReadLine();

        string invertida = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida = invertida + original[i];
        }

        if (original.ToLower() == invertida.ToLower())
        {
            Console.WriteLine("Es un palíndromo.");
        }
        else
        {
            Console.WriteLine("No es un palíndromo.");
        }
    }
}