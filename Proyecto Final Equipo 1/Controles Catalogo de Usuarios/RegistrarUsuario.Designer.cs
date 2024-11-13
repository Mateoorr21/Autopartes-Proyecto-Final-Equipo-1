namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    partial class RegistrarUsuario
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
            this.LblInstruccion = new System.Windows.Forms.Label();
            this.LblErrorUsuario = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblErrorPassword = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblErrorNombre = new System.Windows.Forms.Label();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.RdAdmin = new System.Windows.Forms.RadioButton();
            this.RdCajero = new System.Windows.Forms.RadioButton();
            this.LblNota = new System.Windows.Forms.Label();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(319, 55);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(217, 29);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Registrar Usuario";
            // 
            // LblInstruccion
            // 
            this.LblInstruccion.AutoSize = true;
            this.LblInstruccion.Location = new System.Drawing.Point(184, 94);
            this.LblInstruccion.Name = "LblInstruccion";
            this.LblInstruccion.Size = new System.Drawing.Size(487, 16);
            this.LblInstruccion.TabIndex = 1;
            this.LblInstruccion.Text = "Ingrese los datos (Nombre, Usuario, Contraseña) del usuario que desea registrar";
            // 
            // LblErrorUsuario
            // 
            this.LblErrorUsuario.AutoSize = true;
            this.LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblErrorUsuario.Location = new System.Drawing.Point(240, 199);
            this.LblErrorUsuario.Name = "LblErrorUsuario";
            this.LblErrorUsuario.Size = new System.Drawing.Size(380, 16);
            this.LblErrorUsuario.TabIndex = 18;
            this.LblErrorUsuario.Text = "El usuario solo admite letras, numeros y caracteres especiales\r\n";
            this.LblErrorUsuario.Visible = false;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(235, 279);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(79, 16);
            this.LblPassword.TabIndex = 17;
            this.LblPassword.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(256, 222);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 16);
            this.LblUsuario.TabIndex = 16;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblErrorPassword
            // 
            this.LblErrorPassword.AutoSize = true;
            this.LblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPassword.Location = new System.Drawing.Point(220, 258);
            this.LblErrorPassword.Name = "LblErrorPassword";
            this.LblErrorPassword.Size = new System.Drawing.Size(406, 16);
            this.LblErrorPassword.TabIndex = 21;
            this.LblErrorPassword.Text = "La contraseña solo admite letras, numeros y caracteres especiales\r\n";
            this.LblErrorPassword.Visible = false;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(243, 165);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(59, 16);
            this.LblNombre.TabIndex = 22;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblErrorNombre
            // 
            this.LblErrorNombre.AutoSize = true;
            this.LblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.LblErrorNombre.Location = new System.Drawing.Point(232, 140);
            this.LblErrorNombre.Name = "LblErrorNombre";
            this.LblErrorNombre.Size = new System.Drawing.Size(387, 16);
            this.LblErrorNombre.TabIndex = 24;
            this.LblErrorNombre.Text = "El nombre solo debe contener letras (mayúsculas o minúsculas)";
            this.LblErrorNombre.Visible = false;
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Location = new System.Drawing.Point(227, 330);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.Size = new System.Drawing.Size(60, 16);
            this.LblPermiso.TabIndex = 25;
            this.LblPermiso.Text = "Permiso:";
            // 
            // RdAdmin
            // 
            this.RdAdmin.AutoSize = true;
            this.RdAdmin.Location = new System.Drawing.Point(300, 327);
            this.RdAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdAdmin.Name = "RdAdmin";
            this.RdAdmin.Size = new System.Drawing.Size(66, 20);
            this.RdAdmin.TabIndex = 26;
            this.RdAdmin.Text = "Admin";
            this.RdAdmin.UseVisualStyleBackColor = true;
            // 
            // RdCajero
            // 
            this.RdCajero.AutoSize = true;
            this.RdCajero.Checked = true;
            this.RdCajero.Location = new System.Drawing.Point(392, 327);
            this.RdCajero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdCajero.Name = "RdCajero";
            this.RdCajero.Size = new System.Drawing.Size(68, 20);
            this.RdCajero.TabIndex = 27;
            this.RdCajero.TabStop = true;
            this.RdCajero.Text = "Cajero";
            this.RdCajero.UseVisualStyleBackColor = true;
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.Location = new System.Drawing.Point(261, 114);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(298, 15);
            this.LblNota.TabIndex = 28;
            this.LblNota.Text = "Nota: El Id del usuario se generará automáticamente ";
            // 
            // BtnRegistrarUsuario
            // 
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(501, 314);
            this.BtnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(125, 58);
            this.BtnRegistrarUsuario.TabIndex = 29;
            this.BtnRegistrarUsuario.Text = "Registrar a Catálogo de Usuarios";
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(305, 165);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(312, 22);
            this.Txt_Nombre.TabIndex = 30;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(315, 219);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(312, 22);
            this.Txt_Usuario.TabIndex = 31;
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(315, 279);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(312, 22);
            this.Txt_Password.TabIndex = 32;
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.BtnRegistrarUsuario);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.RdCajero);
            this.Controls.Add(this.RdAdmin);
            this.Controls.Add(this.LblPermiso);
            this.Controls.Add(this.LblErrorNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblErrorPassword);
            this.Controls.Add(this.LblErrorUsuario);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblInstruccion);
            this.Controls.Add(this.LblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrarUsuario";
            this.Size = new System.Drawing.Size(885, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblInstruccion;
        private System.Windows.Forms.Label LblErrorUsuario;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblErrorPassword;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblErrorNombre;
        private System.Windows.Forms.Label LblPermiso;
        private System.Windows.Forms.RadioButton RdAdmin;
        private System.Windows.Forms.RadioButton RdCajero;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Button BtnRegistrarUsuario;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Password;
    }
}
