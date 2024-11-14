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
            this.Btn_Ingreso = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.LblErrorPassword = new System.Windows.Forms.Label();
            this.LblErrorUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Ingreso
            // 
            this.Btn_Ingreso.Location = new System.Drawing.Point(329, 318);
            this.Btn_Ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ingreso.Name = "Btn_Ingreso";
            this.Btn_Ingreso.Size = new System.Drawing.Size(135, 62);
            this.Btn_Ingreso.TabIndex = 10;
            this.Btn_Ingreso.Text = "Ingresar";
            this.Btn_Ingreso.UseVisualStyleBackColor = true;
            this.Btn_Ingreso.Click += new System.EventHandler(this.Btn_Ingreso_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(280, 218);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(76, 16);
            this.LblPassword.TabIndex = 9;
            this.LblPassword.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(283, 256);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(237, 22);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inicio de Sesión (Login)";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(283, 153);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(237, 22);
            this.Txt_Usuario.TabIndex = 2;
            this.Txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Usuario_KeyPress);
            // 
            // LblErrorPassword
            // 
            this.LblErrorPassword.AutoSize = true;
            this.LblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.LblErrorPassword.Location = new System.Drawing.Point(95, 234);
            this.LblErrorPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorPassword.Name = "LblErrorPassword";
            this.LblErrorPassword.Size = new System.Drawing.Size(676, 16);
            this.LblErrorPassword.TabIndex = 15;
            this.LblErrorPassword.Text = "La contraseña solo admite letras, numeros y caracteres especiales   ! \" # $ % & \'" +
    " ( ) * + , - . / : ; < = > ? @ [ \\ ] ^ _` { | } ~\r\n";
            this.LblErrorPassword.Visible = false;
            // 
            // LblErrorUsuario
            // 
            this.LblErrorUsuario.AutoSize = true;
            this.LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.LblErrorUsuario.Location = new System.Drawing.Point(95, 133);
            this.LblErrorUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorUsuario.Name = "LblErrorUsuario";
            this.LblErrorUsuario.Size = new System.Drawing.Size(650, 16);
            this.LblErrorUsuario.TabIndex = 16;
            this.LblErrorUsuario.Text = "El usuario solo admite letras, numeros y caracteres especiales   ! \" # $ % & \' ( " +
    ") * + , - . / : ; < = > ? @ [ \\ ] ^ _` { | } ~\r\n";
            this.LblErrorUsuario.Visible = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.LblErrorUsuario);
            this.Controls.Add(this.LblErrorPassword);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Ingreso);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Ingreso;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label LblErrorPassword;
        private System.Windows.Forms.Label LblErrorUsuario;
    }
}