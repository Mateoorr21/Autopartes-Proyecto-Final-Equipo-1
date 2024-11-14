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

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class ModificarProducto : UserControl
    {
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        float Precio;
        int Cantidad;
        int IdSeleccionado;
        string RutaImagenTemporal;
        public ModificarProducto(Inicio inicio) 
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }

        void EncontrarProductos(string buscar)
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
                            Producto.SubItems.Add(LeerProductos["Imagen"].ToString()); //Cargamos en ListView. El ancho de esa columna es 0

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

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            IdSeleccionado = 0;

            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 100);
            LvProductos.Columns.Add("Descripcion", 120);
            LvProductos.Columns.Add("Marca", 80);
            LvProductos.Columns.Add("Precio", 70);
            LvProductos.Columns.Add("Cantidad en Stock", 80);
            LvProductos.Columns.Add("Imagen", 0);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función EncontrarProductos y limpiamos la caja Buscar
            EncontrarProductos(TxtBuscar.Text);
            TxtBuscar.Clear();
        }

        private void RdId_CheckedChanged(object sender, EventArgs e)
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

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            //Si se selecciona RdNombre cambiar texto de las etiquetas
            if (RdNombre.Checked)
            {
                LblCampoBuscar.Text = "Nombre";
                LblErrorBuscar.Visible = false;
                LblErrorBuscar.Text = "";
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RdId.Checked) //Si esta seleccionado el RadioButton de Id hay restricciones
            {
                //Validar que solo es ingresen numeros o backspace
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    LblErrorBuscar.Visible = true;
                    e.Handled = true;
                }

                else //Si no hay errores, ocultar la etiqueta de error
                {
                    LblErrorBuscar.Visible = false;
                }
            }
        }

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {

                ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);

                //Cargamos la información del ListView en las diferentes cajas de texto y radiobuttons
                Txt_Nombre.Text = ItemSeleccionado.SubItems[1].Text;
                Txt_Descripcion.Text = ItemSeleccionado.SubItems[2].Text;
                Txt_Marca.Text = ItemSeleccionado.SubItems[3].Text;
                Txt_Precio.Text = ItemSeleccionado.SubItems[4].Text;
                Txt_Cantidad.Text = ItemSeleccionado.SubItems[5].Text;

                //Obtenemos la ruta de la imagen
                RutaImagenTemporal = ItemSeleccionado.SubItems[6].Text;

                // Si la ruta no esta vacía y el archivo existe cargamos la imagen
                if (!string.IsNullOrEmpty(RutaImagenTemporal) && System.IO.File.Exists(RutaImagenTemporal)) PicImagenProducto.Image = Image.FromFile(RutaImagenTemporal);

                // Si la ruta está vacía o no existe no se muestra nada
                else  PicImagenProducto.Image = null; 
            }
        }

        void ActualizarProducto(string Nombre, string Descripcion, string Marca, float Precio, float Cantidad, string RutaImagen, int Id)
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
                string.IsNullOrWhiteSpace(Txt_Cantidad.Text))
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
                string query = "UPDATE Productos SET Nombre = @Nombre, Decripcion = @Descripcion, " +
                                "Marca = @Marca, Precio = @Precio, Cantidad_en_Stock = @Cantidad, Imagen = @Ruta WHERE Id = @Id";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //using para liberar objeto cuando se termine de usar
                {
                    //Asignamos a los parámetros de la consulta los valores de las variables que recibe la función 
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@Marca", Marca);
                    comando.Parameters.AddWithValue("@Precio", Precio);
                    comando.Parameters.AddWithValue("@Cantidad", Cantidad);
                    comando.Parameters.AddWithValue("@Ruta", string.Empty);
                    comando.Parameters.AddWithValue("@Id", Id); //Insertamos una ruta vacía que se modificará si se ingreso una imagen

                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            //Declaramos a RutaDesttno (que se colocara en el ListView)
            string RutaDestino = null;

            //Si se proporciono una imagen, reeemplazar esta imagen por la que esta en la carpeta y actualizamos la base de datos

            if (!string.IsNullOrEmpty(RutaImagenTemporal))
            {
                //Reemplazamos la imagen ingresada por el usuario por la que esta en nuestra carpeta que lleva el mismo nombre

                //Obtenemos la extensión del archivo (si es .png o .jpg)
                string ExtensionImagen = Path.GetExtension(RutaImagenTemporal).ToLower();

                string NombreImagen = Id.ToString() + ExtensionImagen; //Nombre que tendrá la imagen, con Id y extensión correcta

                //Obtenemos la ruta destino tomando en cuenta la ubicación de la carpeta Imagenes y el nombre de la imagen
                RutaDestino = "..\\..\\..\\Imagenes\\" + NombreImagen;

                //Obtenemos las dos posibles rutas de la imagen existente con el mismo ID
                string RutaImagenExistentePng = "..\\..\\..\\Imagenes\\" + Id.ToString() + ".png";
                string RutaImagenExistenteJpg = "..\\..\\..\\Imagenes\\" + Id.ToString() + ".jpg";

                //Borramos las imagenes existentes si se encuentran en la carpeta
                if (File.Exists(RutaImagenExistentePng)) File.Delete(RutaImagenExistentePng); // Eliminamos la imagen existente .png
                if (File.Exists(RutaImagenExistenteJpg)) File.Delete(RutaImagenExistenteJpg); // Eliminamos la imagen existente .jpg

                // Pasamos el reemplazo a la ruta destino 
                File.Copy(RutaImagenTemporal, RutaDestino, true);

                //Actualizamos la base de datos con la ruta correcta de la imagen
                using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion)) //Conexion
                {
                    conexion.Open(); //Abrimos conexion

                    string query = "UPDATE Productos SET Imagen = @Imagen WHERE Id = @Id "; //Sentencia de actualización

                    using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Objeto de clase Comando SQL
                    {
                        comando.Parameters.AddWithValue("@Imagen", RutaDestino); //Parametro de Imagen es la RutaDestino
                        comando.Parameters.AddWithValue("@Id", Id); //Parametro IdGenerado

                        comando.ExecuteNonQuery(); //Ejecutamos el comando de actualizacion
                    }
                }
            }

            //Actualizamos el registro seleccionado
            ListViewItem Modificado = LvProductos.SelectedItems[0];
            Modificado.SubItems[1].Text = Nombre;
            Modificado.SubItems[2].Text = Descripcion;
            Modificado.SubItems[3].Text = Marca;
            Modificado.SubItems[4].Text = Precio.ToString();
            Modificado.SubItems[5].Text = Cantidad.ToString();
            Modificado.SubItems[6].Text = RutaDestino;

            //Limpiamos los controles de Actualización de Datos (Cajas de Texto y PictureBox)
            Txt_Nombre.Clear();
            Txt_Descripcion.Clear();
            Txt_Marca.Clear();
            Txt_Precio.Clear();
            Txt_Cantidad.Clear();
            PicImagenProducto.Image = null;

            //Mensaje de Actualización de datos exitosa
            MessageBox.Show("Datos del Producto actualizados correctamente.", "ACTUALIZACION DE DATOS DE PRODUCTO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            //Instancia de OpenFileDialog que permite al usuario seleccionar un archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png"; //Filtro para los tipos de archivo

            //Abrimos openFileDialog, si el usuario selecciona Abrir el archivo se selecciono correctamente
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicImagenProducto.ImageLocation = openFileDialog.FileName; //La imagen seleccionada se muestra en el picture box

                RutaImagenTemporal = openFileDialog.FileName; // Almacena la ruta seleccionada para despues modificarla
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Convertimos el valor de las cajas en tipo float y entero
            Precio = float.Parse(Txt_Precio.Text);
            Cantidad = int.Parse(Txt_Cantidad.Text);

            ActualizarProducto(Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Marca.Text, Precio, Cantidad, RutaImagenTemporal, IdSeleccionado);
        }
    }

}
