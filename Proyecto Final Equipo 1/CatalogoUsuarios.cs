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
        RegistrarUsuario registroUsuario;
        public CatalogoUsuarios(Inicio inicio)
        {
            InitializeComponent();
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
            registroUsuario = new RegistrarUsuario(Inicio_Recibido); //El UserControl Registrar usuario recibe una instancia Inicio
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            PanelCatalogo.Controls.Clear();
            PanelCatalogo.Controls.Add(registroUsuario);
            registroUsuario.Dock = DockStyle.Fill; 
        }
    }
}
