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
        float Precio; 
        int Cantidad;
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
            //Validar que solo es ingresen numeros, backspace o punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
            {
                LblErrorPrecio.Text = "Solo se permiten números y un punto decimal";
                LblErrorPrecio.Visible = true;
                e.Handled = true;
            }

            //Validar para que únicmente se ingrese un punto decimal
            else if (Txt_Precio.Text.IndexOf('.') >= 0 && e.KeyChar == 46)
            //Si en la caja ya hay un "." y la tecla preionada es "."
            {
                LblErrorPrecio.Text = "Solo se permite un punto decimal";
                LblErrorPrecio.Visible = true;
                e.Handled = true; //No se permite ingresar el "."
            }

            else //Si no hay errores, ocultar la etiqueta de error
            {
                LblErrorPrecio.Visible = false;
            }
        }

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

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.CargarImagen(PicImagenProducto, ref RutaImagenTemporal); //LLamamos a la función Cargar Imagen
        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            //Si algun campo esta vacío (exceptuando la descripción o la imagen)  mensaje de error
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Marca.Text) ||
                string.IsNullOrWhiteSpace(Txt_Precio.Text) ||
                string.IsNullOrWhiteSpace(Txt_Cantidad.Text))
            {
                MessageBox.Show("Error. Ingrese la información del producto a ingresar", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Convertimos el valor de las cajas en tipo float y entero
            Precio = float.Parse(Txt_Precio.Text);
            Cantidad = int.Parse(Txt_Cantidad.Text);

            //LLamamos a la función RegistrarProducto
            Inicio_Recibido.RegistrarProducto(Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Marca.Text, Precio, Cantidad, RutaImagenTemporal, IdGenerado,
                Txt_Nombre, Txt_Descripcion, Txt_Marca, Txt_Precio, Txt_Cantidad, PicImagenProducto);
        }

        private void BtnDeseleccionarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.DeseleccionarImagen(PicImagenProducto, ref RutaImagenTemporal); //Llamamos a la función Deseleccionar Imagen
        }
    }
}
