namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class AgregarProducto
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
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.LblNota = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblInstruccion = new System.Windows.Forms.Label();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblImagen = new System.Windows.Forms.Label();
            this.PicImagenProducto = new System.Windows.Forms.PictureBox();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.LblErrorPrecio = new System.Windows.Forms.Label();
            this.LblErrorCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(381, 151);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(312, 47);
            this.Txt_Descripcion.TabIndex = 47;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(381, 116);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(312, 22);
            this.Txt_Nombre.TabIndex = 46;
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(788, 345);
            this.BtnRegistrarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(125, 94);
            this.BtnRegistrarProducto.TabIndex = 45;
            this.BtnRegistrarProducto.Text = "Agregar Producto a Base de Datos";
            this.BtnRegistrarProducto.UseVisualStyleBackColor = true;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.Location = new System.Drawing.Point(361, 73);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(305, 15);
            this.LblNota.TabIndex = 44;
            this.LblNota.Text = "Nota: El Id del producto se generará automáticamente ";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(319, 116);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(59, 16);
            this.LblNombre.TabIndex = 39;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(228, 151);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(147, 16);
            this.LblDescripcion.TabIndex = 35;
            this.LblDescripcion.Text = "Descripción (Opcional):";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(393, 12);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(218, 29);
            this.LblTitulo.TabIndex = 33;
            this.LblTitulo.Text = "Agregar Producto";
            // 
            // LblInstruccion
            // 
            this.LblInstruccion.AutoSize = true;
            this.LblInstruccion.Location = new System.Drawing.Point(198, 49);
            this.LblInstruccion.Name = "LblInstruccion";
            this.LblInstruccion.Size = new System.Drawing.Size(612, 16);
            this.LblInstruccion.TabIndex = 49;
            this.LblInstruccion.Text = "Ingrese los datos (Nombre, Precio, Cantidad, etc) del producto que desea registra" +
    "r a la base de datos\r\n";
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Location = new System.Drawing.Point(381, 212);
            this.Txt_Marca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(312, 22);
            this.Txt_Marca.TabIndex = 51;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(327, 214);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(48, 16);
            this.LblMarca.TabIndex = 50;
            this.LblMarca.Text = "Marca:";
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(381, 247);
            this.Txt_Precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(312, 22);
            this.Txt_Precio.TabIndex = 53;
            this.Txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Precio_KeyPress);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(311, 250);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(67, 16);
            this.LblPrecio.TabIndex = 52;
            this.LblPrecio.Text = "Precio ($):";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(381, 281);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(312, 22);
            this.Txt_Cantidad.TabIndex = 55;
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(229, 284);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(146, 16);
            this.LblCantidad.TabIndex = 54;
            this.LblCantidad.Text = "Cantidad en Existencia:";
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(258, 323);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(117, 16);
            this.LblImagen.TabIndex = 58;
            this.LblImagen.Text = "Imagen (Opcional)";
            // 
            // PicImagenProducto
            // 
            this.PicImagenProducto.Location = new System.Drawing.Point(381, 323);
            this.PicImagenProducto.Name = "PicImagenProducto";
            this.PicImagenProducto.Size = new System.Drawing.Size(196, 131);
            this.PicImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagenProducto.TabIndex = 59;
            this.PicImagenProducto.TabStop = false;
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(583, 323);
            this.BtnCargarImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(110, 58);
            this.BtnCargarImagen.TabIndex = 60;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // LblErrorPrecio
            // 
            this.LblErrorPrecio.AutoSize = true;
            this.LblErrorPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPrecio.Location = new System.Drawing.Point(699, 250);
            this.LblErrorPrecio.Name = "LblErrorPrecio";
            this.LblErrorPrecio.Size = new System.Drawing.Size(248, 16);
            this.LblErrorPrecio.TabIndex = 61;
            this.LblErrorPrecio.Text = "Solo admite números y un punto decimal";
            this.LblErrorPrecio.Visible = false;
            // 
            // LblErrorCantidad
            // 
            this.LblErrorCantidad.AutoSize = true;
            this.LblErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.LblErrorCantidad.Location = new System.Drawing.Point(698, 284);
            this.LblErrorCantidad.Name = "LblErrorCantidad";
            this.LblErrorCantidad.Size = new System.Drawing.Size(182, 16);
            this.LblErrorCantidad.TabIndex = 62;
            this.LblErrorCantidad.Text = "Solo admite números enteros\r\n";
            this.LblErrorCantidad.Visible = false;
            // 
            // AgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblErrorCantidad);
            this.Controls.Add(this.LblErrorPrecio);
            this.Controls.Add(this.BtnCargarImagen);
            this.Controls.Add(this.PicImagenProducto);
            this.Controls.Add(this.LblImagen);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblInstruccion);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.BtnRegistrarProducto);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblTitulo);
            this.Name = "AgregarProducto";
            this.Size = new System.Drawing.Size(1021, 490);
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblInstruccion;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.PictureBox PicImagenProducto;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.Label LblErrorPrecio;
        private System.Windows.Forms.Label LblErrorCantidad;
    }
}
