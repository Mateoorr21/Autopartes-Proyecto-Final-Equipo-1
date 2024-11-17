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

namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    public partial class RegistrarUsuario : UserControl
    {
        public RegistrarUsuario()
        {
            InitializeComponent(); 
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //Llamamos a la función Registrar Usuarios
            FuncionesCatalogoUsuarios.AgregarUsuario(Txt_Nombre.Text, Txt_Usuario.Text, Txt_Password.Text, RdAdmin, Txt_Nombre, Txt_Usuario,
                Txt_Password, LblErrorNombre, LblErrorUsuario, LblErrorPassword);
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtNombreCompleto(e, LblErrorNombre); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorUsuario); //LLamamos a la función de validar entrada del TextBox Usuario
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorPassword); //LLamamos a la función de validar entrada del TextBox Password
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.LimpiarControles(this); //Si se selecciona Cancelar limpiamos todos los controles
        }
    }
}
