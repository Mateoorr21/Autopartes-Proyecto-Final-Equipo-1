using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class CorteCaja : UserControl
    {   
        public CorteCaja()
        {
            InitializeComponent();
        }

        private void CorteCaja_Load(object sender, EventArgs e)
        {
            //Establecemos el ListView, sus propiedades y columnas
            LvVentas.View = View.Details;
            LvVentas.GridLines = true;
            LvVentas.FullRowSelect = true;
            LvVentas.Columns.Add("Usuario", 100);
            LvVentas.Columns.Add("Id Producto", 80);
            LvVentas.Columns.Add("Nombre Producto", 200);
            LvVentas.Columns.Add("Precio", 70);
            LvVentas.Columns.Add("Cantidad", 80);
            LvVentas.Columns.Add("Total", 70);
            LvVentas.Columns.Add("Total IVA", 80);
            LvVentas.Columns.Add("Fecha/Hora", 180);
        }

        public void CargarDineroCaja()
        {
            // Mostrar el dinero en caja en el TextBox
            TxtDineroCaja.Text = Properties.Settings.Default.DineroEnCaja.ToString("C"); // Le ponemos formato de Moneda
        }

        private void BtnCargarVentas_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.CargarVentas(LvVentas, LblCantidadRegistros, TxtDineroVentas); //Llamamos a la función Cargar Ventas
        }

        private void BtnMostrarVenta_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.MostrarVentaSeleccionada(LvVentas); //LLamamos a la función para mostrar una venta seleccionada
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.LimpiarControles(this); //Si se selecciona cancelar limpiamos el control de Usuario
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
            CargarDineroCaja(); //Cargamos el dinero en caja
        }

        private void LvVentas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvVentas); //Llamamos a la función de Ordenamiento de columnas
        }

        private void BtnRegistrarVentas_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.GuardarVentasCerrarSesion(LvVentas); //Llamamos a la función de Guardar Ventas y Cierre de Sesión
        }
    }
}
