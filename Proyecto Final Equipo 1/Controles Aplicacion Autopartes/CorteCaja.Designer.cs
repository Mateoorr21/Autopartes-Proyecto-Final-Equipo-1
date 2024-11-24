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
            this.PicTextoCorte = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PanelCorteCaja = new System.Windows.Forms.Panel();
            this.LblErrorDineroFinal = new System.Windows.Forms.Label();
            this.TxtDineroFinal = new System.Windows.Forms.TextBox();
            this.TxtDineroFisico = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnMostrarVenta = new System.Windows.Forms.Button();
            this.BtnCorteCaja = new System.Windows.Forms.Button();
            this.TxtDineroVentas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDineroInicial = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolTipCorte = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTextoCorte)).BeginInit();
            this.PanelCorteCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDineroFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.LvVentas.Location = new System.Drawing.Point(36, 178);
            this.LvVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LvVentas.MultiSelect = false;
            this.LvVentas.Name = "LvVentas";
            this.LvVentas.Size = new System.Drawing.Size(1149, 569);
            this.LvVentas.TabIndex = 1;
            this.LvVentas.UseCompatibleStateImageBehavior = false;
            this.LvVentas.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvVentas_ColumnClick);
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(976, 756);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(172, 20);
            this.LblCantidadRegistros.TabIndex = 146;
            this.LblCantidadRegistros.Tag = "Ventas Realizadas:";
            this.LblCantidadRegistros.Text = "Ventas Realizadas:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.PicTextoCorte);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 43);
            this.panel2.TabIndex = 0;
            // 
            // PicTextoCorte
            // 
            this.PicTextoCorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicTextoCorte.BackColor = System.Drawing.Color.Transparent;
            this.PicTextoCorte.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoCorte;
            this.PicTextoCorte.Location = new System.Drawing.Point(49, -2);
            this.PicTextoCorte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicTextoCorte.Name = "PicTextoCorte";
            this.PicTextoCorte.Size = new System.Drawing.Size(155, 49);
            this.PicTextoCorte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTextoCorte.TabIndex = 134;
            this.PicTextoCorte.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 527);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(258, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 527);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(34)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 569);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 1);
            this.panel5.TabIndex = 3;
            // 
            // PanelCorteCaja
            // 
            this.PanelCorteCaja.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelCorteCaja.Controls.Add(this.LblErrorDineroFinal);
            this.PanelCorteCaja.Controls.Add(this.TxtDineroFinal);
            this.PanelCorteCaja.Controls.Add(this.TxtDineroFisico);
            this.PanelCorteCaja.Controls.Add(this.label3);
            this.PanelCorteCaja.Controls.Add(this.BtnCancelar);
            this.PanelCorteCaja.Controls.Add(this.BtnMostrarVenta);
            this.PanelCorteCaja.Controls.Add(this.BtnCorteCaja);
            this.PanelCorteCaja.Controls.Add(this.TxtDineroVentas);
            this.PanelCorteCaja.Controls.Add(this.pictureBox1);
            this.PanelCorteCaja.Controls.Add(this.label2);
            this.PanelCorteCaja.Controls.Add(this.TxtDineroInicial);
            this.PanelCorteCaja.Controls.Add(this.pictureBox5);
            this.PanelCorteCaja.Controls.Add(this.label1);
            this.PanelCorteCaja.Controls.Add(this.panel5);
            this.PanelCorteCaja.Controls.Add(this.panel4);
            this.PanelCorteCaja.Controls.Add(this.panel3);
            this.PanelCorteCaja.Controls.Add(this.panel2);
            this.PanelCorteCaja.Location = new System.Drawing.Point(1217, 178);
            this.PanelCorteCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelCorteCaja.Name = "PanelCorteCaja";
            this.PanelCorteCaja.Size = new System.Drawing.Size(259, 570);
            this.PanelCorteCaja.TabIndex = 2;
            this.PanelCorteCaja.TabStop = true;
            // 
            // LblErrorDineroFinal
            // 
            this.LblErrorDineroFinal.AutoSize = true;
            this.LblErrorDineroFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorDineroFinal.ForeColor = System.Drawing.Color.Red;
            this.LblErrorDineroFinal.Location = new System.Drawing.Point(17, 305);
            this.LblErrorDineroFinal.Name = "LblErrorDineroFinal";
            this.LblErrorDineroFinal.Size = new System.Drawing.Size(194, 20);
            this.LblErrorDineroFinal.TabIndex = 215;
            this.LblErrorDineroFinal.Text = "Solo números y un punto\r\n";
            this.LblErrorDineroFinal.Visible = false;
            // 
            // TxtDineroFinal
            // 
            this.TxtDineroFinal.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDineroFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDineroFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDineroFinal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDineroFinal.Location = new System.Drawing.Point(27, 278);
            this.TxtDineroFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDineroFinal.Name = "TxtDineroFinal";
            this.TxtDineroFinal.Size = new System.Drawing.Size(192, 19);
            this.TxtDineroFinal.TabIndex = 5;
            this.TxtDineroFinal.Tag = "0";
            this.TxtDineroFinal.Text = "0";
            this.TxtDineroFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDineroFinal_KeyPress);
            // 
            // TxtDineroFisico
            // 
            this.TxtDineroFisico.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.TxtDineroFisico.InitialImage = null;
            this.TxtDineroFisico.Location = new System.Drawing.Point(17, 271);
            this.TxtDineroFisico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDineroFisico.Name = "TxtDineroFisico";
            this.TxtDineroFisico.Size = new System.Drawing.Size(224, 32);
            this.TxtDineroFisico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TxtDineroFisico.TabIndex = 212;
            this.TxtDineroFisico.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 210;
            this.label3.Text = "Dinero Final (MXN):";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(136, 57);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 102);
            this.BtnCancelar.TabIndex = 3;
            this.ToolTipCorte.SetToolTip(this.BtnCancelar, "Resetear acción");
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnMostrarVenta
            // 
            this.BtnMostrarVenta.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonMostrarVentarRecortado;
            this.BtnMostrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMostrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrarVenta.FlatAppearance.BorderSize = 0;
            this.BtnMostrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarVenta.Location = new System.Drawing.Point(12, 57);
            this.BtnMostrarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMostrarVenta.Name = "BtnMostrarVenta";
            this.BtnMostrarVenta.Size = new System.Drawing.Size(115, 101);
            this.BtnMostrarVenta.TabIndex = 2;
            this.ToolTipCorte.SetToolTip(this.BtnMostrarVenta, "Mostrar detalles de venta");
            this.BtnMostrarVenta.UseVisualStyleBackColor = true;
            this.BtnMostrarVenta.Click += new System.EventHandler(this.BtnMostrarVenta_Click);
            // 
            // BtnCorteCaja
            // 
            this.BtnCorteCaja.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonCorteCaja2;
            this.BtnCorteCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCorteCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCorteCaja.FlatAppearance.BorderSize = 0;
            this.BtnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorteCaja.Location = new System.Drawing.Point(56, 427);
            this.BtnCorteCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCorteCaja.Name = "BtnCorteCaja";
            this.BtnCorteCaja.Size = new System.Drawing.Size(155, 123);
            this.BtnCorteCaja.TabIndex = 6;
            this.ToolTipCorte.SetToolTip(this.BtnCorteCaja, "Corte de caja y cierre de sesión");
            this.BtnCorteCaja.UseVisualStyleBackColor = true;
            this.BtnCorteCaja.Click += new System.EventHandler(this.BtnCorteCaja_Click);
            // 
            // TxtDineroVentas
            // 
            this.TxtDineroVentas.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDineroVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDineroVentas.Enabled = false;
            this.TxtDineroVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDineroVentas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDineroVentas.Location = new System.Drawing.Point(31, 388);
            this.TxtDineroVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDineroVentas.Name = "TxtDineroVentas";
            this.TxtDineroVentas.Size = new System.Drawing.Size(205, 19);
            this.TxtDineroVentas.TabIndex = 5;
            this.TxtDineroVentas.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(19, 380);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 209;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 207;
            this.label2.Text = "Total de Ventas (MXN):";
            // 
            // TxtDineroInicial
            // 
            this.TxtDineroInicial.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDineroInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDineroInicial.Enabled = false;
            this.TxtDineroInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDineroInicial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDineroInicial.Location = new System.Drawing.Point(29, 201);
            this.TxtDineroInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDineroInicial.Name = "TxtDineroInicial";
            this.TxtDineroInicial.Size = new System.Drawing.Size(191, 19);
            this.TxtDineroInicial.TabIndex = 4;
            this.TxtDineroInicial.Tag = "";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(17, 194);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(224, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 206;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 204;
            this.label1.Text = "Dinero Inicial (MXN):";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TituloCorteCaja;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(355, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(832, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 142;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLlanta1;
            this.pictureBox7.Location = new System.Drawing.Point(-9, 38);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(544, 89);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 143;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.PatronLlanta1;
            this.pictureBox8.Location = new System.Drawing.Point(981, 38);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(549, 89);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 144;
            this.pictureBox8.TabStop = false;
            // 
            // CorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelCorteCaja);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LvVentas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CorteCaja";
            this.Size = new System.Drawing.Size(1513, 823);
            this.Load += new System.EventHandler(this.CorteCaja_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTextoCorte)).EndInit();
            this.PanelCorteCaja.ResumeLayout(false);
            this.PanelCorteCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDineroFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.PictureBox PicTextoCorte;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel PanelCorteCaja;
        private System.Windows.Forms.TextBox TxtDineroVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDineroInicial;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMostrarVenta;
        private System.Windows.Forms.Button BtnCorteCaja;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ToolTip ToolTipCorte;
        private System.Windows.Forms.TextBox TxtDineroFinal;
        private System.Windows.Forms.PictureBox TxtDineroFisico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblErrorDineroFinal;
    }
}
