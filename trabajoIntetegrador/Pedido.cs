public class Pedido
{
    private List<Producto> productosPedido = new List<Producto>();

    public string Estado { get; private set; } = "Pendiente";

    private bool cuponAplicado = false;

    public bool AgregarProducto(Producto producto, int cantidad)
    {
        if (producto.DescontarStock(cantidad))
        {
            for (int i = 0; i < cantidad; i++)
            {
                productosPedido.Add(producto);
            }

            return true;
        }

        return false;
    }

    public decimal CalcularTotal(decimal impuesto)
    {
        decimal subtotal = 0;

        foreach (Producto producto in productosPedido)
        {
            subtotal = subtotal + producto.Precio;
        }

        decimal total = subtotal + (subtotal * impuesto);

        if (cuponAplicado)
        {
            total = total - (total * 0.10m);
        }

        return total;
    }

    public void AplicarCupon(string codigo)
    {
        if (codigo == "DESCUENTO10")
        {
            cuponAplicado = true;
        }
    }

    public void ConfirmarPago()
    {
        Estado = "Completado";
    }

    public void VaciarPedido()
    {
        foreach (Producto producto in productosPedido)
        {
            producto.DevolverStock(1);
        }

        productosPedido.Clear();
    }

    public List<Producto> ObtenerProductos()
    {
        return productosPedido;
    }
}