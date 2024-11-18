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
            this.GpBAgregrarInventario = new System.Windows.Forms.GroupBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.LblErrorCantidad = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.BtnAgregarInventario = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GpBAgregrarInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(590, 446);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(167, 18);
            this.LblCantidadRegistros.TabIndex = 83;
            this.LblCantidadRegistros.Tag = "Cantidad de Productos: ";
            this.LblCantidadRegistros.Text = "Cantidad de Productos: ";
            // 
            // LvProductos
            // 
            this.LvProductos.HideSelection = false;
            this.LvProductos.Location = new System.Drawing.Point(26, 63);
            this.LvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(731, 379);
            this.LvProductos.TabIndex = 76;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvProductos_ColumnClick);
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(291, 19);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(385, 29);
            this.LblTitulo.TabIndex = 75;
            this.LblTitulo.Text = "Inventario Tienda de Autopartes";
            // 
            // GpBAgregrarInventario
            // 
            this.GpBAgregrarInventario.Controls.Add(this.BtnCancelar);
            this.GpBAgregrarInventario.Controls.Add(this.BtnAgregarInventario);
            this.GpBAgregrarInventario.Controls.Add(this.TxtProducto);
            this.GpBAgregrarInventario.Controls.Add(this.LblCantidad);
            this.GpBAgregrarInventario.Controls.Add(this.label3);
            this.GpBAgregrarInventario.Controls.Add(this.BtnMenos);
            this.GpBAgregrarInventario.Controls.Add(this.BtnMas);
            this.GpBAgregrarInventario.Controls.Add(this.LblErrorCantidad);
            this.GpBAgregrarInventario.Controls.Add(this.Txt_Cantidad);
            this.GpBAgregrarInventario.Location = new System.Drawing.Point(764, 63);
            this.GpBAgregrarInventario.Name = "GpBAgregrarInventario";
            this.GpBAgregrarInventario.Size = new System.Drawing.Size(238, 379);
            this.GpBAgregrarInventario.TabIndex = 123;
            this.GpBAgregrarInventario.TabStop = false;
            this.GpBAgregrarInventario.Text = "Agregar Inventario";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(9, 97);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(127, 16);
            this.LblCantidad.TabIndex = 120;
            this.LblCantidad.Text = "Cantidad a Agregar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 121;
            this.label3.Text = "Producto a Vender:";
            // 
            // BtnMenos
            // 
            this.BtnMenos.Enabled = false;
            this.BtnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos.Location = new System.Drawing.Point(12, 155);
            this.BtnMenos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(98, 43);
            this.BtnMenos.TabIndex = 119;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // BtnMas
            // 
            this.BtnMas.Enabled = false;
            this.BtnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas.Location = new System.Drawing.Point(118, 155);
            this.BtnMas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(109, 43);
            this.BtnMas.TabIndex = 118;
            this.BtnMas.Text = "+";
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // LblErrorCantidad
            // 
            this.LblErrorCantidad.AutoSize = true;
            this.LblErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.LblErrorCantidad.Location = new System.Drawing.Point(10, 112);
            this.LblErrorCantidad.Name = "LblErrorCantidad";
            this.LblErrorCantidad.Size = new System.Drawing.Size(100, 13);
            this.LblErrorCantidad.TabIndex = 117;
            this.LblErrorCantidad.Text = "Solo admite enteros";
            this.LblErrorCantidad.Visible = false;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(13, 127);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(213, 22);
            this.Txt_Cantidad.TabIndex = 116;
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Txt_Cantidad_TextChanged);
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // TxtProducto
            // 
            this.TxtProducto.Enabled = false;
            this.TxtProducto.Location = new System.Drawing.Point(13, 49);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(213, 22);
            this.TxtProducto.TabIndex = 123;
            // 
            // BtnAgregarInventario
            // 
            this.BtnAgregarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarInventario.Location = new System.Drawing.Point(13, 226);
            this.BtnAgregarInventario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregarInventario.Name = "BtnAgregarInventario";
            this.BtnAgregarInventario.Size = new System.Drawing.Size(213, 67);
            this.BtnAgregarInventario.TabIndex = 124;
            this.BtnAgregarInventario.Text = "Agregar Inventario";
            this.BtnAgregarInventario.UseVisualStyleBackColor = true;
            this.BtnAgregarInventario.Click += new System.EventHandler(this.BtnAgregarInventario_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Beige;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.Location = new System.Drawing.Point(13, 299);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(213, 74);
            this.BtnCancelar.TabIndex = 125;
            this.BtnCancelar.Text = "Cancelar ";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // InventarioProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.GpBAgregrarInventario);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LvProductos);
            this.Controls.Add(this.LblTitulo);
            this.Name = "InventarioProductos";
            this.Size = new System.Drawing.Size(1021, 490);
            this.Load += new System.EventHandler(this.InventarioProductos_Load);
            this.GpBAgregrarInventario.ResumeLayout(false);
            this.GpBAgregrarInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.GroupBox GpBAgregrarInventario;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.Label LblErrorCantidad;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Button BtnAgregarInventario;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
