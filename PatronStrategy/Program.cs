using PatronStrategy;

class Program
{
    static void Main(string[] args)
    {
        CarritoCompra carrito = new CarritoCompra();

        carrito.SeleccionarFormaPago(new PagoTarjetaCredito());
        carrito.RealizarPago(100.50);

        carrito.SeleccionarFormaPago(new PagoPayPal());
        carrito.RealizarPago(55.25);

        carrito.SeleccionarFormaPago(new PagoEfectivo());
        carrito.RealizarPago(30.00);
    }
}