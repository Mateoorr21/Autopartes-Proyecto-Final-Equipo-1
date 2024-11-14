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
using System.Text.RegularExpressions; //namespace para expresiones regulares

namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    public partial class ModificarUsuario : UserControl
    {
        string PermisoUsuario;
        int IdSeleccionado;
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        public ModificarUsuario(Inicio inicio)
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }

        void BuscarUsuario(string buscar)
        {
            //Si la caja de texto esta vacía un mensaje de Error
            if(string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                MessageBox.Show("Error. Ingrese información a buscar", "ERROR. CAMPO DE BUSQUEDA VACÍO", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                conexion.Open(); //Abrimos conexion
                string query;
                ListViewItem Usuario;

                //Consulta SQL si la casilla Aproximada esta seleccionada
                if (RdAproximada.Checked)
                {
                    if (RdNombre.Checked) query = "SELECT * FROM Usuarios_Operativos WHERE Nombre_Completo LIKE @PorBuscar";
                    else query = "SELECT * FROM Usuarios_Operativos WHERE Usuario LIKE @PorBuscar";
                }

                //Consulta SQL si la casilla Exacta esta seleccionada
                else
                {
                    if (RdNombre.Checked) query = "SELECT * FROM Usuarios_Operativos WHERE Nombre_Completo = @PorBuscar";
                    else query = "SELECT * FROM Usuarios_Operativos WHERE Usuario = @PorBuscar";
                }

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //pasamos consulta y conexion
                {
                    //Si la casilla aproximada esta seleccionada el parametro de busqueda usa %
                    if (RdAproximada.Checked) comando.Parameters.AddWithValue("@PorBuscar", "%" + buscar + "%");
                    else comando.Parameters.AddWithValue("@PorBuscar", buscar); //De lo contrario no

                    OleDbDataReader LeerRegistros = comando.ExecuteReader(); //Objeto de lectura

                    if (LeerRegistros.HasRows) //Si se obtuvieron registros de la busqueda
                    {
                        LvUsuarios.Items.Clear(); 

                        while (LeerRegistros.Read()) //Para cada registro obtenido
                        {
                            //Ingresamos a las columnas del ListView los valores de la base de datos 
                            Usuario = new ListViewItem(LeerRegistros["Id"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Nombre_Completo"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Usuario"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Password"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Tipo"].ToString());

                            //Cargamos  el registro al ListView
                            LvUsuarios.Items.Add(Usuario);
                        }
                    }

                    else //Si no se obtuvieron registros, indicarlo con un MessageBox
                    {
                        MessageBox.Show("No se encontraron Usuarios Operativos", "NO SE ENCONTRARON USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void ActualizarUsuario(string Nombre, string Usuario, string Password, string Permiso, int Id)
        {   
            //Si no hay registro seleccionado menssaje de Error
            if(LvUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error. Seleccione un usuario a modificar", "ERROR. NO SE SELECCIONÓ USUARIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si alguno de los campos a actualizar esta vacío mensaje de Error
            if(string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Usuario.Text) ||
                string.IsNullOrWhiteSpace(Txt_Password.Text))
            {
                MessageBox.Show("Error. Ingrese información a modificar", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Consulta SQL para actualizar los campos de un registro
                string query = "UPDATE Usuarios_Operativos SET Nombre_Completo = @Nombre, Usuario = @Usuario, " +
                                "[Password] = @Password, Tipo = @Permiso WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a los parámetros de la consulta los valores de las variables que recibe la función 
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Password", Password);
                    comando.Parameters.AddWithValue("@Permiso", Permiso);
                    comando.Parameters.AddWithValue("@Id", Id);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            //Actualizamos el registro seleccionado
            ListViewItem Modificado = LvUsuarios.SelectedItems[0];
            Modificado.SubItems[1].Text = Nombre;
            Modificado.SubItems[2].Text = Usuario;
            Modificado.SubItems[3].Text = Password;
            Modificado.SubItems[4].Text = Permiso;

            //Limpiamos los controles de Actualización de Datos (Cajas de Texto y Radios)
            Txt_Nombre.Clear();
            Txt_Usuario.Clear();
            Txt_Password.Clear();
            RdAdmin.Checked = false;
            RdCajero.Checked = false;

            //Mensaje de Actualización de datos exitosa
            MessageBox.Show("Datos del Usuario Operativo actualizados correctamente.", "ACTUALIZACION DE DATOS DE USUARIO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función BuscarUsuario y limpiamos la caja Buscar
            BuscarUsuario(TxtBuscar.Text);
            TxtBuscar.Clear();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            //Incializamos IdSeleccionado
            IdSeleccionado = 0;

            //Declaramos el ListView, sus propiedades y columnas
            LvUsuarios.View = View.Details;
            LvUsuarios.GridLines = true;
            LvUsuarios.FullRowSelect = true;
            LvUsuarios.Columns.Add("Id", 0);
            LvUsuarios.Columns.Add("Nombre", 80);
            LvUsuarios.Columns.Add("Usuario", 80);
            LvUsuarios.Columns.Add("Contraseña", 80);
            LvUsuarios.Columns.Add("Permiso", 80);
        }

        private void LvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvUsuarios.SelectedItems.Count > 0) {

                ListViewItem ItemSeleccionado = LvUsuarios.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);

                //Cargamos la información del ListView en las diferentes cajas de texto y radiobuttons
                Txt_Nombre.Text = ItemSeleccionado.SubItems[1].Text;
                Txt_Usuario.Text = ItemSeleccionado.SubItems[2].Text;
                Txt_Password.Text = ItemSeleccionado.SubItems[3].Text;
                RdAdmin.Checked = ItemSeleccionado.SubItems[4].Text == "Admin" ? true : false;
                RdCajero.Checked = ItemSeleccionado.SubItems[4].Text == "Cajero" ? true : false;
            }
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            //Si se selecciona RdNombre cambiar texto de las etiquetas
            if(RdNombre.Checked)
            {
                //Reemplazar todos los que no sean letras (^ niega el patrón)
                TxtBuscar.Text = Regex.Replace(TxtBuscar.Text, @"[^a-zA-Z]", "");
                LblCampoBuscar.Text = "Nombre";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "Solo admite letras";
            }
        }

        private void RdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            //Si se selecciona Usuario cambiar texto de las etiquetas
            if (RdUsuario.Checked)
            {
                LblCampoBuscar.Text = "Usuario";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "Admite letras, numeros \ny caracteres especiales";
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(RdNombre.Checked) //Si esta seleccionado el RadioButton de Nombre
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back) //Si no es letra, espacio o backspace no ingresar
                {
                    LblErrorBuscar.Visible = true;
                    e.Handled = true;
                }

                else
                {
                    LblErrorBuscar.Visible = false;
                }
            }

            else //Si esta seleccionado el RadioButton de Usuario
            {
                if (e.KeyChar > 126 || e.KeyChar == 32) //Si es espacio o un caracter no admitido no ingresar
                {
                    LblErrorBuscar.Visible = true;
                    e.Handled = true;
                }

                else
                {
                    LblErrorBuscar.Visible = false;
                }
            }
        }

        //Validar caracteres que ingresamos a Nombre (misma que en RegistrarUsuario)
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

        //Validar caracteres que ingresamos a Usuario (misma que en RegistrarUsuario)
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

        //Validar caracteres que ingresamos a Password (misma que en RegistrarUsuario)
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            PermisoUsuario = RdAdmin.Checked ? "Admin" : "Cajero"; //Obtenemos el Permiso del usuario operativo


            //Llamamos a la función actualizar y pasamos los parametros de texto, el permiso y el Id del Registro Seleccionado
            ActualizarUsuario(Txt_Nombre.Text, Txt_Usuario.Text, Txt_Password.Text, PermisoUsuario, IdSeleccionado);
        }
    }
}
