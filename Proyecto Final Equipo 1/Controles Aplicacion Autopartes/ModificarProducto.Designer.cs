namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class ModificarProducto
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
            this.GpBBusquedaTipo = new System.Windows.Forms.GroupBox();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbBusquedaCampo = new System.Windows.Forms.GroupBox();
            this.RdId = new System.Windows.Forms.RadioButton();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.PicImagenProducto = new System.Windows.Forms.PictureBox();
            this.LblImagen = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.LblErrorPrecio = new System.Windows.Forms.Label();
            this.LblErrorCantidad = new System.Windows.Forms.Label();
            this.GpBBusquedaTipo.SuspendLayout();
            this.GbBusquedaCampo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(529, 448);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(174, 18);
            this.LblCantidadRegistros.TabIndex = 77;
            this.LblCantidadRegistros.Text = "Productos Encontrados: ";
            // 
            // GpBBusquedaTipo
            // 
            this.GpBBusquedaTipo.Controls.Add(this.RdExacta);
            this.GpBBusquedaTipo.Controls.Add(this.RdAproximada);
            this.GpBBusquedaTipo.Location = new System.Drawing.Point(21, 63);
            this.GpBBusquedaTipo.Margin = new System.Windows.Forms.Padding(4);
            this.GpBBusquedaTipo.Name = "GpBBusquedaTipo";
            this.GpBBusquedaTipo.Padding = new System.Windows.Forms.Padding(4);
            this.GpBBusquedaTipo.Size = new System.Drawing.Size(136, 99);
            this.GpBBusquedaTipo.TabIndex = 69;
            this.GpBBusquedaTipo.TabStop = false;
            this.GpBBusquedaTipo.Text = "Tipo de Busqueda";
            // 
            // RdExacta
            // 
            this.RdExacta.AutoSize = true;
            this.RdExacta.Location = new System.Drawing.Point(19, 61);
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
            this.RdAproximada.Location = new System.Drawing.Point(19, 32);
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
            this.LvProductos.Location = new System.Drawing.Point(165, 63);
            this.LvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(538, 381);
            this.LvProductos.TabIndex = 76;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(319, 20);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(233, 29);
            this.LblTitulo.TabIndex = 75;
            this.LblTitulo.Text = "Modificar Producto";
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(24, 280);
            this.LblErrorBuscar.Name = "LblErrorBuscar";
            this.LblErrorBuscar.Size = new System.Drawing.Size(105, 13);
            this.LblErrorBuscar.TabIndex = 74;
            this.LblErrorBuscar.Text = "Solo admite numeros";
            this.LblErrorBuscar.Visible = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(27, 325);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(124, 22);
            this.TxtBuscar.TabIndex = 73;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.Location = new System.Drawing.Point(24, 302);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(59, 16);
            this.LblCampoBuscar.TabIndex = 72;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(27, 380);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 64);
            this.BtnBuscar.TabIndex = 71;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GbBusquedaCampo
            // 
            this.GbBusquedaCampo.Controls.Add(this.RdId);
            this.GbBusquedaCampo.Controls.Add(this.RdNombre);
            this.GbBusquedaCampo.Location = new System.Drawing.Point(21, 170);
            this.GbBusquedaCampo.Margin = new System.Windows.Forms.Padding(4);
            this.GbBusquedaCampo.Name = "GbBusquedaCampo";
            this.GbBusquedaCampo.Padding = new System.Windows.Forms.Padding(4);
            this.GbBusquedaCampo.Size = new System.Drawing.Size(136, 86);
            this.GbBusquedaCampo.TabIndex = 70;
            this.GbBusquedaCampo.TabStop = false;
            this.GbBusquedaCampo.Text = "Por Campo";
            // 
            // RdId
            // 
            this.RdId.AutoSize = true;
            this.RdId.Location = new System.Drawing.Point(19, 52);
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
            this.RdNombre.Location = new System.Drawing.Point(19, 23);
            this.RdNombre.Margin = new System.Windows.Forms.Padding(4);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(77, 20);
            this.RdNombre.TabIndex = 0;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            this.RdNombre.CheckedChanged += new System.EventHandler(this.RdNombre_CheckedChanged);
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(883, 358);
            this.BtnCargarImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(99, 58);
            this.BtnCargarImagen.TabIndex = 90;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // PicImagenProducto
            // 
            this.PicImagenProducto.Location = new System.Drawing.Point(731, 358);
            this.PicImagenProducto.Name = "PicImagenProducto";
            this.PicImagenProducto.Size = new System.Drawing.Size(135, 107);
            this.PicImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagenProducto.TabIndex = 89;
            this.PicImagenProducto.TabStop = false;
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(729, 338);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(117, 16);
            this.LblImagen.TabIndex = 88;
            this.LblImagen.Text = "Imagen (Opcional)";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(880, 308);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(104, 22);
            this.Txt_Cantidad.TabIndex = 87;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(730, 311);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(146, 16);
            this.LblCantidad.TabIndex = 86;
            this.LblCantidad.Text = "Cantidad en Existencia:";
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(802, 263);
            this.Txt_Precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(180, 22);
            this.Txt_Precio.TabIndex = 85;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(729, 266);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(67, 16);
            this.LblPrecio.TabIndex = 84;
            this.LblPrecio.Text = "Precio ($):";
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Location = new System.Drawing.Point(782, 216);
            this.Txt_Marca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(203, 22);
            this.Txt_Marca.TabIndex = 83;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(728, 219);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(48, 16);
            this.LblMarca.TabIndex = 82;
            this.LblMarca.Text = "Marca:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(731, 157);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(251, 38);
            this.Txt_Descripcion.TabIndex = 81;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(731, 95);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(251, 22);
            this.Txt_Nombre.TabIndex = 80;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(731, 77);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(59, 16);
            this.LblNombre.TabIndex = 79;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(731, 135);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(147, 16);
            this.LblDescripcion.TabIndex = 78;
            this.LblDescripcion.Text = "Descripción (Opcional):";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnActualizar.Location = new System.Drawing.Point(731, 21);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(251, 35);
            this.BtnActualizar.TabIndex = 91;
            this.BtnActualizar.Text = "Modificar Registro";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // LblErrorPrecio
            // 
            this.LblErrorPrecio.AutoSize = true;
            this.LblErrorPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPrecio.Location = new System.Drawing.Point(799, 248);
            this.LblErrorPrecio.Name = "LblErrorPrecio";
            this.LblErrorPrecio.Size = new System.Drawing.Size(105, 13);
            this.LblErrorPrecio.TabIndex = 92;
            this.LblErrorPrecio.Text = "Solo admite numeros";
            this.LblErrorPrecio.Visible = false;
            // 
            // LblErrorCantidad
            // 
            this.LblErrorCantidad.AutoSize = true;
            this.LblErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.LblErrorCantidad.Location = new System.Drawing.Point(877, 293);
            this.LblErrorCantidad.Name = "LblErrorCantidad";
            this.LblErrorCantidad.Size = new System.Drawing.Size(100, 13);
            this.LblErrorCantidad.TabIndex = 93;
            this.LblErrorCantidad.Text = "Solo admite enteros";
            this.LblErrorCantidad.Visible = false;
            // 
            // ModificarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblErrorCantidad);
            this.Controls.Add(this.LblErrorPrecio);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarImagen);
            this.Controls.Add(this.PicImagenProducto);
            this.Controls.Add(this.LblImagen);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.GpBBusquedaTipo);
            this.Controls.Add(this.LvProductos);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblErrorBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblCampoBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GbBusquedaCampo);
            this.Name = "ModificarProducto";
            this.Size = new System.Drawing.Size(1021, 490);
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            this.GpBBusquedaTipo.ResumeLayout(false);
            this.GpBBusquedaTipo.PerformLayout();
            this.GbBusquedaCampo.ResumeLayout(false);
            this.GbBusquedaCampo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.GroupBox GpBBusquedaTipo;
        private System.Windows.Forms.RadioButton RdExacta;
        private System.Windows.Forms.RadioButton RdAproximada;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblErrorBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GbBusquedaCampo;
        private System.Windows.Forms.RadioButton RdId;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.PictureBox PicImagenProducto;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label LblErrorPrecio;
        private System.Windows.Forms.Label LblErrorCantidad;
    }
}
