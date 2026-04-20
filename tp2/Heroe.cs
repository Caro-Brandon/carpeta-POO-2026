using System;
using System.Collections.Generic;

public abstract class Heroe 
{
    public string Nombre { get; set; } 
    protected int puntosVida; 
    
    public int PuntosVida
    {
        get { return puntosVida; }
        set
        {
            if(value < 0)
                puntosVida = 0;
            else
                puntosVida = value;
        }
    }

    public Heroe(string nombre, int vida)
    {
        Nombre = nombre;
        puntosVida = vida;
    }

    public abstract void Atacar();
}

public class Guerrero : Heroe
{
    private int fuerza;

    public int Fuerza
    {
        get { return fuerza; }
        set
        {
            if(value < 0)
                fuerza = 0;
            else
                fuerza = value;
        }
    }

    public Guerrero(string nombre, int vida, int fuerza) : base(nombre, vida)
    {
        Fuerza = fuerza;
    }

    public override void Atacar()
    {
        Console.WriteLine("El guerrero ataca usando " + fuerza + " de poder");
    }
}

public class Mago : Heroe
{
    public Mago(string nombre, int vida) : base(nombre, vida){}

    public override void Atacar()
    {
        Console.WriteLine("El mago lanza un hechizo");
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        List<Heroe> heroes = new List<Heroe>();

        heroes.Add(new Guerrero("Arturo", 100, 50));
        heroes.Add(new Mago("Damian", 80));

        foreach (Heroe h in heroes)
        {
            h.Atacar();
        }

        Console.ReadKey();
    }
}