using System;

class CuentaBancaria
{
    private decimal saldo;
    public readonly int IdCuenta;
    private string clave;
    public const decimal IVA = 0.21m;

    public CuentaBancaria(int id)
    {
        IdCuenta = id;
    }

    public void Depositar(decimal monto)
    {
        saldo = saldo + monto;
    }

    public void Retirar(decimal monto)
    {
        if (monto <= saldo)
        {
            saldo = saldo - monto;
            Console.WriteLine("Retiro realizado.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }

    public string Clave
    {
        set
        {
            clave = value;
        }
    }
}

class Temperatura
{
    private double grados;

    public double Grados
    {
        get
        {
            return grados;
        }

        set
        {
            if (value > -273)
            {
                grados = value;
            }
            else
            {
                Console.WriteLine("Temperatura inválida.");
            }
        }
    }
}

class Rectangulo
{
    public int Ancho { get; set; }
    public int Alto { get; set; }

    public int Perimetro
    {
        get
        {
            return 2 * (Ancho + Alto);
        }
    }
}

class Persona
{
    private string nombre;
    private int edad;

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public int Edad
    {
        get
        {
            return edad;
        }

        set
        {
            if (value >= 0 && value <= 150)
            {
                edad = value;
            }
            else
            {
                Console.WriteLine("Edad inválida.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Punto 1---");

        CuentaBancaria cuenta = new CuentaBancaria(1001);
        cuenta.Depositar(5000);
        cuenta.Retirar(1000);

        Console.WriteLine("Saldo: " + cuenta.ObtenerSaldo());

        Console.WriteLine("---Punto 2---");

        Console.WriteLine("El saldo privado no puede accederse directamente");
        //Console.WriteLine(cuenta.saldo);

        Console.WriteLine("---Punto 3---");

        cuenta.Retirar(10000);
 
        Console.WriteLine("---Punto 4---");

        Temperatura temperatura = new Temperatura();

        temperatura.Grados = 25;
        Console.WriteLine(temperatura.Grados);

        temperatura.Grados = -300;

        Console.WriteLine("---Punto 5---");

        Console.WriteLine("IVA: " + CuentaBancaria.IVA);

        Console.WriteLine("---Punto 6---");

        Console.WriteLine("ID de cuenta: " + cuenta.IdCuenta);

        Console.WriteLine("---Punto 7---");

        cuenta.Clave = "123456";
        Console.WriteLine("Clave asignada.");

        Console.WriteLine("---Punto 8---");

        Rectangulo rectangulo = new Rectangulo();

        rectangulo.Ancho = 10;
        rectangulo.Alto = 5;

        Console.WriteLine("Perímetro: " + rectangulo.Perimetro);

        Console.WriteLine("---Punto 9---");

        Persona persona = new Persona();

        persona.Edad = 25;
        Console.WriteLine("Edad: " + persona.Edad);

        persona.Edad = 200;

        Console.WriteLine("---Punto 10---");

        persona.Nombre = "Brandon";
        persona.Edad = 17;

        Console.WriteLine("Nombre: " + persona.Nombre);
        Console.WriteLine("Edad: " + persona.Edad);
    }
}