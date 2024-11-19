using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1
{
    public class FuncionesCatalogoUsuarios
    {
        //Declaramos la cadena de conexion que usaremos en el codigo
        public static string cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Base\Mi_prueva_personal.accdb;Persist Security Info=False;";

        //Variables Usadas en el Catalogo de Usuarios
        public static int IdSeleccionado = 0;
        public static int ContarUsuarios = 0;



        //FUNCION PARA AGREGAR UN USUARIO
        public static void AgregarUsuario(string Nombre, string Username, string Password, RadioButton RdAdmin, RadioButton RdCajero, TextBox Txt_Nombre, 
            TextBox Txt_Usuario, TextBox Txt_Password, Label LblErrorNombre, Label LblErrorUsuario, Label LblErrorPassword)
        {
            //Ocultamos etiquetas
            LblErrorNombre.Visible = false;
            LblErrorUsuario.Visible = false;
            LblErrorPassword.Visible = false;

            //Si alguno de los campos a añadir esta vacío mensaje de Error
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Usuario.Text) ||
                string.IsNullOrWhiteSpace(Txt_Password.Text) ||
                (RdAdmin.Checked == false && RdCajero.Checked == false))
            {
                MessageBox.Show("Error. Ingrese información a añadir", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Permiso = RdAdmin.Checked ? "Admin" : "Cajero";

            // Usamos un bloque 'using' para asegurarnos de que la conexión se cierre automáticamente
            using (OleDbConnection connection = new OleDbConnection(cadconexion)) //Accedemos a la cadena de la instancia Inicio (La Global)
            {
                // Abre la conexión
                connection.Open();

                //Verificamos que el usuario que se quiera ingresar no exista en la BDDS
                string ConsultaUsuarioExiste = "SELECT COUNT(*) FROM Usuarios_Operativos WHERE Usuario = @Usuario";
                using (OleDbCommand ComandoUsuario = new OleDbCommand(ConsultaUsuarioExiste, connection))
                {
                    ComandoUsuario.Parameters.AddWithValue("@Usuario", Username);

                    int UsuarioExiste = Convert.ToInt32(ComandoUsuario.ExecuteScalar()); // Ejecutamos el comando y obtenemos el resultado con ExecuteScalar
                    if (UsuarioExiste > 0)
                    {
                        MessageBox.Show("Error. El nombre de usuario que ingresó ya existe. Pruebe con otro nombre de usuario", "ERROR. USUARIO YA EXISTENTE",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //Salimos de la funcion si el usuario ya existe
                    }
                }

                //Verificamos que la contraseña que se quiera ingresar no exista en la BDDS
                string ConsultaPasswordExiste = "SELECT COUNT(*) FROM Usuarios_Operativos WHERE [Password] = @Password";
                using (OleDbCommand ComandoPassword = new OleDbCommand(ConsultaPasswordExiste, connection))
                {
                    ComandoPassword.Parameters.AddWithValue("@Password", Password);

                    int PasswordExiste = Convert.ToInt32(ComandoPassword.ExecuteScalar()); // Ejecutamos el comando y obtenemos el resultado con ExecuteScalar
                    if (PasswordExiste > 0)
                    {
                        MessageBox.Show("Error. La contraseña ingresada ya existe. Pruebe con otra contraseña", "ERROR. CONTRASEÑA YA EXISTENTE",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //Salimos de la funcion si la contraseña ya existe
                    }
                }

                // Crea la consulta SQL para insertar el nuevo registro
                string query = "INSERT INTO Usuarios_Operativos (Nombre_Completo, Usuario, [Password], Tipo) VALUES (@Nombre, @Usuario, @Password, @Tipo)";

                // Crea el comando y asigna los parámetros
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Usuario", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Tipo", Permiso);

                    // Ejecuta la consulta
                    command.ExecuteNonQuery();
                }
            }

            //Limpiamos las cajas de texto y Radio Buttons
            Txt_Nombre.Clear();
            Txt_Usuario.Clear();
            Txt_Password.Clear();
            RdAdmin.Checked = false;
            RdCajero.Checked = false;

            //Mensaje de registro de usuario exitoso
            MessageBox.Show("Registro de " + Permiso + " " + Nombre + " Exitoso",
                "Registro exitoso de Nuevo Usuario Operativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //FUNCIONES PARA ELIMINAR A UN USUARIO

        //FUNCION DE BUSCAR USUARIOS PARA ELIMINARLOS
        public static void BuscarUsuarioEliminar(string buscar, string Username, string Permiso, TextBox TxtBuscar, 
            RadioButton RdAproximada, RadioButton RdNombre, ListView LvUsuarios, Label LblCantidadRegistros, Label LblErrorBuscar)
        {
            LblErrorBuscar.Visible = false; //Ocultamos la etiqueta de Error al Buscar
            ContarUsuarios = 0; //Valor de ContarUsuarios en 0

            //Si la caja de texto esta vacía un mensaje de Error
            if (string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                MessageBox.Show("Error. Ingrese información a buscar", "ERROR. CAMPO DE BUSQUEDA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
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

                if (Permiso == "Admin") query += " AND Tipo = @Cajero ORDER BY Nombre_Completo"; //Si es Admin solo puede eliminar cajeros

                else query += " AND Tipo <> @Propietario ORDER BY Tipo, Nombre_Completo"; //Si es Propietario no puede eliminarse a sí mismo

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //pasamos consulta y conexion
                {
                    //Si la casilla aproximada esta seleccionada el parametro de busqueda usa %
                    if (RdAproximada.Checked) comando.Parameters.AddWithValue("@PorBuscar", "%" + buscar + "%");
                    else comando.Parameters.AddWithValue("@PorBuscar", buscar); //De lo contrario no

                    //Si es Admin o Propietario establecemos el ssegundo parametro de busqueda
                    if (Permiso == "Admin") comando.Parameters.AddWithValue("@Cajero", "Cajero");
                    else comando.Parameters.AddWithValue("@Propietario", "Propietario");

                    OleDbDataReader LeerRegistros = comando.ExecuteReader(); //Objeto de lectura

                    if (LeerRegistros.HasRows) //Si se obtuvieron registros de la busqueda
                    {
                        LvUsuarios.Items.Clear();

                        while (LeerRegistros.Read()) //Para cada registro obtenido
                        {
                            // Aumentamos el contador de registros
                            ContarUsuarios++;

                            //Ingresamos a las columnas del ListView los valores de la base de datos 
                            Usuario = new ListViewItem(LeerRegistros["Id"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Nombre_Completo"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Usuario"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Password"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Tipo"].ToString());

                            //Cargamos  el registro al ListView
                            LvUsuarios.Items.Add(Usuario);
                        }

                        // Actualizamos la etiqueta que cuenta los registros
                        LblCantidadRegistros.Text = "Cantidad de Usuarios: " + ContarUsuarios.ToString();
                    }

                    else //Si no se obtuvieron registros, indicarlo con un MessageBox
                    {
                        MessageBox.Show("No se encontraron Usuarios Operativos", "NO SE ENCONTRARON USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                TxtBuscar.Clear(); //Limpiamos la caja de texto Buscar
            }
        }

        //FUNCION ELIMINAR A UN USUARIO
        public static void BorrarUsuario(int Id, ListView LvUsuarios, Label LblCantidadRegistros, Label LblErrorBuscar, TextBox TxtBuscar)
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error. Seleccione un Usuario a Eliminar", "ERROR. NO SE SELECCIONÓ USUARIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmamos que el usuario desea eliminar el registro seleccioando
            DialogResult ConfirmarEliminar;
            ConfirmarEliminar = MessageBox.Show("¿Esta seguro que desea eliminar al Usuario Operativo seleccionado?",
                "CONFIRMACIÓN DE ELIMINADO DE USUARIO OPERATIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarEliminar == DialogResult.No) return;


            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
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
            }

            //Quitamos del ListView el ususario eliminado
            ListViewItem Seleccionado = LvUsuarios.SelectedItems[0];
            LvUsuarios.Items.Remove(Seleccionado);

            //Actualizamos la etiqueta de Cantidad de Registros
            if (ContarUsuarios > 0) LblCantidadRegistros.Text = "Productos Encontrados: " + (ContarUsuarios - 1).ToString();

            LblErrorBuscar.Visible = false; //Ocultamos la etiqueta de Error al Buscar
            TxtBuscar.Clear(); //Limpiamos la caja de texto Buscar

            //Mensaje de Eliminación de usuario exitosa
            MessageBox.Show("Datos del Usuario Operativo eliminados correctamente.", "ELIMINACION DE USUARIO OPERATIVO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //FUNCIONES PARA MODIFICAR UN USUARIO

        //FUNCION BUSCAR UN USUARIO PARA MODIFICARLO
        public static void BuscarUsuarioModificar(string buscar, string Username, string Permiso, TextBox TxtBuscar, 
            RadioButton RdAproximada, RadioButton RdNombre, ListView LvUsuarios, Label LblCantidadRegistros, Label LblErrorBuscar)
        {
            LblErrorBuscar.Visible = false; //Ocultamos la etiqueta de Error al Buscar
            ContarUsuarios = 0; //Valor de ContarUsuarios en 0

            //Si la caja de texto esta vacía un mensaje de Error
            if (string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                MessageBox.Show("Error. Ingrese información a buscar", "ERROR. CAMPO DE BUSQUEDA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
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

                if (Permiso == "Admin") query += " AND (Tipo = @Cajero OR  Usuario = @PropioUsuario) ORDER BY Tipo, Nombre_Completo"; //Si es Admin solo modifica cajeros y el mismo

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //pasamos consulta y conexion
                {
                    //Si la casilla aproximada esta seleccionada el parametro de busqueda usa %
                    if (RdAproximada.Checked) comando.Parameters.AddWithValue("@PorBuscar", "%" + buscar + "%");
                    else comando.Parameters.AddWithValue("@PorBuscar", buscar); //De lo contrario no

                    //Si es Admin establecemos los demas parametros de busqueda
                    if (Permiso == "Admin")
                    {
                        comando.Parameters.AddWithValue("@Cajero", "Cajero");
                        comando.Parameters.AddWithValue("@PropioUsuario", Username);
                    }

                    OleDbDataReader LeerRegistros = comando.ExecuteReader(); //Objeto de lectura

                    if (LeerRegistros.HasRows) //Si se obtuvieron registros de la busqueda
                    {
                        LvUsuarios.Items.Clear();

                        while (LeerRegistros.Read()) //Para cada registro obtenido
                        {
                            ContarUsuarios++; //Agregamos uno al contador de usuarios

                            //Ingresamos a las columnas del ListView los valores de la base de datos 
                            Usuario = new ListViewItem(LeerRegistros["Id"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Nombre_Completo"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Usuario"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Password"].ToString());
                            Usuario.SubItems.Add(LeerRegistros["Tipo"].ToString());

                            //Cargamos  el registro al ListView
                            LvUsuarios.Items.Add(Usuario);

                            // Actualizamos la etiqueta que cuenta los registros
                            LblCantidadRegistros.Text = "Cantidad de Usuarios: " + ContarUsuarios.ToString();
                        }
                    }

                    else //Si no se obtuvieron registros, indicarlo con un MessageBox
                    {
                        MessageBox.Show("No se encontraron Usuarios Operativos", "NO SE ENCONTRARON USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                TxtBuscar.Clear(); //Limpiamos la caja de texto Buscar
            }
        }

        //FUNCION PARA MODFICIAR A UN USUARIO
        public static void ActualizarUsuario(string NombreModificado, string UsuarioModificado, string PasswordModificado, int Id, ListView LvUsuarios, 
            TextBox Txt_Nombre, TextBox Txt_Usuario, TextBox Txt_Password, RadioButton RdAdmin, RadioButton RdCajero, Label LblErrorBuscar, TextBox TxtBuscar)
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvUsuarios.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error. Seleccione un Usuario a modificar", "ERROR. NO SE SELECCIONÓ USUARIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si alguno de los campos a actualizar esta vacío mensaje de Error
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Usuario.Text) ||
                string.IsNullOrWhiteSpace(Txt_Password.Text))
            {
                MessageBox.Show("Error. Ingrese información a modificar", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmamos que el usuario desea modificar el registro seleccioando
            DialogResult ConfirmarModificar;
            ConfirmarModificar = MessageBox.Show("¿Esta seguro que desea modificar la información del Usuario Operativo seleccionado?",
                "CONFIRMACIÓN DE ACTUALIZACIÓN DE USUARIO OPERATIVO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarModificar == DialogResult.No) return;

            string PermisoModificado = RdAdmin.Checked ? "Admin" : "Cajero"; //Obtenemos el Permiso Modificado del usuario operativo

            //Si el usuario es Propietario y se selecciono a si mismo, el permiso continua siendo propietario
            if (FuncionesAplicacion.TipoUsuario == "Propietario" && RdAdmin.Enabled == false) PermisoModificado = "Propietario";

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Consulta SQL para actualizar los campos de un registro
                string query = "UPDATE Usuarios_Operativos SET Nombre_Completo = @Nombre, Usuario = @Usuario, " +
                                "[Password] = @Password, Tipo = @Permiso WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a los parámetros de la consulta lo que recibe la función 
                    comando.Parameters.AddWithValue("@Nombre", NombreModificado);
                    comando.Parameters.AddWithValue("@Usuario", UsuarioModificado);
                    comando.Parameters.AddWithValue("@Password", PasswordModificado);
                    comando.Parameters.AddWithValue("@Permiso", PermisoModificado);
                    comando.Parameters.AddWithValue("@Id", Id);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }


                //Consulta SQL para actualizar la tabla de Ventas
                string ActualizarVentas = "UPDATE Ventas SET Nombre_Completo = @Nombre, Usuario = @Usuario, Tipo = @Permiso WHERE Usuario = @UsuarioViejo";

                using (OleDbCommand comandoVentas = new OleDbCommand(ActualizarVentas, conexion))
                {
                    // Obtener el usuario anterior del registro seleccionado
                    string UsuarioViejo = LvUsuarios.SelectedItems[0].SubItems[2].Text;

                    //Asignar valores a los parámetros de la consulta
                    comandoVentas.Parameters.AddWithValue("@Nombre", NombreModificado);
                    comandoVentas.Parameters.AddWithValue("@Usuario", UsuarioModificado);
                    comandoVentas.Parameters.AddWithValue("@Permiso", PermisoModificado);
                    comandoVentas.Parameters.AddWithValue("@UsuarioViejo", UsuarioViejo);

                    comandoVentas.ExecuteNonQuery(); //Ejecutamos consulta de Actualización
                }
            }

            //Actualizamos el registro seleccionado
            ListViewItem Modificado = LvUsuarios.SelectedItems[0];
            Modificado.SubItems[1].Text = NombreModificado;
            Modificado.SubItems[2].Text = UsuarioModificado;
            Modificado.SubItems[3].Text = PasswordModificado;
            Modificado.SubItems[4].Text = PermisoModificado;

            //Limpiamos los controles de Actualización de Datos (Cajas de Texto y Radios) y se Deselecciona el ListView
            LvUsuarios.SelectedItems.Clear();
            Txt_Nombre.Clear();
            Txt_Usuario.Clear();
            Txt_Password.Clear();
            RdAdmin.Checked = false;
            RdCajero.Checked = false;
            LblErrorBuscar.Visible = false;
            TxtBuscar.Clear();

            //Mensaje de Actualización de datos exitosa
            MessageBox.Show("Datos del Usuario Operativo actualizados correctamente.", "ACTUALIZACION DE DATOS DE USUARIO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //FUNCIONES DE VALIDAR CAMPOS DE ENTRADA DE USUARIO
        public static void ValidarEntradaTxtNombreCompleto(KeyPressEventArgs e, Label LblErrorNombre)
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

        public static void ValidarEntradaTxtUsuarioOPassword(KeyPressEventArgs e, Label LblError)
        {
            if (e.KeyChar > 126 || e.KeyChar == 32) //Si es espacio o un caracter no admitido no ingresar
            {
                LblError.Visible = true;
                e.Handled = true;
            }

            else
            {
                LblError.Visible = false;
            }
        }


        //FUNCIONES PARA VALIDAR CAMPOS DE ENTRADA DE BUSQUEDA Y ADMINSITRAR CONTROLES
        public static void SeleccionoNombreCompleto(RadioButton RdNombre, TextBox TxtBuscar, Label LblCampoBuscar, Label LblErrorBuscar)
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

        public static void SeleccionoUsuario(RadioButton RdUsuario, TextBox TxtBuscar, Label LblCampoBuscar, Label LblErrorBuscar)
        {
            //Si se selecciona Usuario cambiar texto de las etiquetas
            if (RdUsuario.Checked)
            {
                LblCampoBuscar.Text = "Usuario";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "Admite letras, numeros \ny caracteres especiales";
            }
        }
        public static void ValidarEntradaTxtBuscarUsuarioOperativo(KeyPressEventArgs e, RadioButton RdNombre, Label LblErrorBuscar)
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
    }
}
