List<Producto> inventario = new List<Producto>();

inventario.Add(new Producto("Mouse Inalambrico", 8500m, 12));
inventario.Add(new Producto("Teclado Mecanico", 21000m, 5));
inventario.Add(new Producto("Monitor 24 pulgadas", 145000m, 3));
inventario.Add(new Producto("Auriculares Bluetooth", 32000m, 8));

Pedido pedidoActual = new Pedido();

bool ejecutando = true;

while (ejecutando)
{
    Console.WriteLine();
    Console.WriteLine("1. Ver inventario");
    Console.WriteLine("2. Agregar producto al pedido");
    Console.WriteLine("3. Ver resumen del pedido");
    Console.WriteLine("4. Aplicar cupon de descuento");
    Console.WriteLine("5. Confirmar pago");
    Console.WriteLine("6. Vaciar pedido");
    Console.WriteLine("7. Salir");
    Console.Write("Elegi una opcion: ");

    string? entrada = Console.ReadLine();
    int opcion;

    if (!int.TryParse(entrada, out opcion))
    {
        Console.WriteLine("Eso no es un numero valido.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            MostrarInventario(inventario);
            break;

        case 2:
            AgregarAlPedido(inventario, pedidoActual);
            break;

        case 3:
            MostrarResumen(pedidoActual);
            break;

        case 4:
            AplicarCupon(pedidoActual);
            break;

        case 5:
            if (pedidoActual.ObtenerProductos().Count == 0)
            {
                Console.WriteLine("El pedido esta vacio.");
            }
            else if (pedidoActual.Estado == "Completado")
            {
                Console.WriteLine("El pedido ya fue pagado.");
            }
            else
            {
                pedidoActual.ConfirmarPago();
                Console.WriteLine("Pago confirmado. Estado del pedido: " + pedidoActual.Estado);
            }
            break;

        case 6:
            if (pedidoActual.ObtenerProductos().Count == 0)
            {
                Console.WriteLine("El pedido esta vacio.");
            }
            else
            {
                pedidoActual.VaciarPedido();
                Console.WriteLine("El pedido fue vaciado y el stock fue devuelto.");
            }
            break;

        case 7:
            ejecutando = false;
            break;

        default:
            Console.WriteLine("Esa opcion no existe.");
            break;
    }
}

Console.WriteLine("Programa finalizado.");

static void MostrarInventario(List<Producto> inventario)
{
    for (int i = 0; i < inventario.Count; i++)
    {
        Producto producto = inventario[i];

        Console.WriteLine(
            $"{i + 1}. {producto.Nombre} - ${producto.Precio:F2} - Stock: {producto.Stock}"
        );
    }
}

static void AgregarAlPedido(List<Producto> inventario, Pedido pedido)
{
    if (pedido.Estado == "Completado")
    {
        Console.WriteLine("El pedido ya fue pagado.");
        return;
    }

    MostrarInventario(inventario);

    Console.Write("Numero de producto: ");
    string? entradaProducto = Console.ReadLine();
    int indice;

    if (!int.TryParse(entradaProducto, out indice) || indice < 1 || indice > inventario.Count)
    {
        Console.WriteLine("Producto invalido.");
        return;
    }

    Console.Write("Cantidad: ");
    string? entradaCantidad = Console.ReadLine();
    int cantidad;

    if (!int.TryParse(entradaCantidad, out cantidad) || cantidad <= 0)
    {
        Console.WriteLine("Cantidad invalida.");
        return;
    }

    Producto productoElegido = inventario[indice - 1];

    if (pedido.AgregarProducto(productoElegido, cantidad))
    {
        Console.WriteLine("Se agrego " + cantidad + " x " + productoElegido.Nombre);
    }
    else
    {
        Console.WriteLine(
            "No hay stock suficiente de " +
            productoElegido.Nombre +
            ". Quedan " +
            productoElegido.Stock +
            " unidades."
        );
    }
}

static void MostrarResumen(Pedido pedido)
{
    List<Producto> productos = pedido.ObtenerProductos();

    if (productos.Count == 0)
    {
        Console.WriteLine("El pedido esta vacio.");
        return;
    }

    foreach (Producto producto in productos)
    {
        Console.WriteLine($"{producto.Nombre} - ${producto.Precio:F2}");
    }

    decimal total = pedido.CalcularTotal(0.21m);

    Console.WriteLine($"Total con impuesto: ${total:F2}");
    Console.WriteLine("Estado del pedido: " + pedido.Estado);
}

static void AplicarCupon(Pedido pedido)
{
    if (pedido.ObtenerProductos().Count == 0)
    {
        Console.WriteLine("El pedido esta vacio.");
        return;
    }

    if (pedido.Estado == "Completado")
    {
        Console.WriteLine("El pedido ya fue pagado.");
        return;
    }

    Console.Write("Ingresa el codigo del cupon: ");
    string? codigo = Console.ReadLine();

    if (codigo == "DESCUENTO10")
    {
        pedido.AplicarCupon(codigo);
        Console.WriteLine("Cupon aplicado correctamente.");
    }
    else
    {
        Console.WriteLine("El cupon no es valido.");
    }
}