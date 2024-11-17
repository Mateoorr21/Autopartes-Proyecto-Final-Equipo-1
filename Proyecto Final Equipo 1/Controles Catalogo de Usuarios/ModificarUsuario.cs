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
using System.Text.RegularExpressions; //namespace para expresiones regulares

namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    public partial class ModificarUsuario : UserControl
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función BuscarUsuarioModificar de Inicio
            FuncionesCatalogoUsuarios.BuscarUsuarioModificar(TxtBuscar.Text, FuncionesAplicacion.Usuario, 
                FuncionesAplicacion.TipoUsuario, TxtBuscar, RdAproximada, RdNombre, LvUsuarios,LblCantidadRegistros);
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            //Incializamos IdSeleccionado
            FuncionesCatalogoUsuarios.IdSeleccionado = 0;

            //Declaramos el ListView, sus propiedades y columnas
            LvUsuarios.View = View.Details;
            LvUsuarios.GridLines = true;
            LvUsuarios.FullRowSelect = true;
            LvUsuarios.Columns.Add("Id", 0);
            LvUsuarios.Columns.Add("Nombre", 80);
            LvUsuarios.Columns.Add("Usuario", 80);
            LvUsuarios.Columns.Add("Contraseña", 80);
            LvUsuarios.Columns.Add("Permiso", 80);

            if(FuncionesAplicacion.TipoUsuario == "Admin") //Si el usuario que entra es un Admin, no puede cambiar permisos
            {
                RdAdmin.Enabled = false;
                RdCajero.Enabled = false;
            }
        }

        private void LvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvUsuarios.SelectedItems.Count > 0) {

                ListViewItem ItemSeleccionado = LvUsuarios.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                FuncionesCatalogoUsuarios.IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);

                if(FuncionesCatalogoUsuarios.IdSeleccionado == 1 && FuncionesAplicacion.TipoUsuario == "Propietario") //Si el propietario se selecciona inhabilitamos el cambio de permiso
                {
                    RdAdmin.Enabled = false;
                    RdCajero.Enabled = false;
                }

                else if (FuncionesAplicacion.TipoUsuario == "Propietario") //Si no se selecciona a si mismo esta opcion esta habilitada
                {
                    RdAdmin.Enabled = true;
                    RdCajero.Enabled = true;
                }

                //Cargamos la información del ListView en las diferentes cajas de texto y radiobuttons
                Txt_Nombre.Text = ItemSeleccionado.SubItems[1].Text;
                Txt_Usuario.Text = ItemSeleccionado.SubItems[2].Text;
                Txt_Password.Text = ItemSeleccionado.SubItems[3].Text;
                RdAdmin.Checked = ItemSeleccionado.SubItems[4].Text == "Admin" ? true : false; //Si se selecciona propietario nada se marca
                RdCajero.Checked = ItemSeleccionado.SubItems[4].Text == "Cajero" ? true : false;
            }
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

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtNombreCompleto(e, LblErrorNombre); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorUsuario); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorPassword); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función actualizar y pasamos los parametros
            FuncionesCatalogoUsuarios.ActualizarUsuario(Txt_Nombre.Text, Txt_Usuario.Text, Txt_Password.Text, FuncionesCatalogoUsuarios.IdSeleccionado, 
                LvUsuarios,Txt_Nombre, Txt_Usuario, Txt_Password, RdAdmin, RdCajero);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.LimpiarControles(this); //Si se selecciona Cancelar limpiamos todos los controles
        }
    }
}
