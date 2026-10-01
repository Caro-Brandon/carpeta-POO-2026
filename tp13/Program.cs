using System;
using System.Collections.Generic;

class Motor
{
    public int Caballos { get; set; }

    public Motor(int caballos)
    {
        Caballos = caballos;
    }

    public void Encender()
    {
        Console.WriteLine("Motor de " + Caballos + " HP encendido");
    }
}

class Auto
{
    public string Marca { get; set; }
    private Motor motor;

    public Auto(string marca, int caballos)
    {
        Marca = marca;
        motor = new Motor(caballos);
    }

    public void Arrancar()
    {
        Console.WriteLine("Arrancando " + Marca);
        motor.Encender();
    }
}

class CPU
{
    public string Modelo { get; set; }

    public CPU(string modelo)
    {
        Modelo = modelo;
    }
}

class RAM
{
    public int Gigas { get; set; }

    public RAM(int gigas)
    {
        Gigas = gigas;
    }
}

class Computadora
{
    private CPU cpu;
    private RAM ram;

    public Computadora(string modeloCpu, int gigasRam)
    {
        cpu = new CPU(modeloCpu);
        ram = new RAM(gigasRam);
    }

    public void MostrarEspecificaciones()
    {
        Console.WriteLine("CPU: " + cpu.Modelo + " | RAM: " + ram.Gigas + " GB");
    }
}

class Conductor
{
    public string Nombre { get; set; }

    public Conductor(string nombre)
    {
        Nombre = nombre;
    }
}

class Colectivo
{
    public string Linea { get; set; }
    public Conductor Conductor { get; set; }

    public Colectivo(string linea, Conductor conductor)
    {
        Linea = linea;
        Conductor = conductor;
    }
}

class Jugador
{
    public string Nombre { get; set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
    }
}

class Equipo
{
    public string Nombre { get; set; }
    public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

    public Equipo(string nombre)
    {
        Nombre = nombre;
    }

    public void AgregarJugador(Jugador jugador)
    {
        Jugadores.Add(jugador);
    }
}

class Linea
{
    public string Producto { get; set; }
    public double Precio { get; set; }

    public Linea(string producto, double precio)
    {
        Producto = producto;
        Precio = precio;
    }
}

class Factura
{
    public int Numero { get; set; }
    private List<Linea> lineas = new List<Linea>();

    public Factura(int numero)
    {
        Numero = numero;
    }

    public void AgregarLinea(string producto, double precio)
    {
        lineas.Add(new Linea(producto, precio));
    }

    public void Mostrar()
    {
        Console.WriteLine("Factura N° " + Numero);

        double total = 0;

        foreach (Linea linea in lineas)
        {
            Console.WriteLine("- " + linea.Producto + ": $" + linea.Precio);
            total += linea.Precio;
        }

        Console.WriteLine("Total: $" + total);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Ejercicio 1 ---");
        Auto auto = new Auto("Fiat", 90);
        auto.Arrancar();

        Console.WriteLine("\n--- Ejercicio 2 ---");
        Computadora pc = new Computadora("Ryzen 5", 16);
        pc.MostrarEspecificaciones();

        Console.WriteLine("\n--- Ejercicio 3 ---");
        Console.WriteLine("El Motor pertenece al Auto.");

        Console.WriteLine("\n--- Ejercicio 4 ---");
        Conductor juan = new Conductor("Juan");
        Colectivo colectivo60 = new Colectivo("60", juan);
        Console.WriteLine("Colectivo " + colectivo60.Linea + " - " + colectivo60.Conductor.Nombre);

        Console.WriteLine("\n--- Ejercicio 5 ---");
        Conductor maria = new Conductor("Maria");
        Console.WriteLine("Conductor: " + maria.Nombre);

        Console.WriteLine("\n--- Ejercicio 6 ---");
        Colectivo colectivo152 = new Colectivo("152", maria);

        colectivo152.Conductor = juan;
        colectivo60.Conductor = maria;

        Console.WriteLine("60: " + colectivo60.Conductor.Nombre);
        Console.WriteLine("152: " + colectivo152.Conductor.Nombre);

        Console.WriteLine("\n--- Ejercicio 7 ---");
        Equipo equipo = new Equipo("Boca");

        equipo.AgregarJugador(new Jugador("Cavani"));
        equipo.AgregarJugador(new Jugador("Fernandez"));

        Console.WriteLine("Equipo " + equipo.Nombre);

        foreach (Jugador jugador in equipo.Jugadores)
        {
            Console.WriteLine("- " + jugador.Nombre);
        }

        Console.WriteLine("\n--- Ejercicio 8 ---");
        Factura factura = new Factura(1001);

        factura.AgregarLinea("Teclado", 15000);
        factura.AgregarLinea("Mouse", 8000);

        factura.Mostrar();

        Console.WriteLine("\n--- Ejercicio 9 ---");
        Colectivo colectivoSinConductor = new Colectivo("29", null );

        Console.WriteLine(colectivoSinConductor.Conductor?.Nombre ?? "Sin conductor");
        /*
          Ejercicio 10  
             Composicion: el objeto principal crea sus partes y estas dependen de el.
             Por ejemplo, el Auto crea al Motor y la Factura crea sus Lineas.
             Agregacion: los objetos pueden existir por separado y luego relacionarse.
             Por ejemplo, el Conductor existe sin el Colectivo y el Jugador sin el Equipo.
        */
       
    }
}
 