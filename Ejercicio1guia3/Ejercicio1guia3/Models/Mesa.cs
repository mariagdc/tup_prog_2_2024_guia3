using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1guia3.Models
{
    internal class Mesa : Producto
    {
        private double Largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo) : base(descripcion, precioBase, tipoMaterial)
        {
            this.Largo = largo;
        }


        public override double CalcularPrecio()
        {
            return (precioBase * Largo) * (1 + tipoMaterial * 0.33);
        }

        public override string VerDetalle()
        {
           // string tipoProducto = $"Mesa({Largo:f1})";
            return $"{base.VerDetalle()}{tipoMaterial}{CalcularPrecio(),10:f2}";

        }
    }
}
