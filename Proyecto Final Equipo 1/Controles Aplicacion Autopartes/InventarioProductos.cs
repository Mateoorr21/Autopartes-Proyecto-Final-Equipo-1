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
            //El apartado de Agregar Inventario está habilitado si el Usuario es Admin o Propietario
            GpBAgregrarInventario.Enabled = FuncionesAplicacion.TipoUsuario == "Admin" || FuncionesAplicacion.TipoUsuario == "Propietario";

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

        private void LvProductos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvProductos); //Llamamos a la funcion Ordenamiento de Columnas
        }

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos la Caja de Cantidad
            Txt_Cantidad.Clear();

            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {
                //Habilitamos Botones de (+)
                BtnMenos.Enabled = false;
                BtnMas.Enabled = true;

                ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                FuncionesAplicacion.IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);

                LblErrorCantidad.Visible = false; //Ocultamos la etiqueta de error

                TxtProducto.Text = ItemSeleccionado.SubItems[1].Text; //Cargamos el nombre del producto en el TextBox

                //Obtenemos la cantidad de productos en existencia del seleccionado
                FuncionesAplicacion.CantidadEnStockSeleccionado = int.Parse(ItemSeleccionado.SubItems[5].Text);
            }

            else
            {
                TxtProducto.Clear(); //Si no se selecciona algo limpiamos la caja Producto
                BtnMenos.Enabled = false; //Inhabilitamos Botones de (+) y (-)
                BtnMas.Enabled = false;
            }
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtCantidad(e, LblErrorCantidad); //Llamamos a la función para validar la entrada de Cantidad
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            Txt_Cantidad.Text = (FuncionesAplicacion.CantidadIngresada - 1).ToString(); //Restamos 1 a la cantidad ingresada
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            Txt_Cantidad.Text = (FuncionesAplicacion.CantidadIngresada + 1).ToString(); //Aumentamos la cantidad ingresada en 1
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            FuncionesAplicacion.ValidarCantidadParaAgregar(Txt_Cantidad, BtnMenos, BtnMas, LvProductos); //Llamamos a la función para validar la Cantidad
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Confirmamos que el usuario desea cancelar la venta
            DialogResult ConfirmarCancelarAgregarInventario;
            ConfirmarCancelarAgregarInventario = MessageBox.Show("¿Esta seguro que desea cancelar el agregado de productos al inventario?",
                "CONFIRMACIÓN DE CANCELACIÓN DE VENTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarCancelarAgregarInventario == DialogResult.No) return;

            LvProductos.SelectedItems.Clear(); //Quitamos el seleccionado
            TxtProducto.Clear(); //Limpiamos las cajas de texto
            Txt_Cantidad.Clear();
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnAgregarInventario_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.AgregarInventario(LvProductos, TxtProducto, Txt_Cantidad); //Llamamos a la función de Agregar Inventario
        }
    }
}
