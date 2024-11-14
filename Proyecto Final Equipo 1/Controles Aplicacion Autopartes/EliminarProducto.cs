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
    public partial class EliminarProducto : UserControl
    {
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        int IdSeleccionado; //Variable glocal IdGenerado
        int ContarProductos; //Variable Global para contar registros
        public EliminarProducto(Inicio inicio)
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos a Recibido el que se pasa como parametro
        }

        //Función para borrar un producto seleccionado
        void BorrarProducto(int Id)
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
            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
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

                //Quitamos del ListView el eliminado
                ListViewItem Seleccionado = LvProductos.SelectedItems[0];
                LvProductos.Items.Remove(Seleccionado);

                //Actualizamos la etiqueta de Cantidad de Registros
                LblCantidadRegistros.Text = "Productos Encontrados: " + (ContarProductos - 1).ToString();

                //Mensaje de Eliminación de usuario exitosa
                MessageBox.Show("Producto eliminado correctamente.", "ELIMINACION DE PRODUCTO DE LA BASE DE DATOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Misma función para encontrar productos que en Buscar
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

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            IdSeleccionado = 0;

            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 150);
            LvProductos.Columns.Add("Descripcion", 210);
            LvProductos.Columns.Add("Marca", 150);
            LvProductos.Columns.Add("Precio", 100);
            LvProductos.Columns.Add("Cantidad en Stock", 120);
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            //Llamamos a la función EncontrarProductos y limpiamos la caja Buscar
            EncontrarProductos(TxtBuscar.Text);
            TxtBuscar.Clear();
        }

        /*  Idéntico que en User Control de BuscarProducto  */
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
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función Eliminar y pasamos el parametro del Id del Registro Seleccionado
            BorrarProducto(IdSeleccionado);
        }
    }
}
