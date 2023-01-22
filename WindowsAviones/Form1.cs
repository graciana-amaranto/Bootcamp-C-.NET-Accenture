using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAviones.Entidades;

namespace WindowsAviones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarAvion_Click(object sender, EventArgs e)
        {
            AvionComercial avion = new AvionComercial
            {
                Piloto = "Jorge Pereya",
                Copiloto = "Luis Rojas",
                Capacidad = 300,
                LineaAerea = "Air Europa"
            };
            avion.Despegar();
            avion.Aterrizar();

            avion.ToString();

        }
    }
}
