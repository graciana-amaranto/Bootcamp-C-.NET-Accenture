using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Modelos;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto("Pan", "Pan frances", (decimal)450.90, 0.2, 0.21, "Panaderia Filg", "Panificados", "Panes");

            MessageBox.Show($"Nombre producto: {producto.Nombre}" +
                $"\nDescripcion: {producto.Descripcion} " +
                $"\nPrecio costo: {producto.PrecioCosto}" +
                $"\nMargen: {producto.Margen}" +
                $"\nIva: {producto.IVA}" +
                $"\nProveedor: {producto.Proveedor}" +
                $"\nCategoria: {producto.Categoria}" +
                $"\nSubcategoria: {producto.SubCategoria}" +
                $"\nPrecio Bruto: {producto.PrecioBruto}" +
                $"\nSubcategoria:  {producto.PrecioVenta}");
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa("Panaderia Filg", "74129323842", "Marcos Perez", "panaderiafilg@gmail.com","45678123", "Avenida de Mayo 2245");

            MessageBox.Show($"Nombre: {empresa.Nombre}" +
               $"\nCuit: {empresa.CUIT} " +
               $"\nContacto: {empresa.Contacto}" +
               $"\nEmail: {empresa.Email}" +
               $"\nTeléfono: {empresa.Telefono}" +
               $"\nDirección: {empresa.Direccion}");
              
        }

        private void btnIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo("Luis", "Criz","54832948324","luizcriz345@gmail.com","1156567438","Avenida de Mayo 1100");

            MessageBox.Show($"Nombre: {clienteIndividuo.Nombre}" +
               $"\nApellido: {clienteIndividuo.Apellido} " +
               $"\nCuit: {clienteIndividuo.CUIT}" +
               $"\nEmail: {clienteIndividuo.Email}" +
               $"\nTeléfono: {clienteIndividuo.Telefono}" +
               $"\nDirección: {clienteIndividuo.Direccion}");
        }

     

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor("Melisa","Riera", "35765921","melisariera3@gmail.com","1165782352","Avenida Rivadavia 4556");

            MessageBox.Show($"Nombre: {vendedor.Nombre}" +
               $"\nApellido: {vendedor.Apellido} " +
               $"\nDNI: {vendedor.DNI}" +
               $"\nEmail: {vendedor.Email}" +
               $"\nTeléfono: {vendedor.Telefono}" +
               $"\nDirección: {vendedor.Direccion}");
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura("A", "234234242", new DateTime(2023, 1, 20, 12, 15, 00), "Marcos Perez", "Avenida de Mayo 2245", "0.21", "0.2", "Venta Panificado", (decimal)5094.32);

            MessageBox.Show($"Tipo de Factura:  {factura.Tipo}" +
              $"\nNúmero: {factura.Numero} " +
              $"\nFecha de la factura: {factura.Fecha}" +
              $"\nCliente: {factura.Cliente}" +
              $"\nDirección: {factura.Direccion}" +
              $"\nIva: {factura.CondicionIva}" +
              $"\nCondición Venta: {factura.CondicionVenta}" +
              $"\nDetalle: {factura.Detalle}" +
              $"\nTotal: {factura.Total}");
        }

        private void btnRemito_Click(object sender, EventArgs e)
        {
            Remito remito = new Remito("234234242", new DateTime(2023, 1, 20, 12, 15, 00), "Marcos Perez", "Avenida de Mayo 2245", "0.21", "0.2", "Venta Panificado", new DateTime(2023, 1, 24, 17, 15, 00), (decimal)5094.32);

            MessageBox.Show( $"\nNumero: {remito.Numero} " +
             $"\nFecha: {remito.Fecha}" +
             $"\nCliente: {remito.Cliente}" +
             $"\nDirección: {remito.Direccion}" +
             $"\nCondición IVA: {remito.CondicionIva}" +
             $"\nCondición Venta: {remito.CondicionVenta}" +
             $"\nDetalle: {remito.Detalle}" +
             $"\nFecha de Entrega: {remito.FechaEntrega}" +
             $"\nTotal: {remito.Total}");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
