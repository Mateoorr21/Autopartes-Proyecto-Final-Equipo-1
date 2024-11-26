namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class Ventas
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
            this.LvCarrito = new System.Windows.Forms.ListView();
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RdId = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblCantidadRegistrosBuscar = new System.Windows.Forms.Label();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.LblCantidadRegistrosCarrito = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnCancelarVenta = new System.Windows.Forms.Button();
            this.BtnEliminarRegistroCarrito = new System.Windows.Forms.Button();
            this.TxtPorPagar = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVaciarCarrito = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.LblErrorCantidad = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.ToolTipVentas = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // LvCarrito
            // 
            this.LvCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.LvCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvCarrito.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LvCarrito.HideSelection = false;
            this.LvCarrito.Location = new System.Drawing.Point(852, 191);
            this.LvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.LvCarrito.MultiSelect = false;
            this.LvCarrito.Name = "LvCarrito";
            this.LvCarrito.Size = new System.Drawing.Size(619, 387);
            this.LvCarrito.TabIndex = 18;
            this.LvCarrito.UseCompatibleStateImageBehavior = false;
            this.LvCarrito.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvCarrito_ColumnClick);
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(57, 562);
            this.LblErrorBuscar.Name = "LblErrorBuscar";
            this.LblErrorBuscar.Size = new System.Drawing.Size(118, 16);
            this.LblErrorBuscar.TabIndex = 170;
            this.LblErrorBuscar.Text = "Caracter no Valido";
            this.LblErrorBuscar.Visible = false;
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.LblCampoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampoBuscar.ForeColor = System.Drawing.Color.Indigo;
            this.LblCampoBuscar.Location = new System.Drawing.Point(55, 482);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(76, 20);
            this.LblCampoBuscar.TabIndex = 169;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel11.Controls.Add(this.TxtBuscar);
            this.panel11.Controls.Add(this.pictureBox3);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(44, 494);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(237, 82);
            this.panel11.TabIndex = 7;
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
            this.TxtBuscar.TabIndex = 7;
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
            this.panel12.BackColor = System.Drawing.Color.Indigo;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(1, 81);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(235, 1);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Indigo;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(236, 1);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 81);
            this.panel13.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Indigo;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 1);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1, 81);
            this.panel14.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Indigo;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(237, 1);
            this.panel15.TabIndex = 0;
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
            this.panel6.Location = new System.Drawing.Point(43, 341);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 133);
            this.panel6.TabIndex = 5;
            this.panel6.TabStop = true;
            // 
            // RdId
            // 
            this.RdId.AutoSize = true;
            this.RdId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdId.Location = new System.Drawing.Point(37, 90);
            this.RdId.Margin = new System.Windows.Forms.Padding(4);
            this.RdId.Name = "RdId";
            this.RdId.Size = new System.Drawing.Size(120, 25);
            this.RdId.TabIndex = 6;
            this.RdId.Text = "Id_Producto";
            this.RdId.UseVisualStyleBackColor = true;
            this.RdId.CheckedChanged += new System.EventHandler(this.RdId_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Indigo;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(1, 132);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 1);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Indigo;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(239, 46);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 87);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Indigo;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 46);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 87);
            this.panel9.TabIndex = 1;
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Checked = true;
            this.RdNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RdNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdNombre.Location = new System.Drawing.Point(37, 53);
            this.RdNombre.Margin = new System.Windows.Forms.Padding(4);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(91, 25);
            this.RdNombre.TabIndex = 5;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            this.RdNombre.CheckedChanged += new System.EventHandler(this.RdNombre_CheckedChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Indigo;
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
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoPorCampoBlanco;
            this.pictureBox1.Location = new System.Drawing.Point(9, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
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
            this.panel1.Size = new System.Drawing.Size(240, 140);
            this.panel1.TabIndex = 2;
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
            this.RdExacta.TabIndex = 4;
            this.RdExacta.Text = "Exacta";
            this.RdExacta.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 139);
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
            this.RdAproximada.TabIndex = 2;
            this.RdAproximada.TabStop = true;
            this.RdAproximada.Text = "Aproximada";
            this.RdAproximada.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(239, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 94);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 94);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
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
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoBusquedaBlanco;
            this.PicLogo.Location = new System.Drawing.Point(11, -6);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(225, 57);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 134;
            this.PicLogo.TabStop = false;
            // 
            // LblCantidadRegistrosBuscar
            // 
            this.LblCantidadRegistrosBuscar.AutoSize = true;
            this.LblCantidadRegistrosBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistrosBuscar.Location = new System.Drawing.Point(591, 167);
            this.LblCantidadRegistrosBuscar.Name = "LblCantidadRegistrosBuscar";
            this.LblCantidadRegistrosBuscar.Size = new System.Drawing.Size(172, 16);
            this.LblCantidadRegistrosBuscar.TabIndex = 165;
            this.LblCantidadRegistrosBuscar.Tag = "Productos Encontrados:";
            this.LblCantidadRegistrosBuscar.Text = "Productos Encontrados:";
            // 
            // LvProductos
            // 
            this.LvProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.LvProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvProductos.HideSelection = false;
            this.LvProductos.Location = new System.Drawing.Point(297, 191);
            this.LvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(541, 387);
            this.LvProductos.TabIndex = 1;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvProductos_ColumnClick);
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // LblCantidadRegistrosCarrito
            // 
            this.LblCantidadRegistrosCarrito.AutoSize = true;
            this.LblCantidadRegistrosCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistrosCarrito.Location = new System.Drawing.Point(1255, 167);
            this.LblCantidadRegistrosCarrito.Name = "LblCantidadRegistrosCarrito";
            this.LblCantidadRegistrosCarrito.Size = new System.Drawing.Size(152, 16);
            this.LblCantidadRegistrosCarrito.TabIndex = 172;
            this.LblCantidadRegistrosCarrito.Tag = "Productos en Carrito:";
            this.LblCantidadRegistrosCarrito.Text = "Productos en Carrito:";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel16.Controls.Add(this.BtnVender);
            this.panel16.Controls.Add(this.BtnCancelarVenta);
            this.panel16.Controls.Add(this.BtnEliminarRegistroCarrito);
            this.panel16.Controls.Add(this.TxtPorPagar);
            this.panel16.Controls.Add(this.pictureBox6);
            this.panel16.Controls.Add(this.label1);
            this.panel16.Controls.Add(this.BtnVaciarCarrito);
            this.panel16.Controls.Add(this.BtnMenos);
            this.panel16.Controls.Add(this.BtnMas);
            this.panel16.Controls.Add(this.LblErrorCantidad);
            this.panel16.Controls.Add(this.Txt_Cantidad);
            this.panel16.Controls.Add(this.pictureBox5);
            this.panel16.Controls.Add(this.LblCantidad);
            this.panel16.Controls.Add(this.TxtProducto);
            this.panel16.Controls.Add(this.pictureBox4);
            this.panel16.Controls.Add(this.LblProducto);
            this.panel16.Controls.Add(this.BtnAgregarCarrito);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.panel18);
            this.panel16.Controls.Add(this.panel19);
            this.panel16.Controls.Add(this.panel20);
            this.panel16.Location = new System.Drawing.Point(488, 586);
            this.panel16.Margin = new System.Windows.Forms.Padding(4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(985, 225);
            this.panel16.TabIndex = 10;
            this.panel16.TabStop = true;
            // 
            // BtnVender
            // 
            this.BtnVender.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonVentaRecortada;
            this.BtnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVender.FlatAppearance.BorderSize = 0;
            this.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVender.Location = new System.Drawing.Point(855, 41);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(119, 86);
            this.BtnVender.TabIndex = 17;
            this.ToolTipVentas.SetToolTip(this.BtnVender, "Venta de productos");
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // BtnCancelarVenta
            // 
            this.BtnCancelarVenta.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonCancelarVenta2;
            this.BtnCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarVenta.FlatAppearance.BorderSize = 0;
            this.BtnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarVenta.Location = new System.Drawing.Point(791, 132);
            this.BtnCancelarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelarVenta.Name = "BtnCancelarVenta";
            this.BtnCancelarVenta.Size = new System.Drawing.Size(179, 89);
            this.BtnCancelarVenta.TabIndex = 16;
            this.ToolTipVentas.SetToolTip(this.BtnCancelarVenta, "Cancelar venta");
            this.BtnCancelarVenta.UseVisualStyleBackColor = true;
            this.BtnCancelarVenta.Click += new System.EventHandler(this.BtnCancelarVenta_Click);
            // 
            // BtnEliminarRegistroCarrito
            // 
            this.BtnEliminarRegistroCarrito.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonEliminarDeCarrito31;
            this.BtnEliminarRegistroCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarRegistroCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarRegistroCarrito.FlatAppearance.BorderSize = 0;
            this.BtnEliminarRegistroCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarRegistroCarrito.Location = new System.Drawing.Point(523, 110);
            this.BtnEliminarRegistroCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarRegistroCarrito.Name = "BtnEliminarRegistroCarrito";
            this.BtnEliminarRegistroCarrito.Size = new System.Drawing.Size(120, 111);
            this.BtnEliminarRegistroCarrito.TabIndex = 14;
            this.ToolTipVentas.SetToolTip(this.BtnEliminarRegistroCarrito, "Eliminar de carrito");
            this.BtnEliminarRegistroCarrito.UseVisualStyleBackColor = true;
            this.BtnEliminarRegistroCarrito.Click += new System.EventHandler(this.BtnEliminarRegistroCarrito_Click);
            // 
            // TxtPorPagar
            // 
            this.TxtPorPagar.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPorPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPorPagar.Enabled = false;
            this.TxtPorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPorPagar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtPorPagar.Location = new System.Drawing.Point(547, 80);
            this.TxtPorPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPorPagar.Name = "TxtPorPagar";
            this.TxtPorPagar.Size = new System.Drawing.Size(280, 15);
            this.TxtPorPagar.TabIndex = 221;
            this.TxtPorPagar.TabStop = false;
            this.TxtPorPagar.Tag = "0";
            this.TxtPorPagar.Text = "0";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(536, 74);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(304, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 223;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(531, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 222;
            this.label1.Text = "Monto a Pagar IVA (MXN):\r\n";
            // 
            // BtnVaciarCarrito
            // 
            this.BtnVaciarCarrito.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonVaciarCarrito31;
            this.BtnVaciarCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVaciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVaciarCarrito.FlatAppearance.BorderSize = 0;
            this.BtnVaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVaciarCarrito.Location = new System.Drawing.Point(648, 110);
            this.BtnVaciarCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVaciarCarrito.Name = "BtnVaciarCarrito";
            this.BtnVaciarCarrito.Size = new System.Drawing.Size(120, 111);
            this.BtnVaciarCarrito.TabIndex = 15;
            this.ToolTipVentas.SetToolTip(this.BtnVaciarCarrito, "Vaciar carrito");
            this.BtnVaciarCarrito.UseVisualStyleBackColor = true;
            this.BtnVaciarCarrito.Click += new System.EventHandler(this.VaciarCarrito_Click);
            // 
            // BtnMenos
            // 
            this.BtnMenos.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.BotonMenosDes;
            this.BtnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenos.Enabled = false;
            this.BtnMenos.FlatAppearance.BorderSize = 0;
            this.BtnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenos.Location = new System.Drawing.Point(393, 151);
            this.BtnMenos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(68, 58);
            this.BtnMenos.TabIndex = 12;
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // BtnMas
            // 
            this.BtnMas.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.BotonMasDes;
            this.BtnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMas.Enabled = false;
            this.BtnMas.FlatAppearance.BorderSize = 0;
            this.BtnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMas.Location = new System.Drawing.Point(321, 151);
            this.BtnMas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(68, 58);
            this.BtnMas.TabIndex = 11;
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // LblErrorCantidad
            // 
            this.LblErrorCantidad.AutoSize = true;
            this.LblErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.LblErrorCantidad.Location = new System.Drawing.Point(19, 194);
            this.LblErrorCantidad.Name = "LblErrorCantidad";
            this.LblErrorCantidad.Size = new System.Drawing.Size(143, 16);
            this.LblErrorCantidad.TabIndex = 216;
            this.LblErrorCantidad.Text = "Solo enteros positivos ";
            this.LblErrorCantidad.Visible = false;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_Cantidad.Location = new System.Drawing.Point(31, 164);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(248, 15);
            this.Txt_Cantidad.TabIndex = 10;
            this.Txt_Cantidad.Tag = "0";
            this.Txt_Cantidad.Text = "0";
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Txt_Cantidad_TextChanged);
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(20, 158);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(271, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 215;
            this.pictureBox5.TabStop = false;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.Indigo;
            this.LblCantidad.Location = new System.Drawing.Point(15, 128);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(169, 20);
            this.LblCantidad.TabIndex = 214;
            this.LblCantidad.Text = "Cantidad a Vender: \r\n";
            // 
            // TxtProducto
            // 
            this.TxtProducto.BackColor = System.Drawing.SystemColors.Control;
            this.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProducto.Enabled = false;
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtProducto.Location = new System.Drawing.Point(31, 84);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(311, 15);
            this.TxtProducto.TabIndex = 0;
            this.TxtProducto.TabStop = false;
            this.TxtProducto.Tag = "Nombre del Producto";
            this.TxtProducto.Text = "Nombre del Producto";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(20, 78);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(328, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 212;
            this.pictureBox4.TabStop = false;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.ForeColor = System.Drawing.Color.Indigo;
            this.LblProducto.Location = new System.Drawing.Point(21, 48);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(164, 20);
            this.LblProducto.TabIndex = 211;
            this.LblProducto.Text = "Producto a Vender:";
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonAgregarCarrito3;
            this.BtnAgregarCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarCarrito.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(347, 41);
            this.BtnAgregarCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(115, 106);
            this.BtnAgregarCarrito.TabIndex = 13;
            this.ToolTipVentas.SetToolTip(this.BtnAgregarCarrito, "Añadir a carrito");
            this.BtnAgregarCarrito.UseVisualStyleBackColor = true;
            this.BtnAgregarCarrito.Click += new System.EventHandler(this.AgregarCarrito_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Indigo;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(1, 224);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(983, 1);
            this.panel17.TabIndex = 3;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Indigo;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(984, 31);
            this.panel18.Margin = new System.Windows.Forms.Padding(4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1, 194);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Indigo;
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(0, 31);
            this.panel19.Margin = new System.Windows.Forms.Padding(4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1, 194);
            this.panel19.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Indigo;
            this.panel20.Controls.Add(this.pictureBox9);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(985, 31);
            this.panel20.TabIndex = 0;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoVentasBlanco;
            this.pictureBox9.Location = new System.Drawing.Point(401, -1);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(137, 31);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 135;
            this.pictureBox9.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoReset;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(280, 610);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(181, 158);
            this.BtnCancelar.TabIndex = 9;
            this.ToolTipVentas.SetToolTip(this.BtnCancelar, "Resetear búsqueda");
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnRestaurarBusqueda_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonBuscarRecortado;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(60, 606);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(201, 162);
            this.BtnBuscar.TabIndex = 8;
            this.ToolTipVentas.SetToolTip(this.BtnBuscar, "Buscar producto");
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TituloVenderProductos;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(303, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(919, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 161;
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
            this.pictureBox7.TabIndex = 162;
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
            this.pictureBox8.TabIndex = 163;
            this.pictureBox8.TabStop = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblCantidadRegistrosCarrito);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblErrorBuscar);
            this.Controls.Add(this.LblCampoBuscar);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblCantidadRegistrosBuscar);
            this.Controls.Add(this.LvProductos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.LvCarrito);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(1513, 823);
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LvCarrito;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblErrorBuscar;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton RdId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton RdNombre;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RdExacta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton RdAproximada;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LblCantidadRegistrosBuscar;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label LblCantidadRegistrosCarrito;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button BtnCancelarVenta;
        private System.Windows.Forms.Button BtnEliminarRegistroCarrito;
        private System.Windows.Forms.TextBox TxtPorPagar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVaciarCarrito;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.Label LblErrorCantidad;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ToolTip ToolTipVentas;
    }
}
