using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1guia3.Models
{
    abstract class Producto
    {
        public string descripcion;
        protected double precioBase { get; set; }
        protected int tipoMaterial { get; set; }



        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }
        abstract public double CalcularPrecio();

        public virtual string VerDetalle()
        {
            {
                string material = "NN";
                if (tipoMaterial == 0)
                    material = "Pino";
                else if (tipoMaterial == 1)
                    material = "Algarrobo";
                else if (tipoMaterial == 2)
                    material = "Caoba";

                return $"{descripcion,15}{material,10}{precioBase,10:f2}";
            }

        }
    }

}
