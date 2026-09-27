public class Pedido
{
    private List<Producto> productosPedido = new List<Producto>();

    public string Estado { get; private set; } = "Pendiente";

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

        return subtotal + (subtotal * impuesto);
    }

    public void ConfirmarPago()
    {
        Estado = "Completado";
    }

    public List<Producto> ObtenerProductos()
    {
        return productosPedido;
    }
}