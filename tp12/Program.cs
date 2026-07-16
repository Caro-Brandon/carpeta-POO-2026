using System;

class Rectangulo
{
    public int Ancho;
    public int Alto;

    public Rectangulo() : this(1)
    { 
    }

    public Rectangulo(int ancho) : this(ancho, 1)
    {
    }

    public Rectangulo(int ancho, int alto)
    {
        Ancho = ancho;
        Alto = alto;
    }
}

class Persona
{
    private static int contador = 1;

    public int Id;
    public string Nombre;

    public Persona()
    {
        Id = contador;
        contador++;
    }
}

class Fraccion
{
    public int Numerador;
    public int Denominador;

    public Fraccion(int num, int den)
    {
        Numerador = num;

        if (den != 0)
        {
            Denominador = den;
        }
        else
        {
            Denominador = 1;
            Console.WriteLine("El denominador no puede ser 0.");
        }
    }

    public Fraccion(int num)
    {
        Numerador = num;
        Denominador = 1;
    }
}

class Alumno
{
    public string Nombre;

    public Alumno(string Nombre)
    {
        this.Nombre = Nombre;
    }
}

class Jugador
{
    public int X;
    public int Y;

    public Jugador Mover(int x, int y)
    {
        X = X + x;
        Y = Y + y;

        Console.WriteLine("Jugador movido.");

        return this;
    }

    public Jugador Atacar()
    {
        Console.WriteLine("Jugador atacó.");

        return this;
    }
}

class Singleton
{
    private static Singleton instancia = new Singleton();

    private Singleton()
    {
    }

    public static Singleton ObtenerInstancia()
    {
        return instancia;
    }
}

class Config
{
    public string Idioma;
    public string Tema;

    public Config()
    {
        Idioma = "Español";
        Tema = "Claro";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Punto 1---");

        Rectangulo r1 = new Rectangulo();
        Rectangulo r2 = new Rectangulo(5);
        Rectangulo r3 = new Rectangulo(5, 10);

        Console.WriteLine(r1.Ancho + " " + r1.Alto);
        Console.WriteLine(r2.Ancho + " " + r2.Alto);
        Console.WriteLine(r3.Ancho + " " + r3.Alto);

        Console.WriteLine("---Punto 2---");

        Persona p1 = new Persona();
        Persona p2 = new Persona();

        Console.WriteLine("ID Persona 1: " + p1.Id);
        Console.WriteLine("ID Persona 2: " + p2.Id);

        Console.WriteLine("---Punto 3---");

        Persona p3 = new Persona { Nombre = "Ana" };

        Console.WriteLine("Nombre: " + p3.Nombre);
        Console.WriteLine("ID: " + p3.Id);

        Console.WriteLine("---Punto 4---");

        Fraccion f1 = new Fraccion(3, 4);

        Console.WriteLine(f1.Numerador + "/" + f1.Denominador);

        Fraccion f2 = new Fraccion(5, 0);

        Console.WriteLine(f2.Numerador + "/" + f2.Denominador);

        Console.WriteLine("---Punto 5---");

        Fraccion f3 = new Fraccion(8);

        Console.WriteLine(f3.Numerador + "/" + f3.Denominador);

        Console.WriteLine("---Punto 6---");

        Console.WriteLine("Si una clase no tiene constructores, C# crea uno vacio automaticamente.");
        Console.WriteLine("Si tiene al menos uno, ya no crea el constructor vacío.");

        Console.WriteLine("---Punto 7---");

        Alumno alumno = new Alumno("Brandon");

        Console.WriteLine(alumno.Nombre);

        Console.WriteLine("---Punto 8---");

        Jugador jugador = new Jugador();

        jugador.Mover(1, 0).Atacar();

        Console.WriteLine("---Punto 9---");

        Singleton s = Singleton.ObtenerInstancia();

        Console.WriteLine("Singleton creado.");

        Console.WriteLine("---Punto 10---");

        Config config = new Config();

        Console.WriteLine("Idioma: " + config.Idioma);
        Console.WriteLine("Tema: " + config.Tema);
    }
}
