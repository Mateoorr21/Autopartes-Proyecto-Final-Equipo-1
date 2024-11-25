using Proyecto_Final_Equipo_1.Controles_Catalogo_de_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Equipo_1
{
    public partial class CatalogoUsuarios : Form
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
        private void HideTaskbar()
        {
            IntPtr taskbarHandle = FindWindow("Shell_TrayWnd", null);
            if (taskbarHandle != IntPtr.Zero)
            {
                ShowWindow(taskbarHandle, SW_HIDE);
            }
        }

        //Declaramos variables de tipo UserControl a utilizar
        RegistrarUsuario registroUsuario;
        ModificarUsuario modificarUsuario;
        EliminarUsuario eliminarUsuario;

        public CatalogoUsuarios(Aplicacion aplicacion)
        {
            InitializeComponent();
            //Incializamos los controles de Usuario
            registroUsuario = new RegistrarUsuario(); 
            modificarUsuario = new ModificarUsuario(aplicacion, this); 
            eliminarUsuario = new EliminarUsuario(); 
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

        private void LimpiarTodosLosControles()
        {
            //Funcion para Limpiar todos los Controles de Usuario 
            FuncionesAplicacion.LimpiarControles(registroUsuario);
            FuncionesAplicacion.LimpiarControles(modificarUsuario);
            FuncionesAplicacion.LimpiarControles(eliminarUsuario);
        }
        private void HabilitarTodosLosBotones()
        {
            //Habilitamos y ponemos en color original los botones disponibles
            BtnRegistrarUsuario.Enabled = true;
            BtnModificarUsuario.Enabled = true;
            BtnEliminarUsuario.Enabled = true;
            BtnRegistrarUsuario.BackColor = Color.FromArgb(51, 51, 76);
            BtnModificarUsuario.BackColor = Color.FromArgb(51, 51, 76);
            BtnEliminarUsuario.BackColor = Color.FromArgb(51, 51, 76);
        }

        //Funcion para ver si tenemos que abrir un nuevo control de usuario o no
        private void CambiarControlCatalogo(Control control, Button button)
        {
            // Limpiar todos los controles del panel
            PanelCatalogo.Controls.Clear();

            HabilitarTodosLosBotones();
            button.BackColor = Color.FromArgb(0, 83, 198); //EL botón se colorea de azul indicando que está seleccionado
            button.Enabled = false; //Inhabilitamos el botón

            // Agregar el nuevo control
            PanelCatalogo.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            CambiarControlCatalogo(registroUsuario, BtnRegistrarUsuario); //Llamamos a la función mostrrar el control
            LimpiarTodosLosControles();
        }

        private void BtnModificarUsuario_Click(object sender, EventArgs e)
        {
            CambiarControlCatalogo(modificarUsuario, BtnModificarUsuario); //Llamamos a la función mostrar el control
            LimpiarTodosLosControles();
            modificarUsuario.CargarUsuariosModificar();
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            CambiarControlCatalogo(eliminarUsuario, BtnEliminarUsuario); //Llamamos a la función mostrar el control
            LimpiarTodosLosControles();
            eliminarUsuario.CargarUsuariosEliminar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Confirmamos que el usuario desea salir del Catálogo
            DialogResult ConfirmarCierreCatalogo;
            ConfirmarCierreCatalogo = MessageBox.Show("¿Esta seguro que desea salir del Catálogo de Usuarios?",
                "CONFIRMACIÓN DE CIERRE CATALOGO DE USUARIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ConfirmarCierreCatalogo == DialogResult.No) return;

            Dispose(); //Salimos del Catalogo
        }

        private void CatalogoUsuarios_Shown(object sender, EventArgs e)
        {
            // Si pantalla de lap lo centramos en base a toda la pantalla
            if (FormBorderStyle == FormBorderStyle.None)
            {
                Location = new Point(
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

        private void CatalogoUsuarios_Load(object sender, EventArgs e)
        {
            // Detectar resolución de pantalla
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Si la resolución es 1366 x 768, quitamos borde y ocultamos la barra de tareas
            if ((screenWidth == 1366 && screenHeight == 768) || (screenWidth == 1360 && screenHeight == 768))
            {
                FormBorderStyle = FormBorderStyle.None;
                OcultarTaskbar();
            }

            //Cargamos la información del Usuario Operativo en las etqiuetas
            LblUsuario.Text = FuncionesAplicacion.Usuario;
            LblNombreCompleto.Text = FuncionesAplicacion.NombreCompleto;
            LblPermiso.Text = "(" + FuncionesAplicacion.TipoUsuario + ")";
        }
    }
}
