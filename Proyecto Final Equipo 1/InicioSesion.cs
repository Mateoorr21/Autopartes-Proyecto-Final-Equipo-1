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
        public InicioSesion(Inicio inicio) //InicioSesion recibe parametro de instancia Inicio
        {
            InitializeComponent();
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
        }

        void IngresoUsuario(string Username, string Password)
        {
            using (OleDbConnection inicio1 = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                try
                {
                    inicio1.Open(); //Abrimos la conexion
                    string consulta = "SELECT Nombre_Completo, Tipo FROM Usuarios_Operativos WHERE Usuario = @usuario AND Password = @password"; //Consulta
                    OleDbCommand comando = new OleDbCommand(consulta, inicio1);
                    comando.Parameters.AddWithValue("@usuario", Username); //Parametro de busqueda Username
                    comando.Parameters.AddWithValue("@password", Password); //Parametro de bsuqueda Password
                    OleDbDataReader lector = comando.ExecuteReader(); //Ejecutar lectura

                    if (lector.HasRows) //Si hay un resultado, es decir, si existe la cuenta
                    {
                        lector.Read(); //Leemos el registro obtenido
                        string nombreCompleto = lector["Nombre_Completo"].ToString(); //Nombre a cadena String
                        string tipoUsuario = lector["Tipo"].ToString(); //Tipo de Permiso a cadena String

                        // Ocultar la interfaz principal de inicio de sesión
                        this.Hide();

                        //Mensaje de inicio de sesión exitoso
                        MessageBox.Show($"Bienvenido {tipoUsuario} {nombreCompleto}",
                            "INICIO DE SESIÓN EXITOSO. Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Variable booleana (Es un Admin o no)
                        bool EsAdmin = tipoUsuario == "Admin";

                        // Abrir el formulario
                        Aplicacion aplicacion = new Aplicacion(EsAdmin, tipoUsuario, nombreCompleto, Inicio_Recibido); //Aplicaicon recibe el booleano, permiso y nombre
                        //Aplicacion también recibe la instancia de Inicio recibida en el formulario InicioSesion
                        aplicacion.Show();
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
                }

                catch (Exception ex) //Si existe algún error lo msotramos
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
