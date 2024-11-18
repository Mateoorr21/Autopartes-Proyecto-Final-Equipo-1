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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnRegistrarVentas = new System.Windows.Forms.Button();
            this.LblCantidadRegistros = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCargarVentas = new System.Windows.Forms.Button();
            this.TxtDineroCaja = new System.Windows.Forms.TextBox();
            this.LblDineroCaja = new System.Windows.Forms.Label();
            this.TxtDineroVentas = new System.Windows.Forms.TextBox();
            this.LblDineroVentas = new System.Windows.Forms.Label();
            this.BtnMostrarVenta = new System.Windows.Forms.Button();
            this.LvVentas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Beige;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.Location = new System.Drawing.Point(862, 342);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(128, 103);
            this.BtnCancelar.TabIndex = 122;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrarVentas
            // 
            this.BtnRegistrarVentas.BackColor = System.Drawing.Color.LightBlue;
            this.BtnRegistrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegistrarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarVentas.Location = new System.Drawing.Point(738, 342);
            this.BtnRegistrarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegistrarVentas.Name = "BtnRegistrarVentas";
            this.BtnRegistrarVentas.Size = new System.Drawing.Size(117, 103);
            this.BtnRegistrarVentas.TabIndex = 118;
            this.BtnRegistrarVentas.Text = "Registrar Ventas (Cerrar Sesión)";
            this.BtnRegistrarVentas.UseVisualStyleBackColor = false;
            this.BtnRegistrarVentas.Click += new System.EventHandler(this.BtnRegistrarVentas_Click);
            // 
            // LblCantidadRegistros
            // 
            this.LblCantidadRegistros.AutoSize = true;
            this.LblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadRegistros.Location = new System.Drawing.Point(536, 450);
            this.LblCantidadRegistros.Name = "LblCantidadRegistros";
            this.LblCantidadRegistros.Size = new System.Drawing.Size(134, 18);
            this.LblCantidadRegistros.TabIndex = 104;
            this.LblCantidadRegistros.Tag = "Ventas Realizadas:";
            this.LblCantidadRegistros.Text = "Ventas Realizadas:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(234, 18);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(621, 29);
            this.LblTitulo.TabIndex = 102;
            this.LblTitulo.Text = "Corte de Caja (para Terminar la Sesión del Usuario)";
            // 
            // BtnCargarVentas
            // 
            this.BtnCargarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarVentas.Location = new System.Drawing.Point(738, 62);
            this.BtnCargarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCargarVentas.Name = "BtnCargarVentas";
            this.BtnCargarVentas.Size = new System.Drawing.Size(252, 71);
            this.BtnCargarVentas.TabIndex = 98;
            this.BtnCargarVentas.Text = "Cargar Ventas del Día";
            this.BtnCargarVentas.UseVisualStyleBackColor = true;
            this.BtnCargarVentas.Click += new System.EventHandler(this.BtnCargarVentas_Click);
            // 
            // TxtDineroCaja
            // 
            this.TxtDineroCaja.Location = new System.Drawing.Point(737, 170);
            this.TxtDineroCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDineroCaja.Name = "TxtDineroCaja";
            this.TxtDineroCaja.ReadOnly = true;
            this.TxtDineroCaja.Size = new System.Drawing.Size(253, 20);
            this.TxtDineroCaja.TabIndex = 126;
            // 
            // LblDineroCaja
            // 
            this.LblDineroCaja.AutoSize = true;
            this.LblDineroCaja.Location = new System.Drawing.Point(735, 148);
            this.LblDineroCaja.Name = "LblDineroCaja";
            this.LblDineroCaja.Size = new System.Drawing.Size(184, 15);
            this.LblDineroCaja.TabIndex = 125;
            this.LblDineroCaja.Text = "Dinero actual en Caja (en MXN):";
            // 
            // TxtDineroVentas
            // 
            this.TxtDineroVentas.Location = new System.Drawing.Point(737, 237);
            this.TxtDineroVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDineroVentas.Name = "TxtDineroVentas";
            this.TxtDineroVentas.ReadOnly = true;
            this.TxtDineroVentas.Size = new System.Drawing.Size(253, 20);
            this.TxtDineroVentas.TabIndex = 128;
            // 
            // LblDineroVentas
            // 
            this.LblDineroVentas.AutoSize = true;
            this.LblDineroVentas.Location = new System.Drawing.Point(735, 215);
            this.LblDineroVentas.Name = "LblDineroVentas";
            this.LblDineroVentas.Size = new System.Drawing.Size(234, 15);
            this.LblDineroVentas.TabIndex = 127;
            this.LblDineroVentas.Text = "Dinero obtenido por las Ventas (en MXN):";
            // 
            // BtnMostrarVenta
            // 
            this.BtnMostrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarVenta.Location = new System.Drawing.Point(738, 275);
            this.BtnMostrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMostrarVenta.Name = "BtnMostrarVenta";
            this.BtnMostrarVenta.Size = new System.Drawing.Size(252, 59);
            this.BtnMostrarVenta.TabIndex = 129;
            this.BtnMostrarVenta.Text = "Mostrar detalles de Venta";
            this.BtnMostrarVenta.UseVisualStyleBackColor = true;
            this.BtnMostrarVenta.Click += new System.EventHandler(this.BtnMostrarVenta_Click);
            // 
            // LvVentas
            // 
            this.LvVentas.HideSelection = false;
            this.LvVentas.Location = new System.Drawing.Point(32, 62);
            this.LvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.LvVentas.MultiSelect = false;
            this.LvVentas.Name = "LvVentas";
            this.LvVentas.Size = new System.Drawing.Size(682, 381);
            this.LvVentas.TabIndex = 130;
            this.LvVentas.UseCompatibleStateImageBehavior = false;
            this.LvVentas.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LvVentas_ColumnClick);
            // 
            // CorteCaja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LvVentas);
            this.Controls.Add(this.BtnMostrarVenta);
            this.Controls.Add(this.TxtDineroVentas);
            this.Controls.Add(this.LblDineroVentas);
            this.Controls.Add(this.TxtDineroCaja);
            this.Controls.Add(this.LblDineroCaja);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnRegistrarVentas);
            this.Controls.Add(this.LblCantidadRegistros);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnCargarVentas);
            this.Name = "CorteCaja";
            this.Size = new System.Drawing.Size(1021, 490);
            this.Load += new System.EventHandler(this.CorteCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnRegistrarVentas;
        private System.Windows.Forms.Label LblCantidadRegistros;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnCargarVentas;
        private System.Windows.Forms.TextBox TxtDineroCaja;
        private System.Windows.Forms.Label LblDineroCaja;
        private System.Windows.Forms.TextBox TxtDineroVentas;
        private System.Windows.Forms.Label LblDineroVentas;
        private System.Windows.Forms.Button BtnMostrarVenta;
        private System.Windows.Forms.ListView LvVentas;
    }
}
