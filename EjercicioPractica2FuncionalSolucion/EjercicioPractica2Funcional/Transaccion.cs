using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractica2Funcional
{
    public class Transaccion
    {
        public Producto Producto { get; set; }
        public decimal montoPagado { get; set; }
        public decimal Cambio { get; set; }
        public bool Exitoso { get; set; }
        public DateTime FechaHoraTransaccion { get; set; }

    }
}