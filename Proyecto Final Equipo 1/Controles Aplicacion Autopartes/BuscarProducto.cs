using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class BuscarProducto : UserControl
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }
        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables

            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 120);
            LvProductos.Columns.Add("Descripcion", 200);
            LvProductos.Columns.Add("Marca", 100);
            LvProductos.Columns.Add("Precio", 70);
            LvProductos.Columns.Add("Cantidad en Stock", 120);
            LvProductos.Columns.Add("Imagen", 0);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función EncontrarProductos
            FuncionesAplicacion.EncontrarProductos(TxtBuscar.Text, TxtBuscar, RdAproximada, RdNombre, LvProductos, LblCantidadRegistros, LblErrorBuscar);
        }

        private void RdId_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesAplicacion.SeleccionoId(RdId, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //Llamamos a la Funcion SeleccionoId
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesAplicacion.SeleccionoNombre(RdNombre, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtBuscar(e, RdId, LblErrorBuscar); //LLamamos a la función de validar entrada del TextBox Buscar
        }

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {
                ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                FuncionesAplicacion.IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);
            }
        }

        private void BtnMostrarProducto_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.MostrarProducto(LvProductos, PicImagenProducto); //LLamamos a función MostrarProducto
        }

        private void BtnRestaurarBusqueda_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.LimpiarControles(this); //Si se selecciona Cancelar limpiamos todos los controles
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void LvProductos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvProductos); //Llamamos a la funcion Ordenamiento de Columnas
        }
    }
}
