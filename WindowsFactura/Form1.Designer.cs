namespace WindowsFactura
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProd1 = new System.Windows.Forms.TextBox();
            this.txtProd2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProd1
            // 
            this.txtProd1.Location = new System.Drawing.Point(263, 128);
            this.txtProd1.Multiline = true;
            this.txtProd1.Name = "txtProd1";
            this.txtProd1.ReadOnly = true;
            this.txtProd1.Size = new System.Drawing.Size(280, 65);
            this.txtProd1.TabIndex = 0;
            // 
            // txtProd2
            // 
            this.txtProd2.Location = new System.Drawing.Point(263, 280);
            this.txtProd2.Multiline = true;
            this.txtProd2.Name = "txtProd2";
            this.txtProd2.ReadOnly = true;
            this.txtProd2.Size = new System.Drawing.Size(280, 55);
            this.txtProd2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProd2);
            this.Controls.Add(this.txtProd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProd1;
        private System.Windows.Forms.TextBox txtProd2;
    }
}