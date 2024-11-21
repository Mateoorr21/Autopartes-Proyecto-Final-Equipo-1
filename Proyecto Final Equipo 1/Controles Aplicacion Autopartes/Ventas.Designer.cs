namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class Ventas
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
            this.BtnRestaurarBusqueda = new System.Windows.Forms.Button();
            this.LblCantidadRegistrosBuscar = new System.Windows.Forms.Label();
            this.GpBBusquedaTipo = new System.Windows.Forms.GroupBox();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbBusquedaCampo = new System.Windows.Forms.GroupBox();
            this.RdId = new System.Windows.Forms.RadioButton();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.AgregarCarrito = new System.Windows.Forms.Button();
            this.LblErrorCantidad = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnMas = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.LblProductoVender = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.BtnVender = new System.Windows.Forms.Button();
            this.LblCantidadRegistrosCarrito = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.TxtPorPagar = new System.Windows.Forms.TextBox();
            this.BtnEliminarRegistroCarrito = new System.Windows.Forms.Button();
            this.VaciarCarrito = new System.Windows.Forms.Button();
            this.BtnCancelarVenta = new System.Windows.Forms.Button();
            this.LvCarrito = new System.Windows.Forms.ListView();
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.GpBBusquedaTipo.SuspendLayout();
            this.GbBusquedaCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRestaurarBusqueda
            // 
            this.BtnRestaurarBusqueda.BackColor = System.Drawing.Color.Beige;
            this.BtnRestaurarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRestaurarBusqueda.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurarBusqueda.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnRestaurarBusqueda.Location = new System.Drawing.Point(269, 551);
            this.BtnRestaurarBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRestaurarBusqueda.Name = "BtnRestaurarBusqueda";
            this.BtnRestaurarBusqueda.Size = new System.Drawing.Size(124, 65);
            this.BtnRestaurarBusqueda.TabIndex = 108;
            this.BtnRestaurarBusqueda.Text = "Restaurar Búsqueda";
            this.BtnRestaurarBusqueda.UseVisualStyleBackColor = false;
            this.BtnRestaurarBusqueda.Click += new System.EventHandler(this.BtnRestaurarBusqueda_Click);
            // 
            // LblCantidadRegistrosBuscar
            // 
            this.LblCantidadRegistrosBuscar.AutoSize = true;
            this.LblCantidadRegistrosBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistrosBuscar.Location = new System.Drawing.Point(683, 174);
            this.LblCantidadRegistrosBuscar.Name = "LblCantidadRegistrosBuscar";
            this.LblCantidadRegistrosBuscar.Size = new System.Drawing.Size(174, 18);
            this.LblCantidadRegistrosBuscar.TabIndex = 107;
            this.LblCantidadRegistrosBuscar.Tag = "Productos Encontrados: ";
            this.LblCantidadRegistrosBuscar.Text = "Productos Encontrados: ";
            // 
            // GpBBusquedaTipo
            // 
            this.GpBBusquedaTipo.Controls.Add(this.RdExacta);
            this.GpBBusquedaTipo.Controls.Add(this.RdAproximada);
            this.GpBBusquedaTipo.Location = new System.Drawing.Point(263, 195);
            this.GpBBusquedaTipo.Margin = new System.Windows.Forms.Padding(4);
            this.GpBBusquedaTipo.Name = "GpBBusquedaTipo";
            this.GpBBusquedaTipo.Padding = new System.Windows.Forms.Padding(4);
            this.GpBBusquedaTipo.Size = new System.Drawing.Size(136, 99);
            this.GpBBusquedaTipo.TabIndex = 97;
            this.GpBBusquedaTipo.TabStop = false;
            this.GpBBusquedaTipo.Text = "Tipo de Busqueda";
            // 
            // RdExacta
            // 
            this.RdExacta.AutoSize = true;
            this.RdExacta.Location = new System.Drawing.Point(29, 52);
            this.RdExacta.Margin = new System.Windows.Forms.Padding(4);
            this.RdExacta.Name = "RdExacta";
            this.RdExacta.Size = new System.Drawing.Size(69, 20);
            this.RdExacta.TabIndex = 1;
            this.RdExacta.Text = "Exacta";
            this.RdExacta.UseVisualStyleBackColor = true;
            // 
            // RdAproximada
            // 
            this.RdAproximada.AutoSize = true;
            this.RdAproximada.Checked = true;
            this.RdAproximada.Location = new System.Drawing.Point(29, 23);
            this.RdAproximada.Margin = new System.Windows.Forms.Padding(4);
            this.RdAproximada.Name = "RdAproximada";
            this.RdAproximada.Size = new System.Drawing.Size(101, 20);
            this.RdAproximada.TabIndex = 0;
            this.RdAproximada.TabStop = true;
            this.RdAproximada.Text = "Aproximada";
            this.RdAproximada.UseVisualStyleBackColor = true;
            // 
            // LvProductos
            // 
            this.LvProductos.HideSelection = false;
            this.LvProductos.Location = new System.Drawing.Point(407, 196);
            this.LvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(450, 281);
            this.LvProductos.TabIndex = 104;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvProductos_ColumnClick);
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(410, 157);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(209, 29);
            this.LblTitulo.TabIndex = 103;
            this.LblTitulo.Text = "Vender Producto";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(269, 441);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(124, 22);
            this.TxtBuscar.TabIndex = 101;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.Location = new System.Drawing.Point(266, 418);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(59, 16);
            this.LblCampoBuscar.TabIndex = 100;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(269, 471);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 74);
            this.BtnBuscar.TabIndex = 99;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GbBusquedaCampo
            // 
            this.GbBusquedaCampo.Controls.Add(this.RdId);
            this.GbBusquedaCampo.Controls.Add(this.RdNombre);
            this.GbBusquedaCampo.Location = new System.Drawing.Point(263, 302);
            this.GbBusquedaCampo.Margin = new System.Windows.Forms.Padding(4);
            this.GbBusquedaCampo.Name = "GbBusquedaCampo";
            this.GbBusquedaCampo.Padding = new System.Windows.Forms.Padding(4);
            this.GbBusquedaCampo.Size = new System.Drawing.Size(136, 86);
            this.GbBusquedaCampo.TabIndex = 98;
            this.GbBusquedaCampo.TabStop = false;
            this.GbBusquedaCampo.Text = "Por Campo";
            // 
            // RdId
            // 
            this.RdId.AutoSize = true;
            this.RdId.Location = new System.Drawing.Point(29, 52);
            this.RdId.Margin = new System.Windows.Forms.Padding(4);
            this.RdId.Name = "RdId";
            this.RdId.Size = new System.Drawing.Size(39, 20);
            this.RdId.TabIndex = 1;
            this.RdId.Text = "Id";
            this.RdId.UseVisualStyleBackColor = true;
            this.RdId.CheckedChanged += new System.EventHandler(this.RdId_CheckedChanged);
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Checked = true;
            this.RdNombre.Location = new System.Drawing.Point(29, 23);
            this.RdNombre.Margin = new System.Windows.Forms.Padding(4);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(77, 20);
            this.RdNombre.TabIndex = 0;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            this.RdNombre.CheckedChanged += new System.EventHandler(this.RdNombre_CheckedChanged);
            // 
            // AgregarCarrito
            // 
            this.AgregarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarCarrito.Location = new System.Drawing.Point(686, 517);
            this.AgregarCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarCarrito.Name = "AgregarCarrito";
            this.AgregarCarrito.Size = new System.Drawing.Size(171, 99);
            this.AgregarCarrito.TabIndex = 109;
            this.AgregarCarrito.Text = "Añadir a Carrito";
            this.AgregarCarrito.UseVisualStyleBackColor = true;
            this.AgregarCarrito.Click += new System.EventHandler(this.AgregarCarrito_Click);
            // 
            // LblErrorCantidad
            // 
            this.LblErrorCantidad.AutoSize = true;
            this.LblErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.LblErrorCantidad.Location = new System.Drawing.Point(542, 504);
            this.LblErrorCantidad.Name = "LblErrorCantidad";
            this.LblErrorCantidad.Size = new System.Drawing.Size(100, 13);
            this.LblErrorCantidad.TabIndex = 113;
            this.LblErrorCantidad.Text = "Solo admite enteros";
            this.LblErrorCantidad.Visible = false;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(544, 518);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(135, 22);
            this.Txt_Cantidad.TabIndex = 112;
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Txt_Cantidad_TextChanged);
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(413, 518);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(122, 16);
            this.LblCantidad.TabIndex = 111;
            this.LblCantidad.Text = "Cantidad a Vender:";
            // 
            // BtnMas
            // 
            this.BtnMas.Enabled = false;
            this.BtnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas.Location = new System.Drawing.Point(615, 546);
            this.BtnMas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(64, 70);
            this.BtnMas.TabIndex = 114;
            this.BtnMas.Text = "+";
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // BtnMenos
            // 
            this.BtnMenos.Enabled = false;
            this.BtnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos.Location = new System.Drawing.Point(545, 546);
            this.BtnMenos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(62, 70);
            this.BtnMenos.TabIndex = 115;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // LblProductoVender
            // 
            this.LblProductoVender.AutoSize = true;
            this.LblProductoVender.Location = new System.Drawing.Point(414, 487);
            this.LblProductoVender.Name = "LblProductoVender";
            this.LblProductoVender.Size = new System.Drawing.Size(122, 16);
            this.LblProductoVender.TabIndex = 116;
            this.LblProductoVender.Text = "Producto a Vender:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Location = new System.Drawing.Point(542, 487);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(208, 16);
            this.LblProducto.TabIndex = 117;
            this.LblProducto.Text = "Bujía para Vehículo de Alta Gama";
            this.LblProducto.Visible = false;
            // 
            // BtnVender
            // 
            this.BtnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVender.Location = new System.Drawing.Point(1052, 489);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(181, 77);
            this.BtnVender.TabIndex = 118;
            this.BtnVender.Text = "Hacer Venta";
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // LblCantidadRegistrosCarrito
            // 
            this.LblCantidadRegistrosCarrito.AutoSize = true;
            this.LblCantidadRegistrosCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistrosCarrito.Location = new System.Drawing.Point(1066, 174);
            this.LblCantidadRegistrosCarrito.Name = "LblCantidadRegistrosCarrito";
            this.LblCantidadRegistrosCarrito.Size = new System.Drawing.Size(150, 18);
            this.LblCantidadRegistrosCarrito.TabIndex = 119;
            this.LblCantidadRegistrosCarrito.Tag = "Productos en Carrito:";
            this.LblCantidadRegistrosCarrito.Text = "Productos en Carrito:";
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(871, 489);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(173, 16);
            this.Lbl.TabIndex = 120;
            this.Lbl.Text = "Cantidad a Pagar (en MXN):";
            // 
            // TxtPorPagar
            // 
            this.TxtPorPagar.Enabled = false;
            this.TxtPorPagar.Location = new System.Drawing.Point(873, 511);
            this.TxtPorPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPorPagar.Name = "TxtPorPagar";
            this.TxtPorPagar.ReadOnly = true;
            this.TxtPorPagar.Size = new System.Drawing.Size(170, 22);
            this.TxtPorPagar.TabIndex = 121;
            // 
            // BtnEliminarRegistroCarrito
            // 
            this.BtnEliminarRegistroCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarRegistroCarrito.Location = new System.Drawing.Point(872, 539);
            this.BtnEliminarRegistroCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminarRegistroCarrito.Name = "BtnEliminarRegistroCarrito";
            this.BtnEliminarRegistroCarrito.Size = new System.Drawing.Size(171, 77);
            this.BtnEliminarRegistroCarrito.TabIndex = 122;
            this.BtnEliminarRegistroCarrito.Text = "Borrar de Carrito";
            this.BtnEliminarRegistroCarrito.UseVisualStyleBackColor = true;
            this.BtnEliminarRegistroCarrito.Click += new System.EventHandler(this.BtnEliminarRegistroCarrito_Click);
            // 
            // VaciarCarrito
            // 
            this.VaciarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VaciarCarrito.Location = new System.Drawing.Point(1052, 568);
            this.VaciarCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.VaciarCarrito.Name = "VaciarCarrito";
            this.VaciarCarrito.Size = new System.Drawing.Size(181, 48);
            this.VaciarCarrito.TabIndex = 123;
            this.VaciarCarrito.Text = "Vaciar Carrito";
            this.VaciarCarrito.UseVisualStyleBackColor = true;
            this.VaciarCarrito.Click += new System.EventHandler(this.VaciarCarrito_Click);
            // 
            // BtnCancelarVenta
            // 
            this.BtnCancelarVenta.BackColor = System.Drawing.Color.Beige;
            this.BtnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelarVenta.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancelarVenta.Location = new System.Drawing.Point(410, 542);
            this.BtnCancelarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelarVenta.Name = "BtnCancelarVenta";
            this.BtnCancelarVenta.Size = new System.Drawing.Size(128, 74);
            this.BtnCancelarVenta.TabIndex = 124;
            this.BtnCancelarVenta.Text = "Cancelar Venta";
            this.BtnCancelarVenta.UseVisualStyleBackColor = false;
            this.BtnCancelarVenta.Click += new System.EventHandler(this.BtnCancelarVenta_Click);
            // 
            // LvCarrito
            // 
            this.LvCarrito.HideSelection = false;
            this.LvCarrito.Location = new System.Drawing.Point(874, 196);
            this.LvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.LvCarrito.MultiSelect = false;
            this.LvCarrito.Name = "LvCarrito";
            this.LvCarrito.Size = new System.Drawing.Size(359, 281);
            this.LvCarrito.TabIndex = 125;
            this.LvCarrito.UseCompatibleStateImageBehavior = false;
            this.LvCarrito.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvCarrito_ColumnClick);
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(266, 396);
            this.LblErrorBuscar.Name = "LblErrorBuscar";
            this.LblErrorBuscar.Size = new System.Drawing.Size(118, 16);
            this.LblErrorBuscar.TabIndex = 126;
            this.LblErrorBuscar.Tag = "Caracter no Valido";
            this.LblErrorBuscar.Text = "Caracter no Valido\r\n";
            this.LblErrorBuscar.Visible = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.LblErrorBuscar);
            this.Controls.Add(this.LvCarrito);
            this.Controls.Add(this.BtnCancelarVenta);
            this.Controls.Add(this.VaciarCarrito);
            this.Controls.Add(this.BtnEliminarRegistroCarrito);
            this.Controls.Add(this.TxtPorPagar);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.LblCantidadRegistrosCarrito);
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblProductoVender);
            this.Controls.Add(this.BtnMenos);
            this.Controls.Add(this.BtnMas);
            this.Controls.Add(this.LblErrorCantidad);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.AgregarCarrito);
            this.Controls.Add(this.BtnRestaurarBusqueda);
            this.Controls.Add(this.LblCantidadRegistrosBuscar);
            this.Controls.Add(this.GpBBusquedaTipo);
            this.Controls.Add(this.LvProductos);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblCampoBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GbBusquedaCampo);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(1517, 824);
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.GpBBusquedaTipo.ResumeLayout(false);
            this.GpBBusquedaTipo.PerformLayout();
            this.GbBusquedaCampo.ResumeLayout(false);
            this.GbBusquedaCampo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRestaurarBusqueda;
        private System.Windows.Forms.Label LblCantidadRegistrosBuscar;
        private System.Windows.Forms.GroupBox GpBBusquedaTipo;
        private System.Windows.Forms.RadioButton RdExacta;
        private System.Windows.Forms.RadioButton RdAproximada;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GbBusquedaCampo;
        private System.Windows.Forms.RadioButton RdId;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.Button AgregarCarrito;
        private System.Windows.Forms.Label LblErrorCantidad;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Label LblProductoVender;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Label LblCantidadRegistrosCarrito;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.TextBox TxtPorPagar;
        private System.Windows.Forms.Button BtnEliminarRegistroCarrito;
        private System.Windows.Forms.Button VaciarCarrito;
        private System.Windows.Forms.Button BtnCancelarVenta;
        private System.Windows.Forms.ListView LvCarrito;
        private System.Windows.Forms.Label LblErrorBuscar;
    }
}
