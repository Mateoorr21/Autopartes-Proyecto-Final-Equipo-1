using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class EliminarProducto : UserControl
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables

            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 150);
            LvProductos.Columns.Add("Descripcion", 210);
            LvProductos.Columns.Add("Marca", 150);
            LvProductos.Columns.Add("Precio", 100);
            LvProductos.Columns.Add("Cantidad en Stock", 120);
            LvProductos.Columns.Add("Imagen", 0);
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            //Llamamos a la función EncontrarProductos de Inicio
            FuncionesAplicacion.EncontrarProductos(TxtBuscar.Text, TxtBuscar, RdAproximada, RdNombre, LvProductos, LblCantidadRegistros);
        }

        /*  Idéntico que en User Control de BuscarProducto  */
        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesAplicacion.SeleccionoNombre(RdNombre, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void RdId_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesAplicacion.SeleccionoId(RdId, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //Llamamos a la Funcion SeleccionoId
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función Eliminar de la clase FuncionesAplicacion y pasamos paramatros solicitados
            FuncionesAplicacion.BorrarProducto(LvProductos, LblCantidadRegistros);
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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
