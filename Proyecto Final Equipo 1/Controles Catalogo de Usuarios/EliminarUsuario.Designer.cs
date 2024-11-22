namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    partial class EliminarUsuario
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
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.LvUsuarios = new System.Windows.Forms.ListView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbBusquedaCampo = new System.Windows.Forms.GroupBox();
            this.RdUsuario = new System.Windows.Forms.RadioButton();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.GpBBusquedaTipo = new System.Windows.Forms.GroupBox();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GbBusquedaCampo.SuspendLayout();
            this.GpBBusquedaTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(226, 339);
            this.LblErrorBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorBuscar.Name = "LblErrorBuscar";
            this.LblErrorBuscar.Size = new System.Drawing.Size(90, 13);
            this.LblErrorBuscar.TabIndex = 73;
            this.LblErrorBuscar.Text = "Solo admite letras";
            this.LblErrorBuscar.Visible = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(228, 394);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(161, 20);
            this.TxtBuscar.TabIndex = 72;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.Location = new System.Drawing.Point(226, 374);
            this.LblCampoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(47, 13);
            this.LblCampoBuscar.TabIndex = 71;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // LvUsuarios
            // 
            this.LvUsuarios.HideSelection = false;
            this.LvUsuarios.Location = new System.Drawing.Point(407, 189);
            this.LvUsuarios.MultiSelect = false;
            this.LvUsuarios.Name = "LvUsuarios";
            this.LvUsuarios.Size = new System.Drawing.Size(444, 283);
            this.LvUsuarios.TabIndex = 56;
            this.LvUsuarios.UseCompatibleStateImageBehavior = false;
            this.LvUsuarios.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvUsuarios_ColumnClick);
            this.LvUsuarios.SelectedIndexChanged += new System.EventHandler(this.LvUsuarios_SelectedIndexChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(228, 432);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(160, 36);
            this.BtnBuscar.TabIndex = 55;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GbBusquedaCampo
            // 
            this.GbBusquedaCampo.Controls.Add(this.RdUsuario);
            this.GbBusquedaCampo.Controls.Add(this.RdNombre);
            this.GbBusquedaCampo.Location = new System.Drawing.Point(228, 262);
            this.GbBusquedaCampo.Name = "GbBusquedaCampo";
            this.GbBusquedaCampo.Size = new System.Drawing.Size(160, 70);
            this.GbBusquedaCampo.TabIndex = 54;
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
            // GpBBusquedaTipo
            // 
            this.GpBBusquedaTipo.Controls.Add(this.RdExacta);
            this.GpBBusquedaTipo.Controls.Add(this.RdAproximada);
            this.GpBBusquedaTipo.Location = new System.Drawing.Point(228, 186);
            this.GpBBusquedaTipo.Name = "GpBBusquedaTipo";
            this.GpBBusquedaTipo.Size = new System.Drawing.Size(160, 70);
            this.GpBBusquedaTipo.TabIndex = 53;
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
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(403, 145);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(163, 24);
            this.LblTitulo.TabIndex = 52;
            this.LblTitulo.Text = "Eliminar Usuario";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(661, 143);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(189, 30);
            this.BtnEliminar.TabIndex = 74;
            this.BtnEliminar.Text = "Eliminar Usuario Operativo";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(717, 474);
            this.LblCantidadRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(134, 15);
            this.LblCantidadRegistros.TabIndex = 84;
            this.LblCantidadRegistros.Tag = "Usuarios Encontrados: ";
            this.LblCantidadRegistros.Text = "Usuarios Encontrados: ";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Beige;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.Location = new System.Drawing.Point(574, 143);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 28);
            this.BtnCancelar.TabIndex = 97;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.LblErrorBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblCampoBuscar);
            this.Controls.Add(this.LvUsuarios);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GbBusquedaCampo);
            this.Controls.Add(this.GpBBusquedaTipo);
            this.Controls.Add(this.LblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EliminarUsuario";
            this.Size = new System.Drawing.Size(1134, 669);
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            this.GbBusquedaCampo.ResumeLayout(false);
            this.GbBusquedaCampo.PerformLayout();
            this.GpBBusquedaTipo.ResumeLayout(false);
            this.GpBBusquedaTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblErrorBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.ListView LvUsuarios;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GbBusquedaCampo;
        private System.Windows.Forms.RadioButton RdUsuario;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.GroupBox GpBBusquedaTipo;
        private System.Windows.Forms.RadioButton RdExacta;
        private System.Windows.Forms.RadioButton RdAproximada;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
