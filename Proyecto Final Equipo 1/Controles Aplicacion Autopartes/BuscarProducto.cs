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

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class BuscarProducto : UserControl
    {
        int IdSeleccionado;
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        public BuscarProducto(Inicio inicio)
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

                    if (LeerProductos.HasRows) //Si se obtuvieron registros de la busqueda
                    {
                        LvProductos.Items.Clear();

                        while (LeerProductos.Read()) //Para cada registro obtenido
                        {
                            //Ingresamos a las columnas del ListView los valores de la base de datos 
                            Producto = new ListViewItem(LeerProductos["Id"].ToString());
                            Producto.SubItems.Add(LeerProductos["Nombre"].ToString());
                            Producto.SubItems.Add(LeerProductos["Descripcion"].ToString());
                            Producto.SubItems.Add(LeerProductos["Tipo"].ToString());
                            Producto.SubItems.Add(LeerProductos["Marca"].ToString());
                            Producto.SubItems.Add(LeerProductos["Precio"].ToString());
                            Producto.SubItems.Add(LeerProductos["Cantidad_en_Stock"].ToString());
                            Producto.SubItems.Add(LeerProductos["Proveedor"].ToString());

                            //Cargamos  el registro al ListView
                            LvProductos.Items.Add(Producto);
                        }
                    }

                    else //Si no se obtuvieron registros, indicarlo con un MessageBox
                    {
                        MessageBox.Show("No se encontraron Productos", "NO SE ENCONTRARON PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void MostrarProducto(int Id)
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvProductos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para mostrar su información",
                    "ERROR. NO HAY REGISTRO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Objeto de conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                string query = "SELECT * FROM Productos WHERE Id = @IdSeleccionado"; //Consulta de selección

                using (OleDbCommand comando = new OleDbCommand(query, conexion)) //Objeto de consulta
                {
                    comando.Parameters.AddWithValue("@IdSeleccionado", Id); //Parametro IdSeleccioando

                    OleDbDataReader LeerProducto = comando.ExecuteReader(); //Objeto de Lectura y ejecutamos lectura

                    while (LeerProducto.Read()) { //Para el regisro que se lee

                        //Mostramos en un Message Box la información obtenida de la consulta de selección
                        MessageBox.Show("Datos del Producto Seleccionado:" +
                            " \nId: " + LeerProducto["Id"].ToString() +
                            " \nNombre: " + LeerProducto["Nombre"].ToString() +
                            " \nDescripcion: " + LeerProducto["Id"].ToString() +
                            " \nTipo: " + LeerProducto["Tipo"].ToString() +
                            " \nMarca: " + LeerProducto["Marca"].ToString() +
                            " \nPrecio: $ " + LeerProducto["Precio"].ToString() +
                            " \nCantidad en Stock: " + LeerProducto["Cantidad_en_Stock"].ToString() +
                            " \nProveedor: " + LeerProducto["Proveedor"].ToString(),
                            "INFORMACIÓN DEL PRODUCTO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        // Revisamos si el registro tiene una ruta existente o válida
                        string rutaImagen = LeerProducto["Imagen"].ToString(); //Obtenemos la ruta

                        if (!string.IsNullOrEmpty(rutaImagen) && System.IO.File.Exists(rutaImagen)) //Si la ruta no es nula y la imagen existe
                        {
                            PicImagenProducto.Image = Image.FromFile(rutaImagen); // Cargar la imagen en el PictureBox
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

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            IdSeleccionado = 0;

            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 25);
            LvProductos.Columns.Add("Nombre", 80);
            LvProductos.Columns.Add("Descripcion", 80);
            LvProductos.Columns.Add("Tipo", 70);
            LvProductos.Columns.Add("Marca", 60);
            LvProductos.Columns.Add("Precio", 50);
            LvProductos.Columns.Add("Cantidad en Stock", 50);
            LvProductos.Columns.Add("Proveedor", 80);
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

        //Controlar la entrada de datos en el apartado cantidad a vender
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

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {

                ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);
            }

            //Si no hay registro seleccionado el Indice es 0
            else
            {
                IdSeleccionado = 0;
            }
        }

        private void BtnMostrarProducto_Click(object sender, EventArgs e)
        {
            MostrarProducto(IdSeleccionado);
        }

        private void BtnMostrarImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
