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

        public void LiberarPictureBox() //llamamos a la funcion LiberarPictureBox del Inicio
        {
            Inicio_Recibido.LiberarPictureBox(PicImagenProducto);
        }
        public bool EstaEnUso(string archivo)
        {
            try
            {
                using (FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    // Si no lanza una excepción, el archivo no está en uso
                    return false;
                }
            }
            catch (IOException)
            {
                // Si ocurre una excepción, significa que el archivo está en uso
                return true;
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
            //Llamamos a la función EncontrarProductos de Inicio y limpiamos la caja Buscar
            Inicio_Recibido.EncontrarProductos(TxtBuscar.Text, TxtBuscar, RdAproximada, RdNombre, LvProductos, LblCantidadRegistros);
            TxtBuscar.Clear();
        }

        private void RdId_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoId(RdId, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //Llamamos a la Funcion SeleccionoId
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            Inicio_Recibido.SeleccionoNombre(RdNombre, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Inicio_Recibido.ValidarEntradaTxtBuscar(e, RdId, LblErrorBuscar); //LLamamos a la función de validar entrada del TextBox Buscar
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

                //Obtenemos la ruta guardada en el ListView y quitamos los caracteres #
                RutaImagenTemporal = ItemSeleccionado.SubItems[6].Text.Trim('#');

                // Si la ruta no esta vacía creamos la nueva ruta
                if (!string.IsNullOrEmpty(RutaImagenTemporal))
                {
                    string RutaImagenAbrir = "..\\..\\" + RutaImagenTemporal; //Creamos la nueva ruta (saliendo varias carpetas mas)

                    if (System.IO.File.Exists(RutaImagenAbrir)) //Si el archivo de imagen existe se carga la Imagen en el PictureBox
                    {
                        PicImagenProducto.Image = Image.FromFile(RutaImagenAbrir);
                    }
                }

                // Si la ruta está vacía o no existe no se muestra nada
                else PicImagenProducto.Image = null; 
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
                string.IsNullOrWhiteSpace(Txt_Marca.Text))
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
                string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, " +
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

            // Liberamos la imagen del PictureBox
            if (PicImagenProducto.Image != null)
            {
                PicImagenProducto.Image.Dispose();
                PicImagenProducto.Image = null;
            }

            //ELIMINAMOS LA IMAGEN CON ESE ID
            //Obtenemos la posible ruta de la imagen existente con el mismo ID
            string RutaImagenExistenteJpg = "..\\..\\..\\Imagenes\\" + Id.ToString() + ".jpg";

            // EN REVISION TODAVIA ERRONEO
            if (!string.IsNullOrEmpty(RutaImagenTemporal) && File.Exists(RutaImagenExistenteJpg))
            {
                File.Delete(RutaImagenExistenteJpg); // Eliminamos la imagen existente
            }

            //Borramos la imagen existente si se encuentra en la carpeta
            if (File.Exists(RutaImagenExistenteJpg)) File.Delete(RutaImagenExistenteJpg); // Eliminamos la imagen existente .jpg

            string RutaAgregar = null; //Declaramos la ruta que se pondra en el ListView y la base de datos (Por el Momento Nula)
            string RutaDestino = null; //Declaramos la ruta que se va usar para copiar la imagen a la carpeta
            
            //SI SE PROPORCIONO
                //Insertamos la iamgen en carpeta, cambiamos RutaAgregar y actualizamos la base de datos

            //FALTA UN POCO, ERROR SI SE MANTIENE LA MISMA IAMGEN Y NO SE SELECCIONA NADA

            if (!string.IsNullOrEmpty(RutaImagenTemporal))
            {
                //Obtenemos la extensión del archivo (si es .png o .jpg)
                string ExtensionImagen = Path.GetExtension(RutaImagenTemporal).ToLower(); 

                //Obtenemos la ruta destino tomando en cuenta la ubicación de la carpeta Imagenes y el nombre de la imagen
                RutaDestino = "..\\..\\..\\Imagenes\\" + Id.ToString() + ".jpg";

                // Pasamos el reemplazo a la ruta destino 
                File.Copy(RutaImagenTemporal, RutaDestino, true);

                //Obtenemos la ruta que se pondra en la base de datos
                RutaAgregar = "..\\Imagenes\\" + Id.ToString() + ExtensionImagen;

                //Actualizamos la base de datos con la ruta de la imagen del archivo de base de datos a la carpeta imagenes
                using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion)) //Conexion
                {
                    conexion.Open(); //Abrimos conexion

                    string query = "UPDATE Productos SET Imagen = @Imagen WHERE Id = @Id "; //Sentencia de actualización

                    using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Objeto de clase Comando SQL
                    {
                        comando.Parameters.AddWithValue("@Imagen", RutaAgregar); //Parametro de Imagen es la RutaAgregar
                        comando.Parameters.AddWithValue("@Id", Id); //Parametro IdGenerado

                        comando.ExecuteNonQuery(); //Ejecutamos el comando de actualizacion
                    }
                }
            }

            else
            {

            }

            //Actualizamos el registro seleccionado
            ListViewItem Modificado = LvProductos.SelectedItems[0];
            Modificado.SubItems[1].Text = Nombre;
            Modificado.SubItems[2].Text = Descripcion;
            Modificado.SubItems[3].Text = Marca;
            Modificado.SubItems[4].Text = Precio.ToString();
            Modificado.SubItems[5].Text = Cantidad.ToString();
            Modificado.SubItems[6].Text = RutaAgregar;

            //Limpiamos los controles de Actualización de Datos (Cajas de Texto y PictureBox)
            Txt_Nombre.Clear();
            Txt_Descripcion.Clear();
            Txt_Marca.Clear();
            Txt_Precio.Clear();
            Txt_Cantidad.Clear();

            //Mensaje de Actualización de datos exitosa
            MessageBox.Show("Datos del Producto actualizados correctamente.", "ACTUALIZACION DE DATOS DE PRODUCTO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.CargarImagen(PicImagenProducto, ref RutaImagenTemporal); //LLamamos a la función Cargar Imagen
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Si alguno de los campos a actualizar esta vacío mensaje de Error (excepto imagen y descripcion)
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

            //Convertimos el valor de las cajas en tipo float y entero
            Precio = float.Parse(Txt_Precio.Text);
            Cantidad = int.Parse(Txt_Cantidad.Text);

            // Liberamos la imagen del PictureBox
            if (PicImagenProducto.Image != null)
            {
                PicImagenProducto.Image.Dispose();
                PicImagenProducto.Image = null;
            }

            ActualizarProducto(Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Marca.Text, Precio, Cantidad, RutaImagenTemporal, IdSeleccionado);
        }

        private void BtnDeseleccionarImagen_Click(object sender, EventArgs e)
        {
            Inicio_Recibido.DeseleccionarImagen(PicImagenProducto, ref RutaImagenTemporal); //Llamamos a la función Deseleccionar Imagen
        }
    }

}
