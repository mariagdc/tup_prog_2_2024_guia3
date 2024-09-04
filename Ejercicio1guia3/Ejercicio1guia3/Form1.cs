using Ejercicio1guia3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1guia3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
           
            
            ArrayList muebles = new ArrayList(2);

           string descripcion="Mesa comedor" ;
           double precioBase= 10.1;
           int tipoMaterial= 1;
            int largo = 1;

           
            Mesa mesa = new Mesa(descripcion, precioBase, tipoMaterial, largo);


            string descripcion1 = "Silla";
            double precioBase1 = 12.1;
            int tipoMaterial1 = 2;

            Silla sillita = new Silla (descripcion1, precioBase1, tipoMaterial1);
            muebles.Add(sillita);



            tbxPrueba.Text += $"\r\n{mesa.VerDetalle()}\r\n" +
                $"{sillita.VerDetalle()}\r\n";

        }
    }
}
