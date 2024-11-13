using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class AgregarProducto : UserControl
    {
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        int IdGenerado; //Variable glocal IdGenerado
        float Precio;
        int Cantidad;
        string RutaImagenTemporal; //Variable Global Ruta Temporal
        public AgregarProducto(Inicio inicio)
        {
            InitializeComponent(); 
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        void RegistrarProducto(string Nombre, string Descripcion, string Tipo, string Marca, float Precio, int Cantidad, string Proveedor, string RutaTemporal)
        {
            //Establecemos el obejto OledbConnection para conectar con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Primer comando SQL para insertar el registro
                string query = "INSERT INTO Productos (Nombre, Descripcion, Tipo, Marca, Precio, Cantidad_en_Stock, Proveedor, Imagen) " +
                   "VALUES (@Nombre, @Descripcion, @Tipo, @Marca, @Precio, @CantidadEnStock, @Proveedor, @Imagen)";

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Comando SQL
                {
                    //Parametros de consulta, los valores que se van a insertar a la base de datos
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@Tipo", Tipo);
                    comando.Parameters.AddWithValue("@Marca", Marca);
                    comando.Parameters.AddWithValue("@Precio", Precio);
                    comando.Parameters.AddWithValue("@CantidadEnStock", Cantidad);
                    comando.Parameters.AddWithValue("@Proveedor", Proveedor);
                    comando.Parameters.AddWithValue("@Imagen", string.Empty); //Por el momento una cadena vacía en el apartado imagen

                    comando.ExecuteNonQuery();
                    //object resultado = comando.ExecuteScalar(); //Ejecutamos el comando y obtenemo como objeto el Id del Registro Insertado
                    
                    //IdGenerado = Convert.ToInt32(resultado); //Convertimos el objeto a un entero
                }

                //Segundo comando SQL para obtener el último Id Generado
                string queryID = "SELECT LAST(Id) FROM Productos";

                using (OleDbCommand comando = new OleDbCommand(queryID, conexion))
                {
                    IdGenerado = (int)comando.ExecuteScalar(); //Ejecutamos comando y obtenemos el último Id generado
                }
            }


            //Copiamos la imagen ingresada por el usuario a nuestra carpeta, con el nombre que deseamos 

            //Obtenemos la extensión del archivo (si es .png o .jpg)
            string ExtensionImagen = Path.GetExtension(RutaTemporal).ToLower();

            string NombreImagen = IdGenerado.ToString() + ExtensionImagen; //Nuevo nombre de la imagen, con Id y extensión correcta

            //NO ES UTIL
            //Obtenemos la ruta destino usando el camino de aplicacion a carpeta imagenes y el nuevo nombre de la imagen
            //string RutaDestino = Path.Combine(Application.StartupPath, "Imagenes", NombreImagen); 
            string RutaCopiar = "..\\..\\..\\Imagenes\\" + NombreImagen;

            //string RutaInsertarEnBase = "..\\Imagenes\\" + NombreImagen;

            // Copiar el archivo de la ruta temporal a la ruta destino (ya con el nombre correcto)
            File.Copy(RutaTemporal, RutaCopiar, true);

            MessageBox.Show("El id generado es " + IdGenerado);

            //Actualizamos la base de datos con la ruta correcta de la imagen
            using(OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion)) //Conexion
            {
                conexion.Open(); //Abrimos conexion

                string query = "UPDATE Productos SET Imagen = @Imagen WHERE Id = @Id "; //Sentencia de actualización

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Objeto de clase Comando SQL
                {
                    comando.Parameters.AddWithValue("@Imagen", RutaCopiar); //Parametro de Imagen es la RutaDestino
                    comando.Parameters.AddWithValue("@Id", IdGenerado); //Parametro IdGenerado

                    comando.ExecuteNonQuery(); //Ejecutamos el comando de actualizacion
                }
            }

            //Limpiamos las cajas de texto y el Picture Box
            Txt_Nombre.Clear();
            Txt_Descripcion.Clear();
            Txt_Tipo.Clear();
            Txt_Marca.Clear();
            Txt_Precio.Clear();
            Txt_Cantidad.Clear();
            Txt_Proveedor.Clear();
            PicImagenProducto.Image = null;


            //Mensaje de registro de producto exitoso
            MessageBox.Show($"Registro de Producto {Nombre} Exitoso",
                "Registro exitoso de Producto a Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            //Si algun campo esta vacío (exceptuando la descripción), o la ruta temporal es nula, mensaje de error
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(Txt_Tipo.Text) ||
                string.IsNullOrWhiteSpace(Txt_Marca.Text) ||
                string.IsNullOrWhiteSpace(Txt_Precio.Text) ||
                string.IsNullOrWhiteSpace(Txt_Cantidad.Text) ||
                string.IsNullOrWhiteSpace(Txt_Proveedor.Text) ||
                string.IsNullOrEmpty(RutaImagenTemporal))
            {
                MessageBox.Show("Error. Ingrese la información del producto a ingresar", "ERROR. ALGUNO DE LOS CAMPOS ESTA VACÍO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Convertimos el valor de las cajas en tipo float y entero
            Precio = float.Parse(Txt_Precio.Text);
            Cantidad = int.Parse(Txt_Cantidad.Text);

            RegistrarProducto(Txt_Nombre.Text, Txt_Descripcion.Text, Txt_Tipo.Text, Txt_Marca.Text, Precio, Cantidad, Txt_Proveedor.Text, RutaImagenTemporal);
        }
    }
}
