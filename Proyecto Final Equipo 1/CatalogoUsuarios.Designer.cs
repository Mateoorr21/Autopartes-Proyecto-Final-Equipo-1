namespace Proyecto_Final_Equipo_1
{
    partial class CatalogoUsuarios
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
            this.LblOpciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnModificarUsuario = new System.Windows.Forms.Button();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.PanelCatalogo = new System.Windows.Forms.Panel();
            this.LblNotaCajero = new System.Windows.Forms.Label();
            this.LblNotaAdmin = new System.Windows.Forms.Label();
            this.LblNotaPropietario = new System.Windows.Forms.Label();
            this.LblNota = new System.Windows.Forms.Label();
            this.LblEliminarUsuario = new System.Windows.Forms.Label();
            this.LblModificarUsuario = new System.Windows.Forms.Label();
            this.LblRegistrarUsuario = new System.Windows.Forms.Label();
            this.LblTituloInstrucción = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelCatalogo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(223, 14);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(398, 42);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Catálogo de Usuarios";
            // 
            // LblOpciones
            // 
            this.LblOpciones.AutoSize = true;
            this.LblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOpciones.Location = new System.Drawing.Point(36, 29);
            this.LblOpciones.Name = "LblOpciones";
            this.LblOpciones.Size = new System.Drawing.Size(122, 66);
            this.LblOpciones.TabIndex = 1;
            this.LblOpciones.Text = "Seleccione la \r\nOperación\r\na Realizar";
            this.LblOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblOpciones);
            this.panel1.Controls.Add(this.BtnModificarUsuario);
            this.panel1.Controls.Add(this.BtnEliminarUsuario);
            this.panel1.Controls.Add(this.BtnRegistrarUsuario);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 602);
            this.panel1.TabIndex = 2;
            // 
            // BtnModificarUsuario
            // 
            this.BtnModificarUsuario.Location = new System.Drawing.Point(20, 271);
            this.BtnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificarUsuario.Name = "BtnModificarUsuario";
            this.BtnModificarUsuario.Size = new System.Drawing.Size(148, 127);
            this.BtnModificarUsuario.TabIndex = 3;
            this.BtnModificarUsuario.Text = "Modificar Usuario";
            this.BtnModificarUsuario.UseVisualStyleBackColor = true;
            this.BtnModificarUsuario.Click += new System.EventHandler(this.BtnModificarUsuario_Click);
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(20, 414);
            this.BtnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(148, 127);
            this.BtnEliminarUsuario.TabIndex = 4;
            this.BtnEliminarUsuario.Text = "Eliminar Usuario";
            this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
            this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // BtnRegistrarUsuario
            // 
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(20, 126);
            this.BtnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(148, 130);
            this.BtnRegistrarUsuario.TabIndex = 2;
            this.BtnRegistrarUsuario.Text = "Registrar Usuario";
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // PanelCatalogo
            // 
            this.PanelCatalogo.Controls.Add(this.LblNotaCajero);
            this.PanelCatalogo.Controls.Add(this.LblNotaAdmin);
            this.PanelCatalogo.Controls.Add(this.LblNotaPropietario);
            this.PanelCatalogo.Controls.Add(this.LblNota);
            this.PanelCatalogo.Controls.Add(this.LblEliminarUsuario);
            this.PanelCatalogo.Controls.Add(this.LblModificarUsuario);
            this.PanelCatalogo.Controls.Add(this.LblRegistrarUsuario);
            this.PanelCatalogo.Controls.Add(this.LblTituloInstrucción);
            this.PanelCatalogo.Location = new System.Drawing.Point(173, 66);
            this.PanelCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCatalogo.Name = "PanelCatalogo";
            this.PanelCatalogo.Size = new System.Drawing.Size(977, 532);
            this.PanelCatalogo.TabIndex = 3;
            // 
            // LblNotaCajero
            // 
            this.LblNotaCajero.AutoSize = true;
            this.LblNotaCajero.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotaCajero.ForeColor = System.Drawing.Color.Navy;
            this.LblNotaCajero.Location = new System.Drawing.Point(56, 425);
            this.LblNotaCajero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNotaCajero.Name = "LblNotaCajero";
            this.LblNotaCajero.Size = new System.Drawing.Size(730, 24);
            this.LblNotaCajero.TabIndex = 15;
            this.LblNotaCajero.Text = "Cajero: No tiene acceso a este apartado. Si eres cajero, notifica del error a un " +
    "Admin.";
            // 
            // LblNotaAdmin
            // 
            this.LblNotaAdmin.AutoSize = true;
            this.LblNotaAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotaAdmin.ForeColor = System.Drawing.Color.Navy;
            this.LblNotaAdmin.Location = new System.Drawing.Point(56, 359);
            this.LblNotaAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNotaAdmin.Name = "LblNotaAdmin";
            this.LblNotaAdmin.Size = new System.Drawing.Size(718, 48);
            this.LblNotaAdmin.TabIndex = 14;
            this.LblNotaAdmin.Text = "Admin: Puede crear, modificar y eliminar Cajeros, mas no puede cambiar Permisos.\r" +
    "\nPuede actualizar su propia información, mas no eliminarse.";
            // 
            // LblNotaPropietario
            // 
            this.LblNotaPropietario.AutoSize = true;
            this.LblNotaPropietario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotaPropietario.ForeColor = System.Drawing.Color.Navy;
            this.LblNotaPropietario.Location = new System.Drawing.Point(56, 295);
            this.LblNotaPropietario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNotaPropietario.Name = "LblNotaPropietario";
            this.LblNotaPropietario.Size = new System.Drawing.Size(742, 48);
            this.LblNotaPropietario.TabIndex = 13;
            this.LblNotaPropietario.Text = "Propietario: Puede crear, modificar y eliminar Admins y Cajeros.\r\nPuede actualiza" +
    "r su propia información (exceptuando su Permiso), mas no eliminarse.";
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNota.Location = new System.Drawing.Point(33, 253);
            this.LblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(623, 24);
            this.LblNota.TabIndex = 12;
            this.LblNota.Text = "Nota: De acuerdo al pemiso del Usuario (Propietario, Admin o Cajero) ...";
            // 
            // LblEliminarUsuario
            // 
            this.LblEliminarUsuario.AutoSize = true;
            this.LblEliminarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEliminarUsuario.Location = new System.Drawing.Point(29, 200);
            this.LblEliminarUsuario.Name = "LblEliminarUsuario";
            this.LblEliminarUsuario.Size = new System.Drawing.Size(616, 27);
            this.LblEliminarUsuario.TabIndex = 11;
            this.LblEliminarUsuario.Text = "Seleccione Eliminar Uusario para borrar a un Usuario Operativo";
            // 
            // LblModificarUsuario
            // 
            this.LblModificarUsuario.AutoSize = true;
            this.LblModificarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificarUsuario.Location = new System.Drawing.Point(29, 160);
            this.LblModificarUsuario.Name = "LblModificarUsuario";
            this.LblModificarUsuario.Size = new System.Drawing.Size(817, 27);
            this.LblModificarUsuario.TabIndex = 10;
            this.LblModificarUsuario.Text = "Seleccione Modificar Usuario para actualizar la información de un Usuario Operati" +
    "vo";
            // 
            // LblRegistrarUsuario
            // 
            this.LblRegistrarUsuario.AutoSize = true;
            this.LblRegistrarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrarUsuario.Location = new System.Drawing.Point(29, 119);
            this.LblRegistrarUsuario.Name = "LblRegistrarUsuario";
            this.LblRegistrarUsuario.Size = new System.Drawing.Size(607, 27);
            this.LblRegistrarUsuario.TabIndex = 9;
            this.LblRegistrarUsuario.Text = "Seleccione Registrar Usuario para añadir un Usuario Operativo";
            // 
            // LblTituloInstrucción
            // 
            this.LblTituloInstrucción.AutoSize = true;
            this.LblTituloInstrucción.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloInstrucción.Location = new System.Drawing.Point(29, 39);
            this.LblTituloInstrucción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTituloInstrucción.Name = "LblTituloInstrucción";
            this.LblTituloInstrucción.Size = new System.Drawing.Size(801, 44);
            this.LblTituloInstrucción.TabIndex = 8;
            this.LblTituloInstrucción.Text = "Bienvenido al Catálogo de Usuarios Operativos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.BtnSalir);
            this.panel3.Controls.Add(this.LblTitulo);
            this.panel3.Location = new System.Drawing.Point(173, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 70);
            this.panel3.TabIndex = 4;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(776, 13);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(148, 43);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // CatalogoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1148, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelCatalogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Usuarios Operativos (únicamente con acceso si se es Admin)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelCatalogo.ResumeLayout(false);
            this.PanelCatalogo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblOpciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnModificarUsuario;
        private System.Windows.Forms.Button BtnRegistrarUsuario;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.Panel PanelCatalogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblEliminarUsuario;
        private System.Windows.Forms.Label LblModificarUsuario;
        private System.Windows.Forms.Label LblRegistrarUsuario;
        private System.Windows.Forms.Label LblTituloInstrucción;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Label LblNotaAdmin;
        private System.Windows.Forms.Label LblNotaPropietario;
        private System.Windows.Forms.Label LblNotaCajero;
    }
}