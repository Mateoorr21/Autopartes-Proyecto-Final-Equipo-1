namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class InventarioProductos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(787, 450);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(167, 18);
            this.LblCantidadRegistros.TabIndex = 83;
            this.LblCantidadRegistros.Text = "Cantidad de Productos: ";
            // 
            // LvProductos
            // 
            this.LvProductos.HideSelection = false;
            this.LvProductos.Location = new System.Drawing.Point(40, 62);
            this.LvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(939, 381);
            this.LvProductos.TabIndex = 76;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(314, 19);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(385, 29);
            this.LblTitulo.TabIndex = 75;
            this.LblTitulo.Text = "Inventario Tienda de Autopartes";
            // 
            // InventarioProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LvProductos);
            this.Controls.Add(this.LblTitulo);
            this.Name = "InventarioProductos";
            this.Size = new System.Drawing.Size(1021, 490);
            this.Load += new System.EventHandler(this.InventarioProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.Label LblTitulo;
    }
}
