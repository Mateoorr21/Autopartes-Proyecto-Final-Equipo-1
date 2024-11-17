using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;

namespace Proyecto_Final_Equipo_1
{
    public class FuncionesAplicacion
    {
        //Declaramos la cadena de conexion que usaremos en el codigo
        public static string cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Base\Mi_prueva_personal.accdb;Persist Security Info=False;";

        //Declaramos el Nombre Completo, Usuario y Permiso del usuario que inicia sesión
        public static string NombreCompleto = null;
        public static string Usuario = null;
        public static string TipoUsuario = null;
        public static bool TienePermiso = false;
        public static int ErroresInicioSesion = 0;

        //Declaramos e Inicializamos variables que se utilizan en la Aplicacion
        public static int IdGenerado = 0;
        public static bool SeModificoImagen = false;
        public static string RutaImagenTemporal = null;
        public static int IdSeleccionado = 0;
        public static int ContarProductos = 0;

        public static int ColumnaOrdenar = -1; //Variable para OrdenarColumnas



        //FUNCION PARA ORDENAR LAS COLUMANS DE UN LISTVIEW, RECIBE UN LISTVIEW COMO PARAMETRO
        public static void OrdenamientoColumnas(ColumnClickEventArgs e, ListView LvTabla)
        {
            if (e.Column != ColumnaOrdenar)
            { //Si la columna elegida no esta ordenada
                ColumnaOrdenar = e.Column;
                LvTabla.Sorting = SortOrder.Ascending; //La ordenamos ascendente
            }

            else
            { //Si ya esta ordenada, cambiamos su ordenacion...
                if (LvTabla.Sorting == SortOrder.Ascending)
                {
                    LvTabla.Sorting = SortOrder.Descending;
                }

                else
                {
                    LvTabla.Sorting = SortOrder.Ascending;
                }
            }

            LvTabla.Sort();
            LvTabla.ListViewItemSorter =
                new ListViewItemComparer(e.Column, LvTabla.Sorting);
        }



        //FUNCION PARA REINICIAR VARIABLES (MENOS ContarProductos)
        public static void ReiniciarVariables()
        {
            //Reinciamos el valor de las Variables usadas
            IdGenerado = 0;
            SeModificoImagen = false;
            RutaImagenTemporal = null;
            IdSeleccionado = 0;
        }


        //FUNCION PARA INICIAR SESION AL SISTEMA
        public static void IniciarSesion(string Username, string Password, TextBox TxtUsuario, TextBox TxtPassword)
        {
            // Usamos 'using' para gestionar la conexión y asegurar que se liberen los recursos automáticamente
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos la conexión

                string consulta = "SELECT Nombre_Completo, Usuario, Tipo FROM Usuarios_Operativos WHERE Usuario = @usuario AND Password = @password"; //Consulta

                // Usamos 'using' también para el comando, asegurando que se libere correctamente después de su uso
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", Username); //Parametro de busqueda Username
                    comando.Parameters.AddWithValue("@password", Password); //Parametro de búsqueda Password

                    // Usamos 'using' para el lector de datos
                    using (OleDbDataReader lector = comando.ExecuteReader()) //Ejecutar lectura
                    {
                        if (lector.HasRows) //Si hay un resultado, es decir, si existe la cuenta
                        {
                            lector.Read(); //Leemos el registro obtenido
                            NombreCompleto = lector["Nombre_Completo"].ToString(); //Nombre a cadena String
                            Usuario = lector["Usuario"].ToString(); //Usuario a cadena String
                            TipoUsuario = lector["Tipo"].ToString(); //Tipo de Permiso a cadena String

                            //Limpiamos las cajas de Texto
                            TxtUsuario.Clear();
                            TxtPassword.Clear();

                            //Mensaje de inicio de sesión exitoso
                            MessageBox.Show("Bienvenido " + TipoUsuario + " " + NombreCompleto + ".",
                                "INICIO DE SESIÓN EXITOSO. Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Variable booleana (Es un Admin o no)
                            TienePermiso = TipoUsuario == "Admin" || TipoUsuario == "Propietario";

                            // Abrir el formulario
                            Aplicacion aplicacion = new Aplicacion();                                                 
                            aplicacion.ShowDialog();
                        }
                        else
                        {
                            //Error en caso de que no exista el usuario y/o contraseña
                            MessageBox.Show("Usuario y/o Contraseña incorrectos.", "Error. No existe la cuenta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                            ErroresInicioSesion++; //Sumamos un "Strike"

                            if (ErroresInicioSesion == 3)
                            {
                                System.Windows.Forms.Application.Exit(); // Si se llegan a 3 errores se cierra la aplicacion
                            }
                        }
                    }
                }
            }
        }



        public static void LimpiarControles(Control ControlUsuario)
        {
            foreach (Control control in ControlUsuario.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RadioButton radioButton)
                {
                    //El radioButton de Aproximada y Nombre se seleccionan por Default
                    if (radioButton.Name.Contains("Aproximada") || radioButton.Name.Contains("Nombre")) radioButton.Checked = true;

                    else radioButton.Checked = false;
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
                else if (control is Label Etiqueta && Etiqueta.Name.Contains("Error"))
                {
                    Etiqueta.Visible = false; // Ocultamos los labels que son de mensaje de Error
                }
                else if (control is ListView listView)
                {
                    listView.Items.Clear(); //Limpiamos el ListView
                }
                // Si el control es otro contenedor de controles, llamamos a la funcion de nuevo
                else if (control.HasChildren)
                {
                    FuncionesAplicacion.LimpiarControles(control);
                }
            }
        }



        //FUNCION PARA CARGAR PRODUCTOS EN EL INVENTARIO
        public static void CargarProductos(ListView LvProductos, Label LblCantidadRegistros)
        {
            ContarProductos = 0; // Reseteamos el contador de productos

            LvProductos.Items.Clear(); // Limpiamos el contenido del ListView

            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); // Abrimos conexión

                string query = "SELECT * FROM Productos"; //Consulta SQL
                ListViewItem Producto;

                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    OleDbDataReader LeerProductos = comando.ExecuteReader();

                    while (LeerProductos.Read()) // Para cada registro obtenido
                    {
                        // Aumentamos el contador de registros
                        ContarProductos++;

                        // Ingresamos a las columnas del ListView los valores de la base de datos
                        Producto = new ListViewItem(LeerProductos["Id"].ToString());
                        Producto.SubItems.Add(LeerProductos["Nombre"].ToString());
                        Producto.SubItems.Add(LeerProductos["Descripcion"].ToString());
                        Producto.SubItems.Add(LeerProductos["Marca"].ToString());
                        Producto.SubItems.Add(LeerProductos["Precio"].ToString());
                        Producto.SubItems.Add(LeerProductos["Cantidad_en_Stock"].ToString());

                        // Cargamos el registro al ListView
                        LvProductos.Items.Add(Producto);
                    }

                    // Actualizamos la etiqueta que cuenta los registros
                    LblCantidadRegistros.Text = "Cantidad de Productos: " + ContarProductos.ToString();
                }
            }
        }



        //FUNCION PARA AGREGAR UN PRODUCTO A LA BASE DE DATOS
        public static void RegistrarProducto(string Nombre, string Descripcion, string Marca, Label LblErrorPrecio, Label LblErrorCantidad,
                TextBox Txt_Nombre, TextBox Txt_Descripcion, TextBox Txt_Marca, TextBox Txt_Precio, TextBox Txt_Cantidad, PictureBox PicImagenProducto)
        {
            //Ocultamos las etiquetas
            LblErrorPrecio.Visible = false;
            LblErrorCantidad.Visible = false;

            //Si algun campo esta vacío (exceptuando la descripción)  mensaje de error
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Descripcion.Text) ||
                string.IsNullOrWhiteSpace(Txt_Marca.Text) ||
                string.IsNullOrWhiteSpace(Txt_Precio.Text) ||
                string.IsNullOrWhiteSpace(Txt_Cantidad.Text) ||
                PicImagenProducto.Image == null)
            {
                MessageBox.Show("Error. Ingrese la información del producto a ingresar", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Convertimos el valor de las cajas en tipo float y entero
            float Precio = float.Parse(Txt_Precio.Text);
            int Cantidad = int.Parse(Txt_Cantidad.Text);

            //Establecemos el obejto OledbConnection para conectar con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Primer comando SQL para insertar el registro
                string query = "INSERT INTO Productos (Nombre, Descripcion, Marca, Precio, Cantidad_en_Stock, Imagen) " +
                   "VALUES (@Nombre, @Descripcion, @Marca, @Precio, @CantidadEnStock, @Imagen)";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Comando SQL
                {
                    //Parametros de consulta, los valores que se van a insertar a la base de datos
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@Marca", Marca);
                    comando.Parameters.AddWithValue("@Precio", Precio);
                    comando.Parameters.AddWithValue("@CantidadEnStock", Cantidad);
                    comando.Parameters.AddWithValue("@Imagen", string.Empty); //Por el momento una cadena vacía en el apartado imagen

                    comando.ExecuteNonQuery(); //Ejectuamos comando de inserción
                }

                //Segundo comando SQL para obtener el último Id Generado
                string queryID = "SELECT MAX(Id) FROM Productos";

                using (OleDbCommand comando = new OleDbCommand(queryID, conexion))
                {
                    IdGenerado = (int)comando.ExecuteScalar(); //Ejecutamos comando y obtenemos el último Id generado
                }
            }

            //Copiamos la imagen ingresada por el usuario a nuestra carpeta, con el nombre que deseamos 

            //Obtenemos la ruta destino tomando en cuenta la ubicación de la carpeta Imagenes, el nombre de la imagen y .jpg
            string RutaDestino = "..\\..\\..\\Imagenes\\" + IdGenerado.ToString() + ".jpg";

            // Copiar el archivo de la ruta temporal a la ruta destino (ya con el nombre correcto)
            File.Copy(RutaImagenTemporal, RutaDestino, true);

            //Actualizamos la base de datos con la ruta correcta de la imagen
            using (OleDbConnection conexion = new OleDbConnection(cadconexion)) //Conexion
            {
                conexion.Open(); //Abrimos conexion

                //Obtenemos la ruta que se va agregar a la base de datos (Añadimos # para que el hipervinculo en la BDDS funcione)
                string RutaAgregar = "#..\\Imagenes\\" + IdGenerado.ToString() + ".jpg#";

                string query = "UPDATE Productos SET Imagen = @Imagen WHERE Id = @Id "; //Sentencia de actualización

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Objeto de clase Comando SQL
                {
                    comando.Parameters.AddWithValue("@Imagen", RutaAgregar); //Parametro de Imagen es la RutaDestino
                    comando.Parameters.AddWithValue("@Id", IdGenerado); //Parametro IdGenerado

                    comando.ExecuteNonQuery(); //Ejecutamos el comando de actualizacion
                }
            }

            //Limpiamos las cajas de texto y liberamos el Picture Box
            Txt_Nombre.Clear();
            Txt_Descripcion.Clear();
            Txt_Marca.Clear();
            Txt_Precio.Clear();
            Txt_Cantidad.Clear();
            PicImagenProducto.Image = null;

            //Mensaje de registro de producto exitoso
            MessageBox.Show("Registro de Producto " + Nombre + " Exitoso",
                "Registro exitoso de Producto a Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //FUNCION PARA BUSCAR UN PRODUCTO
        public static void EncontrarProductos(string buscar, TextBox TxtBuscar, RadioButton RdAproximada, RadioButton RdNombre, ListView LvProductos, Label LblCantidadRegistros)
        {
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
                ListViewItem Producto;

                //Consulta SQL si la casilla Aproximada esta seleccionada
                if (RdAproximada.Checked)
                {
                    if (RdNombre.Checked) query = "SELECT * FROM Productos WHERE Nombre LIKE @PorBuscar";
                    else query = "SELECT * FROM Productos WHERE Id LIKE @PorBuscar";
                }

                //Consulta SQL si la casilla Exacta esta seleccionada
                else
                {
                    if (RdNombre.Checked) query = "SELECT * FROM Prodcutos WHERE Nombre = @PorBuscar";
                    else query = "SELECT * FROM Productos WHERE Id = @PorBuscar";
                }

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //pasamos consulta y conexion
                {
                    //Si la casilla aproximada esta seleccionada el parametro de busqueda usa %
                    if (RdAproximada.Checked) comando.Parameters.AddWithValue("@PorBuscar", "%" + buscar + "%");
                    else comando.Parameters.AddWithValue("@PorBuscar", buscar); //De lo contrario no

                    OleDbDataReader LeerProductos = comando.ExecuteReader(); //Objeto de lectura

                    ContarProductos = 0; //Variable para contar los registros

                    if (LeerProductos.HasRows) //Si se obtuvieron registros de la busqueda
                    {
                        LvProductos.Items.Clear(); //Limpiamos el contenido del ListView

                        while (LeerProductos.Read()) //Para cada registro obtenido
                        {
                            //Aumentamos el contador de registros
                            ContarProductos++;

                            //Ingresamos a las columnas del ListView los valores de la base de datos 
                            Producto = new ListViewItem(LeerProductos["Id"].ToString());
                            Producto.SubItems.Add(LeerProductos["Nombre"].ToString());
                            Producto.SubItems.Add(LeerProductos["Descripcion"].ToString());
                            Producto.SubItems.Add(LeerProductos["Marca"].ToString());
                            Producto.SubItems.Add(LeerProductos["Precio"].ToString());
                            Producto.SubItems.Add(LeerProductos["Cantidad_en_Stock"].ToString());
                            Producto.SubItems.Add(LeerProductos["Imagen"].ToString().Trim('#')); //Siempre cargamos a ListView eliminando los #

                            //Cargamos  el registro al ListView
                            LvProductos.Items.Add(Producto);

                            //Actualizamos la etiqueta que cuenta los registros
                            LblCantidadRegistros.Text = "Productos Encontrados: " + ContarProductos.ToString();
                        }
                    }

                    else //Si no se obtuvieron registros, indicarlo con un MessageBox
                    {
                        MessageBox.Show("No se encontraron Productos", "NO SE ENCONTRARON PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            TxtBuscar.Clear(); //Limpiamos el TextBox Buscar
        }



        //FUNCION PARA MOSTRAR LA INFORMACION DE UN PRODUCTO
        public static void MostrarProducto(ListView LvProductos, PictureBox PicImagenProducto)
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para mostrar su información",
                    "ERROR. NO HAY REGISTRO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Objeto de conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                string query = "SELECT * FROM Productos WHERE Id = @IdSeleccionado"; //Consulta de selección

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Objeto de consulta
                {
                    comando.Parameters.AddWithValue("@IdSeleccionado", IdSeleccionado); //Parametro IdSeleccioando

                    OleDbDataReader LeerProducto = comando.ExecuteReader(); //Objeto de Lectura y ejecutamos lectura

                    while (LeerProducto.Read())
                    { //Para el regisro que se lee

                        //Mostramos en un Message Box la información obtenida de la consulta de selección
                        MessageBox.Show("Datos del Producto Seleccionado:" +
                            " \n\n\nId: " + LeerProducto["Id"].ToString() +
                            " \n\nNombre: " + LeerProducto["Nombre"].ToString() +
                            " \n\nDescripcion: " + LeerProducto["Id"].ToString() +
                            " \n\nMarca: " + LeerProducto["Marca"].ToString() +
                            " \n\nPrecio: $ " + LeerProducto["Precio"].ToString() +
                            " \n\nCantidad en Stock: " + LeerProducto["Cantidad_en_Stock"].ToString(),
                            "INFORMACIÓN DEL PRODUCTO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string RutaImagen = LeerProducto["Imagen"].ToString().Trim('#'); //Obtenemos la ruta y quitamos los #

                        string RutaImagenAbrir = "..\\..\\" + RutaImagen; //Creamos la nueva ruta (saliendo varias carpetas mas)

                        PicImagenProducto.Image = Image.FromFile(RutaImagenAbrir); //Cargamos la Imagen                
                    }
                }
            }
        }



        //FUNCION PARA MODIFICAR LA INFORMACION DE UN PRODUCTO
        public static void ActualizarProducto(string Nombre, string Descripcion, string Marca, ListView LvProductos,
            TextBox Txt_Nombre, TextBox Txt_Descripcion, TextBox Txt_Marca, TextBox Txt_Precio, TextBox Txt_Cantidad, PictureBox PicImagenProducto)
        {

            //Si no hay registro seleccionado menssaje de Error
            if (LvProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error. Seleccione un producto a modificar", "ERROR. NO SE SELECCIONÓ PRODUCTO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si alguno de los campos a actualizar esta vacío mensaje de Error
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Descripcion.Text) ||
                string.IsNullOrWhiteSpace(Txt_Marca.Text) ||
                string.IsNullOrWhiteSpace(Txt_Precio.Text) ||
                string.IsNullOrWhiteSpace(Txt_Cantidad.Text) ||
                RutaImagenTemporal == null)
            {
                MessageBox.Show("Error. Ingrese información a modificar", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Convertimos el valor de las cajas en tipo float y entero
            float Precio = float.Parse(Txt_Precio.Text);
            float Cantidad = int.Parse(Txt_Cantidad.Text);

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Consulta SQL para actualizar los campos de un registro
                string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, " +
                                "Marca = @Marca, Precio = @Precio, Cantidad_en_Stock = @Cantidad WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a los parámetros de la consulta los valores de las variables que recibe la función 
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@Marca", Marca);
                    comando.Parameters.AddWithValue("@Precio", Precio);
                    comando.Parameters.AddWithValue("@Cantidad", Cantidad);
                    //La ruta de la imagen no la actualizamos ya que seguira siendo la misma
                    comando.Parameters.AddWithValue("@Id", IdSeleccionado);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            // Liberamos la imagen del PictureBox
            PicImagenProducto.Image = null;

            MessageBox.Show(RutaImagenTemporal + " " + SeModificoImagen);
            //Solo si se modifico la imagen, borramos la existente y copiamos la nueva
            if (SeModificoImagen)
            {
                // Obtenemos la ruta de la imagen existente con el mismo ID
                string RutaImagenEnCarpetaJpg = "..\\..\\..\\Imagenes\\" + IdSeleccionado.ToString() + ".jpg";

                // Pasamos el reemplazo a la carpeta usando RutaImagenEnCarpetaJpg
                File.Copy(RutaImagenTemporal, RutaImagenEnCarpetaJpg, true);
            }

            //Actualizamos el registro seleccionado
            ListViewItem Modificado = LvProductos.SelectedItems[0];
            Modificado.SubItems[1].Text = Nombre;
            Modificado.SubItems[2].Text = Descripcion;
            Modificado.SubItems[3].Text = Marca;
            Modificado.SubItems[4].Text = Precio.ToString();
            Modificado.SubItems[5].Text = Cantidad.ToString();

            //Limpiamos los controles de Actualización de Datos (Cajas de Texto ) y deseleccionamos ListView
            Txt_Nombre.Clear();
            Txt_Descripcion.Clear();
            Txt_Marca.Clear();
            Txt_Precio.Clear();
            Txt_Cantidad.Clear();
            LvProductos.SelectedItems.Clear();

            //Mensaje de Actualización de datos exitosa
            MessageBox.Show("Datos del Producto actualizados correctamente.", "ACTUALIZACION DE DATOS DE PRODUCTO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //FUNCION PARA BORRAR UN PRODUCTO
        public static void BorrarProducto(ListView LvProductos, Label LblCantidadRegistros)
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error. Seleccione un producto a Elimianr", "ERROR. NO SE SELECCIONÓ PRODUCTO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmamos que el usuario desea eliminar el registro seleccioando
            DialogResult ConfirmarEliminar;
            ConfirmarEliminar = MessageBox.Show("¿Esta seguro que desea eliminar al producto seleccionado?",
                "CONFIRMACIÓN DE ELIMINADO DE PRODUCTO DE LA BASE DE DATOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarEliminar == DialogResult.No) return;

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Consulta SQL para eliminar un producto
                string query = "DELETE FROM Productos WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a un parametro de consulta el Id del Registro seleccionado
                    comando.Parameters.AddWithValue("@Id", IdSeleccionado);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta de acción
                }

                //Obtenemos la ruta a la Imagen referente al producto
                string RutaImagenEnCarpetaJpg = "..\\..\\..\\Imagenes\\" + IdSeleccionado.ToString() + ".jpg";

                //Borramos la imagen de la carpeta
                if (File.Exists(RutaImagenEnCarpetaJpg)) File.Delete(RutaImagenEnCarpetaJpg);

                //Quitamos del ListView el eliminado
                ListViewItem Seleccionado = LvProductos.SelectedItems[0];
                LvProductos.Items.Remove(Seleccionado);

                //Actualizamos la etiqueta de Cantidad de Registros
                if (ContarProductos > 0) LblCantidadRegistros.Text = "Productos Encontrados: " + (ContarProductos - 1).ToString();

                //Mensaje de Eliminación de usuario exitosa
                MessageBox.Show("Producto eliminado correctamente.", "ELIMINACION DE PRODUCTO DE LA BASE DE DATOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //FUNCIONES PARA CONTROLAR LA ENTRADA DE LO QUE SE QUIERE BUSCAR
        public static void SeleccionoId(RadioButton RdId, TextBox TxtBuscar, Label LblCampoBuscar, Label LblErrorBuscar)
        {
            //Si se selecciona RdId cambiar texto de las etiquetas
            if (RdId.Checked)
            {
                //Reemplazar todos los que no sean letras (^ niega el patrón)
                TxtBuscar.Text = Regex.Replace(TxtBuscar.Text, @"[^0-9]", "");
                LblCampoBuscar.Text = "Id";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "Solo admite numeros";
            }
        }
        public static void SeleccionoNombre(RadioButton RdNombre, Label LblCampoBuscar, Label LblErrorBuscar)
        {
            //Si se selecciona RdNombre cambiar texto de las etiquetas
            if (RdNombre.Checked)
            {
                LblCampoBuscar.Text = "Nombre";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "";
            }
        }
        public static void ValidarEntradaTxtBuscar(KeyPressEventArgs e, RadioButton rdId, Label lblError)
        {
            if (rdId.Checked) // Si está seleccionado el RadioButton de Id hay restricciones
            {
                // Validar que solo se ingresen números o backspace
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    lblError.Visible = true;
                    e.Handled = true; // Cancelar la entrada
                }
                else // Si no hay errores, ocultar la etiqueta de error
                {
                    lblError.Visible = false;
                }
            }
        }



        //FUNCIONES PARA VALIDAR LA ENTRADA DE LOS CAMPOS CANTIDAD Y PRECIO 
        public static void ValidarEntradaTxtPrecio(KeyPressEventArgs e, TextBox Txt_Precio, Label LblErrorPrecio)
        {
            //Validar que solo es ingresen numeros, backspace o punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46)
            {
                LblErrorPrecio.Text = "Solo se permiten números y un punto decimal";
                LblErrorPrecio.Visible = true;
                e.Handled = true;
            }

            //Validar para que únicmente se ingrese un punto decimal
            else if (Txt_Precio.Text.IndexOf('.') >= 0 && e.KeyChar == 46)
            //Si en la caja ya hay un "." y la tecla preionada es "."
            {
                LblErrorPrecio.Text = "Solo se permite un punto decimal";
                LblErrorPrecio.Visible = true;
                e.Handled = true; //No se permite ingresar el "."
            }

            else //Si no hay errores, ocultar la etiqueta de error
            {
                LblErrorPrecio.Visible = false;
            }
        }

        public static void ValidarEntradaTxtCantidad(KeyPressEventArgs e, Label LblErrorCantidad)
        {
            //Validar que solo es ingresen numeros o backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                LblErrorCantidad.Visible = true;
                e.Handled = true;
            }

            else //Si no hay errores, ocultar la etiqueta de error
            {
                LblErrorCantidad.Visible = false;
            }
        }



        //FUNCION PARA CARGAR UNA IMAGEN A UN PICTUREBOX Y PARA ELIMINAR UNA IMAGEN DEL PICTUREBOX
        public static void CargarImagen(PictureBox PicImagenProducto)
        {
            //Instancia de OpenFileDialog que permite al usuario seleccionar un archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg;"; //Filtro para los tipos de archivo

            //Abrimos openFileDialog, si el usuario selecciona Abrir el archivo se selecciono correctamente
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicImagenProducto.Image = null; //Limpiamos la Imagen en el PictureBox

                SeModificoImagen = true; //Indicamos que la imagen se modifico

                PicImagenProducto.ImageLocation = openFileDialog.FileName; //La imagen seleccionada se muestra en el picture box

                RutaImagenTemporal = openFileDialog.FileName; // Almacena la ruta seleccionada para despues modificarla
            }
        }

        public static void DeseleccionarImagen(PictureBox PicImagenProducto)
        {
            PicImagenProducto.Image = null; //Limpiamos el PictureBox
            RutaImagenTemporal = null; //La ruta temporal será nula
        }

    }
}
