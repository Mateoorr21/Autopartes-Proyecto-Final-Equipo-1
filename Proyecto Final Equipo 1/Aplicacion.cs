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

        //Aplicacion recibe parametro de instancia Inicio
        public Aplicacion() //Indicamos que el formulario recibe parámetros
        {
            InitializeComponent();
            //Todos los controles de usuario reciben como parametro un Inicio para tener acceso a cadconexion
            agregarProducto = new AgregarProducto(); 
            buscarProducto = new BuscarProducto(); 
            eliminarProducto = new EliminarProducto(); 
            inventarioProductos = new InventarioProductos();
            modificarProducto = new ModificarProducto();
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
        }

        private void BtnCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios catalogoUsuarios = new CatalogoUsuarios(); //Abrimos formulario de Catalogo de Usuarios
            catalogoUsuarios.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario AgregarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(agregarProducto);
            agregarProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.LimpiarControles(agregarProducto); //Limpiamos los controles del Control de Usuario
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario BuscarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(buscarProducto);
            buscarProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.LimpiarControles(buscarProducto); //Limpiamos los controles del Control de Usuario
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario BuscarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(eliminarProducto);
            eliminarProducto.Dock = DockStyle.Fill;

            FuncionesAplicacion.LimpiarControles(eliminarProducto); //Limpiamos los controles del Control de Usuario
            FuncionesAplicacion.ReiniciarVariables(); //Reiniciamos las Variables
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario InventarioProductos
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(inventarioProductos);
            inventarioProductos.Dock = DockStyle.Fill;

            FuncionesAplicacion.LimpiarControles(inventarioProductos); //Limpiamos los controles del Control de Usuario

            //LLamamos a la función CargarProductos
            inventarioProductos.CargarProductos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario ModificarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(modificarProducto);
            modificarProducto.Dock = DockStyle.Fill;
           
            FuncionesAplicacion.LimpiarControles(modificarProducto); //Limpiamos los controles del Control de Usuario
            FuncionesAplicacion.ReiniciarVariables();
        }
    }
}
