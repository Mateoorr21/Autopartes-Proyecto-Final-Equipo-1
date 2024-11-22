namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class CorteCaja
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
            this.LvVentas = new System.Windows.Forms.ListView();
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDineroCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDineroVentas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnMostrarVenta = new System.Windows.Forms.Button();
            this.BtnRegistrarVentas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.BtnCargarVentas = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.ToolTipCorte = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // LvVentas
            // 
            this.LvVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            this.LvVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvVentas.HideSelection = false;
            this.LvVentas.Location = new System.Drawing.Point(27, 155);
            this.LvVentas.MultiSelect = false;
            this.LvVentas.Name = "LvVentas";
            this.LvVentas.Size = new System.Drawing.Size(863, 453);
            this.LvVentas.TabIndex = 145;
            this.LvVentas.UseCompatibleStateImageBehavior = false;
            this.LvVentas.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvVentas_ColumnClick);
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(732, 614);
            this.LblCantidadRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(142, 16);
            this.LblCantidadRegistros.TabIndex = 146;
            this.LblCantidadRegistros.Tag = "Ventas Realizadas:";
            this.LblCantidadRegistros.Text = "Ventas Realizadas:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.PicLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 41);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 412);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(193, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 412);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 452);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnMostrarVenta);
            this.panel1.Controls.Add(this.BtnRegistrarVentas);
            this.panel1.Controls.Add(this.TxtDineroVentas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtDineroCaja);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCargarVentas);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(913, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 453);
            this.panel1.TabIndex = 147;
            // 
            // TxtDineroCaja
            // 
            this.TxtDineroCaja.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDineroCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDineroCaja.Enabled = false;
            this.TxtDineroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDineroCaja.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDineroCaja.Location = new System.Drawing.Point(18, 179);
            this.TxtDineroCaja.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDineroCaja.Name = "TxtDineroCaja";
            this.TxtDineroCaja.Size = new System.Drawing.Size(154, 15);
            this.TxtDineroCaja.TabIndex = 205;
            this.TxtDineroCaja.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 204;
            this.label1.Text = "Dinero en Caja (MXN):";
            // 
            // TxtDineroVentas
            // 
            this.TxtDineroVentas.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDineroVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDineroVentas.Enabled = false;
            this.TxtDineroVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDineroVentas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDineroVentas.Location = new System.Drawing.Point(18, 238);
            this.TxtDineroVentas.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDineroVentas.Name = "TxtDineroVentas";
            this.TxtDineroVentas.Size = new System.Drawing.Size(154, 15);
            this.TxtDineroVentas.TabIndex = 208;
            this.TxtDineroVentas.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(9, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 207;
            this.label2.Text = "Dinero de Ventas (MXN):";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(100, 367);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 80);
            this.BtnCancelar.TabIndex = 214;
            this.ToolTipCorte.SetToolTip(this.BtnCancelar, "Resetear acción");
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnMostrarVenta
            // 
            this.BtnMostrarVenta.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonMostrarVenta;
            this.BtnMostrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMostrarVenta.FlatAppearance.BorderSize = 0;
            this.BtnMostrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarVenta.Location = new System.Drawing.Point(12, 263);
            this.BtnMostrarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMostrarVenta.Name = "BtnMostrarVenta";
            this.BtnMostrarVenta.Size = new System.Drawing.Size(176, 91);
            this.BtnMostrarVenta.TabIndex = 213;
            this.ToolTipCorte.SetToolTip(this.BtnMostrarVenta, "Mostrar detalles de venta");
            this.BtnMostrarVenta.UseVisualStyleBackColor = true;
            this.BtnMostrarVenta.Click += new System.EventHandler(this.BtnMostrarVenta_Click);
            // 
            // BtnRegistrarVentas
            // 
            this.BtnRegistrarVentas.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonRegistrarVentas;
            this.BtnRegistrarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarVentas.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarVentas.Location = new System.Drawing.Point(10, 368);
            this.BtnRegistrarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrarVentas.Name = "BtnRegistrarVentas";
            this.BtnRegistrarVentas.Size = new System.Drawing.Size(87, 78);
            this.BtnRegistrarVentas.TabIndex = 212;
            this.ToolTipCorte.SetToolTip(this.BtnRegistrarVentas, "Registrar ventas\r\ny cerrar sesión");
            this.BtnRegistrarVentas.UseVisualStyleBackColor = true;
            this.BtnRegistrarVentas.Click += new System.EventHandler(this.BtnRegistrarVentas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(9, 232);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 209;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(9, 173);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(179, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 206;
            this.pictureBox5.TabStop = false;
            // 
            // BtnCargarVentas
            // 
            this.BtnCargarVentas.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonCargarVentas;
            this.BtnCargarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCargarVentas.FlatAppearance.BorderSize = 0;
            this.BtnCargarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarVentas.Location = new System.Drawing.Point(34, 44);
            this.BtnCargarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCargarVentas.Name = "BtnCargarVentas";
            this.BtnCargarVentas.Size = new System.Drawing.Size(121, 105);
            this.BtnCargarVentas.TabIndex = 203;
            this.ToolTipCorte.SetToolTip(this.BtnCargarVentas, "Cargar ventas");
            this.BtnCargarVentas.UseVisualStyleBackColor = true;
            this.BtnCargarVentas.Click += new System.EventHandler(this.BtnCargarVentas_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoVentasBlanco;
            this.PicLogo.Location = new System.Drawing.Point(23, -1);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(149, 41);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 134;
            this.PicLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TituloCorteCaja;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(266, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(624, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 142;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLlanta1;
            this.pictureBox7.Location = new System.Drawing.Point(-7, 31);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(408, 72);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 143;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLlanta1;
            this.pictureBox8.Location = new System.Drawing.Point(736, 31);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(412, 72);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 144;
            this.pictureBox8.TabStop = false;
            // 
            // CorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LvVentas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CorteCaja";
            this.Size = new System.Drawing.Size(1135, 669);
            this.Load += new System.EventHandler(this.CorteCaja_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView LvVentas;
        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCargarVentas;
        private System.Windows.Forms.TextBox TxtDineroVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDineroCaja;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMostrarVenta;
        private System.Windows.Forms.Button BtnRegistrarVentas;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ToolTip ToolTipCorte;
    }
}
