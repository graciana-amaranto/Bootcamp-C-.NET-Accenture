namespace WindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnIndividuo = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnRemito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(38, 36);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(198, 32);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(291, 36);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(198, 32);
            this.btnProveedor.TabIndex = 1;
            this.btnProveedor.Text = "Empresa";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnIndividuo
            // 
            this.btnIndividuo.Location = new System.Drawing.Point(38, 112);
            this.btnIndividuo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIndividuo.Name = "btnIndividuo";
            this.btnIndividuo.Size = new System.Drawing.Size(198, 32);
            this.btnIndividuo.TabIndex = 2;
            this.btnIndividuo.Text = "Cliente Individuo";
            this.btnIndividuo.UseVisualStyleBackColor = true;
            this.btnIndividuo.Click += new System.EventHandler(this.btnIndividuo_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(291, 112);
            this.btnVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(198, 32);
            this.btnVendedor.TabIndex = 4;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(38, 184);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(198, 32);
            this.btnFactura.TabIndex = 5;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnRemito
            // 
            this.btnRemito.Location = new System.Drawing.Point(291, 184);
            this.btnRemito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemito.Name = "btnRemito";
            this.btnRemito.Size = new System.Drawing.Size(198, 32);
            this.btnRemito.TabIndex = 6;
            this.btnRemito.Text = "Remito";
            this.btnRemito.UseVisualStyleBackColor = true;
            this.btnRemito.Click += new System.EventHandler(this.btnRemito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnRemito);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.btnIndividuo);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnProducto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnIndividuo;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnRemito;
    }
}

