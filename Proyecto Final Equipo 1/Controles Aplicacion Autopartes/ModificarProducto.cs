using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class ModificarProducto : UserControl
    {
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        int IdSeleccionado;
        string RutaImagenTemporal;
        bool SeModificoImagen;
        public ModificarProducto(Inicio inicio) 
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            IdSeleccionado = 0; //Inicializamos IdSeleccionado
            SeModificoImagen = false; //Centinela es Falso
            RutaImagenTemporal = null;

            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 100);
            LvProductos.Columns.Add("Descripcion", 120);
            LvProductos.Columns.Add("Marca", 80);
            LvProductos.Columns.Add("Precio", 70);
            LvProductos.Columns.Add("Cantidad en Stock", 80);
            LvProductos.Columns.Add("Imagen", 0);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función EncontrarProductos de Inicio
            Inicio_Recibido.EncontrarProductos(TxtBuscar.Text, TxtBuscar, RdAproximada, RdNombre, LvProductos, LblCantidadRegistros);
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

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {
                ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);

                //Cargamos la información del ListView en las diferentes cajas de texto y radiobuttons
                Txt_Nombre.Text = ItemSeleccionado.SubItems[1].Text;
                Txt_Descripcion.Text = ItemSeleccionado.SubItems[2].Text;
                Txt_Marca.Text = ItemSeleccionado.SubItems[3].Text;
                Txt_Precio.Text = ItemSeleccionado.SubItems[4].Text;
                Txt_Cantidad.Text = ItemSeleccionado.SubItems[5].Text;

                //Obtenemos la ruta guardada en el ListView y quitamos los caracteres #
                RutaImagenTemporal = ItemSeleccionado.SubItems[6].Text.Trim('#');

                string RutaImagenAbrir = "..\\..\\" + RutaImagenTemporal; //Creamos la nueva ruta (saliendo varias carpetas mas)

                SeModificoImagen = false; //Cada que seleccionamos un registro la imagen no se ha modificado
                PicImagenProducto.Image = null; //Limpiamos el PictureBox si existe una imagen cargada

                PicImagenProducto.Image = Image.FromFile(RutaImagenAbrir); //Cargamos la Imagen 
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.CargarImagen(PicImagenProducto, ref RutaImagenTemporal, ref SeModificoImagen); //LLamamos a la función Cargar Imagen
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //LLamamos a la función ActualizarProducto
            Inicio_Recibido.ActualizarProducto(Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Marca.Text, RutaImagenTemporal, IdSeleccionado, SeModificoImagen, LvProductos,
                Txt_Nombre, Txt_Descripcion, Txt_Marca, Txt_Precio, Txt_Cantidad, PicImagenProducto);

            ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnDeseleccionarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.DeseleccionarImagen(PicImagenProducto, ref RutaImagenTemporal); //Llamamos a la función Deseleccionar Imagen
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtPrecio(e, Txt_Precio, LblErrorPrecio); //LLamamos a la función de validar entrada del TextBox Precio
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtCantidad(e, LblErrorCantidad); //LLamamos a la función de validar entrada del TextBox Cantidad
        }

        //Funcion para Reinciar Variables de control ModificarProducto
        public void ReiniciarVariables()
        {
            IdSeleccionado = 0;
            RutaImagenTemporal = null;
            SeModificoImagen = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.LimpiarControles(this); //Si se selecciona Cancelar limpiamos todos los controles
            ReiniciarVariables(); //Reinciamos variables
        }
    }

}
