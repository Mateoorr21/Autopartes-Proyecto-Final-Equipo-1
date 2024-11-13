namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    partial class EliminarProducto
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GpBBusquedaTipo = new System.Windows.Forms.GroupBox();
            this.RdExacta = new System.Windows.Forms.RadioButton();
            this.RdAproximada = new System.Windows.Forms.RadioButton();
            this.PicImagenProducto = new System.Windows.Forms.PictureBox();
            this.BtnMostrarProducto = new System.Windows.Forms.Button();
            this.LvProductos = new System.Windows.Forms.ListView();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblErrorBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCampoBuscar = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbBusquedaCampo = new System.Windows.Forms.GroupBox();
            this.RdId = new System.Windows.Forms.RadioButton();
            this.RdNombre = new System.Windows.Forms.RadioButton();
            this.GpBBusquedaTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).BeginInit();
            this.GbBusquedaCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(829, 337);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(173, 116);
            this.BtnEliminar.TabIndex = 81;
            this.BtnEliminar.Text = "Eliminar Producto";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GpBBusquedaTipo
            // 
            this.GpBBusquedaTipo.Controls.Add(this.RdExacta);
            this.GpBBusquedaTipo.Controls.Add(this.RdAproximada);
            this.GpBBusquedaTipo.Location = new System.Drawing.Point(25, 75);
            this.GpBBusquedaTipo.Margin = new System.Windows.Forms.Padding(4);
            this.GpBBusquedaTipo.Name = "GpBBusquedaTipo";
            this.GpBBusquedaTipo.Padding = new System.Windows.Forms.Padding(4);
            this.GpBBusquedaTipo.Size = new System.Drawing.Size(136, 99);
            this.GpBBusquedaTipo.TabIndex = 68;
            this.GpBBusquedaTipo.TabStop = false;
            this.GpBBusquedaTipo.Text = "Tipo de Busqueda";
            // 
            // RdExacta
            // 
            this.RdExacta.AutoSize = true;
            this.RdExacta.Location = new System.Drawing.Point(29, 52);
            this.RdExacta.Margin = new System.Windows.Forms.Padding(4);
            this.RdExacta.Name = "RdExacta";
            this.RdExacta.Size = new System.Drawing.Size(69, 20);
            this.RdExacta.TabIndex = 1;
            this.RdExacta.Text = "Exacta";
            this.RdExacta.UseVisualStyleBackColor = true;
            // 
            // RdAproximada
            // 
            this.RdAproximada.AutoSize = true;
            this.RdAproximada.Checked = true;
            this.RdAproximada.Location = new System.Drawing.Point(29, 23);
            this.RdAproximada.Margin = new System.Windows.Forms.Padding(4);
            this.RdAproximada.Name = "RdAproximada";
            this.RdAproximada.Size = new System.Drawing.Size(101, 20);
            this.RdAproximada.TabIndex = 0;
            this.RdAproximada.TabStop = true;
            this.RdAproximada.Text = "Aproximada";
            this.RdAproximada.UseVisualStyleBackColor = true;
            // 
            // PicImagenProducto
            // 
            this.PicImagenProducto.Location = new System.Drawing.Point(829, 165);
            this.PicImagenProducto.Name = "PicImagenProducto";
            this.PicImagenProducto.Size = new System.Drawing.Size(173, 165);
            this.PicImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImagenProducto.TabIndex = 77;
            this.PicImagenProducto.TabStop = false;
            // 
            // BtnMostrarProducto
            // 
            this.BtnMostrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarProducto.Location = new System.Drawing.Point(829, 75);
            this.BtnMostrarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMostrarProducto.Name = "BtnMostrarProducto";
            this.BtnMostrarProducto.Size = new System.Drawing.Size(173, 83);
            this.BtnMostrarProducto.TabIndex = 76;
            this.BtnMostrarProducto.Text = "Mostrar Registro \r\ne Imagen";
            this.BtnMostrarProducto.UseVisualStyleBackColor = true;
            this.BtnMostrarProducto.Click += new System.EventHandler(this.BtnMostrarProducto_Click);
            // 
            // LvProductos
            // 
            this.LvProductos.HideSelection = false;
            this.LvProductos.Location = new System.Drawing.Point(169, 75);
            this.LvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.LvProductos.MultiSelect = false;
            this.LvProductos.Name = "LvProductos";
            this.LvProductos.Size = new System.Drawing.Size(652, 381);
            this.LvProductos.TabIndex = 75;
            this.LvProductos.UseCompatibleStateImageBehavior = false;
            this.LvProductos.SelectedIndexChanged += new System.EventHandler(this.LvProductos_SelectedIndexChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(372, 21);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(221, 29);
            this.LblTitulo.TabIndex = 74;
            this.LblTitulo.Text = "Eliminar Producto";
            // 
            // LblErrorBuscar
            // 
            this.LblErrorBuscar.AutoSize = true;
            this.LblErrorBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorBuscar.ForeColor = System.Drawing.Color.Red;
            this.LblErrorBuscar.Location = new System.Drawing.Point(28, 292);
            this.LblErrorBuscar.Name = "LblErrorBuscar";
            this.LblErrorBuscar.Size = new System.Drawing.Size(105, 13);
            this.LblErrorBuscar.TabIndex = 73;
            this.LblErrorBuscar.Text = "Solo admite numeros";
            this.LblErrorBuscar.Visible = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(31, 337);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(124, 22);
            this.TxtBuscar.TabIndex = 72;
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblCampoBuscar
            // 
            this.LblCampoBuscar.AutoSize = true;
            this.LblCampoBuscar.Location = new System.Drawing.Point(28, 314);
            this.LblCampoBuscar.Name = "LblCampoBuscar";
            this.LblCampoBuscar.Size = new System.Drawing.Size(59, 16);
            this.LblCampoBuscar.TabIndex = 71;
            this.LblCampoBuscar.Text = "Nombre:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(31, 392);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(124, 64);
            this.BtnBuscar.TabIndex = 70;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // GbBusquedaCampo
            // 
            this.GbBusquedaCampo.Controls.Add(this.RdId);
            this.GbBusquedaCampo.Controls.Add(this.RdNombre);
            this.GbBusquedaCampo.Location = new System.Drawing.Point(25, 182);
            this.GbBusquedaCampo.Margin = new System.Windows.Forms.Padding(4);
            this.GbBusquedaCampo.Name = "GbBusquedaCampo";
            this.GbBusquedaCampo.Padding = new System.Windows.Forms.Padding(4);
            this.GbBusquedaCampo.Size = new System.Drawing.Size(136, 86);
            this.GbBusquedaCampo.TabIndex = 69;
            this.GbBusquedaCampo.TabStop = false;
            this.GbBusquedaCampo.Text = "Por Campo";
            // 
            // RdId
            // 
            this.RdId.AutoSize = true;
            this.RdId.Location = new System.Drawing.Point(29, 52);
            this.RdId.Margin = new System.Windows.Forms.Padding(4);
            this.RdId.Name = "RdId";
            this.RdId.Size = new System.Drawing.Size(39, 20);
            this.RdId.TabIndex = 1;
            this.RdId.Text = "Id";
            this.RdId.UseVisualStyleBackColor = true;
            this.RdId.CheckedChanged += new System.EventHandler(this.RdId_CheckedChanged);
            // 
            // RdNombre
            // 
            this.RdNombre.AutoSize = true;
            this.RdNombre.Checked = true;
            this.RdNombre.Location = new System.Drawing.Point(29, 23);
            this.RdNombre.Margin = new System.Windows.Forms.Padding(4);
            this.RdNombre.Name = "RdNombre";
            this.RdNombre.Size = new System.Drawing.Size(77, 20);
            this.RdNombre.TabIndex = 0;
            this.RdNombre.TabStop = true;
            this.RdNombre.Text = "Nombre";
            this.RdNombre.UseVisualStyleBackColor = true;
            this.RdNombre.CheckedChanged += new System.EventHandler(this.RdNombre_CheckedChanged);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.GpBBusquedaTipo);
            this.Controls.Add(this.PicImagenProducto);
            this.Controls.Add(this.BtnMostrarProducto);
            this.Controls.Add(this.LvProductos);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblErrorBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblCampoBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GbBusquedaCampo);
            this.Name = "EliminarProducto";
            this.Size = new System.Drawing.Size(1021, 490);
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            this.GpBBusquedaTipo.ResumeLayout(false);
            this.GpBBusquedaTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImagenProducto)).EndInit();
            this.GbBusquedaCampo.ResumeLayout(false);
            this.GbBusquedaCampo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GpBBusquedaTipo;
        private System.Windows.Forms.RadioButton RdExacta;
        private System.Windows.Forms.RadioButton RdAproximada;
        private System.Windows.Forms.PictureBox PicImagenProducto;
        private System.Windows.Forms.Button BtnMostrarProducto;
        private System.Windows.Forms.ListView LvProductos;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblErrorBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCampoBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GbBusquedaCampo;
        private System.Windows.Forms.RadioButton RdId;
        private System.Windows.Forms.RadioButton RdNombre;
    }
}
