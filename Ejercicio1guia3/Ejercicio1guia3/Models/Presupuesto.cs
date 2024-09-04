using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1guia3.Models
{
    internal class Presupuesto
    {
        public int CantidadProductos {  get; private set; }
        public double CostoTotal { get; private set; }

        public string Cliente {  get; set; }
        public string Direccion {  get; set; }


        public Presupuesto(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;

        }

        public  AgregarProducto(Producto)
        {

        }

        public int VerProducto(int idx)
        {
            return idx;
        }
    }
}
