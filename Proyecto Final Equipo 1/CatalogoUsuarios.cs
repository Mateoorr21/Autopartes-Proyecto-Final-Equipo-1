using Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1
{
    public partial class CatalogoUsuarios : Form
    {
        //Declaramos variables de tipo UserControl a utilizar
        RegistrarUsuario registroUsuario;
        ModificarUsuario modificarUsuario;
        EliminarUsuario eliminarUsuario;

        public CatalogoUsuarios(Aplicacion aplicacion)
        {
            InitializeComponent();
            //Incializamos los controles de Usuario
            registroUsuario = new RegistrarUsuario(); 
            modificarUsuario = new ModificarUsuario(aplicacion, this); 
            eliminarUsuario = new EliminarUsuario(); 
        }

        private void LimpiarTodosLosControles()
        {
            //Funcion para Limpiar todos los Controles de Usuario 
            FuncionesAplicacion.LimpiarControles(registroUsuario);
            FuncionesAplicacion.LimpiarControles(modificarUsuario);
            FuncionesAplicacion.LimpiarControles(eliminarUsuario);
        }

        //Funcion para ver si tenemos que abrir un nuevo control de usuario o no
        private void MostrarControlCatalogo(Control control)
        {
            // Si el control ya está cargado en el panel no hacemos nada
            if (PanelCatalogo.Controls.Count > 0 && PanelCatalogo.Controls[0] == control)
            {
                return;
            }

            // Limpiar todos los controles del panel
            PanelCatalogo.Controls.Clear();

            // Agregar el nuevo control
            PanelCatalogo.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles();
            MostrarControlCatalogo(registroUsuario); //Llamamos a la función mostrrar el control
        }

        private void BtnModificarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles();
            MostrarControlCatalogo(modificarUsuario); //Llamamos a la función mostrar el control
            modificarUsuario.CargarUsuariosModificar();
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles();
            MostrarControlCatalogo(eliminarUsuario); //Llamamos a la función mostrar el control
            eliminarUsuario.CargarUsuariosEliminar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Confirmamos que el usuario desea salir del Catálogo
            DialogResult ConfirmarCierreCatalogo;
            ConfirmarCierreCatalogo = MessageBox.Show("¿Esta seguro que desea salir del Catálogo de Usuarios?",
                "CONFIRMACIÓN DE CIERRE CATALOGO DE USUARIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarCierreCatalogo == DialogResult.No) return;

            Dispose(); //Salimos del Catalogo
        }

        private void CatalogoUsuarios_Shown(object sender, EventArgs e)
        {
            // Recalculamos la posicion del formulario para que aparezca centrado despues de que AutoSize lo ajusto
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
        }

        private void CatalogoUsuarios_Load(object sender, EventArgs e)
        {
            //Cargamos la información del Usuario Operativo en las etqiuetas
            LblUsuario.Text = FuncionesAplicacion.Usuario;
            LblNombreCompleto.Text = FuncionesAplicacion.NombreCompleto;
            LblPermiso.Text = "(" + FuncionesAplicacion.TipoUsuario + ")";
        }
    }
}
