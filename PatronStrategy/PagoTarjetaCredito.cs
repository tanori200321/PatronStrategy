using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    public class PagoTarjetaCredito : IFormaPago
    {
        public void ProcesarPago(double cantidad)
        {
            Console.WriteLine($"Pago de {cantidad} realizado con tarjeta de crédito.");
        }

    }
}
