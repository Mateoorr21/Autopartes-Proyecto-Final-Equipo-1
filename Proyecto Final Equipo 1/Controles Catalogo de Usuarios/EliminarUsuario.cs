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
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función BuscarUsuarioEliminar de Inicio
            FuncionesCatalogoUsuarios.BuscarUsuarioEliminar(TxtBuscar.Text, FuncionesAplicacion.Usuario, FuncionesAplicacion.TipoUsuario,
                TxtBuscar, RdAproximada, RdNombre, LvUsuarios, LblCantidadRegistros, LblErrorBuscar);
        }

        private void LvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem ItemSeleccionado = LvUsuarios.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                FuncionesCatalogoUsuarios.IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);
            }
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            FuncionesCatalogoUsuarios.IdSeleccionado = 0;

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
            FuncionesCatalogoUsuarios.SeleccionoNombreCompleto(RdNombre, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void RdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesCatalogoUsuarios.SeleccionoUsuario(RdUsuario, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtBuscarUsuarioOperativo(e, RdNombre, LblErrorBuscar); //LLamamos a la función ValidaEntrada del campo Buscar
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función Eliminar que está en Inicio y pasamos el parametro del Id del Registro Seleccionado
            FuncionesCatalogoUsuarios.BorrarUsuario(FuncionesCatalogoUsuarios.IdSeleccionado, LvUsuarios, LblCantidadRegistros, LblErrorBuscar, TxtBuscar);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.LimpiarControles(this); //Si se selecciona Cancelar limpiamos todos los controles
        }

        private void LvUsuarios_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvUsuarios); //Llamamos a la funcion Ordenamiento de Columnas
        }
    }
}
