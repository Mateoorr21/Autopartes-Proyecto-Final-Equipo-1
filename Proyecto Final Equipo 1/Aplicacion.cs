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

        private void BtnCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios catalogoUsuarios = new CatalogoUsuarios(); //Abrimos formulario de Catalogo de Usuarios
            catalogoUsuarios.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //Limpiamos panel y cargamos el Control de Usuario AgregarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(agregarProducto);
            agregarProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //Limpiamos panel y cargamos el Control de Usuario BuscarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(buscarProducto);
            buscarProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //Limpiamos panel y cargamos el Control de Usuario BuscarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(eliminarProducto);
            eliminarProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //Limpiamos panel y cargamos el Control de Usuario InventarioProductos
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(inventarioProductos);
            inventarioProductos.Dock = DockStyle.Fill;

            //LLamamos a la función CargarProductos
            inventarioProductos.CargarProductos();

            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las variables
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //Limpiamos panel y cargamos el Control de Usuario ModificarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(modificarProducto);
            modificarProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
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

            //Limpiamos panel y cargamos el Control de Usuario ventaProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(ventaProducto);
            ventaProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //Limpiamos panel y cargamos el Control de Usuario corteCaja
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(corteCaja);
            corteCaja.Dock = DockStyle.Fill;

            corteCaja.CargarDineroCaja(); //Cargamos el dinero en caja
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }


        //Evitar que el usuario cierre la aplicacion cuando da click en X
        private void Aplicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
