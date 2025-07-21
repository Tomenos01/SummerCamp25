using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractica2
{
    public class VendingMachine
    {
        private List<Slot> _slots = new();
        private List<Transaccion> _transacciones = new();
        private Monedero _monedero = new();

        public IReadOnlyList<Slot> Slots => _slots;
        public decimal SaldoDisponible => _monedero.Saldo;

        public void AgregarSlot(Slot slot)
        {
            _slots.Add(slot);
        }

        public void InsertarDinero(decimal cantidad)
        {
            _monedero.Insertar(cantidad);
        }

        public void ComprarProducto(int numeroSlot)
        {
            var slot = _slots.FirstOrDefault(s => s.Numero == numeroSlot);
            if (slot == null) throw new InvalidOperationException("Slot no encontrado.");
            if (!slot.HayStock()) throw new InvalidOperationException("Producto agotado.");
            if (!_monedero.PuedePagar(slot.Producto.Precio))
                throw new InvalidOperationException("Saldo insuficiente.");

            _monedero.Descontar(slot.Producto.Precio);
            slot.Dispensar();
            _transacciones.Add(new Transaccion(slot.Producto, slot.Producto.Precio));
        }

        public decimal DevolverCambio()
        {
            return _monedero.DevolverCambio();
        }

        public IReadOnlyList<Transaccion> ObtenerHistorial() => _transacciones.AsReadOnly();
    }

}