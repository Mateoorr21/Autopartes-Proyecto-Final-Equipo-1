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
        public AgregarProducto()
        {
            InitializeComponent(); 
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtPrecio(e, Txt_Precio, LblErrorPrecio); //LLamamos a la función de validar entrada del TextBox Precio
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtCantidad(e, LblErrorCantidad); //LLamamos a la función de validar entrada del TextBox Cantidad
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.CargarImagen(PicImagenProducto); //LLamamos a la función Cargar Imagen
        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.OcultarEtiquetasDeError(this); //Ocultamos las etiquetas de Error del Formulario

            //LLamamos a la función RegistrarProducto
            FuncionesAplicacion.SeCompletoOperacion = FuncionesAplicacion.RegistrarProducto(Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Marca.Text, 
                Txt_Nombre, Txt_Descripcion, Txt_Marca, Txt_Precio, Txt_Cantidad, PicImagenProducto);

            if(FuncionesAplicacion.SeCompletoOperacion) FuncionesAplicacion.ReiniciarVariables(); //Si se registro reiniciamos las Variables
        }

        private void BtnDeseleccionarImagen_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.DeseleccionarImagen(PicImagenProducto); //Llamamos a la función Deseleccionar Imagen
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.LimpiarControles(this); //Si se selecciona Cancelar limpiamos todos los controles
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtNombreDescripcionMarca(e, LblErrorNombre, Txt_Nombre); //Llamamos a la función de validar entrada
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtNombreDescripcionMarca(e, LblErrorDescripcion, Txt_Descripcion); //Llamamos a la función de validar entrada
        }

        private void Txt_Marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtNombreDescripcionMarca(e, LblErrorMarca, Txt_Marca); //Llamamos a la función de validar entrada
        }
    }
}
