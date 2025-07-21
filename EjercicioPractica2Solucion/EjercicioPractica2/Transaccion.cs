using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractica2
{
    public class Transaccion
    {
        public DateTime Fecha { get; }
        public Producto Producto { get; }
        public decimal PrecioPagado { get; }

        public Transaccion(Producto producto, decimal precioPagado)
        {
            Fecha = DateTime.Now;
            Producto = producto;
            PrecioPagado = precioPagado;
        }
    }

}