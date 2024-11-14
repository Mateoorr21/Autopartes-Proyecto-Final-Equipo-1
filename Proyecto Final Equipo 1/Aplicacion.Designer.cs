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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCatalogoUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelAplicacion = new System.Windows.Forms.Panel();
            this.PanelAutoPartes = new System.Windows.Forms.Panel();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.LblTituloInstrucción = new System.Windows.Forms.Label();
            this.LblInventario = new System.Windows.Forms.Label();
            this.LblAgregar = new System.Windows.Forms.Label();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.LblVender = new System.Windows.Forms.Label();
            this.LblEliminar = new System.Windows.Forms.Label();
            this.LblModificar = new System.Windows.Forms.Label();
            this.LblCorte = new System.Windows.Forms.Label();
            this.LblCatalogo = new System.Windows.Forms.Label();
            this.LblNota = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelAutoPartes.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(419, 9);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(199, 42);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Aplicación";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(11, 85);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(130, 51);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(11, 151);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(130, 51);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(11, 282);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 51);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(11, 346);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 51);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modfiicar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCatalogoUsuarios
            // 
            this.BtnCatalogoUsuarios.Location = new System.Drawing.Point(11, 480);
            this.BtnCatalogoUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCatalogoUsuarios.Name = "BtnCatalogoUsuarios";
            this.BtnCatalogoUsuarios.Size = new System.Drawing.Size(130, 51);
            this.BtnCatalogoUsuarios.TabIndex = 5;
            this.BtnCatalogoUsuarios.Text = "Catálogo de Usuarios";
            this.BtnCatalogoUsuarios.UseVisualStyleBackColor = true;
            this.BtnCatalogoUsuarios.Click += new System.EventHandler(this.BtnCatalogoUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnCorte);
            this.panel1.Controls.Add(this.BtnVender);
            this.panel1.Controls.Add(this.BtnInventario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnCatalogoUsuarios);
            this.panel1.Controls.Add(this.BtnModificar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 553);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(188, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 73);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.PanelAplicacion);
            this.panel3.Controls.Add(this.LblTitulo);
            this.panel3.Location = new System.Drawing.Point(160, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 71);
            this.panel3.TabIndex = 7;
            // 
            // PanelAplicacion
            // 
            this.PanelAplicacion.Location = new System.Drawing.Point(19, 94);
            this.PanelAplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAplicacion.Name = "PanelAplicacion";
            this.PanelAplicacion.Size = new System.Drawing.Size(746, 370);
            this.PanelAplicacion.TabIndex = 1;
            // 
            // PanelAutoPartes
            // 
            this.PanelAutoPartes.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.PanelAutoPartes.Location = new System.Drawing.Point(160, 63);
            this.PanelAutoPartes.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAutoPartes.Name = "PanelAutoPartes";
            this.PanelAutoPartes.Size = new System.Drawing.Size(1021, 490);
            this.PanelAutoPartes.TabIndex = 7;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Location = new System.Drawing.Point(11, 20);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(130, 51);
            this.BtnInventario.TabIndex = 7;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnVender
            // 
            this.BtnVender.Location = new System.Drawing.Point(11, 217);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(130, 51);
            this.BtnVender.TabIndex = 8;
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = true;
            // 
            // BtnCorte
            // 
            this.BtnCorte.Location = new System.Drawing.Point(11, 413);
            this.BtnCorte.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(130, 51);
            this.BtnCorte.TabIndex = 9;
            this.BtnCorte.Text = "Corte de Caja";
            this.BtnCorte.UseVisualStyleBackColor = true;
            // 
            // LblTituloInstrucción
            // 
            this.LblTituloInstrucción.AutoSize = true;
            this.LblTituloInstrucción.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloInstrucción.Location = new System.Drawing.Point(36, 17);
            this.LblTituloInstrucción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTituloInstrucción.Name = "LblTituloInstrucción";
            this.LblTituloInstrucción.Size = new System.Drawing.Size(945, 45);
            this.LblTituloInstrucción.TabIndex = 2;
            this.LblTituloInstrucción.Text = "Bienvenido a la Aplicación de la Tienda de Autopartes";
            // 
            // LblInventario
            // 
            this.LblInventario.AutoSize = true;
            this.LblInventario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInventario.Location = new System.Drawing.Point(39, 86);
            this.LblInventario.Name = "LblInventario";
            this.LblInventario.Size = new System.Drawing.Size(698, 27);
            this.LblInventario.TabIndex = 3;
            this.LblInventario.Text = "Seleccione Inventario para ver los productos de la Tienda de Autopartes";
            // 
            // LblAgregar
            // 
            this.LblAgregar.AutoSize = true;
            this.LblAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregar.Location = new System.Drawing.Point(39, 127);
            this.LblAgregar.Name = "LblAgregar";
            this.LblAgregar.Size = new System.Drawing.Size(685, 27);
            this.LblAgregar.TabIndex = 4;
            this.LblAgregar.Text = "Seleccione Agregar para añadir un producto a la Tienda de Autopartes";
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(39, 167);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(724, 27);
            this.LblBuscar.TabIndex = 5;
            this.LblBuscar.Text = "Seleccione Buscar para encontrar y mostrar la información de un producto";
            // 
            // LblVender
            // 
            this.LblVender.AutoSize = true;
            this.LblVender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVender.Location = new System.Drawing.Point(42, 208);
            this.LblVender.Name = "LblVender";
            this.LblVender.Size = new System.Drawing.Size(645, 27);
            this.LblVender.TabIndex = 6;
            this.LblVender.Text = "Seleccione Vender para realizar una venta a un cliente de la Tienda";
            // 
            // LblEliminar
            // 
            this.LblEliminar.AutoSize = true;
            this.LblEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminar.Location = new System.Drawing.Point(42, 250);
            this.LblEliminar.Name = "LblEliminar";
            this.LblEliminar.Size = new System.Drawing.Size(697, 27);
            this.LblEliminar.TabIndex = 7;
            this.LblEliminar.Text = "Seleccione Eliminar para borrar un producto de la Tienda de Autopartes";
            // 
            // LblModificar
            // 
            this.LblModificar.AutoSize = true;
            this.LblModificar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificar.Location = new System.Drawing.Point(42, 294);
            this.LblModificar.Name = "LblModificar";
            this.LblModificar.Size = new System.Drawing.Size(653, 27);
            this.LblModificar.TabIndex = 8;
            this.LblModificar.Text = "Seleccione Modificar para actualizar la información de un producto";
            // 
            // LblCorte
            // 
            this.LblCorte.AutoSize = true;
            this.LblCorte.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorte.Location = new System.Drawing.Point(42, 339);
            this.LblCorte.Name = "LblCorte";
            this.LblCorte.Size = new System.Drawing.Size(868, 27);
            this.LblCorte.TabIndex = 9;
            this.LblCorte.Text = "Seleccione Corte de Caja para cerrar sesión y contabilizar las ventas hechas por " +
    "el usuario \r\n";
            // 
            // LblCatalogo
            // 
            this.LblCatalogo.AutoSize = true;
            this.LblCatalogo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCatalogo.Location = new System.Drawing.Point(42, 381);
            this.LblCatalogo.Name = "LblCatalogo";
            this.LblCatalogo.Size = new System.Drawing.Size(824, 27);
            this.LblCatalogo.TabIndex = 10;
            this.LblCatalogo.Text = "Seleccione Catálogo para añadir, eliminar y modificar usuarios operativos del sis" +
    "tema";
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNota.Location = new System.Drawing.Point(43, 418);
            this.LblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(624, 48);
            this.LblNota.TabIndex = 11;
            this.LblNota.Text = "Nota: Funciones de Agregar, Eliminar, Modificar y Catálogo de Usuarios \r\núnicamen" +
    "te están disponibles para usuarios con permiso Admin";
            // 
            // Aplicacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1183, 552);
            this.Controls.Add(this.PanelAutoPartes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelAutoPartes.ResumeLayout(false);
            this.PanelAutoPartes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCatalogoUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelAutoPartes;
        private System.Windows.Forms.Panel PanelAplicacion;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnCorte;
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
    }
}