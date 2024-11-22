namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class BuscarProducto
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
            this.LvProductos = new System.Windows.Forms.ListView();
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RdId = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnRestaurarBusqueda = new System.Windows.Forms.Button();
            this.BtnMostrarProducto = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PicImagenProducto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LvProductos
            // 
            this.LvProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(243)))));
            this.LvProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvProductos.HideSelection = false;
            this.LvProductos.Location = new System.Drawing.Point(232, 155);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(699, 453);
            this.LvProductos.TabIndex = 130;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvProductos_ColumnClick);
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(749, 614);
            this.LblCantidadRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(172, 16);
            this.LblCantidadRegistros.TabIndex = 131;
            this.LblCantidadRegistros.Tag = "Productos Encontrados:";
            this.LblCantidadRegistros.Text = "Productos Encontrados:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdExacta);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.RdAproximada);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(33, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 122);
            this.panel1.TabIndex = 132;
            // 
            // RdExacta
            // 
            this.RdExacta.AutoSize = true;
            this.RdExacta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdExacta.Location = new System.Drawing.Point(27, 79);
            this.RdExacta.Name = "RdExacta";
            this.RdExacta.Size = new System.Drawing.Size(77, 25);
            this.RdExacta.TabIndex = 2;
            this.RdExacta.Text = "Exacta";
            this.RdExacta.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 1);
            this.panel5.TabIndex = 3;
            // 
            // RdAproximada
            // 
            this.RdAproximada.AutoSize = true;
            this.RdAproximada.Checked = true;
            this.RdAproximada.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdAproximada.Location = new System.Drawing.Point(27, 49);
            this.RdAproximada.Name = "RdAproximada";
            this.RdAproximada.Size = new System.Drawing.Size(120, 25);
            this.RdAproximada.TabIndex = 1;
            this.RdAproximada.TabStop = true;
            this.RdAproximada.Text = "Aproximada";
            this.RdAproximada.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(179, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 85);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 85);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.PicLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 37);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.RdId);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.RdNombre);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Location = new System.Drawing.Point(32, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 120);
            this.panel6.TabIndex = 133;
            // 
            // RdId
            // 
            this.RdId.AutoSize = true;
            this.RdId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdId.Location = new System.Drawing.Point(28, 79);
            this.RdId.Name = "RdId";
            this.RdId.Size = new System.Drawing.Size(120, 25);
            this.RdId.TabIndex = 4;
            this.RdId.Text = "Id_Producto";
            this.RdId.UseVisualStyleBackColor = true;
            this.RdId.CheckedChanged += new System.EventHandler(this.RdId_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Tan;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(178, 1);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Tan;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(179, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 83);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Tan;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 83);
            this.panel9.TabIndex = 1;
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Checked = true;
            this.RdNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdNombre.Location = new System.Drawing.Point(28, 49);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(91, 25);
            this.RdNombre.TabIndex = 3;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            this.RdNombre.CheckedChanged += new System.EventHandler(this.RdNombre_CheckedChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Tan;
            this.panel10.Controls.Add(this.pictureBox1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(180, 37);
            this.panel10.TabIndex = 0;
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampoBuscar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LblCampoBuscar.Location = new System.Drawing.Point(41, 418);
            this.LblCampoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(76, 20);
            this.LblCampoBuscar.TabIndex = 135;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.TxtBuscar);
            this.panel11.Controls.Add(this.pictureBox3);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(33, 427);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(178, 67);
            this.panel11.TabIndex = 134;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscar.Location = new System.Drawing.Point(20, 28);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(143, 15);
            this.TxtBuscar.TabIndex = 5;
            this.TxtBuscar.Tag = "Buscar...";
            this.TxtBuscar.Text = "Buscar...";
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Tan;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(1, 66);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(176, 1);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Tan;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(177, 1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 66);
            this.panel13.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Tan;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1, 66);
            this.panel14.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Tan;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(178, 1);
            this.panel15.TabIndex = 0;
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(43, 483);
            this.LblErrorBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorBuscar.Name = "LblErrorBuscar";
            this.LblErrorBuscar.Size = new System.Drawing.Size(118, 16);
            this.LblErrorBuscar.TabIndex = 137;
            this.LblErrorBuscar.Text = "Caracter no Valido";
            this.LblErrorBuscar.Visible = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonBuscarRecortado;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(54, 511);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(129, 117);
            this.BtnBuscar.TabIndex = 157;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnRestaurarBusqueda
            // 
            this.BtnRestaurarBusqueda.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnRestaurarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRestaurarBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnRestaurarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurarBusqueda.Location = new System.Drawing.Point(945, 428);
            this.BtnRestaurarBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRestaurarBusqueda.Name = "BtnRestaurarBusqueda";
            this.BtnRestaurarBusqueda.Size = new System.Drawing.Size(166, 152);
            this.BtnRestaurarBusqueda.TabIndex = 8;
            this.BtnRestaurarBusqueda.UseVisualStyleBackColor = true;
            this.BtnRestaurarBusqueda.Click += new System.EventHandler(this.BtnRestaurarBusqueda_Click);
            // 
            // BtnMostrarProducto
            // 
            this.BtnMostrarProducto.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonMostrarProducto;
            this.BtnMostrarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMostrarProducto.FlatAppearance.BorderSize = 0;
            this.BtnMostrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarProducto.Location = new System.Drawing.Point(950, 167);
            this.BtnMostrarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMostrarProducto.Name = "BtnMostrarProducto";
            this.BtnMostrarProducto.Size = new System.Drawing.Size(155, 69);
            this.BtnMostrarProducto.TabIndex = 7;
            this.BtnMostrarProducto.UseVisualStyleBackColor = true;
            this.BtnMostrarProducto.Click += new System.EventHandler(this.BtnMostrarProducto_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(9, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 130;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoPorCampo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoBusqueda;
            this.PicLogo.Location = new System.Drawing.Point(4, -4);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(169, 46);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 134;
            this.PicLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TituloBuscarProducto;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(227, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(681, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 127;
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
            this.pictureBox7.TabIndex = 128;
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
            this.pictureBox8.TabIndex = 129;
            this.pictureBox8.TabStop = false;
            // 
            // PicImagenProducto
            // 
            this.PicImagenProducto.Location = new System.Drawing.Point(945, 257);
            this.PicImagenProducto.Margin = new System.Windows.Forms.Padding(2);
            this.PicImagenProducto.Name = "PicImagenProducto";
            this.PicImagenProducto.Size = new System.Drawing.Size(166, 157);
            this.PicImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagenProducto.TabIndex = 62;
            this.PicImagenProducto.TabStop = false;
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnRestaurarBusqueda);
            this.Controls.Add(this.BtnMostrarProducto);
            this.Controls.Add(this.LblErrorBuscar);
            this.Controls.Add(this.LblCampoBuscar);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LvProductos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.PicImagenProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscarProducto";
            this.Size = new System.Drawing.Size(1135, 669);
            this.Load += new System.EventHandler(this.BuscarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PicImagenProducto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RdExacta;
        private System.Windows.Forms.RadioButton RdAproximada;
        private System.Windows.Forms.RadioButton RdId;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblErrorBuscar;
        private System.Windows.Forms.Button BtnMostrarProducto;
        private System.Windows.Forms.Button BtnRestaurarBusqueda;
        private System.Windows.Forms.Button BtnBuscar;
    }
}
