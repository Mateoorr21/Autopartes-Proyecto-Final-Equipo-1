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
        int IdSeleccionado;
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        Aplicacion Aplicacion_Recibida; //Declaramos Aplicacion al que le asiganarmos el que se recibe
        public ModificarUsuario(Inicio inicio, Aplicacion aplicacion)
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
            Aplicacion_Recibida = aplicacion;
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

            string PermisoModificado = RdAdmin.Checked ? "Admin" : "Cajero"; //Obtenemos el Permiso del usuario operativo
            
            //Si el usuario es Propietario y se selecciono a si mismo, el permiso continua siendo propietario
            if (Permiso == "Propietario" && RdCajero.Enabled == false) PermisoModificado = "Propietario";

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Consulta SQL para actualizar los campos de un registro
                string query = "UPDATE Usuarios_Operativos SET Nombre_Completo = @Nombre, Usuario = @Usuario, " +
                                "[Password] = @Password, Tipo = @Permiso WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a los parámetros de la consulta lo que recibe la función 
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Usuario", Usuario);
                    comando.Parameters.AddWithValue("@Password", Password);
                    comando.Parameters.AddWithValue("@Permiso", PermisoModificado);
                    comando.Parameters.AddWithValue("@Id", Id);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            //Actualizamos el registro seleccionado
            ListViewItem Modificado = LvUsuarios.SelectedItems[0];
            Modificado.SubItems[1].Text = Nombre;
            Modificado.SubItems[2].Text = Usuario;
            Modificado.SubItems[3].Text = Password;
            Modificado.SubItems[4].Text = PermisoModificado;

            //Limpiamos los controles de Actualización de Datos (Cajas de Texto y Radios) y se Deselecciona el ListView
            LvUsuarios.SelectedItems.Clear();
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
            //Llamamos a la función BuscarUsuarioModificar de Inicio
            Inicio_Recibido.BuscarUsuarioModificar(TxtBuscar.Text, Aplicacion_Recibida.Usuario, Aplicacion_Recibida.TipoUsuario, TxtBuscar, RdAproximada, RdNombre, LvUsuarios);
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

            if(Aplicacion_Recibida.TipoUsuario == "Admin") //Si el usuario que entra es un Admin, no puede cambiar permisos
            {
                RdAdmin.Enabled = false;
                RdCajero.Enabled = false;
            }
        }

        private void LvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvUsuarios.SelectedItems.Count > 0) {

                ListViewItem ItemSeleccionado = LvUsuarios.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);

                if(IdSeleccionado == 1 && Aplicacion_Recibida.TipoUsuario == "Propietario") //Si el propietario se selecciona inhabilitamos el cambio de permiso
                {
                    RdAdmin.Enabled = false;
                    RdCajero.Enabled = false;
                }

                else //Si no se selecciona a si mismo esta opcion esta habilitada
                {
                    RdAdmin.Enabled = true;
                    RdCajero.Enabled = true;
                }

                //Cargamos la información del ListView en las diferentes cajas de texto y radiobuttons
                Txt_Nombre.Text = ItemSeleccionado.SubItems[1].Text;
                Txt_Usuario.Text = ItemSeleccionado.SubItems[2].Text;
                Txt_Password.Text = ItemSeleccionado.SubItems[3].Text;
                RdAdmin.Checked = ItemSeleccionado.SubItems[4].Text == "Admin" ? true : false; //Si se selecciona propietario nada se marca
                RdCajero.Checked = ItemSeleccionado.SubItems[4].Text == "Cajero" ? true : false;
            }
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoNombreCompleto(RdNombre, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void RdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoUsuario(RdUsuario, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtBuscarUsuarioOperativo(e, RdNombre, LblErrorBuscar); //LLamamos a la función ValidaEntrada del campo Buscar
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtNombreCompleto(e, LblErrorNombre); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtUsuarioOPassword(e, LblErrorNombre); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtUsuarioOPassword(e, LblErrorNombre); //LLamamos a la función de validar entrada del TextBox Nombre
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función actualizar y pasamos los parametros de texto, el permiso y el Id del Registro Seleccionado
            ActualizarUsuario(Txt_Nombre.Text, Txt_Usuario.Text, Txt_Password.Text, Aplicacion_Recibida.TipoUsuario, IdSeleccionado);
        }
    }
}
