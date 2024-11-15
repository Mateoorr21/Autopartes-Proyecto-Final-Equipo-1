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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1
{
    public partial class Inicio : Form
    {
        //Declaramos la cadena de conexion global disponible para formulario Inicio
        public string cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Base\Mi_prueva_personal.accdb;Persist Security Info=False;";

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


        //FUNCION PARA CARGAR PRODUCTOS EN EL INVENTARIO
        public void CargarProductos(ListView lvProductos, Label lblCantidadRegistros)
        {
            int ContarProductos = 0; // Reseteamos el contador de productos

            lvProductos.Items.Clear(); // Limpiamos el contenido del ListView

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
                        lvProductos.Items.Add(Producto);
                    }

                    // Actualizamos la etiqueta que cuenta los registros
                    lblCantidadRegistros.Text = "Cantidad de Productos: " + ContarProductos.ToString();
                }
            }
        }

        //FUNCION PARA AGREGAR UN PRODUCTO A LA BASE DE DATOS
        public void RegistrarProducto(string Nombre, string Descripcion, string Marca, float Precio, int Cantidad, string RutaTemporal, int IdGenerado,
                TextBox Txt_Nombre, TextBox Txt_Descripcion, TextBox Txt_Marca, TextBox Txt_Precio, TextBox Txt_Cantidad, PictureBox PicImagenProducto)
        {
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

            //Si se proporciono una imagen, copiamos esta imagen a la carpeta y actualizamos la base de datos
            if (!string.IsNullOrEmpty(RutaTemporal))
            {
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
            if (rdId.Checked) // Si está seleccionado el RadioButton de Id
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
                            " \n\nId: " + LeerProducto["Id"].ToString() +
                            " \nNombre: " + LeerProducto["Nombre"].ToString() +
                            " \nDescripcion: " + LeerProducto["Id"].ToString() +
                            " \nMarca: " + LeerProducto["Marca"].ToString() +
                            " \nPrecio: $ " + LeerProducto["Precio"].ToString() +
                            " \nCantidad en Stock: " + LeerProducto["Cantidad_en_Stock"].ToString(),
                            "INFORMACIÓN DEL PRODUCTO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string RutaImagenTemporal = LeerProducto["Imagen"].ToString().Trim('#'); //Obtenemos la ruta y quitamos los #

                        // Si la ruta no esta vacía creamos la nueva ruta
                        if (!string.IsNullOrEmpty(RutaImagenTemporal))
                        {
                            string RutaImagenAbrir = "..\\..\\" + RutaImagenTemporal; //Creamos la nueva ruta (saliendo varias carpetas mas)

                            if (System.IO.File.Exists(RutaImagenAbrir)) //Si el archivo de imagen existe se carga la Imagen en el PictureBox
                            {
                                PicImagenProducto.Image = Image.FromFile(RutaImagenAbrir);
                            }
                        }

                        else
                        {
                            MessageBox.Show("La Imagen no está disponible.", "IMAGEN NO DISPONIBLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PicImagenProducto.Image = null; // Limpiamos el Picture Box
                        }
                    }
                }
            }
        }


        //FUNCION PARA CARGAR UNA IMAGEN A UN PICTUREBOX Y PARA ELIMINAR UNA IMAGEN DEL PICTUREBOX
        //LA RUTA LA PASAMOS POR REFERENCIA PORQUE QUEREMOS QUE SE MODIFIQUE SU VALOR
        public void LiberarPictureBox(PictureBox PicImagenProducto)
        {
            PicImagenProducto.Image = null;
            /* if (PicImagenProducto != null && PicImagenProducto.Image != null) // Verifica que no sea null
             {
                 PicImagenProducto.Image.Dispose(); // Liberamos la imagen
                 PicImagenProducto.Image = null;    // Limpiamos el PictureBox
             } */
        }

        public void CargarImagen (PictureBox PicImagenProducto, ref string RutaImagenTemporal)
        {
            // Si ya existe una imagen cargada, se limpia
            PicImagenProducto.Image = null;

            //Instancia de OpenFileDialog que permite al usuario seleccionar un archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg;"; //Filtro para los tipos de archivo

            //Abrimos openFileDialog, si el usuario selecciona Abrir el archivo se selecciono correctamente
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicImagenProducto.ImageLocation = openFileDialog.FileName; //La imagen seleccionada se muestra en el picture box

                RutaImagenTemporal = openFileDialog.FileName; // Almacena la ruta seleccionada para despues modificarla
            }
        }
        public void DeseleccionarImagen(PictureBox PicImagenProducto, ref string RutaImagenTemporal)
        {
            PicImagenProducto.Image.Dispose(); //Liberamos la imagen
            PicImagenProducto.Image = null; //Limpiamos el PictureBox
            RutaImagenTemporal = null; //La ruta temporal será nula
        }
    }
}
