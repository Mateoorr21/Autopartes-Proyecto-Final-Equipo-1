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
        string PermisoUsuario;
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        public RegistrarUsuario(Inicio inicio)
        {
            InitializeComponent();
            this.Inicio_Recibido = inicio; //A Inicio_Recibido le asignamos el parametro recibido 
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            PermisoUsuario = RdAdmin.Checked ? "Admin" : "Cajero";
            Inicio_Recibido.AgregarUsuario(Txt_Nombre.Text, Txt_Usuario.Text, Txt_Password.Text, PermisoUsuario, Txt_Nombre, Txt_Usuario,
                Txt_Password, LblErrorNombre, LblErrorUsuario, LblErrorPassword);
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtNombreCompleto(e, LblErrorNombre); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtUsuarioOPassword(e, LblErrorUsuario); //LLamamos a la función de validar entrada del TextBox Usuario
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtUsuarioOPassword(e, LblErrorPassword); //LLamamos a la función de validar entrada del TextBox Password
        }
    }
}
