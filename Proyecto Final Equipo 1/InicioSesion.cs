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
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        string Nombre_Completo;
        string Usuario;
        string Permiso;
        public InicioSesion(Inicio inicio) //InicioSesion recibe parametro de instancia Inicio
        {
            InitializeComponent();
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
        }

        void IngresoUsuario(string Username, string Password)
        {
            OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion);

            conexion.Open(); //Abrimos la conexion
            string consulta = "SELECT Nombre_Completo, Usuario, Tipo FROM Usuarios_Operativos WHERE Usuario = @usuario AND Password = @password"; //Consulta
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", Username); //Parametro de busqueda Username
            comando.Parameters.AddWithValue("@password", Password); //Parametro de bsuqueda Password
            OleDbDataReader lector = comando.ExecuteReader(); //Ejecutar lectura

            if (lector.HasRows) //Si hay un resultado, es decir, si existe la cuenta
            {
                lector.Read(); //Leemos el registro obtenido
                string NombreCompleto = lector["Nombre_Completo"].ToString(); //Nombre a cadena String
                string Usuario = lector["Usuario"].ToString(); //Usuario a cadena String
                string TipoUsuario = lector["Tipo"].ToString(); //Tipo de Permiso a cadena String

                //Mensaje de inicio de sesión exitoso
                MessageBox.Show( "Bienvenido " + TipoUsuario + " " + NombreCompleto + ".",
                    "INICIO DE SESIÓN EXITOSO. Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Variable booleana (Es un Admin o no)
                bool TienePermiso = TipoUsuario == "Admin" || TipoUsuario == "Propietario";

                // Abrir el formulario
                Aplicacion aplicacion = new Aplicacion(TienePermiso, TipoUsuario, Usuario, NombreCompleto, Inicio_Recibido); //Aplicacion recibe el booleano, permiso y nombre
                                                                                                               //Aplicacion también recibe la instancia de Inicio recibida en el formulario InicioSesion
                aplicacion.ShowDialog();
            }

            else
            {   //Error en caso de que no exista el usuario y/o contraseña
                MessageBox.Show("Usuario y/o Contraseña incorrectos.", "Error. No existe la cuenta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErroresInicioSesion++;
                if (ErroresInicioSesion == 3)
                {
                    System.Windows.Forms.Application.Exit(); // Si estás intentando salir de la aplicación
                }
            }

            if (conexion.State == ConnectionState.Open) //Si la conexion esta abierta la cerramos
            {
                conexion.Close();
            }
        }

        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {
            IngresoUsuario(Txt_Usuario.Text, Txt_Password.Text);
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar > 126 || e.KeyChar == 32) //Si es espacio o un caracter no admitido no ingresar
            {
                LblErrorUsuario.Visible = true;
                e.Handled = true;
            }

            else
            {
                LblErrorUsuario.Visible = false;
            }
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 126 || e.KeyChar == 32) //Si es espacio o es un caracter no admitido no ingresar
            {
                LblErrorPassword.Visible = true;
                e.Handled = true;
            }

            else
            {
                LblErrorPassword.Visible = false;
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            ErroresInicioSesion = 0;
        }
    }
}
