using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class AgregarProducto : UserControl
    {
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        int IdGenerado; //Variable glocal IdGenerado
        bool SeModificoImagen;
        string RutaImagenTemporal; //Variable Global Ruta Temporal

        public AgregarProducto(Inicio inicio)
        {
            InitializeComponent(); 
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }

        public void LiberarPictureBox() //llamamos a la funcion LiberarPictureBox del Inicio
        {
            Inicio_Recibido.LiberarPictureBox(PicImagenProducto);
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtPrecio(e, Txt_Precio, LblErrorPrecio); //LLamamos a la función de validar entrada del TextBox Precio
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtCantidad(e, LblErrorCantidad); //LLamamos a la función de validar entrada del TextBox Cantidad
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.CargarImagen(PicImagenProducto, ref RutaImagenTemporal, ref SeModificoImagen); //LLamamos a la función Cargar Imagen
        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {     
            //LLamamos a la función RegistrarProducto
            Inicio_Recibido.RegistrarProducto(Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Marca.Text, RutaImagenTemporal, IdGenerado,
                Txt_Nombre, Txt_Descripcion, Txt_Marca, Txt_Precio, Txt_Cantidad, PicImagenProducto);
        }

        private void BtnDeseleccionarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.DeseleccionarImagen(PicImagenProducto, ref RutaImagenTemporal); //Llamamos a la función Deseleccionar Imagen
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            //Inicializamos Variables
            IdGenerado = 0; //Inicializamos IdSeleccionado
            SeModificoImagen = false; //Centinela es Falso
            RutaImagenTemporal = null;
        }
    }
}
