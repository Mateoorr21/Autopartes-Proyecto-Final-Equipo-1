using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1
{
    public partial class Inicio : Form
    {
        //Declaramos la cadena de conexion global disponible para formulario Inicio
        public string cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Base\Mi_prueva_personal.accdb;Persist Security Info=False;";

        //Declaramos el Nombre, Usuario y Permiso
        string Nombre = null;
        string Usuario = null;
        string Permiso = null;

        //NOTAS A TOMAR EN CUENTA
        /*La cadena de conexion se declaro de manera global para no tener que estarla declarando cada vez que se use
         *Cuando trabajen en un nuevo formulario (Eliminacion, grabado y modificacion) recuerden nombrarlo
         *Se debe indicar cuando se declare el formulario el parametro al llamarlo (una instancia de tipo Inicio)
         *En el nuevo formulario...
         *     - Se declara la instancia Tipo Inicio que recibira el parametro
         *     - Se debe indicar que el formulario recibe un parametro de inicio
         *     - Se le asigna al que inicio delcarado el formulario que se recibe como parametro
         *     
         * PARA ACCEDER A LA CADENA DE CONEXION CON Inicio_Recibido.cadconexion
         */

        //EJEMPLO
        /* Si se tiene un formulario Eliminar
         * En formulario Aplicaion escribir
         *          Eliminar eliminar = new Eliminar(Inicio_Recibido);
         *          
         * En formulario Eliminar escrbir como global
         *          Inicio Inicio_Recibido;
         * 
         * public CatalogoUsuarios(Inicio inicio)
                {
                    InitializeComponent();
                    this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
                }
         */

        //Se pueden ver ejemplos de esto en cualquiera de los formularios.
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion(this); //Pasamos al siguiente formulario una instancia de Inicio
            inicioSesion.ShowDialog();
        }

        //Todas las funciones a utilizar se encuentran en este Formulario
        //Como pasamos una instancia de este Formulario Inicio siempre que abrimos uno nuevo
        //Podemos llamar a cualquier función desde cualquier parte del programa

        //FUNCION PARA LIMPIAR TODOS LOS CONTROLES DE UN CONTROL DE USUARIO 
        public void LimpiarControles(Control ControlUsuario)
        {
            foreach (Control control in ControlUsuario.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
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
                    LimpiarControles(control);
                }
            }
        }

        //FUNCION PARA CARGAR PRODUCTOS EN EL INVENTARIO
        public void CargarProductos(ListView LvProductos, Label lblCantidadRegistros)
        {
            int ContarProductos = 0; // Reseteamos el contador de productos

            LvProductos.Items.Clear(); // Limpiamos el contenido del ListView

            using (OleDbConnection conexion = new OleDbConnection(cadconexion))
            {
                conexion.Open(); // Abrimos conexión

                string query = "SELECT * FROM Productos";
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
                    lblCantidadRegistros.Text = "Cantidad de Productos: " + ContarProductos.ToString();
                }
            }
        }

        //FUNCION PARA AGREGAR UN PRODUCTO A LA BASE DE DATOS
        public void RegistrarProducto(string Nombre, string Descripcion, string Marca, string RutaTemporal, int IdGenerado,
                TextBox Txt_Nombre, TextBox Txt_Descripcion, TextBox Txt_Marca, TextBox Txt_Precio, TextBox Txt_Cantidad, PictureBox PicImagenProducto)
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
            File.Copy(RutaTemporal, RutaDestino, true);

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
        public void EncontrarProductos(string buscar, TextBox TxtBuscar, RadioButton RdAproximada, RadioButton RdNombre, ListView LvProductos, Label LblCantidadRegistros)
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

                    int ContarProductos = 0; //Variable para contar los registros

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
        public void MostrarProducto(int Id, ListView LvProductos, PictureBox PicImagenProducto)
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
                    comando.Parameters.AddWithValue("@IdSeleccionado", Id); //Parametro IdSeleccioando

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

                        string RutaImagenTemporal = LeerProducto["Imagen"].ToString().Trim('#'); //Obtenemos la ruta y quitamos los #

                        string RutaImagenAbrir = "..\\..\\" + RutaImagenTemporal; //Creamos la nueva ruta (saliendo varias carpetas mas)

                        PicImagenProducto.Image = Image.FromFile(RutaImagenAbrir); //Cargamos la Imagen                
                    }
                }
            }
        }


        //FUNCION PARA MODIFICAR LA INFORMACION DE UN PRODUCTO
        public void ActualizarProducto(string Nombre, string Descripcion, string Marca, string RutaImagenTemporal, int Id, bool SeModificoImagen, ListView LvProductos,
            TextBox Txt_Nombre, TextBox Txt_Descripcion, TextBox Txt_Marca, TextBox Txt_Precio, TextBox Txt_Cantidad, PictureBox PicImagenProducto)
        {
            
            //Si no hay registro seleccionado menssaje de Error
            if (LvProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error. Seleccione un producto a modificar", "ERROR. NO SE SELECCIONÓ PRODUCTO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("La ruta es" + RutaImagenTemporal);

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
                    comando.Parameters.AddWithValue("@Id", Id);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            // Liberamos la imagen del PictureBox
            PicImagenProducto.Image = null;

            //Solo si se modifico la imagen, borramos la existente y copiamos la nueva
            if (SeModificoImagen)
            {
                // Obtenemos la ruta de la imagen existente con el mismo ID
                string RutaImagenEnCarpetaJpg = "..\\..\\..\\Imagenes\\" + Id.ToString() + ".jpg";

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
        public void BorrarProducto (int Id, ListView LvProductos, Label LblCantidadRegistros, int ContarProductos)
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
                    comando.Parameters.AddWithValue("@Id", Id);

                    comando.ExecuteNonQuery(); //Ejecutamos consulta de acción
                }

                //Obtenemos la ruta a la Imagen referente al producto
                string RutaImagenEnCarpetaJpg = "..\\..\\..\\Imagenes\\" + Id.ToString() + ".jpg";

                //Borramos la imagen de la carpeta
                if (File.Exists(RutaImagenEnCarpetaJpg)) File.Delete(RutaImagenEnCarpetaJpg);

                //Quitamos del ListView el eliminado
                ListViewItem Seleccionado = LvProductos.SelectedItems[0];
                LvProductos.Items.Remove(Seleccionado);

                //Actualizamos la etiqueta de Cantidad de Registros
                if(ContarProductos > 0) LblCantidadRegistros.Text = "Productos Encontrados: " + (ContarProductos - 1).ToString();

                //Mensaje de Eliminación de usuario exitosa
                MessageBox.Show("Producto eliminado correctamente.", "ELIMINACION DE PRODUCTO DE LA BASE DE DATOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //FUNCIONES PARA CONTROLAR LA ENTRADA DE LO QUE SE QUIERE BUSCAR
        public void SeleccionoId(RadioButton RdId, TextBox TxtBuscar, Label LblCampoBuscar, Label LblErrorBuscar)
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
        public void SeleccionoNombre(RadioButton RdNombre, Label LblCampoBuscar, Label LblErrorBuscar)
        {
            //Si se selecciona RdNombre cambiar texto de las etiquetas
            if (RdNombre.Checked)
            {
                LblCampoBuscar.Text = "Nombre";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "";
            }
        }
        public void ValidarEntradaTxtBuscar(KeyPressEventArgs e, RadioButton rdId, Label lblError)
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
        public void ValidarEntradaTxtPrecio(KeyPressEventArgs e, TextBox Txt_Precio, Label LblErrorPrecio)
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

        public void ValidarEntradaTxtCantidad(KeyPressEventArgs e, Label LblErrorCantidad)
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
        //LA RUTA LA PASAMOS POR REFERENCIA PORQUE QUEREMOS QUE SE MODIFIQUE SU VALOR
        public void CargarImagen (PictureBox PicImagenProducto, ref string RutaImagenTemporal, ref bool SeModificoImagen)
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

        public void DeseleccionarImagen(PictureBox PicImagenProducto, ref string RutaImagenTemporal)
        {
            PicImagenProducto.Image = null; //Limpiamos el PictureBox
            RutaImagenTemporal = null; //La ruta temporal será nula
        }



        //FUNCIONES DE CATALOGO DE USUARIOS

        //FUNCION PARA AGREGAR UN USUARIO
        public void AgregarUsuario(string Nombre, string Username, string Password, string Permiso, TextBox Txt_Nombre, TextBox Txt_Usuario,
            TextBox Txt_Password, Label LblErrorNombre, Label LblErrorUsuario, Label LblErrorPassword)
        {
            //Ocultamos etiquetas
            LblErrorNombre.Visible = false;
            LblErrorUsuario.Visible = false;
            LblErrorPassword.Visible = false;

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

            //Limpiamos las cajas de texto
            Txt_Nombre.Clear();
            Txt_Usuario.Clear();
            Txt_Password.Clear();

            //Mensaje de registro de usuario exitoso
            MessageBox.Show("Registro de " + Permiso + " " + Nombre + " Exitoso",
                "Registro exitoso de Nuevo Usuario Operativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //FUNCIONES PARA ELIMINAR A UN USUARIO

        //FUNCION DE BUSCAR USUARIOS PARA ELIMINARLOS
        public void BuscarUsuarioEliminar(string buscar, string Username, string Permiso, TextBox TxtBuscar, RadioButton RdAproximada, RadioButton RdNombre, ListView LvUsuarios)
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

                TxtBuscar.Clear(); //Limpiamos la caja de texto Buscar
            }
        }

        //FUNCION ELIMINAR A UN USUARIO
        public void BorrarUsuario(int Id, ListView LvUsuarios)
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

                //Quitamos del ListView el ususario eliminado
                ListViewItem Seleccionado = LvUsuarios.SelectedItems[0];
                LvUsuarios.Items.Remove(Seleccionado);

                //Mensaje de Eliminación de usuario exitosa
                MessageBox.Show("Datos del Usuario Operativo eliminados correctamente.", "ELIMINACION DE USUARIO OPERATIVO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        //FUNCIONES PARA MODIFICAR UN USUARIO

        //FUNCION BUSCAR UN USUARIO PARA MODIFICARLO
        public void BuscarUsuarioModificar(string buscar, string Username, string Permiso, TextBox TxtBuscar, RadioButton RdAproximada, RadioButton RdNombre, ListView LvUsuarios)
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

                TxtBuscar.Clear(); //Limpiamos la caja de texto Buscar
            }
        }

        //FUNCION MODIFICAR UN USUARIO

        //FUNCIONES DE VALIDAR CAMPOS DE ENTRADA DE USUARIO
        public void ValidarEntradaTxtNombreCompleto(KeyPressEventArgs e, Label LblErrorNombre)
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

        public void ValidarEntradaTxtUsuarioOPassword(KeyPressEventArgs e, Label LblError)
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


        //FUNCIONES DE CONTROLES DE CAMPOS DE ENTRADA DE BUSQUEDA
        public void SeleccionoNombreCompleto(RadioButton RdNombre, TextBox TxtBuscar, Label LblCampoBuscar, Label LblErrorBuscar) 
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

        public void SeleccionoUsuario(RadioButton RdUsuario, TextBox TxtBuscar, Label LblCampoBuscar, Label LblErrorBuscar)
        {
            //Si se selecciona Usuario cambiar texto de las etiquetas
            if (RdUsuario.Checked)
            {
                LblCampoBuscar.Text = "Usuario";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "Admite letras, numeros \ny caracteres especiales";
            }
        }

        public void ValidarEntradaTxtBuscarUsuarioOperativo(KeyPressEventArgs e, RadioButton RdNombre, Label LblErrorBuscar)
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
