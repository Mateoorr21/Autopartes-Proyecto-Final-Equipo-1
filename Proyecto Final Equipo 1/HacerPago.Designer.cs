namespace Proyecto_Final_Equipo_1
{
    partial class HacerPago
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblErrorDineroRecibo = new System.Windows.Forms.Label();
            this.BtnCobrar = new System.Windows.Forms.Button();
            this.TxtDineroRecibo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblRecibo = new System.Windows.Forms.Label();
            this.TxtPorPagar = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.ToolTipCobro = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblErrorDineroRecibo);
            this.panel1.Controls.Add(this.BtnCobrar);
            this.panel1.Controls.Add(this.TxtDineroRecibo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblRecibo);
            this.panel1.Controls.Add(this.TxtPorPagar);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 152);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            this.panel1.UseWaitCursor = true;
            // 
            // LblErrorDineroRecibo
            // 
            this.LblErrorDineroRecibo.AutoSize = true;
            this.LblErrorDineroRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorDineroRecibo.ForeColor = System.Drawing.Color.Red;
            this.LblErrorDineroRecibo.Location = new System.Drawing.Point(258, 120);
            this.LblErrorDineroRecibo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorDineroRecibo.Name = "LblErrorDineroRecibo";
            this.LblErrorDineroRecibo.Size = new System.Drawing.Size(204, 16);
            this.LblErrorDineroRecibo.TabIndex = 231;
            this.LblErrorDineroRecibo.Text = "Solo números y un punto decimal";
            this.LblErrorDineroRecibo.UseWaitCursor = true;
            this.LblErrorDineroRecibo.Visible = false;
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.IconoBotonCobrar;
            this.BtnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCobrar.FlatAppearance.BorderSize = 0;
            this.BtnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCobrar.Location = new System.Drawing.Point(437, 51);
            this.BtnCobrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.Size = new System.Drawing.Size(127, 90);
            this.BtnCobrar.TabIndex = 3;
            this.ToolTipCobro.SetToolTip(this.BtnCobrar, "Cobrar");
            this.BtnCobrar.UseVisualStyleBackColor = true;
            this.BtnCobrar.UseWaitCursor = true;
            this.BtnCobrar.Click += new System.EventHandler(this.BtnCobrar_Click);
            // 
            // TxtDineroRecibo
            // 
            this.TxtDineroRecibo.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDineroRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDineroRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDineroRecibo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtDineroRecibo.Location = new System.Drawing.Point(267, 96);
            this.TxtDineroRecibo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDineroRecibo.Name = "TxtDineroRecibo";
            this.TxtDineroRecibo.Size = new System.Drawing.Size(137, 15);
            this.TxtDineroRecibo.TabIndex = 2;
            this.TxtDineroRecibo.Tag = "";
            this.TxtDineroRecibo.UseWaitCursor = true;
            this.TxtDineroRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDineroRecibo_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(259, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 229;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // LblRecibo
            // 
            this.LblRecibo.AutoSize = true;
            this.LblRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecibo.ForeColor = System.Drawing.Color.Black;
            this.LblRecibo.Location = new System.Drawing.Point(255, 69);
            this.LblRecibo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRecibo.Name = "LblRecibo";
            this.LblRecibo.Size = new System.Drawing.Size(125, 20);
            this.LblRecibo.TabIndex = 228;
            this.LblRecibo.Text = "Recibo (MXN):";
            this.LblRecibo.UseWaitCursor = true;
            // 
            // TxtPorPagar
            // 
            this.TxtPorPagar.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPorPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPorPagar.Enabled = false;
            this.TxtPorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPorPagar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtPorPagar.Location = new System.Drawing.Point(38, 96);
            this.TxtPorPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPorPagar.Name = "TxtPorPagar";
            this.TxtPorPagar.Size = new System.Drawing.Size(171, 15);
            this.TxtPorPagar.TabIndex = 224;
            this.TxtPorPagar.Tag = "0";
            this.TxtPorPagar.Text = "0";
            this.TxtPorPagar.UseWaitCursor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.cajagris;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(30, 91);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(189, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 226;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 225;
            this.label1.Text = "Por Pagar IVA (MXN):\r\n";
            this.label1.UseWaitCursor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(1, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 1);
            this.panel5.TabIndex = 3;
            this.panel5.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(586, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 111);
            this.panel4.TabIndex = 2;
            this.panel4.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 111);
            this.panel3.TabIndex = 1;
            this.panel3.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Controls.Add(this.PicLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 41);
            this.panel2.TabIndex = 0;
            this.panel2.UseWaitCursor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = global::Proyecto_Final_Equipo_1.Properties.Resources.Boton_X_Blanco;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(548, 3);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(33, 33);
            this.BtnSalir.TabIndex = 1;
            this.ToolTipCobro.SetToolTip(this.BtnSalir, "Cancelar cobro");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.UseWaitCursor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = global::Proyecto_Final_Equipo_1.Properties.Resources.TextoVentanaCobro2;
            this.PicLogo.Location = new System.Drawing.Point(43, 0);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(467, 41);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 134;
            this.PicLogo.TabStop = false;
            this.PicLogo.UseWaitCursor = true;
            // 
            // HacerPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(613, 176);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HacerPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de Productos";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.HacerPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.TextBox TxtDineroRecibo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblRecibo;
        private System.Windows.Forms.TextBox TxtPorPagar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCobrar;
        private System.Windows.Forms.ToolTip ToolTipCobro;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblErrorDineroRecibo;
    }
}