using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios
{
    public partial class EliminarUsuario : UserControl
    {
        int IdSeleccionado;
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        public EliminarUsuario(Inicio inicio)
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }


        //Misma función de busqueda de usuario que en ModificarUsuario
        void BuscarUsuario(string buscar)
        {
            //Si la caja de texto esta vacía un mensaje de Error
            if (string.IsNullOrWhiteSpace(TxtBuscar.Text))
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

        //Función para borrar un usuario seleccionado
        void BorrarUsuario(int Id)
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error. Seleccione un usuario a Elimianr", "ERROR. NO SE SELECCIONÓ USUARIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmamos que el usuario desea eliminar el registro seleccioando
            DialogResult ConfirmarEliminar;
            ConfirmarEliminar = MessageBox.Show("¿Esta seguro que desea eliminar al Usuario Operativo seleccionado?",
                "CONFIRMACIÓN DE ELIMINADO DE USUARIO OPERATIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarEliminar == DialogResult.No) return;


            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Consulta SQL para eliminar un registro
                string query = "DELETE FROM Usuarios_Operativos WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a un parametro de consulta el Id del Registro seleccionado
                    comando.Parameters.AddWithValue("@Id", Id);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta de acción
                }

                //Mensaje de Eliminación de usuario exitosa
                MessageBox.Show("Datos del Usuario Operativo eliminados correctamente.", "ELIMINACION DE USUARIO OPERATIVO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función BuscarUsuario y limpiamos la caja Buscar
            BuscarUsuario(TxtBuscar.Text);
            TxtBuscar.Clear();
        }

        private void LvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem ItemSeleccionado = LvUsuarios.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);
            }
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            //Incializamos IdSeleccionado
            IdSeleccionado = 0;

            //Declaramos el ListView, sus propiedades y columnas
            LvUsuarios.View = View.Details;
            LvUsuarios.GridLines = true;
            LvUsuarios.FullRowSelect = true;
            LvUsuarios.Columns.Add("Id", 0);
            LvUsuarios.Columns.Add("Nombre", 120);
            LvUsuarios.Columns.Add("Usuario", 110);
            LvUsuarios.Columns.Add("Contraseña", 100);
            LvUsuarios.Columns.Add("Permiso", 100);
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            //Si se selecciona RdNombre cambiar texto de las etiquetas
            if (RdNombre.Checked)
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
            if (RdNombre.Checked) //Si esta seleccionado el RadioButton de Nombre
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función Eliminar y pasamos el parametro del Id del Registro Seleccionado
            BorrarUsuario(IdSeleccionado);
        }
    }
}
