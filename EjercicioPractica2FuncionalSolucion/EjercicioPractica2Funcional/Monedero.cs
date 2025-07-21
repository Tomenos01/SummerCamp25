using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractica2Funcional
{
    public class Monedero
    {
        public decimal Saldo { get; private set; }
        public int MonedaTipoEuro { get; set; } // Moneda de 1 Euro
        publit int MonedaTipoCincuentaCentimos { get; set; } // Moneda de 0.50 Euros

    }

    public class Moneda
    {
        public int Valor { get; set; }


    }
}