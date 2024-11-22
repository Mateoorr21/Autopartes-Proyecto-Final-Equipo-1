using Microsoft.Win32;
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
    public partial class Ventas : UserControl
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables

            //Establecemos el ListView de Productos, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 160);
            LvProductos.Columns.Add("Descripcion", 0);
            LvProductos.Columns.Add("Marca", 80);
            LvProductos.Columns.Add("Precio", 70);
            LvProductos.Columns.Add("Cantidad en Stock", 75);
            LvProductos.Columns.Add("Imagen", 0);

            //Establecemos el ListView de Productos en Carrito, sus propiedades y columnas
            LvCarrito.View = View.Details;
            LvCarrito.GridLines = true;
            LvCarrito.FullRowSelect= true;
            LvCarrito.Columns.Add("Id", 25);
            LvCarrito.Columns.Add("Nombre", 180);
            LvCarrito.Columns.Add("Precio", 50);
            LvCarrito.Columns.Add("Cantidad", 65);
            LvCarrito.Columns.Add("Total", 50);
            LvCarrito.Columns.Add("Total IVA", 70);
        }

        //Funcion Cargar Productos que se llama cada vez que se da click en el Boton Ventas
        public void CargarProductos()
        {
            FuncionesAplicacion.CargarProductos(LvProductos, LblCantidadRegistrosBuscar);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Llamamos a la función EncontrarProductos
            FuncionesAplicacion.EncontrarProductos(TxtBuscar.Text, TxtBuscar, RdAproximada, RdNombre, LvProductos, LblCantidadRegistrosBuscar, LblErrorBuscar);
        }

        private void RdId_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesAplicacion.SeleccionoId(RdId, TxtBuscar, LblCampoBuscar, LblErrorBuscar); //Llamamos a la Funcion SeleccionoId
        }

        private void RdNombre_CheckedChanged(object sender, EventArgs e)
        {
            FuncionesAplicacion.SeleccionoNombre(RdNombre, LblCampoBuscar, LblErrorBuscar); //LLamamos a la Función SeleccionoNombre
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtBuscar(e, RdId, RdNombre, LblErrorBuscar); //LLamamos a la función de validar entrada del TextBox Buscar
        }

        private void BtnRestaurarBusqueda_Click(object sender, EventArgs e)
        {
            //Llamamos a la función para limpiar el Subapartado de Busqueda del control de Usuario Ventas
            FuncionesAplicacion.RestaurarBusquedaVentas(LvProductos, TxtBuscar, TxtProducto, Txt_Cantidad, LblErrorBuscar,
                LblErrorCantidad, RdAproximada, RdExacta, RdNombre, RdId, LblCantidadRegistrosBuscar);
            CargarProductos();
        }

        private void LvProductos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvProductos); //Llamamos a la funcion Ordenamiento de Columnas
        }

        private void LvCarrito_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvCarrito); //Llamamos a la funcion Ordenamiento de Columnas
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtCantidad(e, LblErrorCantidad); //LLamamos a la función de validar entrada del TextBox Cantidad
        }

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos la Caja de Cantidad
            Txt_Cantidad.Text = Txt_Cantidad.Tag.ToString();

            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {
                //Habilitamos Botones de (+)
                BtnMas.Enabled = true;
                BtnMenos.Enabled = false;
                BtnMas.BackgroundImage = Properties.Resources.BotonMas;
                BtnMenos.BackgroundImage = Properties.Resources.BotonMenosDes;

                ListViewItem ItemSeleccionado = LvProductos.SelectedItems[0]; //Obtenemos registro seleccionado

                //Obtenemos el Valor del Id del Registro Seleccionado
                FuncionesAplicacion.IdSeleccionado = int.Parse(ItemSeleccionado.SubItems[0].Text);
                
                LblErrorCantidad.Visible = false; //Ocultamos la etiqueta de error

                //Obtenemos la cantidad de productos en existencia del seleccionado
                FuncionesAplicacion.CantidadEnStockSeleccionado = int.Parse(ItemSeleccionado.SubItems[5].Text);

                //Mostramos la etiqueta producto con el nombre del producto seleccionado
                TxtProducto.Text = ItemSeleccionado.SubItems[1].Text;
            }

            else
            {
                TxtProducto.Text = TxtProducto.Tag.ToString(); //Restablecemos la caja de texto
                BtnMas.Enabled = false; //Inhabilitamos Botones de (+) y (-)
                BtnMenos.Enabled = false;
                BtnMas.BackgroundImage = Properties.Resources.BotonMasDes; //Cambiamos a imagen Deshabilitada
                BtnMenos.BackgroundImage = Properties.Resources.BotonMenosDes;

            }          
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            //Llamamos a la función validar cantidad con el stock cada vez que se cambie el texto de la caja cantidad
            FuncionesAplicacion.ValidarCantidadConStock(Txt_Cantidad, BtnMenos, BtnMas, LvProductos);
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            Txt_Cantidad.Text = (FuncionesAplicacion.CantidadIngresada + 1).ToString(); //Aumentamos la cantidad ingresada en 1
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            Txt_Cantidad.Text = (FuncionesAplicacion.CantidadIngresada - 1).ToString(); //Restamos 1 a la cantidad ingresada
        }

        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            // Confirmamos que el usuario desea cancelar la venta
            DialogResult ConfirmarCancelarVenta;
            ConfirmarCancelarVenta = MessageBox.Show("¿Esta seguro que desea cancelar la venta de los productos cargados en el carrito?",
                "CONFIRMACIÓN DE CANCELACIÓN DE VENTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarCancelarVenta == DialogResult.No) return;

            FuncionesAplicacion.LimpiarControles(this); //Si se Selecciona Cancelar limpiamos todos los controles
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void AgregarCarrito_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.AgregarAlCarrito(LvProductos, LvCarrito, Txt_Cantidad, TxtPorPagar, LblCantidadRegistrosCarrito); //Llamamos a la funcion de Agregar al Carrito
        }

        private void VaciarCarrito_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.VaciarElCarrito(LvCarrito, TxtPorPagar, LblCantidadRegistrosCarrito); //Llamamos a la función de Vaciar el Carrito
        }

        private void BtnEliminarRegistroCarrito_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.EliminarProductoCarrito(LvCarrito, TxtPorPagar, LblCantidadRegistrosCarrito); //Llamamos a la funcion de Eliminar Producto de Carrito
        }

        private void BtnVender_Click(object sender, EventArgs e)
        { 
            FuncionesAplicacion.SeCompletoOperacion = FuncionesAplicacion.VenderProductos(LvCarrito, TxtPorPagar, LblCantidadRegistrosCarrito); //Llamamos a la función de Vender Productos

            if (FuncionesAplicacion.SeCompletoOperacion) //Solo si la venta fue Exitosa limpiamos y reiniciamos
            {
                FuncionesAplicacion.LimpiarControles(this); //Limpiamos todos los controles una vez hecha la venta
                CargarProductos();
                FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
            }
        }
    }
}
