﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy
{
    public interface IFormaPago
    {
        void ProcesarPago(double cantidad);

    }
}
