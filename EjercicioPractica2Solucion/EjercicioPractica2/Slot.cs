using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractica2
{
    public class Slot
    {
        public int Numero { get; }
        public Producto Producto { get; }
        public int Cantidad { get; private set; }

        public Slot(int numero, Producto producto, int cantidadInicial)
        {
            Numero = numero;
            Producto = producto;
            Cantidad = cantidadInicial;
        }

        public bool HayStock() => Cantidad > 0;

        public void Dispensar()
        {
            if (!HayStock())
                throw new InvalidOperationException("No queda stock en este slot.");
            Cantidad--;
        }

        public void Reponer(int cantidad) => Cantidad += cantidad;
    }

}