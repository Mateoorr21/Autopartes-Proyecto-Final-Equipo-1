namespace Proyecto_Final_Equipo_1
{
    partial class Aplicacion
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCatalogoUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelAplicacion = new System.Windows.Forms.Panel();
            this.PanelAutoPartes = new System.Windows.Forms.Panel();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(441, 9);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(199, 42);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Aplicación";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(11, 85);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(130, 51);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(11, 151);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(130, 51);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(11, 282);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 51);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(11, 346);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 51);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modfiicar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnCatalogoUsuarios
            // 
            this.BtnCatalogoUsuarios.Location = new System.Drawing.Point(11, 480);
            this.BtnCatalogoUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCatalogoUsuarios.Name = "BtnCatalogoUsuarios";
            this.BtnCatalogoUsuarios.Size = new System.Drawing.Size(130, 51);
            this.BtnCatalogoUsuarios.TabIndex = 5;
            this.BtnCatalogoUsuarios.Text = "Catálogo de Usuarios";
            this.BtnCatalogoUsuarios.UseVisualStyleBackColor = true;
            this.BtnCatalogoUsuarios.Click += new System.EventHandler(this.BtnCatalogoUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnCorte);
            this.panel1.Controls.Add(this.BtnVender);
            this.panel1.Controls.Add(this.BtnInventario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnCatalogoUsuarios);
            this.panel1.Controls.Add(this.BtnModificar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 553);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(188, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 73);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.PanelAplicacion);
            this.panel3.Controls.Add(this.LblTitulo);
            this.panel3.Location = new System.Drawing.Point(160, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 71);
            this.panel3.TabIndex = 7;
            // 
            // PanelAplicacion
            // 
            this.PanelAplicacion.Location = new System.Drawing.Point(19, 94);
            this.PanelAplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAplicacion.Name = "PanelAplicacion";
            this.PanelAplicacion.Size = new System.Drawing.Size(746, 370);
            this.PanelAplicacion.TabIndex = 1;
            // 
            // PanelAutoPartes
            // 
            this.PanelAutoPartes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelAutoPartes.Location = new System.Drawing.Point(160, 63);
            this.PanelAutoPartes.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAutoPartes.Name = "PanelAutoPartes";
            this.PanelAutoPartes.Size = new System.Drawing.Size(1021, 490);
            this.PanelAutoPartes.TabIndex = 7;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Location = new System.Drawing.Point(11, 20);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(130, 51);
            this.BtnInventario.TabIndex = 7;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            // 
            // BtnVender
            // 
            this.BtnVender.Location = new System.Drawing.Point(11, 217);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(130, 51);
            this.BtnVender.TabIndex = 8;
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = true;
            // 
            // BtnCorte
            // 
            this.BtnCorte.Location = new System.Drawing.Point(11, 413);
            this.BtnCorte.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(130, 51);
            this.BtnCorte.TabIndex = 9;
            this.BtnCorte.Text = "Corte de Caja";
            this.BtnCorte.UseVisualStyleBackColor = true;
            // 
            // Aplicacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1183, 552);
            this.Controls.Add(this.PanelAutoPartes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Aplicacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCatalogoUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelAutoPartes;
        private System.Windows.Forms.Panel PanelAplicacion;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnCorte;
    }
}