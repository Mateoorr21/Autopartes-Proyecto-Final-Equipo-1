
using Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes;
using Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1
{
    public partial class Aplicacion : Form
    {
        //IGNORE LOS SIGUIENTES BLOQUES DE CODIGO, PARA MOSTRAR EN PANTALLA COMPLETA SI LA RESOLUCION ES DE LAPTOP
        // Constantes para el manejo de la barra de tareas
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;

        //Funciones para programar el mostrar y ocultar de la barra de tareas
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);


        //Cadena que contiene el control en el que estamos
        string ControlActual = null;

        DineroInicial CerrarVentana2;
        InicioSesion CerrarVentana1;
        Inicio MostrarVentanaInicio;

        //Declaramos los diferentes tipos de controles de usuario que se utilizaran en la aplicacion
        AgregarProducto agregarProducto; 
        BuscarProducto buscarProducto; 
        EliminarProducto eliminarProducto; 
        InventarioProductos inventarioProductos; 
        ModificarProducto modificarProducto;
        Ventas ventaProducto;
        CorteCaja corteCaja;

        public Aplicacion(DineroInicial dineroInicial, InicioSesion inicioSesion, Inicio inicio) 
        {
            InitializeComponent();

            MostrarVentanaInicio = inicio;
            CerrarVentana1 = inicioSesion;
            CerrarVentana2 = dineroInicial;

            //Inicializamos todos los controle de Usuario
            agregarProducto = new AgregarProducto();
            buscarProducto = new BuscarProducto();
            eliminarProducto = new EliminarProducto();
            inventarioProductos = new InventarioProductos();
            modificarProducto = new ModificarProducto();
            ventaProducto = new Ventas();
            corteCaja = new CorteCaja();

            //Evento de cerrar sesion lo asignamos a un evento aqui que funga como click al cerrar sesion
            corteCaja.CerrarSesion += CerrarSesionCorteCaja;
        }

        private void CerrarSesionCorteCaja(object sender, EventArgs e)
        {
            // Ejecuta el clic del botón de cierre de sesion
            BtnCerrarSesion.PerformClick();
        }

        //FUNCIONES PARA OCULTAR Y MOSTRAR BARRA DE TAREAS (IGNORESE)
        private void OcultarTaskbar()
        {
            IntPtr taskbarHandle = FindWindow("Shell_TrayWnd", null);
            if (taskbarHandle != IntPtr.Zero)
            {
                ShowWindow(taskbarHandle, SW_HIDE);
            }
        }

        private void ShowTaskbar()
        {
            IntPtr taskbarHandle = FindWindow("Shell_TrayWnd", null);
            if (taskbarHandle != IntPtr.Zero)
            {
                ShowWindow(taskbarHandle, SW_SHOW);
            }
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            KeyPreview = true; //Habilitamos el KeyPreview para capturar teclas antes de que lleguen a los controles

            // Detectar resolución de pantalla
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Si la resolución es 1366 x 768, quitamos borde y ocultamos la barra de tareas
            if ((screenWidth == 1366 && screenHeight == 768) || (screenWidth == 1360 && screenHeight == 768))
            {
                this.FormBorderStyle = FormBorderStyle.None;
                OcultarTaskbar();
            }


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

        // Función para habilitar todos los botones y restaurar sus imágenes de fondo
        private void HabilitarTodosLosBotones()
        {
            //Habilitamos y ponemos en color original los botones disponibles para todo el usuario
            BtnInventario.Enabled = true;
            BtnVender.Enabled = true;
            BtnBuscar.Enabled = true;
            BtnCorte.Enabled = true;
            BtnInventario.BackColor = Color.FromArgb(51, 51, 76);
            BtnVender.BackColor = Color.FromArgb(51, 51, 76);
            BtnBuscar.BackColor = Color.FromArgb(51, 51, 76);
            BtnCorte.BackColor = Color.FromArgb(51, 51, 76);

            if (FuncionesAplicacion.TienePermiso == true)
            {  //Si el usuario tiene permiso también se habilitan y ponen en color original los demas botones
                BtnAgregar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnModificar.Enabled = true;
                BtnAgregar.BackColor = Color.FromArgb(51, 51, 76);
                BtnEliminar.BackColor = Color.FromArgb(51, 51, 76);
                BtnModificar.BackColor = Color.FromArgb(51, 51, 76);
            }
        }

        //Funcion para ver si tenemos que abrir un nuevo control de usuario o no
        private void CambioDeControlUsuario(Control control, Button button)
        {
            FuncionesAplicacion.CambioControl = false; //Todavia no se cambia de control
            FuncionesAplicacion.PrimeraTecla = true;

            // Verificamos si el cambio de control es permitido
            if (!ConfirmarCambioControl())
            {
                return; // Si el cambio no es confirmado, salimos de la función
            }

            FuncionesAplicacion.CambioControl = true; //Se Cambio de control
            FuncionesAplicacion.PrimeraTecla = true;
            ControlActual = control.Name; //Guardamos el nombre del control en el que estamos

            FuncionesAplicacion.ReestablecerPrimeraTecla(control);

            HabilitarTodosLosBotones();
            button.BackColor = Color.FromArgb(0, 83, 198); //EL botón se colorea de azul indicando que está seleccionado
            button.Enabled = false; //Inhabilitamos el botón
            
            // Limpiar todos los controles del panel
            PanelAutoPartes.Controls.Clear();

            // Agregar el nuevo control
            PanelAutoPartes.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            // Reiniciar variables si el control no es el de catálogo de usuarios
            if (!control.Name.Contains("Usuario")) FuncionesAplicacion.ReiniciarVariables();
        }


        //FUNCION PARA CONFIRMAR EL CAMBIO DE CONTROL, ESTE SE PONE EN DUDA SOLO SI HAY VENTAS EN EL CARRITO
        private bool ConfirmarCambioControl()
        {
            FuncionesAplicacion.ConfirmarLimpiezaDeVenta = true; //Booleano empieza en true

            if (ventaProducto.HayRegistrosEnCarrito()) //Si hay registros en carrito confirmamos que se desea salir
            {
                DialogResult ConfirmarCambioApartado = MessageBox.Show("Existen registros en el carrito. Si cambia de apartado, la venta se cancelará automáticamente. " +
                    "¿Está seguro de que desea continuar?", "Confirmación de cambio de apartado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (ConfirmarCambioApartado == DialogResult.No)
                {
                    FuncionesAplicacion.ConfirmarLimpiezaDeVenta = false; //No se limpiara apartado de venta
                    return false; //No se permite el cambio
                }
                    
                else return true; //Si dice que si se permite el cambio
            }

            else return true; //Si no hay productos en carrito se permite el cambio de control
        }


        private void BtnCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios catalogoUsuarios = new CatalogoUsuarios(this); //Abrimos formulario de Catalogo de Usuarios
            catalogoUsuarios.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            CambioDeControlUsuario(agregarProducto, BtnAgregar);
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CambioDeControlUsuario(buscarProducto, BtnBuscar);
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //LLamamos a la función CargarProductos
            buscarProducto.CargarProductos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CambioDeControlUsuario(eliminarProducto, BtnEliminar);
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //LLamamos a la función CargarProductos
            eliminarProducto.CargarProductos();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            CambioDeControlUsuario(inventarioProductos, BtnInventario);
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //LLamamos a la función CargarProductos
            inventarioProductos.CargarProductos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            CambioDeControlUsuario(modificarProducto, BtnModificar);
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //LLamamos a la función CargarProductos
            modificarProducto.CargarProductos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (FuncionesAplicacion.HayVentas == true) //Si ya se realizaron ventas indicamos que debe ir a Corte de Caja
            {
                MessageBox.Show("Hay ventas realizadas. Dirijase al apartado Corte de Caja para poder cerrar.",
                    "ADVERTENCIA DE CIERRE DE APLICACION. VENTAS REALIZADAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            FuncionesAplicacion.SalirAplicacion = true; //Booleano de terminar aplicacion verdadero

            Application.Exit(); //Salimos de la Aplicacion
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            CambioDeControlUsuario(ventaProducto, BtnVender);
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //LLamamos a la función CargarProductos
            ventaProducto.CargarProductos();
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            CambioDeControlUsuario(corteCaja, BtnCorte);
            LimpiarTodosLosControles(); //Limpiamos todos los controles de Usuario

            //Llamamoss a la función CargarVentas
            corteCaja.CargarVentas();
        }

        private void Aplicacion_Shown(object sender, EventArgs e)
        {   
            // Si pantalla de lap lo centramos en base a toda la pantalla
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2
                );
                return;
            }

            // Recalculamos la posicion del formulario para que aparezca centrado despues de que AutoSize lo ajusto
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
        }

        private void Aplicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FuncionesAplicacion.SalirAplicacion == false)
            {
                e.Cancel = true; //Si no se sale del sistema cancelamos el evento
                return;

            }

            // Asegurarse de mostrar la barra de tareas al cerrar el formulario
            ShowTaskbar();
        }

        private void Aplicacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (FuncionesAplicacion.CambioControl == true && FuncionesAplicacion.PrimeraTecla == true)
            {   

                switch(ControlActual) {
                    case "AgregarProducto":
                        FuncionesAplicacion.LaPrimeraTecla(agregarProducto);
                        agregarProducto.Txt_Nombre.Focus();
                        break;
                    case "BuscarProducto":
                        FuncionesAplicacion.LaPrimeraTecla(buscarProducto);
                        buscarProducto.TxtBuscar.Focus();
                        break;
                    case "CorteCaja":
                        FuncionesAplicacion.LaPrimeraTecla(corteCaja);
                        corteCaja.TxtDineroFinal.Focus();
                        break;
                    case "EliminarProducto":
                        FuncionesAplicacion.LaPrimeraTecla(eliminarProducto);
                        eliminarProducto.TxtBuscar.Focus();
                        break;
                    case "InventarioProductos":
                        FuncionesAplicacion.LaPrimeraTecla(inventarioProductos);
                        inventarioProductos.LvProductos.Focus();
                        break;
                    case "ModificarProducto":
                        FuncionesAplicacion.LaPrimeraTecla(modificarProducto);
                        modificarProducto.TxtBuscar.Focus();
                        break;
                    case "Ventas":
                        FuncionesAplicacion.LaPrimeraTecla(ventaProducto);
                        ventaProducto.TxtBuscar.Focus();
                        break;
                }

                FuncionesAplicacion.PrimeraTecla = false;
                FuncionesAplicacion.CambioControl = false;
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.SalirAplicacion = false;

            if (FuncionesAplicacion.HayVentas == true) //Si ya se realizaron ventas indicamos que debe ir a Corte de Caja
            {
                MessageBox.Show("Hay ventas realizadas. Dirijase al apartado Corte de Caja para poder cerrar sesión.",
                    "ADVERTENCIA DE CIERRE DE SESION. VENTAS REALIZADAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(FuncionesAplicacion.SeHizoCorte == false)
            {
                //Solo si no se hizo corte confirmarmos que quiere salir de sesion
                DialogResult ConfirmarCierreSesion;
                ConfirmarCierreSesion = MessageBox.Show("¿Esta seguro que desea cerrar sesión?",
                    "CONFIRMACIÓN DE CIERRE DE SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ConfirmarCierreSesion == DialogResult.No) return;

                //Mostramos un mensaje de Agradecimiento
                MessageBox.Show("Gracias por usar nuestro sistema. ¡Vuelva Pronto!",
                    "CIERRE DE SESIÓN EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //Mostramos un mensaje de Agradecimiento
                MessageBox.Show("Gracias por su jornada. Tenga un buen día!",
                    "CORTE EXITOSO. CERRANDO SESIÓN...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FuncionesAplicacion.SalirAplicacion = true;

            //Regresamos a inicio
            this.Dispose();
            CerrarVentana2.Dispose();
            CerrarVentana1.Dispose();
            MostrarVentanaInicio.Show();
        }
    }
}
