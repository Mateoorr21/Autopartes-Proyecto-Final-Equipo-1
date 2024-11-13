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
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        //Declaramos variables de tipo UserControl a utilizar
        RegistrarUsuario registroUsuario;
        ModificarUsuario modificarUsuario;
        EliminarUsuario eliminarUsuario;
        public CatalogoUsuarios(Inicio inicio)
        {
            InitializeComponent();
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
            registroUsuario = new RegistrarUsuario(Inicio_Recibido); //El UserControl RegistrarUsuario recibe una instancia Inicio
            modificarUsuario = new ModificarUsuario(Inicio_Recibido); //El UserControl ModificarUsuario recibe una instancia Inicio
            eliminarUsuario = new EliminarUsuario(Inicio_Recibido); //El UserControl EliminarUsuario recibe una instancia Inicio
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            PanelCatalogo.Controls.Clear();
            PanelCatalogo.Controls.Add(registroUsuario);
            registroUsuario.Dock = DockStyle.Fill; 
        }

        private void BtnModificarUsuario_Click(object sender, EventArgs e)
        {
            PanelCatalogo.Controls.Clear();
            PanelCatalogo.Controls.Add(modificarUsuario);
            modificarUsuario.Dock = DockStyle.Fill;
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            PanelCatalogo.Controls.Clear();
            PanelCatalogo.Controls.Add(eliminarUsuario);
            eliminarUsuario.Dock = DockStyle.Fill;
        }
    }
}
