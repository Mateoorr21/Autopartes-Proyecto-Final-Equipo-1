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
            this.components = new System.ComponentModel.Container();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RdId = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.ToolTipBuscarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnRestaurarBusqueda = new System.Windows.Forms.Button();
            this.BtnMostrarProducto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.PicImagenProducto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.LvProductos.Location = new System.Drawing.Point(309, 191);
            this.LvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(931, 557);
            this.LvProductos.TabIndex = 8;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvProductos_ColumnClick);
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(999, 756);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(172, 16);
            this.LblCantidadRegistros.TabIndex = 131;
            this.LblCantidadRegistros.Tag = "Productos Encontrados:";
            this.LblCantidadRegistros.Text = "Productos Encontrados:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.RdExacta);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.RdAproximada);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(44, 191);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 150);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // RdExacta
            // 
            this.RdExacta.AutoSize = true;
            this.RdExacta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdExacta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdExacta.Location = new System.Drawing.Point(36, 97);
            this.RdExacta.Margin = new System.Windows.Forms.Padding(4);
            this.RdExacta.Name = "RdExacta";
            this.RdExacta.Size = new System.Drawing.Size(77, 25);
            this.RdExacta.TabIndex = 3;
            this.RdExacta.Text = "Exacta";
            this.RdExacta.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 149);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 1);
            this.panel5.TabIndex = 3;
            // 
            // RdAproximada
            // 
            this.RdAproximada.AutoSize = true;
            this.RdAproximada.Checked = true;
            this.RdAproximada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdAproximada.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdAproximada.Location = new System.Drawing.Point(36, 60);
            this.RdAproximada.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel4.Location = new System.Drawing.Point(239, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 104);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 104);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.PicLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 46);
            this.panel2.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoBusqueda;
            this.PicLogo.Location = new System.Drawing.Point(5, -5);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(225, 57);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 134;
            this.PicLogo.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Controls.Add(this.RdId);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.RdNombre);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Location = new System.Drawing.Point(43, 353);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 148);
            this.panel6.TabIndex = 4;
            this.panel6.TabStop = true;
            // 
            // RdId
            // 
            this.RdId.AutoSize = true;
            this.RdId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdId.Location = new System.Drawing.Point(37, 97);
            this.RdId.Margin = new System.Windows.Forms.Padding(4);
            this.RdId.Name = "RdId";
            this.RdId.Size = new System.Drawing.Size(120, 25);
            this.RdId.TabIndex = 5;
            this.RdId.Text = "Id_Producto";
            this.RdId.UseVisualStyleBackColor = true;
            this.RdId.CheckedChanged += new System.EventHandler(this.RdId_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Tan;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 147);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 1);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Tan;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(239, 46);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 102);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Tan;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 46);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 102);
            this.panel9.TabIndex = 1;
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Checked = true;
            this.RdNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdNombre.Location = new System.Drawing.Point(37, 60);
            this.RdNombre.Margin = new System.Windows.Forms.Padding(4);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(91, 25);
            this.RdNombre.TabIndex = 4;
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
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 46);
            this.panel10.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoPorCampo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.BackColor = System.Drawing.Color.Transparent;
            this.LblCampoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampoBuscar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LblCampoBuscar.Location = new System.Drawing.Point(55, 514);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(76, 20);
            this.LblCampoBuscar.TabIndex = 135;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel11.Controls.Add(this.TxtBuscar);
            this.panel11.Controls.Add(this.pictureBox3);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(44, 526);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(237, 82);
            this.panel11.TabIndex = 6;
            this.panel11.TabStop = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtBuscar.Location = new System.Drawing.Point(27, 34);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscar.MaxLength = 50;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(191, 15);
            this.TxtBuscar.TabIndex = 6;
            this.TxtBuscar.Tag = "Buscar...";
            this.TxtBuscar.Text = "Buscar...";
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(12, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(217, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 130;
            this.pictureBox3.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Tan;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(1, 81);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(235, 1);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Tan;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(236, 1);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 81);
            this.panel13.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Tan;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 1);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1, 81);
            this.panel14.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Tan;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(237, 1);
            this.panel15.TabIndex = 0;
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(57, 594);
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
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(72, 629);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(172, 144);
            this.BtnBuscar.TabIndex = 7;
            this.ToolTipBuscarProducto.SetToolTip(this.BtnBuscar, "Buscar producto");
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnRestaurarBusqueda
            // 
            this.BtnRestaurarBusqueda.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnRestaurarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRestaurarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurarBusqueda.FlatAppearance.BorderSize = 0;
            this.BtnRestaurarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurarBusqueda.Location = new System.Drawing.Point(1260, 527);
            this.BtnRestaurarBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRestaurarBusqueda.Name = "BtnRestaurarBusqueda";
            this.BtnRestaurarBusqueda.Size = new System.Drawing.Size(221, 187);
            this.BtnRestaurarBusqueda.TabIndex = 10;
            this.ToolTipBuscarProducto.SetToolTip(this.BtnRestaurarBusqueda, "Resetear acción");
            this.BtnRestaurarBusqueda.UseVisualStyleBackColor = true;
            this.BtnRestaurarBusqueda.Click += new System.EventHandler(this.BtnRestaurarBusqueda_Click);
            // 
            // BtnMostrarProducto
            // 
            this.BtnMostrarProducto.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonMostrarProducto;
            this.BtnMostrarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMostrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrarProducto.FlatAppearance.BorderSize = 0;
            this.BtnMostrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarProducto.Location = new System.Drawing.Point(1267, 206);
            this.BtnMostrarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMostrarProducto.Name = "BtnMostrarProducto";
            this.BtnMostrarProducto.Size = new System.Drawing.Size(207, 85);
            this.BtnMostrarProducto.TabIndex = 9;
            this.ToolTipBuscarProducto.SetToolTip(this.BtnMostrarProducto, "Mostrar detalles de producto");
            this.BtnMostrarProducto.UseVisualStyleBackColor = true;
            this.BtnMostrarProducto.Click += new System.EventHandler(this.BtnMostrarProducto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TituloBuscarProducto;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(303, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(908, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 127;
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
            this.pictureBox7.TabIndex = 128;
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
            this.pictureBox8.TabIndex = 129;
            this.pictureBox8.TabStop = false;
            // 
            // PicImagenProducto
            // 
            this.PicImagenProducto.Location = new System.Drawing.Point(1260, 316);
            this.PicImagenProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicImagenProducto.Name = "PicImagenProducto";
            this.PicImagenProducto.Size = new System.Drawing.Size(221, 193);
            this.PicImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagenProducto.TabIndex = 62;
            this.PicImagenProducto.TabStop = false;
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuscarProducto";
            this.Size = new System.Drawing.Size(1513, 823);
            this.Load += new System.EventHandler(this.BuscarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.ToolTip ToolTipBuscarProducto;
    }
}
