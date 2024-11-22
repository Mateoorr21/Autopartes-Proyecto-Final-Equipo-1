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
            this.components = new System.ComponentModel.Container();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.RdAdminAgregar = new System.Windows.Forms.RadioButton();
            this.RdCajeroAgregar = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelAddInventario = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LblErrorNombre = new System.Windows.Forms.Label();
            this.LblErrorUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.LblErrorPassword = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ToolTipRegistrar = new System.Windows.Forms.ToolTip(this.components);
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PanelAddInventario.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(745, 550);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 16;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(738, 506);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 22;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPermiso.ForeColor = System.Drawing.Color.Purple;
            this.LblPermiso.Location = new System.Drawing.Point(40, 330);
            this.LblPermiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.Size = new System.Drawing.Size(90, 20);
            this.LblPermiso.TabIndex = 25;
            this.LblPermiso.Text = "Permiso: *";
            // 
            // RdAdminAgregar
            // 
            this.RdAdminAgregar.AutoSize = true;
            this.RdAdminAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdAdminAgregar.Location = new System.Drawing.Point(145, 328);
            this.RdAdminAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdAdminAgregar.Name = "RdAdminAgregar";
            this.RdAdminAgregar.Size = new System.Drawing.Size(72, 24);
            this.RdAdminAgregar.TabIndex = 4;
            this.RdAdminAgregar.TabStop = true;
            this.RdAdminAgregar.Text = "Admin";
            this.RdAdminAgregar.UseVisualStyleBackColor = true;
            // 
            // RdCajeroAgregar
            // 
            this.RdCajeroAgregar.AutoSize = true;
            this.RdCajeroAgregar.Checked = true;
            this.RdCajeroAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCajeroAgregar.Location = new System.Drawing.Point(230, 328);
            this.RdCajeroAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdCajeroAgregar.Name = "RdCajeroAgregar";
            this.RdCajeroAgregar.Size = new System.Drawing.Size(73, 24);
            this.RdCajeroAgregar.TabIndex = 5;
            this.RdCajeroAgregar.TabStop = true;
            this.RdCajeroAgregar.Text = "Cajero";
            this.RdCajeroAgregar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(552, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "Ingrese los datos (Nombre, Usuario, Contraseña) del Usuario Operativo que desea r" +
    "egistrar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 16);
            this.label9.TabIndex = 98;
            this.label9.Text = "Nota: El Id del usuario se generará automáticamente ";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Nombre.Location = new System.Drawing.Point(41, 86);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(319, 17);
            this.Txt_Nombre.TabIndex = 1;
            this.Txt_Nombre.Tag = "Ingrese Nombre Completo";
            this.Txt_Nombre.Text = "Ingrese Nombre Completo";
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Location = new System.Drawing.Point(42, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 2);
            this.panel2.TabIndex = 108;
            // 
            // PanelAddInventario
            // 
            this.PanelAddInventario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelAddInventario.Controls.Add(this.BtnRegistrar);
            this.PanelAddInventario.Controls.Add(this.label6);
            this.PanelAddInventario.Controls.Add(this.BtnCancelar);
            this.PanelAddInventario.Controls.Add(this.label5);
            this.PanelAddInventario.Controls.Add(this.label4);
            this.PanelAddInventario.Controls.Add(this.LblErrorPassword);
            this.PanelAddInventario.Controls.Add(this.panel7);
            this.PanelAddInventario.Controls.Add(this.Txt_Password);
            this.PanelAddInventario.Controls.Add(this.LblErrorUsuario);
            this.PanelAddInventario.Controls.Add(this.panel1);
            this.PanelAddInventario.Controls.Add(this.Txt_Usuario);
            this.PanelAddInventario.Controls.Add(this.LblErrorNombre);
            this.PanelAddInventario.Controls.Add(this.panel2);
            this.PanelAddInventario.Controls.Add(this.Txt_Nombre);
            this.PanelAddInventario.Controls.Add(this.panel5);
            this.PanelAddInventario.Controls.Add(this.panel4);
            this.PanelAddInventario.Controls.Add(this.panel3);
            this.PanelAddInventario.Controls.Add(this.panel6);
            this.PanelAddInventario.Controls.Add(this.RdCajeroAgregar);
            this.PanelAddInventario.Controls.Add(this.RdAdminAgregar);
            this.PanelAddInventario.Controls.Add(this.LblPermiso);
            this.PanelAddInventario.Location = new System.Drawing.Point(235, 187);
            this.PanelAddInventario.Name = "PanelAddInventario";
            this.PanelAddInventario.Size = new System.Drawing.Size(657, 418);
            this.PanelAddInventario.TabIndex = 1;
            this.PanelAddInventario.TabStop = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Purple;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(655, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(656, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 381);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 381);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(657, 37);
            this.panel6.TabIndex = 0;
            // 
            // LblErrorNombre
            // 
            this.LblErrorNombre.AutoSize = true;
            this.LblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.LblErrorNombre.Location = new System.Drawing.Point(39, 111);
            this.LblErrorNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorNombre.Name = "LblErrorNombre";
            this.LblErrorNombre.Size = new System.Drawing.Size(242, 16);
            this.LblErrorNombre.TabIndex = 76;
            this.LblErrorNombre.Text = "Solo letras (mayúsuclas o minúsuculas)";
            this.LblErrorNombre.Visible = false;
            // 
            // LblErrorUsuario
            // 
            this.LblErrorUsuario.AutoSize = true;
            this.LblErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblErrorUsuario.Location = new System.Drawing.Point(42, 195);
            this.LblErrorUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorUsuario.Name = "LblErrorUsuario";
            this.LblErrorUsuario.Size = new System.Drawing.Size(276, 16);
            this.LblErrorUsuario.TabIndex = 109;
            this.LblErrorUsuario.Text = "Solo letras, números y caracteres especiales";
            this.LblErrorUsuario.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(43, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 2);
            this.panel1.TabIndex = 111;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Usuario.Location = new System.Drawing.Point(42, 170);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(318, 17);
            this.Txt_Usuario.TabIndex = 2;
            this.Txt_Usuario.Tag = "Usuario...";
            this.Txt_Usuario.Text = "Usuario...";
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // LblErrorPassword
            // 
            this.LblErrorPassword.AutoSize = true;
            this.LblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPassword.Location = new System.Drawing.Point(41, 282);
            this.LblErrorPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorPassword.Name = "LblErrorPassword";
            this.LblErrorPassword.Size = new System.Drawing.Size(276, 16);
            this.LblErrorPassword.TabIndex = 112;
            this.LblErrorPassword.Text = "Solo letras, números y caracteres especiales";
            this.LblErrorPassword.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Purple;
            this.panel7.Location = new System.Drawing.Point(42, 275);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(318, 2);
            this.panel7.TabIndex = 114;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Password.Location = new System.Drawing.Point(41, 257);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(319, 17);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.Tag = " Contraseña...";
            this.Txt_Password.Text = " Contraseña...";
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(38, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Nombre Completo: *\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(39, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 116;
            this.label5.Text = "Usuario: *\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(38, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "Contraseña: *\r\n";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonAgregarUsuario;
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Location = new System.Drawing.Point(431, 46);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(184, 170);
            this.BtnRegistrar.TabIndex = 6;
            this.ToolTipRegistrar.SetToolTip(this.BtnRegistrar, "Registrar usuario");
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(434, 218);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(184, 176);
            this.BtnCancelar.TabIndex = 7;
            this.ToolTipRegistrar.SetToolTip(this.BtnCancelar, "Resetear acción");
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoInformacionGeneral;
            this.pictureBox6.Location = new System.Drawing.Point(164, 1);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(326, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 135;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TituloRegistrarUsuario2;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(234, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(657, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLLanta2;
            this.pictureBox7.Location = new System.Drawing.Point(-15, 31);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(410, 72);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 106;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLLanta2;
            this.pictureBox8.Location = new System.Drawing.Point(736, 31);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(412, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 107;
            this.pictureBox8.TabStop = false;
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelAddInventario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarUsuario";
            this.Size = new System.Drawing.Size(1134, 669);
            this.PanelAddInventario.ResumeLayout(false);
            this.PanelAddInventario.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblPermiso;
        private System.Windows.Forms.RadioButton RdAdminAgregar;
        private System.Windows.Forms.RadioButton RdCajeroAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelAddInventario;
        private System.Windows.Forms.Label LblErrorNombre;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label LblErrorPassword;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label LblErrorUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.ToolTip ToolTipRegistrar;
    }
}
