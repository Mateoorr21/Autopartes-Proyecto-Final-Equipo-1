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
        int IdSeleccionado;
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        public BuscarProducto(Inicio inicio)
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }
        public void LiberarPictureBox() //llamamos a la funcion LiberarPictureBox del Inicio
        {
            Inicio_Recibido.LiberarPictureBox(PicImagenProducto);
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            IdSeleccionado = 0;

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
            //Llamamos a la función EncontrarProductos y limpiamos la caja Buscar
            Inicio_Recibido.EncontrarProductos(TxtBuscar.Text, TxtBuscar, RdAproximada, RdNombre, LvProductos, LblCantidadRegistros);
            TxtBuscar.Clear();
        }

        private void RdId_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoId(RdId, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //Llamamos a la Funcion SeleccionoId
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoNombre(RdNombre, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtBuscar(e, RdId, LblErrorBuscar); //LLamamos a la función de validar entrada del TextBox Buscar
        }

        //Controlar la entrada de datos en el apartado cantidad a vender
        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que solo es ingresen numeros o backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                LblErrorCantidad.Visible = true;
                e.Handled = true;
            }

            else //Si no hay errores, ocultar la etiqueta de error
            {
                LblErrorCantidad.Visible = false;
            }
        }

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {
                ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);
            }
        }

        private void BtnMostrarProducto_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.MostrarProducto(IdSeleccionado, LvProductos, PicImagenProducto); //LLamamos a función MostrarProducto
        }

    }
}
