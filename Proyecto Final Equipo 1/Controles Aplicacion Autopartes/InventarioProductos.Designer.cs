namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class InventarioProductos
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
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.PanelAddInventario = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblErrorCantidad = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.BtnAgregarInventario = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PanelAddInventario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(578, 622);
            this.LblCantidadRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(173, 16);
            this.LblCantidadRegistros.TabIndex = 83;
            this.LblCantidadRegistros.Tag = "Cantidad de Productos: ";
            this.LblCantidadRegistros.Text = "Cantidad de Productos: ";
            // 
            // LvProductos
            // 
            this.LvProductos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LvProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvProductos.HideSelection = false;
            this.LvProductos.Location = new System.Drawing.Point(51, 155);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(716, 464);
            this.LvProductos.TabIndex = 76;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvProductos_ColumnClick);
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // PanelAddInventario
            // 
            this.PanelAddInventario.Controls.Add(this.BtnAgregarInventario);
            this.PanelAddInventario.Controls.Add(this.BtnCancelar);
            this.PanelAddInventario.Controls.Add(this.BtnMenos);
            this.PanelAddInventario.Controls.Add(this.BtnMas);
            this.PanelAddInventario.Controls.Add(this.LblErrorCantidad);
            this.PanelAddInventario.Controls.Add(this.Txt_Cantidad);
            this.PanelAddInventario.Controls.Add(this.pictureBox3);
            this.PanelAddInventario.Controls.Add(this.TxtProducto);
            this.PanelAddInventario.Controls.Add(this.pictureBox1);
            this.PanelAddInventario.Controls.Add(this.LblCantidad);
            this.PanelAddInventario.Controls.Add(this.LblProducto);
            this.PanelAddInventario.Controls.Add(this.panel5);
            this.PanelAddInventario.Controls.Add(this.panel4);
            this.PanelAddInventario.Controls.Add(this.panel3);
            this.PanelAddInventario.Controls.Add(this.panel2);
            this.PanelAddInventario.Location = new System.Drawing.Point(782, 155);
            this.PanelAddInventario.Name = "PanelAddInventario";
            this.PanelAddInventario.Size = new System.Drawing.Size(303, 464);
            this.PanelAddInventario.TabIndex = 133;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 463);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(301, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(302, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 427);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 427);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.PicLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 37);
            this.panel2.TabIndex = 0;
            // 
            // LblErrorCantidad
            // 
            this.LblErrorCantidad.AutoSize = true;
            this.LblErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.LblErrorCantidad.Location = new System.Drawing.Point(17, 209);
            this.LblErrorCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorCantidad.Name = "LblErrorCantidad";
            this.LblErrorCantidad.Size = new System.Drawing.Size(242, 16);
            this.LblErrorCantidad.TabIndex = 143;
            this.LblErrorCantidad.Text = "Solo admite números enteros positivos ";
            this.LblErrorCantidad.Visible = false;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Cantidad.Location = new System.Drawing.Point(25, 177);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(248, 15);
            this.Txt_Cantidad.TabIndex = 2;
            this.Txt_Cantidad.Tag = "0";
            this.Txt_Cantidad.Text = "0";
            // 
            // TxtProducto
            // 
            this.TxtProducto.BackColor = System.Drawing.SystemColors.Control;
            this.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProducto.Enabled = false;
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtProducto.Location = new System.Drawing.Point(24, 84);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(248, 15);
            this.TxtProducto.TabIndex = 1;
            this.TxtProducto.Tag = "Nombre del Producto";
            this.TxtProducto.Text = "Nombre del Producto";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblCantidad.Location = new System.Drawing.Point(13, 137);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(175, 20);
            this.LblCantidad.TabIndex = 139;
            this.LblCantidad.Text = "Cantidad a Agregar: \r\n";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblProducto.Location = new System.Drawing.Point(12, 44);
            this.LblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(175, 20);
            this.LblProducto.TabIndex = 138;
            this.LblProducto.Text = "Producto a Agregar: \r\n";
            // 
            // BtnAgregarInventario
            // 
            this.BtnAgregarInventario.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonInventario;
            this.BtnAgregarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarInventario.FlatAppearance.BorderSize = 0;
            this.BtnAgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarInventario.Location = new System.Drawing.Point(19, 320);
            this.BtnAgregarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregarInventario.Name = "BtnAgregarInventario";
            this.BtnAgregarInventario.Size = new System.Drawing.Size(144, 137);
            this.BtnAgregarInventario.TabIndex = 5;
            this.BtnAgregarInventario.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(163, 325);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(133, 128);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnMenos
            // 
            this.BtnMenos.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.BotonMenosDes;
            this.BtnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenos.Enabled = false;
            this.BtnMenos.FlatAppearance.BorderSize = 0;
            this.BtnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenos.Location = new System.Drawing.Point(173, 232);
            this.BtnMenos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(86, 80);
            this.BtnMenos.TabIndex = 4;
            this.BtnMenos.UseVisualStyleBackColor = true;
            // 
            // BtnMas
            // 
            this.BtnMas.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.BotonMasDes;
            this.BtnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMas.Enabled = false;
            this.BtnMas.FlatAppearance.BorderSize = 0;
            this.BtnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMas.Location = new System.Drawing.Point(53, 232);
            this.BtnMas.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(86, 80);
            this.BtnMas.TabIndex = 3;
            this.BtnMas.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(17, 166);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 142;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoInventario;
            this.PicLogo.Location = new System.Drawing.Point(67, -5);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(169, 46);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 135;
            this.PicLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TituloAgregarInventario;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(227, -8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(681, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 124;
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
            this.pictureBox7.TabIndex = 125;
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
            this.pictureBox8.TabIndex = 126;
            this.pictureBox8.TabStop = false;
            // 
            // InventarioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelAddInventario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LvProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventarioProductos";
            this.Size = new System.Drawing.Size(1135, 669);
            this.Load += new System.EventHandler(this.InventarioProductos_Load);
            this.PanelAddInventario.ResumeLayout(false);
            this.PanelAddInventario.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel PanelAddInventario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAgregarInventario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.Label LblErrorCantidad;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.PictureBox PicLogo;
    }
}
