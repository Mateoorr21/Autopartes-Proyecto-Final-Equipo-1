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

namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    public partial class EliminarUsuario : UserControl
    {
        int IdSeleccionado;
        Inicio Inicio_Recibido; //Declaramos el Inicio al que le asignaremos el que se recibe
        Aplicacion Aplicacion_Recibida; //Declaramos Aplicacion al que le asiganarmos el que se recibe
        public EliminarUsuario(Inicio inicio, Aplicacion aplicacion)
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
            Aplicacion_Recibida = aplicacion; 
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función BuscarUsuarioEliminar de Inicio
            Inicio_Recibido.BuscarUsuarioEliminar(TxtBuscar.Text, Aplicacion_Recibida.Usuario, Aplicacion_Recibida.TipoUsuario,
                TxtBuscar, RdAproximada, RdNombre, LvUsuarios);
        }

        private void LvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem ItemSeleccionado = LvUsuarios.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);
            }
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            //Incializamos IdSeleccionado
            IdSeleccionado = 0;

            //Declaramos el ListView, sus propiedades y columnas
            LvUsuarios.View = View.Details;
            LvUsuarios.GridLines = true;
            LvUsuarios.FullRowSelect = true;
            LvUsuarios.Columns.Add("Id", 0);
            LvUsuarios.Columns.Add("Nombre", 120);
            LvUsuarios.Columns.Add("Usuario", 110);
            LvUsuarios.Columns.Add("Contraseña", 100);
            LvUsuarios.Columns.Add("Permiso", 100);
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoNombreCompleto(RdNombre, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void RdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoUsuario(RdUsuario, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtBuscarUsuarioOperativo(e, RdNombre, LblErrorBuscar); //LLamamos a la función ValidaEntrada del campo Buscar
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función Eliminar que está en Inicio y pasamos el parametro del Id del Registro Seleccionado
            Inicio_Recibido.BorrarUsuario(IdSeleccionado, LvUsuarios);
        }
    }
}
