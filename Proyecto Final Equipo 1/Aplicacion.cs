using Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes;
using Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1
{
    public partial class Aplicacion : Form
    {
        //Declaramos los diferentes tipos de controles de usuario que se utilizaran en la aplicacion
        AgregarProducto agregarProducto; 
        BuscarProducto buscarProducto; 
        EliminarProducto eliminarProducto; 
        InventarioProductos inventarioProductos; 
        ModificarProducto modificarProducto;
        Ventas ventaProducto;
        CorteCaja corteCaja;

        public Aplicacion() 
        {
            InitializeComponent();
            //Inicializamos todos los controle de Usuario
            agregarProducto = new AgregarProducto();
            buscarProducto = new BuscarProducto();
            eliminarProducto = new EliminarProducto();
            inventarioProductos = new InventarioProductos();
            modificarProducto = new ModificarProducto();
            ventaProducto = new Ventas();
            corteCaja = new CorteCaja();
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            //Si no es Administrador únicamente puede acceder a "Buscar/Vender"
            if (!FuncionesAplicacion.TienePermiso)
            {
                BtnAgregar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnModificar.Enabled = false;
                BtnCatalogoUsuarios.Enabled = false;

                //Mostramos como imagenes de los botones las versiones deshabilitadas
                BtnAgregar.BackgroundImage = Properties.Resources.IconoAgregarProductoDes2;
                BtnEliminar.BackgroundImage = Properties.Resources.IconoEliminarProductoDes;
                BtnModificar.BackgroundImage = Properties.Resources.IconoModificarProductoDes;
                BtnCatalogoUsuarios.BackgroundImage = Properties.Resources.IconoCatalogoUsuariosDes2;
            }

            //Cargamos la información del Usuario Operativo en las etqiuetas
            LblUsuario.Text = FuncionesAplicacion.Usuario;
            LblNombreCompleto.Text = FuncionesAplicacion.NombreCompleto;
            LblPermiso.Text = "(" + FuncionesAplicacion.TipoUsuario + ")";
        }

        private void LimpiarTodosLosControles()
        {
            //Funcion para Limpiar todos los Controles de Usuario 
            FuncionesAplicacion.LimpiarControles(modificarProducto);
            FuncionesAplicacion.LimpiarControles(eliminarProducto);
            FuncionesAplicacion.LimpiarControles(buscarProducto);
            FuncionesAplicacion.LimpiarControles(agregarProducto);
            FuncionesAplicacion.LimpiarControles(inventarioProductos);
            FuncionesAplicacion.LimpiarControles(ventaProducto);
            FuncionesAplicacion.LimpiarControles(corteCaja);
        }
        
        //Funcion para ver si tenemos que abrir un nuevo control de usuario o no
        private void MostrarControlUsuario(Control control)
        {
            // Si el control ya está cargado en el panel no hacemos nada
            if (PanelAutoPartes.Controls.Count > 0 && PanelAutoPartes.Controls[0] == control)
            {
                return;
            }

            // Limpiar todos los controles del panel
            PanelAutoPartes.Controls.Clear();

            // Agregar el nuevo control
            PanelAutoPartes.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            FuncionesAplicacion.ReiniciarVariables(); // Reiniciamos las variables
        }

        private void BtnCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios catalogoUsuarios = new CatalogoUsuarios(this); //Abrimos formulario de Catalogo de Usuarios
            catalogoUsuarios.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
            MostrarControlUsuario(agregarProducto); 
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
            MostrarControlUsuario(buscarProducto);

            //LLamamos a la función CargarProductos
            buscarProducto.CargarProductos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
            MostrarControlUsuario(eliminarProducto);

            //LLamamos a la función CargarProductos
            eliminarProducto.CargarProductos();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
            MostrarControlUsuario(inventarioProductos);

            //LLamamos a la función CargarProductos
            inventarioProductos.CargarProductos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
            MostrarControlUsuario(modificarProducto);

            //LLamamos a la función CargarProductos
            modificarProducto.CargarProductos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (FuncionesAplicacion.HayVentas == true) //Si ya se realizaron ventas indicamos que debe ir a Corte de Caja
            {
                MessageBox.Show("Hay ventas realizadas sin guardar. Dirijase al apartado Corte de Caja para guardarlas y cerrar sesión.",
                    "ADVERTENCIA. VENTAS REALIZADAS SIN GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Confirmamos que el usuario desea salir de la Aplicación
            DialogResult ConfirmarCierreSesion;
            ConfirmarCierreSesion = MessageBox.Show("¿Esta seguro que desea realizar salir de la Aplicación? Se cerrará sesión automáticamente.",
                "CONFIRMACIÓN DE CIERRE DE APLICACIÓN Y SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarCierreSesion == DialogResult.No) return;


            //Mostramos un mensaje de Agradecimiento
            MessageBox.Show("Gracias por usar nuestro sistema. ¡Vuelva Pronto!",
                "¡VUELVA PRONTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit(); //Salimos de la Aplicacion
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
            MostrarControlUsuario(ventaProducto);

            //LLamamos a la función CargarProductos
            ventaProducto.CargarProductos();
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
            MostrarControlUsuario(corteCaja);

            corteCaja.CargarDineroCaja(); //Cargamos el dinero en caja
        }

        private void Aplicacion_Shown(object sender, EventArgs e)
        {
            // Recalculamos la posicion del formulario para que aparezca centrado despues de que AutoSize lo ajusto
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
        }
    }
}
