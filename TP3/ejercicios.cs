using System;

class Program
{
    static void Main()
    {
        string nombre = "Brandon";
        int edad = 17;
        double altura = 1.68;
        string ciudad = "caba";

        var numero = 10;
        var texto = "Hola";
        var decimalNum = 2.12;

        Console.WriteLine(numero.GetType());
        Console.WriteLine(texto.GetType());
        Console.WriteLine(decimalNum.GetType());

        bool esMayorDeEdad;
        if(edad >= 18)
        {
            esMayorDeEdad = true;
        }
        else
        {
            esMayorDeEdad = false;
        }

        char inicial = 'B';

        Console.WriteLine(nombre);
        Console.WriteLine(edad);
        Console.WriteLine(altura);
        Console.WriteLine(ciudad);
        Console.WriteLine(esMayorDeEdad);
        Console.WriteLine(inicial);

        Console.WriteLine($"Me llamo {nombre} y tengo {edad} años");

        //int texto = "para ver un error ";
        //string noPonerNda;
        //Console.WriteLine(noPonerNda);
        
        Console.ReadKey();
    }
}