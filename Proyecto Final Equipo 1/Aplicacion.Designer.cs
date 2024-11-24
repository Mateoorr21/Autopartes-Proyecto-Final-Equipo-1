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
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.LblNombreCompleto = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PanelAutoPartes = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToolTipAplicacion = new System.Windows.Forms.ToolTip(this.components);
            this.PicIndicaciones = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.PicIndicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTitulo.Location = new System.Drawing.Point(355, 30);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(411, 55);
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
            this.panel1.Location = new System.Drawing.Point(1, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 670);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(32)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.BtnSalir);
            this.panel3.Controls.Add(this.LblTitulo);
            this.panel3.Location = new System.Drawing.Point(204, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 109);
            this.panel3.TabIndex = 1;
            this.panel3.TabStop = true;
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPermiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPermiso.Location = new System.Drawing.Point(88, 67);
            this.LblPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPermiso.Size = new System.Drawing.Size(50, 13);
            this.LblPermiso.TabIndex = 10;
            this.LblPermiso.Text = "(Permiso)\r\n";
            this.LblPermiso.UseMnemonic = false;
            // 
            // LblNombreCompleto
            // 
            this.LblNombreCompleto.AutoSize = true;
            this.LblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombreCompleto.Location = new System.Drawing.Point(88, 54);
            this.LblNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreCompleto.Name = "LblNombreCompleto";
            this.LblNombreCompleto.Size = new System.Drawing.Size(91, 13);
            this.LblNombreCompleto.TabIndex = 9;
            this.LblNombreCompleto.Text = "Nombre Completo";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Location = new System.Drawing.Point(86, 35);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(67, 18);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "Usuario";
            // 
            // PanelAutoPartes
            // 
            this.PanelAutoPartes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelAutoPartes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelAutoPartes.Controls.Add(this.PicIndicaciones);
            this.PanelAutoPartes.Location = new System.Drawing.Point(204, 108);
            this.PanelAutoPartes.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAutoPartes.Name = "PanelAutoPartes";
            this.PanelAutoPartes.Size = new System.Drawing.Size(1135, 669);
            this.PanelAutoPartes.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LblPermiso);
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.LblNombreCompleto);
            this.panel2.Controls.Add(this.PicUsuario);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 109);
            this.panel2.TabIndex = 10;
            // 
            // PicIndicaciones
            // 
            this.PicIndicaciones.BackColor = System.Drawing.Color.Transparent;
            this.PicIndicaciones.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.ImagenIndicacionesAplicacionConLogo;
            this.PicIndicaciones.Location = new System.Drawing.Point(4, 0);
            this.PicIndicaciones.Margin = new System.Windows.Forms.Padding(2);
            this.PicIndicaciones.Name = "PicIndicaciones";
            this.PicIndicaciones.Size = new System.Drawing.Size(1126, 667);
            this.PicIndicaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicIndicaciones.TabIndex = 12;
            this.PicIndicaciones.TabStop = false;
            // 
            // PicUsuario
            // 
            this.PicUsuario.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Usuario2;
            this.PicUsuario.InitialImage = null;
            this.PicUsuario.Location = new System.Drawing.Point(20, 28);
            this.PicUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.PicUsuario.Name = "PicUsuario";
            this.PicUsuario.Size = new System.Drawing.Size(56, 61);
            this.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUsuario.TabIndex = 7;
            this.PicUsuario.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.Boton_X_Blanco;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(1059, 19);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(56, 61);
            this.BtnSalir.TabIndex = 2;
            this.ToolTipAplicacion.SetToolTip(this.BtnSalir, "Cerrar aplicación");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCatalogoUsuarios
            // 
            this.BtnCatalogoUsuarios.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoCatalogoUsuarios2;
            this.BtnCatalogoUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCatalogoUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnCatalogoUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCatalogoUsuarios.Location = new System.Drawing.Point(2, 587);
            this.BtnCatalogoUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCatalogoUsuarios.Name = "BtnCatalogoUsuarios";
            this.BtnCatalogoUsuarios.Size = new System.Drawing.Size(204, 91);
            this.BtnCatalogoUsuarios.TabIndex = 10;
            this.BtnCatalogoUsuarios.UseVisualStyleBackColor = true;
            this.BtnCatalogoUsuarios.Click += new System.EventHandler(this.BtnCatalogoUsuarios_Click);
            // 
            // BtnCorte
            // 
            this.BtnCorte.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoCorteCaja;
            this.BtnCorte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCorte.FlatAppearance.BorderSize = 0;
            this.BtnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorte.Location = new System.Drawing.Point(-1, 498);
            this.BtnCorte.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(204, 89);
            this.BtnCorte.TabIndex = 9;
            this.BtnCorte.UseVisualStyleBackColor = true;
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoEliminarProducto;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(2, 412);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(204, 89);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoModificarProducto;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Location = new System.Drawing.Point(2, 334);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(204, 77);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBuscarProducto;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(0, 243);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(204, 95);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoAgregarProducto;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(2, 154);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(204, 95);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnVender
            // 
            this.BtnVender.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoVender;
            this.BtnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVender.FlatAppearance.BorderSize = 0;
            this.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVender.Location = new System.Drawing.Point(0, 73);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(204, 91);
            this.BtnVender.TabIndex = 4;
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
            this.BtnInventario.Size = new System.Drawing.Size(204, 89);
            this.BtnInventario.TabIndex = 3;
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1336, 774);
            this.ControlBox = false;
            this.Controls.Add(this.PanelAutoPartes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación AutoPartes One";
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            this.Shown += new System.EventHandler(this.Aplicacion_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelAutoPartes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIndicaciones)).EndInit();
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