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
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_Final_Equipo_1
{
    public partial class InicioSesion : Form
    {
        int ErroresInicioSesion;
        public InicioSesion() 
        {
            InitializeComponent();
        }

        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.IniciarSesion(Txt_Usuario.Text, Txt_Password.Text);
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorUsuario); //Llamamos a la función validar entrada de Usuario
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorPassword); //Llamamos a la función validar entrada de Password
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            ErroresInicioSesion = 0;
        }
    }
}
