using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractica2
{
    public class Monedero
    {
        public decimal Saldo { get; private set; }

        public void Insertar(decimal cantidad)
        {
            if (cantidad <= 0) throw new ArgumentException("La cantidad debe ser positiva.");
            Saldo += cantidad;
        }

        public bool PuedePagar(decimal monto) => Saldo >= monto;

        public void Descontar(decimal monto)
        {
            if (!PuedePagar(monto))
                throw new InvalidOperationException("Saldo insuficiente.");
            Saldo -= monto;
        }

        public decimal DevolverCambio()
        {
            var cambio = Saldo;
            Saldo = 0;
            return cambio;
        }
    }

}