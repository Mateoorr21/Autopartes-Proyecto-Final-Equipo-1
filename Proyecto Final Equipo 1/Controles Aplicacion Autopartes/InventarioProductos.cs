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
            //El apartado de Agregar Inventario está deshabilitado si el Usuario es Cajero
            if (FuncionesAplicacion.TipoUsuario != "Admin" && FuncionesAplicacion.TipoUsuario != "Propietario")
            {
                PanelAddInventario.Enabled = false;
                PicInventario.Image = Properties.Resources.TextoInventarioDes; //Imagen Deshabilitada
            }

            //Declaramos el ListView, sus propiedades y columnas
            LvProductos.View = View.Details;
            LvProductos.GridLines = true;
            LvProductos.FullRowSelect = true;
            LvProductos.Columns.Add("Id", 40);
            LvProductos.Columns.Add("Nombre", 160);
            LvProductos.Columns.Add("Descripcion", 250);
            LvProductos.Columns.Add("Marca", 100);
            LvProductos.Columns.Add("Precio", 70);
            LvProductos.Columns.Add("Cantidad en Stock", 75);
            LvProductos.Columns.Add("Imagen", 0);
        }

        private void LvProductos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvProductos); //Llamamos a la funcion Ordenamiento de Columnas
        }

        private void LvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Restablecemos la Caja de Cantidad
            Txt_Cantidad.Text = Txt_Cantidad.Tag.ToString();

            //Si se selecciona un registro
            if (LvProductos.SelectedItems.Count > 0)
            {
                //Habilitamos Botones de (+)
                BtnMenos.Enabled = false; 
                BtnMas.Enabled = true;
                BtnMenos.BackgroundImage = Properties.Resources.BotonMenosDes; //Imagen de Menos Deshabilitado
                BtnMas.BackgroundImage = Properties.Resources.BotonMas; //Imagen de Mas Deshabilitado

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
                TxtProducto.Text = TxtProducto.Tag.ToString(); //Si no se selecciona algo reestablecemos la caja de producto
                BtnMenos.Enabled = false; //Inhabilitamos Botones de (+) y (-)
                BtnMas.Enabled = false;
                BtnMenos.BackgroundImage = Properties.Resources.BotonMenosDes; //Imagenes de botones Deshabilitados
                BtnMas.BackgroundImage = Properties.Resources.BotonMasDes;
            }
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtCantidad(e, LblErrorCantidad); //Llamamos a la función para validar la entrada de Cantidad
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            //Txt_Cantidad.Text = (FuncionesAplicacion.CantidadIngresada - 1).ToString(); //Restamos 1 a la cantidad ingresada

            // Variables de validación
            bool cantidadInvalida = !int.TryParse((FuncionesAplicacion.CantidadIngresada - 1).ToString(), out int ValidarCantidad) || ValidarCantidad > 1000000;

            if (cantidadInvalida) // Si la cantidad es invalida
            {
                MessageBox.Show("El valor contenido en la caja de cantidad no es valido. Debe estar entre 1 y 1,000,000.",
                    "ERROR. VALOR DE CANTIDAD NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Cantidad.Text = Txt_Cantidad.Tag.ToString();
                LblErrorCantidad.Visible = false;
                return;
            }

            Txt_Cantidad.Text = (FuncionesAplicacion.CantidadIngresada - 1).ToString(); //Restamos 1 a la cantidad ingresada
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            Txt_Cantidad.Text = (FuncionesAplicacion.CantidadIngresada + 1).ToString(); //Aumentamos la cantidad ingresada en 1

            // Variables de validación
            bool cantidadInvalida = !int.TryParse(Txt_Cantidad.Text, out int ValidarCantidad) || ValidarCantidad > 1000000;

            if (cantidadInvalida) // Si la cantidad es invalida
            {
                MessageBox.Show("El valor contenido en la caja de cantidad no es valido. Debe estar entre 1 y 1,000,000.",
                    "ERROR. VALOR DE CANTIDAD NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Cantidad.Text = Txt_Cantidad.Tag.ToString();
                LblErrorCantidad.Visible = false;
                return;
            }
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
            TxtProducto.Text = TxtProducto.Tag.ToString(); //Reestablecemos la caja de producto
            Txt_Cantidad.Text = Txt_Cantidad.Tag.ToString(); //Restablecemos la Caja de Cantidad
            LblErrorCantidad.Visible = false;
            FuncionesAplicacion.ReestablecerPrimeraTecla(this);
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnAgregarInventario_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.AgregarInventario(LvProductos, TxtProducto, Txt_Cantidad); //Llamamos a la función de Agregar Inventario
        }

 
    }
}
