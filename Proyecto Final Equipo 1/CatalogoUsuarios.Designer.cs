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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoUsuarios));
            this.PanelCatalogo = new System.Windows.Forms.Panel();
            this.PicIndicaciones = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblNombreCompleto = new System.Windows.Forms.Label();
            this.PicUsuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.BtnModificarUsuario = new System.Windows.Forms.Button();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.ToolTipCatalogo = new System.Windows.Forms.ToolTip(this.components);
            this.PanelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIndicaciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCatalogo
            // 
            this.PanelCatalogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelCatalogo.Controls.Add(this.PicIndicaciones);
            this.PanelCatalogo.Location = new System.Drawing.Point(269, 129);
            this.PanelCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelCatalogo.Name = "PanelCatalogo";
            this.PanelCatalogo.Size = new System.Drawing.Size(1512, 823);
            this.PanelCatalogo.TabIndex = 3;
            // 
            // PicIndicaciones
            // 
            this.PicIndicaciones.BackColor = System.Drawing.Color.Transparent;
            this.PicIndicaciones.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.ImagenIndicacionesCatalogoConLogo;
            this.PicIndicaciones.Location = new System.Drawing.Point(5, 2);
            this.PicIndicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicIndicaciones.Name = "PicIndicaciones";
            this.PicIndicaciones.Size = new System.Drawing.Size(1501, 824);
            this.PicIndicaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicIndicaciones.TabIndex = 13;
            this.PicIndicaciones.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(39)))), ((int)(((byte)(154)))));
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(269, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1512, 134);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.Boton_X_Blanco;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(1417, 30);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 75);
            this.BtnSalir.TabIndex = 8;
            this.ToolTipCatalogo.SetToolTip(this.BtnSalir, "Cerrar catálogo");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1101, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "C A T A L O G O  D E  U S U A R I O S";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.LblPermiso);
            this.panel3.Controls.Add(this.LblUsuario);
            this.panel3.Controls.Add(this.LblNombreCompleto);
            this.panel3.Controls.Add(this.PicUsuario);
            this.panel3.Location = new System.Drawing.Point(-5, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 132);
            this.panel3.TabIndex = 11;
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPermiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPermiso.Location = new System.Drawing.Point(123, 76);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPermiso.Size = new System.Drawing.Size(65, 16);
            this.LblPermiso.TabIndex = 10;
            this.LblPermiso.Text = "(Permiso)\r\n";
            this.LblPermiso.UseMnemonic = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Location = new System.Drawing.Point(120, 37);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(79, 22);
            this.LblUsuario.TabIndex = 8;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblNombreCompleto
            // 
            this.LblNombreCompleto.AutoSize = true;
            this.LblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombreCompleto.Location = new System.Drawing.Point(123, 60);
            this.LblNombreCompleto.Name = "LblNombreCompleto";
            this.LblNombreCompleto.Size = new System.Drawing.Size(117, 16);
            this.LblNombreCompleto.TabIndex = 9;
            this.LblNombreCompleto.Text = "Nombre Completo";
            // 
            // PicUsuario
            // 
            this.PicUsuario.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Usuario2;
            this.PicUsuario.InitialImage = null;
            this.PicUsuario.Location = new System.Drawing.Point(32, 28);
            this.PicUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicUsuario.Name = "PicUsuario";
            this.PicUsuario.Size = new System.Drawing.Size(75, 75);
            this.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUsuario.TabIndex = 7;
            this.PicUsuario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BtnRegistrarUsuario);
            this.panel1.Controls.Add(this.BtnModificarUsuario);
            this.panel1.Controls.Add(this.BtnEliminarUsuario);
            this.panel1.Location = new System.Drawing.Point(-8, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 823);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Location = new System.Drawing.Point(11, 542);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 1);
            this.panel5.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(11, 272);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 1);
            this.panel4.TabIndex = 16;
            // 
            // BtnRegistrarUsuario
            // 
            this.BtnRegistrarUsuario.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoRegistrarUsuario;
            this.BtnRegistrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(6, -3);
            this.BtnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(272, 277);
            this.BtnRegistrarUsuario.TabIndex = 1;
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // BtnModificarUsuario
            // 
            this.BtnModificarUsuario.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoModificarUsuario;
            this.BtnModificarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarUsuario.Location = new System.Drawing.Point(3, 272);
            this.BtnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificarUsuario.Name = "BtnModificarUsuario";
            this.BtnModificarUsuario.Size = new System.Drawing.Size(275, 270);
            this.BtnModificarUsuario.TabIndex = 2;
            this.BtnModificarUsuario.UseVisualStyleBackColor = true;
            this.BtnModificarUsuario.Click += new System.EventHandler(this.BtnModificarUsuario_Click);
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoEliminarUsuario;
            this.BtnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(3, 542);
            this.BtnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(276, 281);
            this.BtnEliminarUsuario.TabIndex = 3;
            this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
            this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // CatalogoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(1781, 953);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelCatalogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatalogoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Usuarios Operativos";
            this.Load += new System.EventHandler(this.CatalogoUsuarios_Load);
            this.Shown += new System.EventHandler(this.CatalogoUsuarios_Shown);
            this.PanelCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicIndicaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelCatalogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label LblPermiso;
        public System.Windows.Forms.Label LblUsuario;
        public System.Windows.Forms.Label LblNombreCompleto;
        private System.Windows.Forms.PictureBox PicUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnRegistrarUsuario;
        private System.Windows.Forms.Button BtnModificarUsuario;
        private System.Windows.Forms.PictureBox PicIndicaciones;
        private System.Windows.Forms.ToolTip ToolTipCatalogo;
    }
}