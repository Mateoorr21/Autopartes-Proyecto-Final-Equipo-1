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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.LblNota = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblInstruccion = new System.Windows.Forms.Label();
            this.LblImagen = new System.Windows.Forms.Label();
            this.LblErrorNombre = new System.Windows.Forms.Label();
            this.LblErrorDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.LblErrorMarca = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.LblErrorCantidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblErrorPrecio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToolTipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.PicInstruccion = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BtnDeseleccionarImagen = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.PicImagenProducto = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInstruccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Descripcion.Location = new System.Drawing.Point(26, 171);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Descripcion.MaxLength = 1000;
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(312, 48);
            this.Txt_Descripcion.TabIndex = 3;
            this.Txt_Descripcion.Tag = "Descripción del Producto...";
            this.Txt_Descripcion.Text = "Descripción del Producto...";
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descripcion_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Nombre.Location = new System.Drawing.Point(26, 72);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Nombre.MaxLength = 50;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(312, 15);
            this.Txt_Nombre.TabIndex = 2;
            this.Txt_Nombre.Tag = "Nombre del Producto";
            this.Txt_Nombre.Text = "Nombre del Producto";
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.Location = new System.Drawing.Point(402, 145);
            this.LblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(331, 16);
            this.LblNota.TabIndex = 44;
            this.LblNota.Text = "Nota: El Id del producto se generará automáticamente ";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Maroon;
            this.LblNombre.Location = new System.Drawing.Point(16, 41);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 16);
            this.LblNombre.TabIndex = 39;
            this.LblNombre.Text = "Nombre: *";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.Maroon;
            this.LblDescripcion.Location = new System.Drawing.Point(16, 140);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(104, 16);
            this.LblDescripcion.TabIndex = 35;
            this.LblDescripcion.Text = "Descripción: *";
            // 
            // LblInstruccion
            // 
            this.LblInstruccion.AutoSize = true;
            this.LblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstruccion.Location = new System.Drawing.Point(259, 125);
            this.LblInstruccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblInstruccion.Name = "LblInstruccion";
            this.LblInstruccion.Size = new System.Drawing.Size(612, 16);
            this.LblInstruccion.TabIndex = 49;
            this.LblInstruccion.Text = "Ingrese los datos (Nombre, Precio, Cantidad, etc) del producto que desea registra" +
    "r a la base de datos\r\n";
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImagen.ForeColor = System.Drawing.Color.Maroon;
            this.LblImagen.Location = new System.Drawing.Point(22, 283);
            this.LblImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(68, 16);
            this.LblImagen.TabIndex = 58;
            this.LblImagen.Text = "Imagen *";
            // 
            // LblErrorNombre
            // 
            this.LblErrorNombre.AutoSize = true;
            this.LblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.LblErrorNombre.Location = new System.Drawing.Point(16, 102);
            this.LblErrorNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorNombre.Name = "LblErrorNombre";
            this.LblErrorNombre.Size = new System.Drawing.Size(210, 16);
            this.LblErrorNombre.TabIndex = 66;
            this.LblErrorNombre.Text = "Solo admite letras, números   /   \"  -";
            this.LblErrorNombre.Visible = false;
            // 
            // LblErrorDescripcion
            // 
            this.LblErrorDescripcion.AutoSize = true;
            this.LblErrorDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.LblErrorDescripcion.Location = new System.Drawing.Point(16, 232);
            this.LblErrorDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorDescripcion.Name = "LblErrorDescripcion";
            this.LblErrorDescripcion.Size = new System.Drawing.Size(210, 16);
            this.LblErrorDescripcion.TabIndex = 67;
            this.LblErrorDescripcion.Text = "Solo admite letras, números   /   \"  -";
            this.LblErrorDescripcion.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnDeseleccionarImagen);
            this.panel1.Controls.Add(this.Txt_Descripcion);
            this.panel1.Controls.Add(this.Txt_Nombre);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblErrorDescripcion);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.LblErrorNombre);
            this.panel1.Controls.Add(this.BtnCargarImagen);
            this.panel1.Controls.Add(this.LblDescripcion);
            this.panel1.Controls.Add(this.PicImagenProducto);
            this.panel1.Controls.Add(this.LblImagen);
            this.panel1.Location = new System.Drawing.Point(78, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 416);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 75;
            this.label5.Text = "Información General";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Txt_Marca);
            this.panel2.Controls.Add(this.LblErrorMarca);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.Txt_Cantidad);
            this.panel2.Controls.Add(this.Txt_Precio);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.LblErrorCantidad);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblErrorPrecio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(473, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 230);
            this.panel2.TabIndex = 6;
            this.panel2.TabStop = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 22);
            this.label6.TabIndex = 76;
            this.label6.Text = "Precios y Existencias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(16, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Marca: *";
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Marca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Marca.Location = new System.Drawing.Point(26, 170);
            this.Txt_Marca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Marca.MaxLength = 30;
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(251, 15);
            this.Txt_Marca.TabIndex = 8;
            this.Txt_Marca.Tag = "Marca del Producto";
            this.Txt_Marca.Text = "Marca del Producto";
            this.Txt_Marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Marca_KeyPress);
            // 
            // LblErrorMarca
            // 
            this.LblErrorMarca.AutoSize = true;
            this.LblErrorMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMarca.Location = new System.Drawing.Point(16, 198);
            this.LblErrorMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorMarca.Name = "LblErrorMarca";
            this.LblErrorMarca.Size = new System.Drawing.Size(180, 16);
            this.LblErrorMarca.TabIndex = 76;
            this.LblErrorMarca.Text = "Solo admite letras y números";
            this.LblErrorMarca.Visible = false;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Cantidad.Location = new System.Drawing.Point(328, 72);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(233, 15);
            this.Txt_Cantidad.TabIndex = 7;
            this.Txt_Cantidad.Tag = "0";
            this.Txt_Cantidad.Text = "0";
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Precio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Precio.Location = new System.Drawing.Point(26, 72);
            this.Txt_Precio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(251, 15);
            this.Txt_Precio.TabIndex = 6;
            this.Txt_Precio.Tag = "0";
            this.Txt_Precio.Text = "0";
            this.Txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Precio_KeyPress);
            // 
            // LblErrorCantidad
            // 
            this.LblErrorCantidad.AutoSize = true;
            this.LblErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.LblErrorCantidad.Location = new System.Drawing.Point(316, 102);
            this.LblErrorCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorCantidad.Name = "LblErrorCantidad";
            this.LblErrorCantidad.Size = new System.Drawing.Size(182, 16);
            this.LblErrorCantidad.TabIndex = 67;
            this.LblErrorCantidad.Text = "Solo admite números enteros\r\n";
            this.LblErrorCantidad.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Precio (MXN): *";
            // 
            // LblErrorPrecio
            // 
            this.LblErrorPrecio.AutoSize = true;
            this.LblErrorPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPrecio.Location = new System.Drawing.Point(16, 102);
            this.LblErrorPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorPrecio.Name = "LblErrorPrecio";
            this.LblErrorPrecio.Size = new System.Drawing.Size(248, 16);
            this.LblErrorPrecio.TabIndex = 66;
            this.LblErrorPrecio.Text = "Solo admite números y un punto decimal";
            this.LblErrorPrecio.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(316, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cantidad en Existencia: *";
            // 
            // PicInstruccion
            // 
            this.PicInstruccion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PicInstruccion.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoInstruccion;
            this.PicInstruccion.Location = new System.Drawing.Point(-15, 0);
            this.PicInstruccion.Name = "PicInstruccion";
            this.PicInstruccion.Size = new System.Drawing.Size(1243, 25);
            this.PicInstruccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicInstruccion.TabIndex = 82;
            this.PicInstruccion.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Logo_Recortado;
            this.PicLogo.Location = new System.Drawing.Point(894, 462);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(169, 162);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 78;
            this.PicLogo.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(674, 454);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(187, 170);
            this.BtnCancelar.TabIndex = 10;
            this.ToolTipAgregar.SetToolTip(this.BtnCancelar, "Resetear acción");
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.BotonAgregarProducto;
            this.BtnRegistrarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarProducto.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(473, 462);
            this.BtnRegistrarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(186, 162);
            this.BtnRegistrarProducto.TabIndex = 9;
            this.ToolTipAgregar.SetToolTip(this.BtnRegistrarProducto, "Agregar producto");
            this.BtnRegistrarProducto.UseVisualStyleBackColor = true;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(16, 158);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(271, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 75;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(316, 60);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(16, 60);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(271, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 71;
            this.pictureBox5.TabStop = false;
            // 
            // BtnDeseleccionarImagen
            // 
            this.BtnDeseleccionarImagen.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoQuitarImagen;
            this.BtnDeseleccionarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDeseleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeseleccionarImagen.FlatAppearance.BorderSize = 0;
            this.BtnDeseleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeseleccionarImagen.Location = new System.Drawing.Point(270, 344);
            this.BtnDeseleccionarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeseleccionarImagen.Name = "BtnDeseleccionarImagen";
            this.BtnDeseleccionarImagen.Size = new System.Drawing.Size(76, 58);
            this.BtnDeseleccionarImagen.TabIndex = 5;
            this.ToolTipAgregar.SetToolTip(this.BtnDeseleccionarImagen, "Quitar imagen");
            this.BtnDeseleccionarImagen.UseVisualStyleBackColor = true;
            this.BtnDeseleccionarImagen.Click += new System.EventHandler(this.BtnDeseleccionarImagen_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(16, 158);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(326, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoAgregarImagen2;
            this.BtnCargarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargarImagen.FlatAppearance.BorderSize = 0;
            this.BtnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarImagen.Location = new System.Drawing.Point(270, 283);
            this.BtnCargarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(76, 61);
            this.BtnCargarImagen.TabIndex = 4;
            this.ToolTipAgregar.SetToolTip(this.BtnCargarImagen, "Cargar imagen");
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // PicImagenProducto
            // 
            this.PicImagenProducto.Location = new System.Drawing.Point(92, 283);
            this.PicImagenProducto.Margin = new System.Windows.Forms.Padding(2);
            this.PicImagenProducto.Name = "PicImagenProducto";
            this.PicImagenProducto.Size = new System.Drawing.Size(174, 110);
            this.PicImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagenProducto.TabIndex = 59;
            this.PicImagenProducto.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Titulo2AgregarProducto;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(239, -10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(657, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLlanta1;
            this.pictureBox7.Location = new System.Drawing.Point(-15, 31);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(408, 72);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 80;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLlanta1;
            this.pictureBox8.Location = new System.Drawing.Point(736, 31);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(412, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 81;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(907, 526);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 50);
            this.pictureBox10.TabIndex = 83;
            this.pictureBox10.TabStop = false;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.PicInstruccion);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrarProducto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblInstruccion);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarProducto";
            this.Size = new System.Drawing.Size(1135, 669);
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgregarProducto_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInstruccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblInstruccion;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.PictureBox PicImagenProducto;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.Label LblErrorNombre;
        private System.Windows.Forms.Label LblErrorDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnDeseleccionarImagen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblErrorPrecio;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LblErrorCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblErrorMarca;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ToolTip ToolTipAgregar;
        public System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.PictureBox PicInstruccion;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}
