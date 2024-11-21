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
using Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes;
using System.Data.SqlClient;

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
        public static string PasswordBD = null;
        public static bool TienePermiso = false;
        public static int ErroresInicioSesion = 0;

        //Declaramos e Inicializamos variables que se utilizan en la Aplicacion
        public static int IdGenerado = 0;
        public static bool SeModificoImagen = false;
        public static string RutaImagenTemporal = null;
        public static int IdSeleccionado = 0;
        public static int ContarProductos = 0;

        //Declaramos e Inicializamos variables que se utilizan en Ventas y Corte de Caja
        public static int CantidadEnStockSeleccionado = 0;
        public static int CantidadIngresada = 0;
        public static int CantidadEnCarrito = 0;
        public static float PorPagar = 0;
        public static float ProductoPaga = 0;
        public static bool HayVentas = false;
        public static int ContarVentas = 0;
        public static float DineroVentas = 0;

        public static int ColumnaOrdenar = -1; //Variable para OrdenarColumnas



        //FUNCION PARA ORDENAR LAS COLUMANS DE UN LISTVIEW, RECIBE UN LISTVIEW COMO PARAMETRO
        public static void OrdenamientoColumnas(ColumnClickEventArgs e, ListView LvTabla)
        {
            if (e.Column != ColumnaOrdenar)
            { //Si la columna elegida no esta ordenada
                ColumnaOrdenar = e.Column;
                LvTabla.Sorting = System.Windows.Forms.SortOrder.Ascending; //La ordenamos ascendente
            }

            else
            { //Si ya esta ordenada, cambiamos su ordenacion...
                if (LvTabla.Sorting == System.Windows.Forms.SortOrder.Ascending)
                {
                    LvTabla.Sorting = System.Windows.Forms.SortOrder.Descending;
                }

                else
                {
                    LvTabla.Sorting = System.Windows.Forms.SortOrder.Ascending;
                }
            }

            LvTabla.Sort();
            LvTabla.ListViewItemSorter =
                new ListViewItemComparer(e.Column, LvTabla.Sorting);
        }



        //FUNCION PARA LIMPIAR LOS CONTROLES DE UN CONTENEDOR
        public static void LimpiarControles(Control ControlUsuario)
        {
            foreach (Control control in ControlUsuario.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (textBox.Tag != null) textBox.Text = textBox.Tag.ToString(); //Si tiene tag 
                    
                    else textBox.Text = string.Empty;
                }
                else if (control is RadioButton radioButton)
                {
                    //El radioButton de Aproximada y Nombre se seleccionan por Default
                    if (radioButton.Name.Contains("Aproximada") || radioButton.Name.Contains("Nombre")) radioButton.Checked = true;

                    else radioButton.Checked = false;
                }
                else if (control is PictureBox pictureBox && pictureBox.Name.Contains("PicImagenProducto"))
                {
                    pictureBox.Image = null;
                }
                else if (control is Label Etiqueta && Etiqueta.Name.Contains("Error"))
                {
                    Etiqueta.Visible = false; // Ocultamos los labels que son de mensaje de Error
                }
                else if (control is Label Etiqueta2 && Etiqueta2.Name.Contains("CantidadRegistros"))
                {
                    Etiqueta2.Text = Etiqueta2.Tag.ToString(); //Si la etiqueta indica cantidad de Registros vuelve a su texto original
                }
                else if (control is ListView listView)
                {
                    listView.Items.Clear(); //Limpiamos el ListView
                }
                // Si el control es otro contenedor de controles, llamamos a la funcion de nuevo
                else if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }



        //FUNCION PARA REINICIAR VARIABLES (MENOS ContarProductos)
        public static void ReiniciarVariables()
        {
            //Reinciamos el valor de las Variables usadas
            IdGenerado = 0;
            SeModificoImagen = false;
            RutaImagenTemporal = null;
            IdSeleccionado = 0;
            CantidadEnStockSeleccionado = 0;
            CantidadIngresada = 0;
            CantidadEnCarrito = 0;
            PorPagar = 0;
            ProductoPaga = 0;
            ContarVentas = 0;
            DineroVentas = 0;
        }
 


        //FUNCION PARA INICIAR SESION AL SISTEMA
        public static void IniciarSesion(string Username, string Password, TextBox TxtUsuario, TextBox TxtPassword)
        {
            // Usamos 'using' para gestionar la conexión y asegurar que se liberen los recursos automáticamente
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos la conexión

                string consulta = "SELECT Nombre_Completo, Usuario, [Password], Tipo FROM Usuarios_Operativos WHERE Usuario = @usuario"; //Consulta

                // Usamos 'using' también para el comando, asegurando que se libere correctamente después de su uso
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", Username); //Parametro de busqueda Username

                    // Usamos 'using' para el lector de datos
                    using (OleDbDataReader lector = comando.ExecuteReader()) //Ejecutar lectura
                    {
                        if (lector.HasRows) //Si hay un resultado, es decir, si existe la cuenta
                        {
                            lector.Read(); //Leemos el registro obtenido

                            NombreCompleto = lector["Nombre_Completo"].ToString(); //Nombre a cadena String
                            Usuario = lector["Usuario"].ToString(); //Usuario a cadena String
                            PasswordBD = lector["Password"].ToString(); //Contraseña en base de datos
                            TipoUsuario = lector["Tipo"].ToString(); //Tipo de Permiso a cadena String

                            if (Username == Usuario && Password == PasswordBD) //Si coinciden Inicio Sesión
                            {
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
                                /*aplicacion.StartPosition = FormStartPosition.Manual;
                                aplicacion.Location = new Point(
                                    (Screen.PrimaryScreen.WorkingArea.Width - aplicacion.Width) / 2,
                                    (Screen.PrimaryScreen.WorkingArea.Height - aplicacion.Height) / 2);*/
                                aplicacion.ShowDialog();

                                ReiniciarVariables(); //Reinciamos las variables a usar.
                            }
                                
                            else //Mensaje de error
                            {
                                MessageBox.Show("Usuario y/o Contraseña incorrectos.", "Error. No existe la cuenta.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                ErroresInicioSesion++; //Sumamos un "Strike"

                                if (ErroresInicioSesion == 3)
                                {
                                    System.Windows.Forms.Application.Exit(); // Si se llegan a 3 errores se cierra la aplicacion
                                }
                            }
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


        //FUNCION PARA VALIDAR LA ENTRADA CANTIDAD DEL SUBAPARTADO AGREAGR INVENTARIO
        public static void ValidarCantidadParaAgregar(TextBox Txt_Cantidad, Button BtnMenos, Button BtnMas, ListView LvProductos)
        {
            //Verificamos si la caja esta vacia. Si lo esta, solo deshabilitamos el boton de menos y cantidad ingresada es 0
            if (string.IsNullOrEmpty(Txt_Cantidad.Text))
            {
                CantidadIngresada = 0;
                BtnMenos.Enabled = false;
                BtnMas.Enabled = true;
                return;
            }

            //Si no se ha seleccionado producto mensaje de error
            if (LvProductos.SelectedItems.Count == 0)
            {
                Txt_Cantidad.Clear(); //Limpiamos la caja
                MessageBox.Show("Seleccione un registro antes de ingresar la cantidad de ejemplares a agregar al Inventario.",
                    "ERROR. NO SE SELECCIONÓ PRODUCTO PARA AÑADIR EJEMPLARES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(Txt_Cantidad.Text, out CantidadIngresada)) //Si lo contenido en la Caja es un entero, validamos
            {
                BtnMenos.Enabled = CantidadIngresada > 0; //Si es mayor a 0 se habilita, de lo contrario se deshabilita.
            }
        }


        //FUNCION PARA AGREGAR PRODUCTOS AL INVENTARIO
        public static void AgregarInventario(ListView LvProductos, TextBox TxtProducto, TextBox Txt_Cantidad)
        {
            //Si no se selecciono producto mensaje de error
            if (LvProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para agregar al Inventario.",
                    "ERROR. NO SE SELECCIONO PRODUCTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si se quieren agregar 0 productos mensaje de error
            if (CantidadIngresada == 0)
            {
                MessageBox.Show("No se pueden agregar 0 ejemplares al inventario.",
                    "ERROR. VALOR DE CANTIDAD NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmamos que el usuario desea realizar agregar los ejemplares ingresados
            DialogResult ConfirmarVenta;
            ConfirmarVenta = MessageBox.Show("¿Esta seguro que desea agregar la cantidad de ejemplares del producto al Inventario?",
                "CONFIRMACIÓN DE AGREGADO A INVENTARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarVenta == DialogResult.No) return;

            CantidadEnStockSeleccionado += CantidadIngresada; //Actualizamos la cantidad en Stock

            ListViewItem ProductoSeleccioando = LvProductos.SelectedItems[0]; //Obtenemos el producto seleccionado;

            ProductoSeleccioando.SubItems[5].Text = CantidadEnStockSeleccionado.ToString(); //Actualizamos ListView

            //Actualizamos BDDS Producto
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Consulta SQL para actualizar los campos de un registro
                string query = "UPDATE Productos SET Cantidad_en_Stock = @NuevaCantidad WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a los parámetros de la consulta
                    comando.Parameters.AddWithValue("@Cantidad", CantidadEnStockSeleccionado);
                    comando.Parameters.AddWithValue("@Id", IdSeleccionado);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            LvProductos.SelectedItems.Clear(); //Quitamos el seleccionado
            TxtProducto.Clear(); //Limpiamos las cajas de texto
            Txt_Cantidad.Clear();
            ReiniciarVariables(); //Reiniciamos las Variables

            //Mensaje de Agregado de Productos a Inventario exitoso
            MessageBox.Show("Se han agregado los ejemplares al Inventario.", "AGREGADO DE INVENTARIO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //FUNCION PARA AGREGAR UN PRODUCTO A LA BASE DE DATOS
        public static void RegistrarProducto(string Nombre, string Descripcion, string Marca, TextBox Txt_Nombre, TextBox Txt_Descripcion, 
            TextBox Txt_Marca, TextBox Txt_Precio, TextBox Txt_Cantidad, PictureBox PicImagenProducto)
        {
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

            if(Precio == 0 || Cantidad == 0) //Validamos que precio y cantidad no sean iguales a 0
            {
                MessageBox.Show("Error. No se puede ingresar 0 como valor de Precio o Cantidad en Existencia", "ERROR. 0 NO ES VALIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
        public static void EncontrarProductos(string buscar, TextBox TxtBuscar, RadioButton RdAproximada, 
            RadioButton RdNombre, ListView LvProductos, Label LblCantidadRegistros, Label LblErrorBuscar)
        {
            LblErrorBuscar.Visible = false; //Ocultamos la etiqueta del Error al Buscar

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
                    if (RdNombre.Checked) query = "SELECT * FROM Productos WHERE Nombre = @PorBuscar";
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

            ListViewItem ProductoSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos el producto seleccionado

            //MessageBox con los datos del Producto
            MessageBox.Show("Datos del Producto Seleccionado:" +
                " \n\n\nId: " + ProductoSeleccionado.SubItems[0].Text +
                " \n\nNombre: " + ProductoSeleccionado.SubItems[1].Text +
                " \n\nDescripcion: " + ProductoSeleccionado.SubItems[2].Text +
                " \n\nMarca: " + ProductoSeleccionado.SubItems[3].Text +
                " \n\nPrecio: $ " + ProductoSeleccionado.SubItems[4].Text +
                " \n\nCantidad en Stock: " + ProductoSeleccionado.SubItems[5].Text,
                "INFORMACIÓN DEL PRODUCTO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string RutaImagen = ProductoSeleccionado.SubItems[6].Text; //Obtenemos la ruta 

            string RutaImagenAbrir = "..\\..\\" + RutaImagen; //Creamos la nueva ruta (saliendo varias carpetas mas)

            PicImagenProducto.Image = Image.FromFile(RutaImagenAbrir); //Cargamos la Imagen
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

            //Confirmamos que el usuario desea modificar el registro seleccioando
            DialogResult ConfirmarModificar;
            ConfirmarModificar = MessageBox.Show("¿Esta seguro que desea modificar la información del producto seleccionado?",
                "CONFIRMACIÓN DE ACTUALIZACIÓN DE PRODUCTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarModificar == DialogResult.No) return;

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


        //FUNCION PARA OCULTAR TODAS LAS ETIQUETAS DE ERROR DE UN FORMULARIO
        public static void OcultarEtiquetasDeError(Control control)
        {
            // foreach para recorrer todos los controles del formulario
            foreach (Control ControlenFormularrio in control.Controls)
            {
                // Si es un Label y si contiene "error" en su nombre
                if (ControlenFormularrio is Label Etiqueta && Etiqueta.Name.Contains("Error"))
                {
                    Etiqueta.Visible = false; // Ocultar la etiqueta
                }

                // Si el control es un contenedor volvemos a llamar a la función
                if (ControlenFormularrio.HasChildren)
                {
                    OcultarEtiquetasDeError(ControlenFormularrio);
                }
            }
        }


        //FUNCIONES PARA CONTROLAR LA ENTRADA DE LO QUE SE QUIERE BUSCAR
        public static void SeleccionoId(RadioButton RdId, TextBox TxtBuscar, Label LblCampoBuscar, Label LblErrorBuscar)
        {
            //Si se selecciona RdId cambiar texto de las etiquetas
            if (RdId.Checked)
            {
                //Reemplazar todos los que no sean numeros (^ niega el patrón)
                TxtBuscar.Text = Regex.Replace(TxtBuscar.Text, @"[^0-9]", "");
                LblCampoBuscar.Text = "Id";
                LblErrorBuscar.Visible = false;
            }
        }
        public static void SeleccionoNombre(RadioButton RdNombre, Label LblCampoBuscar, Label LblErrorBuscar)
        {
            //Si se selecciona RdNombre cambiar texto de las etiquetas y ocultar error
            if (RdNombre.Checked)
            {
                LblCampoBuscar.Text = "Nombre";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "";
            }
        }


        //NO FUNCIONA LA ETIQUETA DE ERROR EN LOS CAMPOS DE BUSCAR POR ALGUNA RAZON :(
        public static void ValidarEntradaTxtBuscar(KeyPressEventArgs e, RadioButton RdId, RadioButton RdNombre, Label LblErrorBuscar)
        {
            LblErrorBuscar.Visible = false; //Ocultamos siempre que se ingresa un caracter

            if (RdId.Checked) // Si está seleccionado el RadioButton de Id hay restricciones
            {
                // Validar que solo se ingresen números o backspace
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {                  
                    LblErrorBuscar.Visible = true;
                    e.Handled = true; // Cancelar la entrada
                }
            }

            else //Si está seleccionado el RadioButton de Nombre también hay restricciones 
            {
                // Validar que solo se ingresen letras, números, backspace, space, comillas dobles, guiones o barras diagonales
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 34 && e.KeyChar != 45 && e.KeyChar != 47)
                {
                    LblErrorBuscar.Visible = true;
                    e.Handled = true; // Cancelar la entrada
                }
            }
        }


        //FUNCIONES PARA VALIDAR LA ENTRADA DE  CAMPOS NOMBRE, DESCRIPCION Y MARCA
        public static void ValidarEntradaTxtNombreDescripcionMarca(KeyPressEventArgs e, Label LblError, TextBox TxtCampo)
        {
            //Si la caja de texto es la de Marca no se pueden ingresar comillas dobles, guiones ni barras diagonales
            if (TxtCampo.Name.Contains("Marca") && (e.KeyChar == 34 || e.KeyChar == 45 || e.KeyChar == 47))
            {
                LblError.Visible = true;
                e.Handled = true; // Cancelar la entrada
                return;
            }

            // Validar que solo se ingresen letras, números, backspace, space, comillas dobles, guiones o barras diagonales
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 34 && e.KeyChar != 45 && e.KeyChar != 47)
            {
                LblError.Visible = true;
                e.Handled = true; // Cancelar la entrada
            }

            else //Si no hay errores, ocultar la etiqueta de error
            {
                LblError.Visible = false;
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
            //Validar que solo se ingresen numeros o backspace
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




        //FUNCIONES RELACIONADAS AL APARTADO DE VENTAS


        //FUNCION PARA AGREGAR UN PRODUCTO AL CARRITO
        public static void AgregarAlCarrito(ListView LvProductos, ListView LvCarrito, TextBox Txt_Cantidad, TextBox TxtPorPagar, Label LblCantidadRegistrosCarrito)
        {
            //Si no se ha seleccionado producto mensaje de error
            if (LvProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para agregar al carrito.",
                    "ERROR. NO SE SELECCIONO PRODUCTO PARA EL CARRITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si la cantidad ingresada es 0 mensaje de error
            if (CantidadIngresada == 0)
            {
                MessageBox.Show("No se pueden agregar 0 productos al carrito.",
                    "ERROR. CANTIDAD INVALIDA DE PRODUCTOS PARA AGREGAR AL CARRITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

            //Obtenemos la información que se cargara al Carrito
            string ProductoId = ItemSeleccionado.SubItems[0].Text;
            string ProductoNombre = ItemSeleccionado.SubItems[1].Text;
            string ProductoPrecio = ItemSeleccionado.SubItems[4].Text;
            string ProductoCantidad = CantidadIngresada.ToString();


            //Validamos que el producto no se encuentre en el carrito
            foreach (ListViewItem ProductoEnCarrito in LvCarrito.Items)
            {
                //Comparamos el Id del que se quiere agregar con los de los productos del carrito
                if (ProductoEnCarrito.SubItems[0].Text == ProductoId)
                {
                    //Limpiamos la caja cantidad y desceleccionamos el producto
                    Txt_Cantidad.Clear();
                    LvProductos.SelectedItems.Clear();

                    //Si ya se encuentra en Carrito mensaje de advertencia
                    MessageBox.Show("El producto que selecciono ya está en el carrito." +
                        "\nSi desea modificar este producto, elimínelo del carrito y vuélvalo a agregar.",
                        "ADVERTENCIA. PRODUCTO YA SE ENCUENTRA EN CARRITO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ProductoPaga = CantidadIngresada * float.Parse(ProductoPrecio); //Obtenemos lo que se pagara por ese producto.

            PorPagar += ProductoPaga; //Lo agregamos al total de la venta

            TxtPorPagar.Text = PorPagar.ToString("C"); //Actualizamos la caja de texto

            //Creamos el nuevo registro del ListView carrito y definimos los valores de sus campos
            ListViewItem ProductoCarrito = new ListViewItem(ProductoId);
            ProductoCarrito.SubItems.Add(ProductoNombre);
            ProductoCarrito.SubItems.Add(ProductoPrecio);
            ProductoCarrito.SubItems.Add(ProductoCantidad);
            ProductoCarrito.SubItems.Add(ProductoPaga.ToString());

            LvCarrito.Items.Add(ProductoCarrito); //Cargamos el producto
            CantidadEnCarrito++; //Agregamos uno a la cantidad de productos en carrito

            LblCantidadRegistrosCarrito.Text = "Productos en Carrito: " + CantidadEnCarrito.ToString(); //Actualizamos etiqueta 

            LvProductos.SelectedItems.Clear(); //Desceleccionamos el Producto
        }


        //FUNCION PARA VACIAR EL CARRITO
        public static void VaciarElCarrito(ListView LvCarrito, TextBox TxtPorPagar, Label LblCantidadRegistrosCarrito)
        {
            //Si el Carrito esta vacío mensaje de error
            if (LvCarrito.Items.Count == 0)
            {
                MessageBox.Show("Agregue productos al carrito.",
                    "ERROR. CARRITO ESTA VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmamos que el usuario desea vaciar el carrito
            DialogResult ConfirmarVaciarCarrito;
            ConfirmarVaciarCarrito = MessageBox.Show("¿Esta seguro que desea vaciar el carrito de productos?",
                "CONFIRMACIÓN DE VACIADO DE CARRITO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarVaciarCarrito == DialogResult.No) return;

            LvCarrito.Items.Clear(); //Limpiamos ListView de Carrito
            TxtPorPagar.Clear(); //Limpiamos caja de texto PorPagar
            LblCantidadRegistrosCarrito.Text = LblCantidadRegistrosCarrito.Tag.ToString(); //Etiqueta cantidad a su original
            CantidadEnCarrito = 0;
        }


        //FUNCION PARA BORRAR UN PRODUCTO DEL CARRITO
        public static void EliminarProductoCarrito(ListView LvCarrito, TextBox TxtPorPagar, Label LblCantidadRegistrosCarrito)
        {
            //Si el Carrito esta vacío mensaje de error
            if (LvCarrito.Items.Count == 0)
            {
                MessageBox.Show("Agregue productos al carrito.",
                    "ERROR. CARRITO ESTA VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Si no se ha seleccionado producto del carrito mensaje de error
            if (LvCarrito.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar del carrito.",
                    "ERROR. NO SE SELECCIONO PRODUCTO PARA BORRAR DEL CARRITO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem ItemSeleccionado = LvCarrito.SelectedItems[0]; //Obtenemos el producto seleccionado del carrito

            ProductoPaga = float.Parse(ItemSeleccionado.SubItems[4].Text); //Obtenemos lo que se paga por los ejemplares de ese producto

            PorPagar -= ProductoPaga; //Lo restamos del total de la venta

            TxtPorPagar.Text = PorPagar.ToString("C"); //Actualizamos la caja de texto

            LvCarrito.Items.Remove(ItemSeleccionado); //Eliminamos el producto del Carrito

            CantidadEnCarrito--; //Quitamos uno a la cantidad de productos en carrito y actualizamos la etiqueta
            LblCantidadRegistrosCarrito.Text = "Productos en Carrito: " + CantidadEnCarrito.ToString();
        }


        //FUNCION PARA HACER LA VENTA DE LOS PRODUCTOS DEL CARRITO
        public static bool VenderProductos(ListView LvCarrito, TextBox TxtPorPagar, Label LblCantidadRegistrosCarrito)
        {
            //Si el Carrito esta vacío mensaje de error
            if (LvCarrito.Items.Count == 0)
            {
                MessageBox.Show("Agregue productos al carrito para poder hacer venta.",
                    "ERROR. CARRITO ESTA VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Confirmamos que el usuario desea realizar la venta de los productos seleccionados
            DialogResult ConfirmarVenta;
            ConfirmarVenta = MessageBox.Show("¿Esta seguro que desea realizar la venta de los productos en el carrito?",
                "CONFIRMACIÓN DE VENTA DE PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarVenta == DialogResult.No) return false;

            //Establecemos el obejto OledbConnection para conectar con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Primer Comando SQL para insertar la venta de un producto a la BDDS de ventas
                string query = "INSERT INTO Ventas (Nombre_Completo, Usuario, Tipo, Id_Producto, Nombre_Producto, Precio_Producto, Cantidad_Producto, Total) " +
                   "VALUES (@NombreCompleto, @Usuario, @Tipo, @IdProducto, @NombreProducto, @Precio, @Cantidad, @Total)";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Comando SQL
                {
                    //Para cada registro del Carrito
                    foreach (ListViewItem ProductoEnCarrito in LvCarrito.Items)
                    {
                        // Limpiar los parámetros para cada registro
                        comando.Parameters.Clear();

                        // Parametros de consulta, los valores que se van a insertar a la base de datos
                        comando.Parameters.AddWithValue("@NombreCompleto", NombreCompleto);
                        comando.Parameters.AddWithValue("@Usuario", Usuario);
                        comando.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
                        comando.Parameters.AddWithValue("@IdProducto", int.Parse(ProductoEnCarrito.SubItems[0].Text));
                        comando.Parameters.AddWithValue("@NombreProducto", ProductoEnCarrito.SubItems[1].Text);
                        comando.Parameters.AddWithValue("@Precio", float.Parse(ProductoEnCarrito.SubItems[2].Text));
                        comando.Parameters.AddWithValue("@Cantidad", int.Parse(ProductoEnCarrito.SubItems[3].Text));
                        comando.Parameters.AddWithValue("@Total", float.Parse(ProductoEnCarrito.SubItems[4].Text));

                        comando.ExecuteNonQuery(); //Ejectuamos comando de inserción
                    }
                }

                //Segundo Comando SQL para actualizar la cantidad de productos en Stock en la tabla Productos
                string ActualizarStock = "UPDATE Productos SET Cantidad_en_Stock = Cantidad_en_Stock - @Cantidad WHERE Id = @IdProducto";

                using (OleDbCommand comando = new OleDbCommand(ActualizarStock, conexion)) //Comando SQL
                {
                    //Para cada registro del Carrito
                    foreach (ListViewItem ProductoEnCarrito in LvCarrito.Items)
                    {
                        // Limpiar los parámetros para cada registro
                        comando.Parameters.Clear();

                        // Parametros de consulta, los valores que se van a insertar a la base de datos
                        comando.Parameters.AddWithValue("@Cantidad", int.Parse(ProductoEnCarrito.SubItems[3].Text));
                        comando.Parameters.AddWithValue("@IdProducto", int.Parse(ProductoEnCarrito.SubItems[0].Text));

                        comando.ExecuteNonQuery(); //Ejectuamos comando de inserción
                    }
                }
            }

            LblCantidadRegistrosCarrito.Text = "Productos en Carrito: "; //AActualizamos la etiqueta de Cantidad de Registros de Carrito

            LvCarrito.Items.Clear(); //Limpiamos el Carrito
            TxtPorPagar.Clear(); //Limpiamos la caja con el total de la venta

            //Mensaje de Venta Exitosa
            MessageBox.Show("La venta ha sido completada.", "VENTA EXITOSA DE PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HayVentas = true; //Cabiamos el booleano a True, indicando que ya se realizó una Venta
            return true; //Devolvemos True si la venta fue un exito
        }

        //FUNCION PARA LIMPIAR EL SUBAPARTADO DE BUSQUEDA DE VENTAS
        public static void RestaurarBusquedaVentas(ListView LvProductos, TextBox TxtBuscar, TextBox Txt_Cantidad, 
            Label LblErrorBuscar, Label LblErrorCantidad, Label LblProducto, RadioButton RdAproximada, 
            RadioButton RdExacta, RadioButton RdNombre, RadioButton RdId, Label LblCantidadRegistrosBuscar)
        {
            //Limpiamos los controles relacionados a buscar y agregar un producto al carrito
            LvProductos.Items.Clear();
            TxtBuscar.Clear();
            Txt_Cantidad.Clear();
            LblErrorBuscar.Visible = false;
            LblErrorCantidad.Visible = false;
            LblProducto.Visible = false;
            RdAproximada.Checked = true;
            RdExacta.Checked = false;
            RdNombre.Checked = true;
            RdId.Checked = false;
            LblCantidadRegistrosBuscar.Text = LblCantidadRegistrosBuscar.Tag.ToString();
        }


        //FUNCION PARA VALIDAR LA ENTRADA DE CANTIDAD, QUE LA CANTIDAD INGRESADA NO PASE DE STOCK
        public static void ValidarCantidadConStock(TextBox Txt_Cantidad, Button BtnMenos, Button BtnMas, ListView LvProductos)
        {
            //Verificamos si la caja esta vacia. Si lo esta, solo deshabilitamos el boton de menos y cantidad ingresada es 0
            if (string.IsNullOrEmpty(Txt_Cantidad.Text))
            {
                CantidadIngresada = 0;
                BtnMenos.Enabled = false;
                BtnMas.Enabled = true;
                return;
            }

            //Si no se ha seleccionado producto mensaje de error
            if (LvProductos.SelectedItems.Count == 0)
            {
                Txt_Cantidad.Clear(); //Limpiamos la caja
                MessageBox.Show("Seleccione un registro antes de ingresar la cantidad de productos a vender.",
                    "ERROR. NO SE HA SELECCIONADO PRODUCTO PARA VENDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(Txt_Cantidad.Text, out CantidadIngresada)) //Si lo contenido en la Caja es un entero, validamos
            {
                BtnMenos.Enabled = CantidadIngresada > 0; //Si es mayor a 0 se habilita, de lo contrario se deshabilita.
                BtnMas.Enabled = CantidadIngresada < CantidadEnStockSeleccionado; //Solo se habilita si cantidad es menor a la de Stock se habilita.

                if (CantidadIngresada > CantidadEnStockSeleccionado) //Si sobrepasa la cantidad en Stock mensaje de Error
                {
                    MessageBox.Show("La Cantidad a Vender no debe ser mayor que la cantidad de ejemplares en stock: " +
                        CantidadEnStockSeleccionado + ".", "ERROR. CANTIDAD A VENDER SOBREPASA CANTIDAD EN STOCK",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Txt_Cantidad.Clear(); //Limpiamos la caja de Cantidad
                }
            }
        }



        



        //FUNCIONES UTILIZADAS PARA EL CORTE DE CAJA
        public static void CargarVentas(ListView LvVentas, Label LblCantidadRegistros, TextBox TxtDineroVentas)
        {
            //Si la no se han realizado ventas mensaje de error
            if (HayVentas == false)
            {
                MessageBox.Show("Error. No se han realizado ventas.", "ERROR. NO HAY VENTAS POR MOSTRAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LvVentas.Items.Count > 0) // Si las ventas ya están cargadas indicamos advertencia
            {
                MessageBox.Show("Advertencia. Las ventas ya han sido cargadas.", "ADVERTENCIA. VENTAS YA CARGADAS",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion
                ListViewItem Venta;

                string ComandoVentas = "SELECT Nombre_Completo, Usuario, Id_Producto, Nombre_Producto, Precio_Producto, Cantidad_Producto, Total" +
                    " FROM Ventas WHERE SeGuardo = False"; //Consulta para seleccionar las ventas hechas por el Usuario

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(ComandoVentas, conexion)) //pasamos consulta y conexion
                {
                    OleDbDataReader LeerVentas = comando.ExecuteReader(); //Objeto de lectura

                    ContarVentas = 0; //Variable para contar los registros
                    DineroVentas = 0; //Vairable para contar el dinero generado

                    if (LeerVentas.HasRows) //Si se obtuvieron registros de la busqueda
                    {
                        LvVentas.Items.Clear(); //Limpiamos el contenido del ListView

                        while (LeerVentas.Read()) //Para cada registro obtenido
                        {
                            //Aumentamos el contador de registros
                            ContarVentas++;

                            //Ingresamos a las columnas del ListView los valores de la base de datos 
                            Venta = new ListViewItem(LeerVentas["Nombre_Completo"].ToString());
                            Venta.SubItems.Add(LeerVentas["Usuario"].ToString());
                            Venta.SubItems.Add(LeerVentas["Id_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Nombre_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Precio_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Cantidad_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Total"].ToString());

                            //Cargamos el registro al ListView
                            LvVentas.Items.Add(Venta);

                            DineroVentas += float.Parse(LeerVentas["Total"].ToString()); //Sumamos el dinero generado de cada Venta

                            //Actualizamos la etiqueta que cuenta los registros
                            LblCantidadRegistros.Text = "Ventas Realizadas: " + ContarVentas.ToString();
                        }
                    }
                }

                TxtDineroVentas.Text = DineroVentas.ToString("C"); //Actualizamos la caja de texto de Dinero Ventas
            }
        }


        //FUNCION PARA MOSTRAR LOS DETALLES DE UNA VENTA SELECCIOANADA
        public static void MostrarVentaSeleccionada(ListView LvVentas)
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvVentas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para mostrar sus detalles",
                    "ERROR. NO HAY VENTA SELECCIONADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem VentaSeleccionada = LvVentas.SelectedItems[0]; //Obtenemos el registro Seleccionado

            //Mostramos en un Message Box la información obtenida de la venta seleccionada
            MessageBox.Show("Datos de la Venta Seleccioada Seleccionada:" +
                "\n\n\nNombre Completo: " + VentaSeleccionada.SubItems[0].Text +
                "\n\nUsuario: " + VentaSeleccionada.SubItems[1].Text +
                " \n\nId de Producto: " + VentaSeleccionada.SubItems[2].Text +
                " \n\nNombre de Producto: " + VentaSeleccionada.SubItems[3].Text +
                " \n\nPrecio: $ " + VentaSeleccionada.SubItems[4].Text +
                " \n\nCantidad Vendida: " + VentaSeleccionada.SubItems[5].Text +
                " \n\nTotal: $ " + VentaSeleccionada.SubItems[6].Text,
                "INFORMACIÓN DE LA VENTA SELECCIONADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //FUNCION PARA REGISTRAR LAS VENTAS Y CERRAR SESION
        public static void GuardarVentasCerrarSesion(ListView LvVentas)
        {
            //Si no se han realizado ventas mensaje de error
            if (HayVentas == false)
            {
                MessageBox.Show("Error. No se han realizado ventas.", "ERROR. NO HAY VENTAS POR REGISTRAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LvVentas.Items.Count == 0) // Si las ventas no han sido cargadas mensaje de error
            {
                MessageBox.Show("Cargue las ventas para poder guardarlas correctamente.", "ERROR. NO SE HAN CARGADO VENTAS",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Confirmamos que el usuario desea realizar la venta de los productos seleccionados
            DialogResult ConfirmarGuardarVentas;
            ConfirmarGuardarVentas = MessageBox.Show("¿Esta seguro que desea guardar las ventas realizadas? Se cerrará sesión automáticamente.",
                "CONFIRMACIÓN DE GUARDADO DE VENTAS Y CIERRE DE SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarGuardarVentas == DialogResult.No) return;

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Actualizamos la BDDS Ventas para Guardar las ventas hechas por el Usuario
                string ComandoVentas = "UPDATE Ventas SET SeGuardo = True WHERE SeGuardo = False";

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(ComandoVentas, conexion)) //pasamos consulta y conexion
                {
                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            // Sumar las ventas del usuario al dinero que tenemos en la caja
            Properties.Settings.Default.DineroEnCaja += DineroVentas;

            Properties.Settings.Default.Save(); // Guardamos los cambios de la variable DineroEnCaja

            //Mostramos un mensaje de éxito en el Guardado de Ventas
            MessageBox.Show("Las ventas han sido guardadas con Éxito. Gracias por usar nuestro sistema. ¡Vuelva Pronto!",
                "VENTAS GUARDADAS CON EXITO. CERRANDO SESIÓN Y APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit(); //Cerramos Aplicacion
        }


        //FUNCION PARA ACTUALIZAR LAS ETIQUETAS DE LOS DATOS DE INICIO DE SESION
        public static void ActualizarDatos(Label LblNombreCompleto, Label LblUsuario, Label LblPermiso)
        {
            //Actualizamos la información del que inicia sesión 
            LblUsuario.Text = Usuario;
            LblNombreCompleto.Text = NombreCompleto;
            LblPermiso.Text = "(" + TipoUsuario + ")";
        }
    }
}
