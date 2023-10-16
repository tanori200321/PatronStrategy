using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    public class CarritoCompra
    {
        private IFormaPago _formaPago;

        public void SeleccionarFormaPago(IFormaPago formaPago)
        {
            _formaPago = formaPago;
        }

        public void RealizarPago(double cantidad)
        {
            _formaPago.ProcesarPago(cantidad);
        }
    }

}
