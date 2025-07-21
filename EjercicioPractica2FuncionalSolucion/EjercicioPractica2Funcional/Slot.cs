using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractica2Funcional
{
    public class Slot
    {
        public String Identificador { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; } //Cuantos hay ahora
        public int Capacidad { get; set; } //Cuantos caben en el slot
        public DateTime UltimaReposicion { get; set; } // Ultima fecha de reposición
        public int stockMinimo { get; set; } // Stock mínimo para considerar que se debe reponer

        //Método para reponer el producto
        public void Reponer(int cantidad)
        {
            if (Cantidad + cantidad <= Capacidad)
            {
                Cantidad += cantidad;
                UltimaReposicion = DateTime.Now;
            }
            else
            {
            //    throw new InvalidOperationException("No se puede reponer más allá de la capacidad del slot.");
            }
        }

        // Establecer el producto en el slot
        public void EstablecerProducto(Producto producto)
        {
            Producto = producto;
            Cantidad = 0; // Inicialmente no hay productos en el slot
            UltimaReposicion = DateTime.Now; // Fecha de reposición inicial
        }

        //Establecer si el slot necesita reposición
        public bool NecesitaReposicion()
        {
            return Cantidad < stockMinimo;
        }

        //Retirar un producto del slot
        public bool RetirarProducto()
        {
            if (Cantidad > 0)
            {
                Cantidad--;
                return true; // Producto retirado exitosamente
            }
            else
            {
                return false; // No hay productos para retirar
            }
        }

        //si existe el producto en el slot, retorna true
        public bool ContieneProducto(string nombreProducto)
        {
            return Producto != null && Producto.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase);
        }

        //vaciar slot  
        public void Vaciar()
        {
            Cantidad = 0;
            Producto = null; // Eliminar el producto del slot
            UltimaReposicion = DateTime.MinValue; // Reiniciar la fecha de reposición
        }


    }
}