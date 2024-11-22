namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    partial class ModificarUsuario
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.GpBBusquedaTipo = new System.Windows.Forms.GroupBox();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.GbBusquedaCampo = new System.Windows.Forms.GroupBox();
            this.RdUsuario = new System.Windows.Forms.RadioButton();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LvUsuarios = new System.Windows.Forms.ListView();
            this.LblDatos = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.RdCajero = new System.Windows.Forms.RadioButton();
            this.RdAdmin = new System.Windows.Forms.RadioButton();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.LblErrorUsuario = new System.Windows.Forms.Label();
            this.LblErrorNombre = new System.Windows.Forms.Label();
            this.LblErrorPassword = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GpBBusquedaTipo.SuspendLayout();
            this.GbBusquedaCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(430, 160);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(172, 24);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Modificar Usuario";
            // 
            // GpBBusquedaTipo
            // 
            this.GpBBusquedaTipo.Controls.Add(this.RdExacta);
            this.GpBBusquedaTipo.Controls.Add(this.RdAproximada);
            this.GpBBusquedaTipo.Location = new System.Drawing.Point(238, 200);
            this.GpBBusquedaTipo.Name = "GpBBusquedaTipo";
            this.GpBBusquedaTipo.Size = new System.Drawing.Size(126, 70);
            this.GpBBusquedaTipo.TabIndex = 2;
            this.GpBBusquedaTipo.TabStop = false;
            this.GpBBusquedaTipo.Text = "Tipo de Busqueda";
            // 
            // RdExacta
            // 
            this.RdExacta.AutoSize = true;
            this.RdExacta.Location = new System.Drawing.Point(22, 42);
            this.RdExacta.Name = "RdExacta";
            this.RdExacta.Size = new System.Drawing.Size(58, 17);
            this.RdExacta.TabIndex = 1;
            this.RdExacta.Text = "Exacta";
            this.RdExacta.UseVisualStyleBackColor = true;
            // 
            // RdAproximada
            // 
            this.RdAproximada.AutoSize = true;
            this.RdAproximada.Checked = true;
            this.RdAproximada.Location = new System.Drawing.Point(22, 19);
            this.RdAproximada.Name = "RdAproximada";
            this.RdAproximada.Size = new System.Drawing.Size(80, 17);
            this.RdAproximada.TabIndex = 0;
            this.RdAproximada.TabStop = true;
            this.RdAproximada.Text = "Aproximada";
            this.RdAproximada.UseVisualStyleBackColor = true;
            // 
            // GbBusquedaCampo
            // 
            this.GbBusquedaCampo.Controls.Add(this.RdUsuario);
            this.GbBusquedaCampo.Controls.Add(this.RdNombre);
            this.GbBusquedaCampo.Location = new System.Drawing.Point(238, 277);
            this.GbBusquedaCampo.Name = "GbBusquedaCampo";
            this.GbBusquedaCampo.Size = new System.Drawing.Size(126, 70);
            this.GbBusquedaCampo.TabIndex = 3;
            this.GbBusquedaCampo.TabStop = false;
            this.GbBusquedaCampo.Text = "Por Campo";
            // 
            // RdUsuario
            // 
            this.RdUsuario.AutoSize = true;
            this.RdUsuario.Location = new System.Drawing.Point(22, 42);
            this.RdUsuario.Name = "RdUsuario";
            this.RdUsuario.Size = new System.Drawing.Size(61, 17);
            this.RdUsuario.TabIndex = 1;
            this.RdUsuario.Text = "Usuario";
            this.RdUsuario.UseVisualStyleBackColor = true;
            this.RdUsuario.CheckedChanged += new System.EventHandler(this.RdUsuario_CheckedChanged);
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Checked = true;
            this.RdNombre.Location = new System.Drawing.Point(22, 19);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(62, 17);
            this.RdNombre.TabIndex = 0;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            this.RdNombre.CheckedChanged += new System.EventHandler(this.RdNombre_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(242, 448);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(117, 36);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LvUsuarios
            // 
            this.LvUsuarios.HideSelection = false;
            this.LvUsuarios.Location = new System.Drawing.Point(370, 200);
            this.LvUsuarios.MultiSelect = false;
            this.LvUsuarios.Name = "LvUsuarios";
            this.LvUsuarios.Size = new System.Drawing.Size(327, 283);
            this.LvUsuarios.TabIndex = 5;
            this.LvUsuarios.UseCompatibleStateImageBehavior = false;
            this.LvUsuarios.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvUsuarios_ColumnClick);
            this.LvUsuarios.SelectedIndexChanged += new System.EventHandler(this.LvUsuarios_SelectedIndexChanged);
            // 
            // LblDatos
            // 
            this.LblDatos.AutoSize = true;
            this.LblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatos.Location = new System.Drawing.Point(709, 162);
            this.LblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDatos.Name = "LblDatos";
            this.LblDatos.Size = new System.Drawing.Size(145, 20);
            this.LblDatos.TabIndex = 6;
            this.LblDatos.Text = "Datos a Modificar...";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(706, 346);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(199, 20);
            this.Txt_Password.TabIndex = 41;
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(707, 283);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(199, 20);
            this.Txt_Usuario.TabIndex = 40;
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(707, 219);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(198, 20);
            this.Txt_Nombre.TabIndex = 39;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(706, 200);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 37;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(703, 322);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(64, 13);
            this.LblPassword.TabIndex = 34;
            this.LblPassword.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(707, 261);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 33;
            this.LblUsuario.Text = "Usuario:";
            // 
            // RdCajero
            // 
            this.RdCajero.AutoSize = true;
            this.RdCajero.Checked = true;
            this.RdCajero.Location = new System.Drawing.Point(778, 403);
            this.RdCajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdCajero.Name = "RdCajero";
            this.RdCajero.Size = new System.Drawing.Size(55, 17);
            this.RdCajero.TabIndex = 44;
            this.RdCajero.TabStop = true;
            this.RdCajero.Text = "Cajero";
            this.RdCajero.UseVisualStyleBackColor = true;
            // 
            // RdAdmin
            // 
            this.RdAdmin.AutoSize = true;
            this.RdAdmin.Location = new System.Drawing.Point(709, 401);
            this.RdAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdAdmin.Name = "RdAdmin";
            this.RdAdmin.Size = new System.Drawing.Size(54, 17);
            this.RdAdmin.TabIndex = 43;
            this.RdAdmin.Text = "Admin";
            this.RdAdmin.UseVisualStyleBackColor = true;
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Location = new System.Drawing.Point(707, 385);
            this.LblPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.Size = new System.Drawing.Size(47, 13);
            this.LblPermiso.TabIndex = 42;
            this.LblPermiso.Text = "Permiso:";
            // 
            // LblErrorUsuario
            // 
            this.LblErrorUsuario.AutoSize = true;
            this.LblErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblErrorUsuario.Location = new System.Drawing.Point(754, 252);
            this.LblErrorUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorUsuario.Name = "LblErrorUsuario";
            this.LblErrorUsuario.Size = new System.Drawing.Size(139, 26);
            this.LblErrorUsuario.TabIndex = 45;
            this.LblErrorUsuario.Text = "Solo admite letras, numeros \r\ny caracteres especiales\r\n";
            this.LblErrorUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblErrorUsuario.Visible = false;
            // 
            // LblErrorNombre
            // 
            this.LblErrorNombre.AutoSize = true;
            this.LblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.LblErrorNombre.Location = new System.Drawing.Point(763, 199);
            this.LblErrorNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorNombre.Name = "LblErrorNombre";
            this.LblErrorNombre.Size = new System.Drawing.Size(90, 13);
            this.LblErrorNombre.TabIndex = 46;
            this.LblErrorNombre.Text = "Solo admite letras";
            this.LblErrorNombre.Visible = false;
            // 
            // LblErrorPassword
            // 
            this.LblErrorPassword.AutoSize = true;
            this.LblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPassword.Location = new System.Drawing.Point(762, 314);
            this.LblErrorPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorPassword.Name = "LblErrorPassword";
            this.LblErrorPassword.Size = new System.Drawing.Size(139, 26);
            this.LblErrorPassword.TabIndex = 47;
            this.LblErrorPassword.Text = "Solo admite letras, numeros \r\ny caracteres especiales\r\n";
            this.LblErrorPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblErrorPassword.Visible = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(709, 434);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(107, 50);
            this.BtnModificar.TabIndex = 48;
            this.BtnModificar.Text = "Modificar Usuario";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(242, 403);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(118, 20);
            this.TxtBuscar.TabIndex = 50;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.Location = new System.Drawing.Point(240, 384);
            this.LblCampoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(47, 13);
            this.LblCampoBuscar.TabIndex = 49;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(240, 355);
            this.LblErrorBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorBuscar.Name = "LblErrorBuscar";
            this.LblErrorBuscar.Size = new System.Drawing.Size(66, 9);
            this.LblErrorBuscar.TabIndex = 51;
            this.LblErrorBuscar.Text = "Solo admite letras";
            this.LblErrorBuscar.Visible = false;
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(558, 487);
            this.LblCantidadRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(134, 15);
            this.LblCantidadRegistros.TabIndex = 83;
            this.LblCantidadRegistros.Tag = "Usuarios Encontrados: ";
            this.LblCantidadRegistros.Text = "Usuarios Encontrados: ";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Beige;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.Location = new System.Drawing.Point(821, 435);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 49);
            this.BtnCancelar.TabIndex = 96;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LblErrorBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblCampoBuscar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.LblErrorPassword);
            this.Controls.Add(this.LblErrorNombre);
            this.Controls.Add(this.LblErrorUsuario);
            this.Controls.Add(this.RdCajero);
            this.Controls.Add(this.RdAdmin);
            this.Controls.Add(this.LblPermiso);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblDatos);
            this.Controls.Add(this.LvUsuarios);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GbBusquedaCampo);
            this.Controls.Add(this.GpBBusquedaTipo);
            this.Controls.Add(this.LblTitulo);
            this.Name = "ModificarUsuario";
            this.Size = new System.Drawing.Size(1134, 669);
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            this.GpBBusquedaTipo.ResumeLayout(false);
            this.GpBBusquedaTipo.PerformLayout();
            this.GbBusquedaCampo.ResumeLayout(false);
            this.GbBusquedaCampo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.GroupBox GpBBusquedaTipo;
        private System.Windows.Forms.RadioButton RdExacta;
        private System.Windows.Forms.RadioButton RdAproximada;
        private System.Windows.Forms.GroupBox GbBusquedaCampo;
        private System.Windows.Forms.RadioButton RdUsuario;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ListView LvUsuarios;
        private System.Windows.Forms.Label LblDatos;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.RadioButton RdCajero;
        private System.Windows.Forms.RadioButton RdAdmin;
        private System.Windows.Forms.Label LblPermiso;
        private System.Windows.Forms.Label LblErrorUsuario;
        private System.Windows.Forms.Label LblErrorNombre;
        private System.Windows.Forms.Label LblErrorPassword;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.Label LblErrorBuscar;
        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
