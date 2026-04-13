using System;
public class Heroe 
{
    public string Nombre { get ; set ; } 
    private int puntosVida; 
    
    public int PuntosVida
    {
        get { return  puntosVida; }
        set
        {
            if(value < 0)
            {
                puntosVida = 0;
            }
            else
            {
                puntosVida = value;
            }
        }
    }

    public Heroe(string nombre, int vida)
    {
        Nombre = nombre;
        puntosVida = vida;
    }
     public void Mostrar()
    {
        Console.WriteLine("Héroe: " + Nombre + " - Vida: " + PuntosVida);
    }

}

class Program 
{
    static void Main(string[] args) 
    {
        Heroe miHeroe = new Heroe("Arturo", 100);  
        
        miHeroe.PuntosVida = -500;  

        miHeroe.Mostrar();

        Console.ReadKey();
    }

}

