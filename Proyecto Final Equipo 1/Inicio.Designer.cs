namespace Proyecto_Final_Equipo_1
{
    partial class Inicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BtnInicio = new System.Windows.Forms.Button();
            this.PicBienvenido = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBienvenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInicio.Location = new System.Drawing.Point(-18, 534);
            this.BtnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(537, 47);
            this.BtnInicio.TabIndex = 6;
            this.BtnInicio.Text = "I N G R E S AR";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // PicBienvenido
            // 
            this.PicBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.PicBienvenido.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.MensajeBienvenida2;
            this.PicBienvenido.Location = new System.Drawing.Point(126, 12);
            this.PicBienvenido.Name = "PicBienvenido";
            this.PicBienvenido.Size = new System.Drawing.Size(280, 96);
            this.PicBienvenido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBienvenido.TabIndex = 2;
            this.PicBienvenido.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(3, -35);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(504, 689);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 3;
            this.PicLogo.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(510, 580);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.PicBienvenido);
            this.Controls.Add(this.PicLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Sistema Tienda AutoPartes One";
            ((System.ComponentModel.ISupportInitialize)(this.PicBienvenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PicBienvenido;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnInicio;
    }
}

