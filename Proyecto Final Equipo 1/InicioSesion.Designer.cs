namespace Proyecto_Final_Equipo_1
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblErrorPassword = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.LblErrorUsuario = new System.Windows.Forms.Label();
            this.Btn_Ingreso = new System.Windows.Forms.Button();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.BtnVolverInicio = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnPassword = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicCaja = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.LblTitulo.Location = new System.Drawing.Point(152, 178);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(222, 71);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "LOG IN";
            // 
            // LblErrorPassword
            // 
            this.LblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPassword.Location = new System.Drawing.Point(134, 368);
            this.LblErrorPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorPassword.Name = "LblErrorPassword";
            this.LblErrorPassword.Size = new System.Drawing.Size(154, 18);
            this.LblErrorPassword.TabIndex = 15;
            this.LblErrorPassword.Text = "Entrada no valida";
            this.LblErrorPassword.Visible = false;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(78)))), ((int)(((byte)(176)))));
            this.Txt_Password.Location = new System.Drawing.Point(185, 337);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(151, 20);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.Text = "Contraseña...";
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // LblErrorUsuario
            // 
            this.LblErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblErrorUsuario.Location = new System.Drawing.Point(141, 298);
            this.LblErrorUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorUsuario.Name = "LblErrorUsuario";
            this.LblErrorUsuario.Size = new System.Drawing.Size(199, 22);
            this.LblErrorUsuario.TabIndex = 16;
            this.LblErrorUsuario.Text = "Entrada no valida";
            this.LblErrorUsuario.Visible = false;
            // 
            // Btn_Ingreso
            // 
            this.Btn_Ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Btn_Ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Ingreso.FlatAppearance.BorderSize = 0;
            this.Btn_Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingreso.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Ingreso.Location = new System.Drawing.Point(138, 409);
            this.Btn_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ingreso.Name = "Btn_Ingreso";
            this.Btn_Ingreso.Size = new System.Drawing.Size(246, 42);
            this.Btn_Ingreso.TabIndex = 5;
            this.Btn_Ingreso.Text = "LOG IN";
            this.Btn_Ingreso.UseVisualStyleBackColor = false;
            this.Btn_Ingreso.Click += new System.EventHandler(this.Btn_Ingreso_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(78)))), ((int)(((byte)(176)))));
            this.Txt_Usuario.Location = new System.Drawing.Point(186, 266);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(189, 20);
            this.Txt_Usuario.TabIndex = 2;
            this.Txt_Usuario.Text = "Usuario...";
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // BtnVolverInicio
            // 
            this.BtnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVolverInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnVolverInicio.FlatAppearance.BorderSize = 0;
            this.BtnVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolverInicio.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVolverInicio.Location = new System.Drawing.Point(138, 472);
            this.BtnVolverInicio.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVolverInicio.Name = "BtnVolverInicio";
            this.BtnVolverInicio.Size = new System.Drawing.Size(246, 42);
            this.BtnVolverInicio.TabIndex = 6;
            this.BtnVolverInicio.Text = "SALIR";
            this.BtnVolverInicio.UseVisualStyleBackColor = false;
            this.BtnVolverInicio.Click += new System.EventHandler(this.BtnVolverInicio_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Password1;
            this.pictureBox4.Location = new System.Drawing.Point(144, 332);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // BtnPassword
            // 
            this.BtnPassword.BackColor = System.Drawing.Color.White;
            this.BtnPassword.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.Mostrar_Password;
            this.BtnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPassword.FlatAppearance.BorderSize = 0;
            this.BtnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPassword.Location = new System.Drawing.Point(345, 334);
            this.BtnPassword.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPassword.Name = "BtnPassword";
            this.BtnPassword.Size = new System.Drawing.Size(30, 25);
            this.BtnPassword.TabIndex = 4;
            this.BtnPassword.UseVisualStyleBackColor = false;
            this.BtnPassword.Click += new System.EventHandler(this.BtnPassword_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.UsuariosInicioSesion;
            this.pictureBox3.Location = new System.Drawing.Point(192, 46);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Usuario;
            this.pictureBox2.Location = new System.Drawing.Point(145, 261);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // PicCaja
            // 
            this.PicCaja.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.CajaDatos;
            this.PicCaja.Location = new System.Drawing.Point(138, 259);
            this.PicCaja.Margin = new System.Windows.Forms.Padding(2);
            this.PicCaja.Name = "PicCaja";
            this.PicCaja.Size = new System.Drawing.Size(246, 35);
            this.PicCaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCaja.TabIndex = 21;
            this.PicCaja.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.CajaDatos;
            this.pictureBox1.Location = new System.Drawing.Point(138, 329);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 602);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnVolverInicio);
            this.Controls.Add(this.BtnPassword);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Ingreso);
            this.Controls.Add(this.LblErrorUsuario);
            this.Controls.Add(this.LblErrorPassword);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PicCaja);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión AutoPartes One";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblErrorPassword;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label LblErrorUsuario;
        private System.Windows.Forms.Button Btn_Ingreso;
        private System.Windows.Forms.PictureBox PicCaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Button BtnPassword;
        private System.Windows.Forms.Button BtnVolverInicio;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}