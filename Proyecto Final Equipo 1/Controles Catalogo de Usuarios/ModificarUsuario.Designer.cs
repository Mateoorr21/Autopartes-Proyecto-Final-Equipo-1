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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GpBBusquedaTipo.SuspendLayout();
            this.GbBusquedaCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(263, 25);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(218, 29);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Modificar Usuario";
            // 
            // GpBBusquedaTipo
            // 
            this.GpBBusquedaTipo.Controls.Add(this.RdExacta);
            this.GpBBusquedaTipo.Controls.Add(this.RdAproximada);
            this.GpBBusquedaTipo.Location = new System.Drawing.Point(7, 75);
            this.GpBBusquedaTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpBBusquedaTipo.Name = "GpBBusquedaTipo";
            this.GpBBusquedaTipo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GpBBusquedaTipo.Size = new System.Drawing.Size(168, 86);
            this.GpBBusquedaTipo.TabIndex = 2;
            this.GpBBusquedaTipo.TabStop = false;
            this.GpBBusquedaTipo.Text = "Tipo de Busqueda";
            // 
            // RdExacta
            // 
            this.RdExacta.AutoSize = true;
            this.RdExacta.Location = new System.Drawing.Point(29, 52);
            this.RdExacta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdExacta.Name = "RdExacta";
            this.RdExacta.Size = new System.Drawing.Size(69, 20);
            this.RdExacta.TabIndex = 1;
            this.RdExacta.TabStop = true;
            this.RdExacta.Text = "Exacta";
            this.RdExacta.UseVisualStyleBackColor = true;
            // 
            // RdAproximada
            // 
            this.RdAproximada.AutoSize = true;
            this.RdAproximada.Location = new System.Drawing.Point(29, 23);
            this.RdAproximada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdAproximada.Name = "RdAproximada";
            this.RdAproximada.Size = new System.Drawing.Size(101, 20);
            this.RdAproximada.TabIndex = 0;
            this.RdAproximada.TabStop = true;
            this.RdAproximada.Text = "Aproximada";
            this.RdAproximada.UseVisualStyleBackColor = true;
            // 
            // GbBusquedaCampo
            // 
            this.GbBusquedaCampo.Controls.Add(this.RdUsuario);
            this.GbBusquedaCampo.Controls.Add(this.RdNombre);
            this.GbBusquedaCampo.Location = new System.Drawing.Point(7, 169);
            this.GbBusquedaCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbBusquedaCampo.Name = "GbBusquedaCampo";
            this.GbBusquedaCampo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbBusquedaCampo.Size = new System.Drawing.Size(168, 86);
            this.GbBusquedaCampo.TabIndex = 3;
            this.GbBusquedaCampo.TabStop = false;
            this.GbBusquedaCampo.Text = "Por Campo";
            // 
            // RdUsuario
            // 
            this.RdUsuario.AutoSize = true;
            this.RdUsuario.Location = new System.Drawing.Point(29, 52);
            this.RdUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdUsuario.Name = "RdUsuario";
            this.RdUsuario.Size = new System.Drawing.Size(75, 20);
            this.RdUsuario.TabIndex = 1;
            this.RdUsuario.TabStop = true;
            this.RdUsuario.Text = "Usuario";
            this.RdUsuario.UseVisualStyleBackColor = true;
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Location = new System.Drawing.Point(29, 23);
            this.RdNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(77, 20);
            this.RdNombre.TabIndex = 0;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(13, 379);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(156, 44);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(183, 75);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 347);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // LblDatos
            // 
            this.LblDatos.AutoSize = true;
            this.LblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatos.Location = new System.Drawing.Point(635, 28);
            this.LblDatos.Name = "LblDatos";
            this.LblDatos.Size = new System.Drawing.Size(178, 25);
            this.LblDatos.TabIndex = 6;
            this.LblDatos.Text = "Datos a Modificar...";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(631, 254);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(240, 22);
            this.Txt_Password.TabIndex = 41;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(632, 177);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(240, 22);
            this.Txt_Usuario.TabIndex = 40;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(633, 98);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(239, 22);
            this.Txt_Nombre.TabIndex = 39;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(631, 75);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(59, 16);
            this.LblNombre.TabIndex = 37;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(628, 225);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 16);
            this.LblPassword.TabIndex = 34;
            this.LblPassword.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(632, 149);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 16);
            this.LblUsuario.TabIndex = 33;
            this.LblUsuario.Text = "Usuario:";
            // 
            // RdCajero
            // 
            this.RdCajero.AutoSize = true;
            this.RdCajero.Checked = true;
            this.RdCajero.Location = new System.Drawing.Point(727, 324);
            this.RdCajero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdCajero.Name = "RdCajero";
            this.RdCajero.Size = new System.Drawing.Size(68, 20);
            this.RdCajero.TabIndex = 44;
            this.RdCajero.TabStop = true;
            this.RdCajero.Text = "Cajero";
            this.RdCajero.UseVisualStyleBackColor = true;
            // 
            // RdAdmin
            // 
            this.RdAdmin.AutoSize = true;
            this.RdAdmin.Location = new System.Drawing.Point(636, 322);
            this.RdAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdAdmin.Name = "RdAdmin";
            this.RdAdmin.Size = new System.Drawing.Size(66, 20);
            this.RdAdmin.TabIndex = 43;
            this.RdAdmin.Text = "Admin";
            this.RdAdmin.UseVisualStyleBackColor = true;
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Location = new System.Drawing.Point(632, 302);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.Size = new System.Drawing.Size(60, 16);
            this.LblPermiso.TabIndex = 42;
            this.LblPermiso.Text = "Permiso:";
            // 
            // LblErrorUsuario
            // 
            this.LblErrorUsuario.AutoSize = true;
            this.LblErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblErrorUsuario.Location = new System.Drawing.Point(695, 139);
            this.LblErrorUsuario.Name = "LblErrorUsuario";
            this.LblErrorUsuario.Size = new System.Drawing.Size(176, 32);
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
            this.LblErrorNombre.Location = new System.Drawing.Point(708, 73);
            this.LblErrorNombre.Name = "LblErrorNombre";
            this.LblErrorNombre.Size = new System.Drawing.Size(115, 16);
            this.LblErrorNombre.TabIndex = 46;
            this.LblErrorNombre.Text = "Solo admite letras";
            this.LblErrorNombre.Visible = false;
            // 
            // LblErrorPassword
            // 
            this.LblErrorPassword.AutoSize = true;
            this.LblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPassword.Location = new System.Drawing.Point(706, 215);
            this.LblErrorPassword.Name = "LblErrorPassword";
            this.LblErrorPassword.Size = new System.Drawing.Size(176, 32);
            this.LblErrorPassword.TabIndex = 47;
            this.LblErrorPassword.Text = "Solo admite letras, numeros \r\ny caracteres especiales\r\n";
            this.LblErrorPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblErrorPassword.Visible = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(635, 362);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(237, 62);
            this.BtnModificar.TabIndex = 48;
            this.BtnModificar.Text = "Modificar Usuario";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 321);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 50;
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.Location = new System.Drawing.Point(9, 274);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(54, 16);
            this.LblCampoBuscar.TabIndex = 49;
            this.LblCampoBuscar.Text = "Campo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(9, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Mensaje de Error";
            this.label4.Visible = false;
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GbBusquedaCampo);
            this.Controls.Add(this.GpBBusquedaTipo);
            this.Controls.Add(this.LblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificarUsuario";
            this.Size = new System.Drawing.Size(885, 455);
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
        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.Label label4;
    }
}
