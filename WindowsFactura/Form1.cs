using LibFactura.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Producto producto1 = new Producto() { NombreProducto = "Cuadro de Mona Lisa" };
            Producto producto2 = new Producto() { NombreProducto = "Escultura El Pensador" };
            List<Producto> productos = new List<Producto>() { producto1, producto2 };

            Categoria pintura = new Categoria() { CategoriaProducto = "Pintura" };
            producto1.Categoria = pintura;
            Categoria escultura = new Categoria() { CategoriaProducto = "Escultura" };
            producto2.Categoria = escultura;

            Cliente cliente1 = new Cliente(1, "San Jose 133", "Juan", "Perez", 34526302);
            Usuario usuario = new Usuario("pepe24", "68754sdr", "Jose", "Ramirez", 59452325);
            Empleado empleado = new Empleado(5, "Gerente", "Luz", "Gonzales", 14785693);
            Factura factura = new Factura("Accenture");

            empleado.Facturas = new List<Factura> { factura };
            cliente1.Facturas = new List<Factura> { factura };

            DetalleFactura detalleFactura = new DetalleFactura() { Descripcion = "Compra en efectivo"};
            factura.DetalleFacturas = new List<DetalleFactura> { detalleFactura };

            producto1.DetalleFactura = detalleFactura;
            producto2.DetalleFactura = detalleFactura;

            txtProd1.Text = $"Producto 1: {producto1.NombreProducto}, Detalle de factura: {producto1.DetalleFactura},  Categoria: {producto1.Categoria} ";

            txtProd2.Text = $"Producto 2: {producto2.NombreProducto}, Detalle de factura: {producto2.DetalleFactura},  Categoria: {producto2.Categoria} ";

        }

       
    }
}
