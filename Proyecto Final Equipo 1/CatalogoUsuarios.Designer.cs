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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnModificarUsuario = new System.Windows.Forms.Button();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.PanelCatalogo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la \r\nOpción a Realizar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnModificarUsuario);
            this.panel1.Controls.Add(this.BtnEliminarUsuario);
            this.panel1.Controls.Add(this.BtnRegistrarUsuario);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 524);
            this.panel1.TabIndex = 2;
            // 
            // BtnModificarUsuario
            // 
            this.BtnModificarUsuario.Location = new System.Drawing.Point(20, 242);
            this.BtnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificarUsuario.Name = "BtnModificarUsuario";
            this.BtnModificarUsuario.Size = new System.Drawing.Size(148, 102);
            this.BtnModificarUsuario.TabIndex = 3;
            this.BtnModificarUsuario.Text = "Modificar Usuario";
            this.BtnModificarUsuario.UseVisualStyleBackColor = true;
            this.BtnModificarUsuario.Click += new System.EventHandler(this.BtnModificarUsuario_Click);
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(20, 361);
            this.BtnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(148, 102);
            this.BtnEliminarUsuario.TabIndex = 4;
            this.BtnEliminarUsuario.Text = "Eliminar Usuario";
            this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrarUsuario
            // 
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(20, 121);
            this.BtnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(148, 105);
            this.BtnRegistrarUsuario.TabIndex = 2;
            this.BtnRegistrarUsuario.Text = "Registrar Usuario";
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // PanelCatalogo
            // 
            this.PanelCatalogo.Location = new System.Drawing.Point(173, 66);
            this.PanelCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCatalogo.Name = "PanelCatalogo";
            this.PanelCatalogo.Size = new System.Drawing.Size(885, 455);
            this.PanelCatalogo.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.LblTitulo);
            this.panel3.Location = new System.Drawing.Point(173, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 70);
            this.panel3.TabIndex = 4;
            // 
            // CatalogoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelCatalogo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogoUsuarios";
            this.Text = "CatalogoUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnModificarUsuario;
        private System.Windows.Forms.Button BtnRegistrarUsuario;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.Panel PanelCatalogo;
        private System.Windows.Forms.Panel panel3;
    }
}