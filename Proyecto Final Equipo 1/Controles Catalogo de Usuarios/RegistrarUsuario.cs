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

        void AgregarUsuario(string Nombre, string Username, string Password, string Permiso)
        {
            //Si alguno de los campos a añadir esta vacío mensaje de Error
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Usuario.Text) ||
                string.IsNullOrWhiteSpace(Txt_Password.Text))
            {
                MessageBox.Show("Error. Ingrese información a añadir", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Usamos un bloque 'using' para asegurarnos de que la conexión se cierre automáticamente
            using (OleDbConnection connection = new OleDbConnection(Inicio_Recibido.cadconexion)) //Accedemos a la cadena de la instancia Inicio (La Global)
            {
                // Abre la conexión
               connection.Open();

                // Crea la consulta SQL para insertar el nuevo registro
                string query = "INSERT INTO Usuarios_Operativos (Nombre_Completo, Usuario, [Password], Tipo) VALUES (?, ?, ?, ?)";

                    // Crea el comando y asigna los parámetros
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("?", Nombre);
                        command.Parameters.AddWithValue("?", Username);
                        command.Parameters.AddWithValue("?", Password);
                        command.Parameters.AddWithValue("?", Permiso);
                       
                        // Ejecuta la consulta
                        command.ExecuteNonQuery();
                    }

                //Limpiamos las cajas de texto
                Txt_Nombre.Clear();
                Txt_Usuario.Clear();
                Txt_Password.Clear();

                //Mensaje de registro de usuario exitoso
                MessageBox.Show($"Registro de {Permiso} {Nombre} Exitoso",
                    "Registro exitoso de Nuevo Usuario Operativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        } 

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            PermisoUsuario = RdAdmin.Checked ? "Admin" : "Cajero";
            AgregarUsuario(Txt_Nombre.Text, Txt_Usuario.Text, Txt_Password.Text, PermisoUsuario);
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back) //Si no es letra, espacio o backspace no ingresar
            {
                LblErrorNombre.Visible = true;
                e.Handled = true;
            }

            else
            {
                LblErrorNombre.Visible = false;
            }
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 126 || e.KeyChar == 32) //Si es espacio o un caracter no admitido no ingresar
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
            if (e.KeyChar > 126 || e.KeyChar == 32) //Si es espacio o un caracter no admitido no ingresar
            {
                LblErrorPassword.Visible = true;
                e.Handled = true;
            }

            else
            {
                LblErrorPassword.Visible = false;
            }
        }
    }
}
