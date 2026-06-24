 ﻿using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("---ejercicio 21-----");
      int num1 = 10;
      int num2 = 5;
      
      int resto1 = num1 % 2;
      int resto2 = num2 % 2;
      
      if(resto1 == 0){
        Console.WriteLine("El numero1 es par");
        }
        else
        {
           Console.WriteLine("El numero1 es impar");
        }

      if(resto2 == 0){
        Console.WriteLine("El numero2 es par");
        }
        else
        {
           Console.WriteLine("El numero2 es impar");
        }

    Console.WriteLine("---ejercicio 22-----");
     int num3 = 12;
       if(num3 > 0)
        {
        Console.WriteLine("El numero: " + num3 + " es positivo");
        }
        else if(num3 < 0)
        {
        Console.WriteLine("El numero: " + num3 + " es negativo");
        }
        else
        {
            Console.WriteLine("El numero es cero");
        }

    Console.WriteLine("---ejercicio 23-----");
      int edad = 17;
        if(edad >= 18)
            {
            Console.WriteLine("Sos mayor de edad");
            }
            else
            {
            Console.WriteLine("Sos menor de edad");      
            }

    Console.WriteLine("---ejercicio 24-----");
     int numero = 100;
     if(numero >= 1 && numero <= 1000)
        {
        Console.WriteLine("El numero esta entre el 1 y el 1000");    
        }
        else
        {
        Console.WriteLine("El numero no esta entre el 1 y el 1000");
        }
    
    Console.WriteLine("---ejercicio 25-----");
     string dia = "sabado";
       if(dia == "sabado" || dia == "domingo")
        {
            Console.WriteLine("El dia cae fin de semana");
        }
        else
        {
           Console.WriteLine("El dia no cae fin de semana");    
        }
     


    Console.WriteLine("---ejercicio 26-----");
     int edad1 = 17;
     string mayoriaDeEdad = edad1 >= 18 ? "Es mayor de edad" : "Es menor de edad"; 
     Console.WriteLine("La edad es: " + mayoriaDeEdad);

    Console.WriteLine("---ejercicio 27-----");
     string dia1 = "sabado";
     switch ( dia1 )
        {
        case "lunes" :
             Console.WriteLine("Es el dia lunes"); 
             break;

        case "martes" :
             Console.WriteLine("Es el dia martes"); 
             break;
        
        case "miercoles" :
             Console.WriteLine("Es el dia miercoles"); 
             break;
        
        case "jueves" :
             Console.WriteLine("Es el dia jueves"); 
             break;

        case "viernes" :
             Console.WriteLine("Es el dia viernes"); 
             break;

        case "sabado" :
             Console.WriteLine("Es el dia sabado"); 
             break;

        case "domingo" :
             Console.WriteLine("Es el dia domingo"); 
             break;
        default: Console.WriteLine("nse q dia pusiste ._.");
             break;
        }

    Console.WriteLine("---ejercicio 28-----"); 
      int nombreProducto = 2;
      string listaProducto = nombreProducto switch {
          1 => "shampo", 2 => "doritos", 3 => "jabon", _ => "otro producto.."
      };
      Console.WriteLine("El producto es: " + listaProducto);

    Console.WriteLine("---ejercicio 29-----"); 
    int edad29 = 29;
    bool licencia = true;

        if (edad29 >= 18)
        {
            if (licencia)
            {
                Console.WriteLine("es mayor de edad y tiene licencia");
            }
            else
            {
            Console.WriteLine("Es mayor de edad pero no tiene licencia");
            }
        }
             
        else
        {
            Console.WriteLine("Es menor de edad y no tiene licencia");
        }
     
    }
}