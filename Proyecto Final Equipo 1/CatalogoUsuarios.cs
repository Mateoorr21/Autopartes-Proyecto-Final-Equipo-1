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
        public CatalogoUsuarios()
        {
            InitializeComponent();
            //Incializamos los controles de Usuario
            registroUsuario = new RegistrarUsuario(); 
            modificarUsuario = new ModificarUsuario(); 
            eliminarUsuario = new EliminarUsuario(); 
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            PanelCatalogo.Controls.Clear();
            PanelCatalogo.Controls.Add(registroUsuario);
            registroUsuario.Dock = DockStyle.Fill;
            
            FuncionesAplicacion.LimpiarControles(registroUsuario); //Limpiamos los controles del Control de Usuario
        }

        private void BtnModificarUsuario_Click(object sender, EventArgs e)
        {
            PanelCatalogo.Controls.Clear();
            PanelCatalogo.Controls.Add(modificarUsuario);
            modificarUsuario.Dock = DockStyle.Fill;

            FuncionesAplicacion.LimpiarControles(modificarUsuario); //Limpiamos los controles del Control de Usuario
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            PanelCatalogo.Controls.Clear();
            PanelCatalogo.Controls.Add(eliminarUsuario);
            eliminarUsuario.Dock = DockStyle.Fill;

            FuncionesAplicacion.LimpiarControles(modificarUsuario); //Limpiamos los controles del Control de Usuario
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose(); //Salimos del Catalogo
        }
    }
}
