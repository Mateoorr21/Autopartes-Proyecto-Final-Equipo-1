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
        public InicioSesion() 
        {
            InitializeComponent();
        }

        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.IniciarSesion(Txt_Usuario.Text, Txt_Password.Text, Txt_Usuario, Txt_Password);
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
        }

        private void BtnVolverInicio_Click(object sender, EventArgs e)
        {
            Dispose(); //Volvemos a la Ventana de Inicio con el Logo de la Aplicacion
        }

        private void BtnPassword_MouseDown(object sender, MouseEventArgs e)
        {
            BtnPassword.BackgroundImage = Properties.Resources.Mostrar_Password; // Imagen de mostrar contraseña
            Txt_Password.PasswordChar = '\0'; //Se muestra
        }

        private void BtnPassword_MouseUp(object sender, MouseEventArgs e)
        {
            BtnPassword.BackgroundImage = Properties.Resources.Esconder_Password; // Imagen de ocultar contraseña
            Txt_Password.PasswordChar = '*'; //Se oculta
        }
    }
}
