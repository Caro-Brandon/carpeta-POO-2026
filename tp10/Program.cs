using System;

class Persona
{
    public string Nombre;
    public int Edad;

    public void Presentarse()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
    }

    public bool EsMayor()
    {
        if (Edad >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Rectangulo
{
    public int Ancho;
    public int Alto;

    public int Area()
    {
        return Ancho * Alto;
    }

    public int Perimetro()
    {
        return (Ancho * 2) + (Alto * 2);
    }
}

class Auto
{
    public string Marca;
    public string Modelo;
    public int Año;

    public void Descripcion()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Año: " + Año);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Punto 1---");

        Persona persona1 = new Persona();
        persona1.Nombre = "Brandon";
        persona1.Edad = 17;

        Persona persona2 = new Persona();
        persona2.Nombre = "Juan";
        persona2.Edad = 25;

        Console.WriteLine("Se crearon dos objetos Persona");

        Console.WriteLine("---Punto 2---");

        persona1.Presentarse();
        Console.WriteLine();
        persona2.Presentarse();

        Console.WriteLine("---Punto 3---");

        Console.WriteLine(persona1.Nombre + " es mayor de edad: " + persona1.EsMayor());
        Console.WriteLine(persona2.Nombre + " es mayor de edad: " + persona2.EsMayor());

        Console.WriteLine("---Punto 4---");

        Rectangulo rectangulo = new Rectangulo();
        rectangulo.Ancho = 5;
        rectangulo.Alto = 8;

        Console.WriteLine("Rectángulo creado");

        Console.WriteLine("---Punto 5---");

        Console.WriteLine("Área: " + rectangulo.Area());
        Console.WriteLine("Perímetro: " + rectangulo.Perimetro());

        Console.WriteLine("---Punto 6---");

        Auto auto1 = new Auto();
        auto1.Marca = "Ford";
        auto1.Modelo = "Focus";
        auto1.Año = 2018;

        Console.WriteLine("Clase Auto creada");

        Console.WriteLine("---Punto 7---");

        Auto auto2 = new Auto();
        auto2.Marca = "Toyota";
        auto2.Modelo = "Corolla";
        auto2.Año = 2020;

        Auto auto3 = new Auto();
        auto3.Marca = "Chevrolet";
        auto3.Modelo = "Cruze";
        auto3.Año = 2022;

        Console.WriteLine("Tres autos creados");

        Console.WriteLine("---Punto 8---");

        auto1.Modelo = "Fiesta";

        Console.WriteLine("Auto 1: " + auto1.Modelo);
        Console.WriteLine("Auto 2: " + auto2.Modelo);
        Console.WriteLine("Auto 3: " + auto3.Modelo);

        Console.WriteLine("Cada objeto tiene su propia copia de los datos");

        Console.WriteLine("---Punto 9---");

        auto1.Descripcion();
        Console.WriteLine();

        auto2.Descripcion();
        Console.WriteLine();

        auto3.Descripcion();

        Console.WriteLine("---Punto 10---");

        Persona[] personas = new Persona[3];

        personas[0] = new Persona();
        personas[0].Nombre = "Ana";
        personas[0].Edad = 20;

        personas[1] = new Persona();
        personas[1].Nombre = "Luis";
        personas[1].Edad = 15;

        personas[2] = new Persona();
        personas[2].Nombre = "María";
        personas[2].Edad = 30;

        foreach (Persona p in personas)
        {
            p.Presentarse();
            Console.WriteLine();
        }
    }
}