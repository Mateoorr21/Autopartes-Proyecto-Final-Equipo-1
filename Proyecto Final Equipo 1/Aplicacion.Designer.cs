namespace Proyecto_Final_Equipo_1
{
    partial class Aplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicacion));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.LblNombreCompleto = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PanelAutoPartes = new System.Windows.Forms.Panel();
            this.LblNota = new System.Windows.Forms.Label();
            this.LblCatalogo = new System.Windows.Forms.Label();
            this.LblCorte = new System.Windows.Forms.Label();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.LblVender = new System.Windows.Forms.Label();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.LblAgregar = new System.Windows.Forms.Label();
            this.LblInventario = new System.Windows.Forms.Label();
            this.LblTituloInstrucción = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicUsuario = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCatalogoUsuarios = new System.Windows.Forms.Button();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelAutoPartes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTitulo.Location = new System.Drawing.Point(519, 39);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(379, 52);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "A U T O  -  O N E\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.BtnCatalogoUsuarios);
            this.panel1.Controls.Add(this.BtnCorte);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnModificar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnVender);
            this.panel1.Controls.Add(this.BtnInventario);
            this.panel1.Location = new System.Drawing.Point(1, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 825);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(32)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.BtnSalir);
            this.panel3.Controls.Add(this.LblTitulo);
            this.panel3.Location = new System.Drawing.Point(272, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1581, 134);
            this.panel3.TabIndex = 7;
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPermiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPermiso.Location = new System.Drawing.Point(117, 82);
            this.LblPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPermiso.Size = new System.Drawing.Size(65, 16);
            this.LblPermiso.TabIndex = 10;
            this.LblPermiso.Text = "(Permiso)\r\n";
            this.LblPermiso.UseMnemonic = false;
            // 
            // LblNombreCompleto
            // 
            this.LblNombreCompleto.AutoSize = true;
            this.LblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombreCompleto.Location = new System.Drawing.Point(117, 67);
            this.LblNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreCompleto.Name = "LblNombreCompleto";
            this.LblNombreCompleto.Size = new System.Drawing.Size(117, 16);
            this.LblNombreCompleto.TabIndex = 9;
            this.LblNombreCompleto.Text = "Nombre Completo";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Location = new System.Drawing.Point(114, 43);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(79, 22);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "Usuario";
            // 
            // PanelAutoPartes
            // 
            this.PanelAutoPartes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelAutoPartes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAutoPartes.Controls.Add(this.LblNota);
            this.PanelAutoPartes.Controls.Add(this.LblCatalogo);
            this.PanelAutoPartes.Controls.Add(this.LblCorte);
            this.PanelAutoPartes.Controls.Add(this.LblModificar);
            this.PanelAutoPartes.Controls.Add(this.LblEliminar);
            this.PanelAutoPartes.Controls.Add(this.LblVender);
            this.PanelAutoPartes.Controls.Add(this.LblBuscar);
            this.PanelAutoPartes.Controls.Add(this.LblAgregar);
            this.PanelAutoPartes.Controls.Add(this.LblInventario);
            this.PanelAutoPartes.Controls.Add(this.LblTituloInstrucción);
            this.PanelAutoPartes.Location = new System.Drawing.Point(272, 133);
            this.PanelAutoPartes.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAutoPartes.Name = "PanelAutoPartes";
            this.PanelAutoPartes.Size = new System.Drawing.Size(1513, 823);
            this.PanelAutoPartes.TabIndex = 7;
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNota.Location = new System.Drawing.Point(43, 418);
            this.LblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(670, 48);
            this.LblNota.TabIndex = 11;
            this.LblNota.Text = "Nota: Funciones de Agregar, Eliminar, Modificar y Catálogo de Usuarios \r\núnicamen" +
    "te están disponibles para usuarios con permiso Admin o Propietario\r\n";
            // 
            // LblCatalogo
            // 
            this.LblCatalogo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCatalogo.Location = new System.Drawing.Point(42, 381);
            this.LblCatalogo.Name = "LblCatalogo";
            this.LblCatalogo.Size = new System.Drawing.Size(824, 27);
            this.LblCatalogo.TabIndex = 10;
            this.LblCatalogo.Text = "Seleccione Catálogo para añadir, eliminar y modificar usuarios operativos del sis" +
    "tema";
            // 
            // LblCorte
            // 
            this.LblCorte.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorte.Location = new System.Drawing.Point(42, 339);
            this.LblCorte.Name = "LblCorte";
            this.LblCorte.Size = new System.Drawing.Size(868, 27);
            this.LblCorte.TabIndex = 9;
            this.LblCorte.Text = "Seleccione Corte de Caja para cerrar sesión y contabilizar las ventas hechas por " +
    "el usuario \r\n";
            // 
            // LblModificar
            // 
            this.LblModificar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificar.Location = new System.Drawing.Point(42, 294);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(653, 27);
            this.LblModificar.TabIndex = 8;
            this.LblModificar.Text = "Seleccione Modificar para actualizar la información de un producto";
            // 
            // LblEliminar
            // 
            this.LblEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminar.Location = new System.Drawing.Point(42, 250);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(697, 27);
            this.LblEliminar.TabIndex = 7;
            this.LblEliminar.Text = "Seleccione Eliminar para borrar un producto de la Tienda de Autopartes";
            // 
            // LblVender
            // 
            this.LblVender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVender.Location = new System.Drawing.Point(42, 208);
            this.LblVender.Name = "LblVender";
            this.LblVender.Size = new System.Drawing.Size(645, 27);
            this.LblVender.TabIndex = 6;
            this.LblVender.Text = "Seleccione Vender para realizar una venta a un cliente de la Tienda";
            // 
            // LblBuscar
            // 
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(39, 167);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(724, 27);
            this.LblBuscar.TabIndex = 5;
            this.LblBuscar.Text = "Seleccione Buscar para encontrar y mostrar la información de un producto";
            // 
            // LblAgregar
            // 
            this.LblAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregar.Location = new System.Drawing.Point(39, 127);
            this.LblAgregar.Name = "LblAgregar";
            this.LblAgregar.Size = new System.Drawing.Size(685, 27);
            this.LblAgregar.TabIndex = 4;
            this.LblAgregar.Text = "Seleccione Agregar para añadir un producto a la Tienda de Autopartes";
            // 
            // LblInventario
            // 
            this.LblInventario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInventario.Location = new System.Drawing.Point(39, 86);
            this.LblInventario.Name = "LblInventario";
            this.LblInventario.Size = new System.Drawing.Size(698, 27);
            this.LblInventario.TabIndex = 3;
            this.LblInventario.Text = "Seleccione Inventario para ver los productos de la Tienda de Autopartes";
            // 
            // LblTituloInstrucción
            // 
            this.LblTituloInstrucción.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloInstrucción.Location = new System.Drawing.Point(36, 16);
            this.LblTituloInstrucción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTituloInstrucción.Name = "LblTituloInstrucción";
            this.LblTituloInstrucción.Size = new System.Drawing.Size(915, 44);
            this.LblTituloInstrucción.TabIndex = 2;
            this.LblTituloInstrucción.Text = "Bienvenido a la Aplicación de la Tienda de Autopartes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LblPermiso);
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.LblNombreCompleto);
            this.panel2.Controls.Add(this.PicUsuario);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 134);
            this.panel2.TabIndex = 10;
            // 
            // PicUsuario
            // 
            this.PicUsuario.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Usuario2;
            this.PicUsuario.InitialImage = null;
            this.PicUsuario.Location = new System.Drawing.Point(26, 35);
            this.PicUsuario.Name = "PicUsuario";
            this.PicUsuario.Size = new System.Drawing.Size(75, 75);
            this.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUsuario.TabIndex = 7;
            this.PicUsuario.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.Boton_X;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(1405, 23);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 75);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCatalogoUsuarios
            // 
            this.BtnCatalogoUsuarios.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoCatalogoUsuarios2;
            this.BtnCatalogoUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCatalogoUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnCatalogoUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCatalogoUsuarios.Location = new System.Drawing.Point(2, 722);
            this.BtnCatalogoUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCatalogoUsuarios.Name = "BtnCatalogoUsuarios";
            this.BtnCatalogoUsuarios.Size = new System.Drawing.Size(272, 112);
            this.BtnCatalogoUsuarios.TabIndex = 21;
            this.BtnCatalogoUsuarios.UseVisualStyleBackColor = true;
            this.BtnCatalogoUsuarios.Click += new System.EventHandler(this.BtnCatalogoUsuarios_Click);
            // 
            // BtnCorte
            // 
            this.BtnCorte.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoCorteCaja;
            this.BtnCorte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCorte.FlatAppearance.BorderSize = 0;
            this.BtnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorte.Location = new System.Drawing.Point(-1, 613);
            this.BtnCorte.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(272, 109);
            this.BtnCorte.TabIndex = 20;
            this.BtnCorte.UseVisualStyleBackColor = true;
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoEliminarProducto;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(2, 507);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(272, 109);
            this.BtnEliminar.TabIndex = 19;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoModificarProducto;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Location = new System.Drawing.Point(2, 411);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(272, 95);
            this.BtnModificar.TabIndex = 18;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBuscarProducto;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(0, 299);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(272, 117);
            this.BtnBuscar.TabIndex = 17;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoAgregarProducto;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(2, 190);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(272, 117);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnVender
            // 
            this.BtnVender.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoVender;
            this.BtnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVender.FlatAppearance.BorderSize = 0;
            this.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVender.Location = new System.Drawing.Point(0, 90);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(272, 112);
            this.BtnVender.TabIndex = 15;
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoInventario;
            this.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Location = new System.Drawing.Point(0, 0);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(272, 109);
            this.BtnInventario.TabIndex = 7;
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1782, 953);
            this.Controls.Add(this.PanelAutoPartes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación AutoPartes One";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Aplicacion_FormClosing);
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelAutoPartes.ResumeLayout(false);
            this.PanelAutoPartes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelAutoPartes;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Label LblEliminar;
        private System.Windows.Forms.Label LblVender;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Label LblAgregar;
        private System.Windows.Forms.Label LblInventario;
        private System.Windows.Forms.Label LblTituloInstrucción;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Label LblCatalogo;
        private System.Windows.Forms.Label LblCorte;
        private System.Windows.Forms.Label LblModificar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox PicUsuario;
        public System.Windows.Forms.Label LblPermiso;
        public System.Windows.Forms.Label LblNombreCompleto;
        public System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCorte;
        private System.Windows.Forms.Button BtnCatalogoUsuarios;
    }
}