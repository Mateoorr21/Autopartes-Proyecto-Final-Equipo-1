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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplicacion));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCatalogoUsuarios = new System.Windows.Forms.Button();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.LblNombreCompleto = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PanelAutoPartes = new System.Windows.Forms.Panel();
            this.PicIndicaciones = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicUsuario = new System.Windows.Forms.PictureBox();
            this.ToolTipAplicacion = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelAutoPartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIndicaciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTitulo.Location = new System.Drawing.Point(473, 37);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(508, 69);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 825);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // BtnCatalogoUsuarios
            // 
            this.BtnCatalogoUsuarios.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoCatalogoUsuarios2;
            this.BtnCatalogoUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCatalogoUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCatalogoUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnCatalogoUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCatalogoUsuarios.Location = new System.Drawing.Point(3, 722);
            this.BtnCatalogoUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCatalogoUsuarios.Name = "BtnCatalogoUsuarios";
            this.BtnCatalogoUsuarios.Size = new System.Drawing.Size(272, 112);
            this.BtnCatalogoUsuarios.TabIndex = 10;
            this.BtnCatalogoUsuarios.UseVisualStyleBackColor = true;
            this.BtnCatalogoUsuarios.Click += new System.EventHandler(this.BtnCatalogoUsuarios_Click);
            // 
            // BtnCorte
            // 
            this.BtnCorte.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoCorteCaja;
            this.BtnCorte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCorte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCorte.FlatAppearance.BorderSize = 0;
            this.BtnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorte.Location = new System.Drawing.Point(-1, 613);
            this.BtnCorte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(272, 110);
            this.BtnCorte.TabIndex = 9;
            this.BtnCorte.UseVisualStyleBackColor = true;
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoEliminarProducto;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(-1, 507);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(276, 110);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoModificarProducto;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Location = new System.Drawing.Point(-1, 411);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(276, 95);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBuscarProducto;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(0, 299);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(272, 117);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoAgregarProducto;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(-1, 190);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(276, 117);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnVender
            // 
            this.BtnVender.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoVender;
            this.BtnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVender.FlatAppearance.BorderSize = 0;
            this.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVender.Location = new System.Drawing.Point(0, 90);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(272, 112);
            this.BtnVender.TabIndex = 4;
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoInventario;
            this.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Location = new System.Drawing.Point(0, 0);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(272, 110);
            this.BtnInventario.TabIndex = 3;
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(32)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.BtnSalir);
            this.panel3.Controls.Add(this.LblTitulo);
            this.panel3.Location = new System.Drawing.Point(272, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1513, 134);
            this.panel3.TabIndex = 1;
            this.panel3.TabStop = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.Boton_X_Blanco;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(1412, 23);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 75);
            this.BtnSalir.TabIndex = 2;
            this.ToolTipAplicacion.SetToolTip(this.BtnSalir, "Cerrar aplicación");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPermiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPermiso.Location = new System.Drawing.Point(117, 82);
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
            this.LblNombreCompleto.Location = new System.Drawing.Point(117, 66);
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
            this.LblUsuario.Location = new System.Drawing.Point(115, 43);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(79, 22);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "Usuario";
            // 
            // PanelAutoPartes
            // 
            this.PanelAutoPartes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelAutoPartes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAutoPartes.Controls.Add(this.PicIndicaciones);
            this.PanelAutoPartes.Location = new System.Drawing.Point(272, 133);
            this.PanelAutoPartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelAutoPartes.Name = "PanelAutoPartes";
            this.PanelAutoPartes.Size = new System.Drawing.Size(1513, 823);
            this.PanelAutoPartes.TabIndex = 11;
            // 
            // PicIndicaciones
            // 
            this.PicIndicaciones.BackColor = System.Drawing.Color.Transparent;
            this.PicIndicaciones.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.ImagenIndicacionesAplicacionConLogo;
            this.PicIndicaciones.Location = new System.Drawing.Point(5, 0);
            this.PicIndicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicIndicaciones.Name = "PicIndicaciones";
            this.PicIndicaciones.Size = new System.Drawing.Size(1501, 821);
            this.PicIndicaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicIndicaciones.TabIndex = 12;
            this.PicIndicaciones.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LblPermiso);
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.LblNombreCompleto);
            this.panel2.Controls.Add(this.PicUsuario);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 134);
            this.panel2.TabIndex = 10;
            // 
            // PicUsuario
            // 
            this.PicUsuario.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Usuario2;
            this.PicUsuario.InitialImage = null;
            this.PicUsuario.Location = new System.Drawing.Point(27, 34);
            this.PicUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicUsuario.Name = "PicUsuario";
            this.PicUsuario.Size = new System.Drawing.Size(75, 75);
            this.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUsuario.TabIndex = 7;
            this.PicUsuario.TabStop = false;
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(1781, 953);
            this.ControlBox = false;
            this.Controls.Add(this.PanelAutoPartes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación AutoPartes One";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Aplicacion_FormClosing);
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            this.Shown += new System.EventHandler(this.Aplicacion_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelAutoPartes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicIndicaciones)).EndInit();
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
        private System.Windows.Forms.PictureBox PicIndicaciones;
        private System.Windows.Forms.ToolTip ToolTipAplicacion;
    }
}