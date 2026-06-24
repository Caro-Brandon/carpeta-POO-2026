using System;

class Program
{
    static void Main()
    {
        double baseRect = 5;
        double altura = 3;

        double area = baseRect * altura;
        Console.WriteLine("area: " + area);

        int resto = 100 % 7;
        Console.WriteLine("resto: " + resto);
        
        double celsius = 30;
        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine("Fahrenheit: " + fahrenheit);

        string numeroTexto = "12";
        int numero = int.Parse(numeroTexto);
        Console.WriteLine("numero convertido: " + numero);

        string textoDouble = "12.5";
        double valor;

        if (double.TryParse(textoDouble, out valor))
            {
                Console.WriteLine("conversion es: " + valor);
            }
            else
            {
                Console.WriteLine("error al convertir");
            }

        int precio = 1000;
        double precioFinal = precio * 1.21;
        Console.WriteLine("precio final: " + precioFinal);

        int divisionEntera = 5 / 2;
        double divisionReal = 5.0 / 2.0;
        Console.WriteLine("division entera: " + divisionEntera);
        Console.WriteLine("division real: " + divisionReal);

        int contador = 0;
        contador++;
        Console.WriteLine("contador: " + contador);

        double numeroDecimal = 9.8;
        int numeroEntero = (int)numeroDecimal;

        Console.WriteLine("Entero: " + numeroEntero);

        int horas = 1000;
        int dias = horas / 24;

        Console.WriteLine("dias completos: " + dias);

    }
}