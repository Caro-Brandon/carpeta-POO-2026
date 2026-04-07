using System;

public class Auto
{
    public string Marca { get ; set ; }
    public string Modelo{get;set;}
    public string Color{get;set;}


   public Auto(string marca ,string modelo, string color)
        {
        Marca = marca;   
        Modelo = modelo;    
        Color = color;  
        } 

    public void Encender()
    {
        Console.WriteLine("El " + Marca +" " + Modelo + " de color " + Color + " esta encendido.");
    }

    public void Acelerar()
    {
        Console.WriteLine("El" + Marca + " " + Modelo + " esta acelerado.");
    }   
        
}

class Program
    {
        static void  Main(string[] args)
        {
           //.2 Creacion de objetos(instancias)
           Auto auto1 = new Auto("Toyota" , "Corolla" , "Rojo"); 
           Auto auto2 = new Auto("Ford" , "Mustang" , "Negro"); 

           //3 uso de los objetos
           auto1.Encender();
           auto1.Acelerar();

           Console.WriteLine("----------------------");

           auto2.Encender();
           auto2.Acelerar();
           Console.ReadKey();
        }
    }