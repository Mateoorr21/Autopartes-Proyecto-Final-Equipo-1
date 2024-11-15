using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class InventarioProductos : UserControl
    {
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        int ContarProductos;

        public InventarioProductos(Inicio inicio)
        {
            InitializeComponent();
            Inicio_Recibido = inicio; //Asignamos el parametro recibido a nuestro Inicio_Recibido
        }

        public void CargarProductos()
        {
            Inicio_Recibido.CargarProductos(LvProductos, LblCantidadRegistros);
        }
        /*
        public void CargarProductos()
        {
            ContarProductos = 0; //Reseteamos el contador de productos

            LvProductos.Items.Clear(); //Limpiamos el contenido del ListView

            using (OleDbConnection conexion = new OleDbConnection(Inicio_Recibido.cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                string query = "SELECT * FROM Productos";
                ListViewItem Producto;

                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    OleDbDataReader LeerProductos = comando.ExecuteReader();

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
                        LblCantidadRegistros.Text = "Cantidad de Productos: " + ContarProductos.ToString();
                    }
                }
            }
        }*/
        private void InventarioProductos_Load(object sender, EventArgs e)
        {
            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 120);
            LvProductos.Columns.Add("Descripcion", 200);
            LvProductos.Columns.Add("Marca", 100);
            LvProductos.Columns.Add("Precio", 70);
            LvProductos.Columns.Add("Cantidad en Stock", 120);
        }
    }
}
