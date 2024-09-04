using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1guia3.Models
{
    internal class Silla : Producto
    {

        public Silla(string descripcion, double precioBase, int tipoMaterial) : base(descripcion, precioBase, tipoMaterial)
        {

        }

    }
    public override double CalcularPrecio()
    {
        return precioBase * (1 + tipoMaterial * 0.25);
    }


    public override string VerDetalle()

    {
        string tipoProducto = $"Mesa({largo:f1})";
        return $"{base.VerDetalle(),15}{tipoProducto,15}{CalcularPrecio(),10:f2}";

    }
}
