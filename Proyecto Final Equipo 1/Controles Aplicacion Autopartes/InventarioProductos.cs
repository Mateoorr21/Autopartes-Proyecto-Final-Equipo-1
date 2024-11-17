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
        public InventarioProductos()
        {
            InitializeComponent();
        }

        //Funcion Cargar Productos que se llama cada vez que se da click en el Boton Inventario
        public void CargarProductos()
        {
            FuncionesAplicacion.CargarProductos(LvProductos, LblCantidadRegistros);
        }
       
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
