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
        //Variables que contendran la información del usuario que inicia sesión
        public bool TienePermiso;
        public string Usuario;
        public string TipoUsuario;
        public string NombreCompleto;

        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro

        //Declaramos los diferentes tipos de controles de usuario que se utilizaran en la aplicacion
        AgregarProducto agregarProducto; 
        BuscarProducto buscarProducto; 
        EliminarProducto eliminarProducto; 
        InventarioProductos inventarioProductos; 
        ModificarProducto modificarProducto;

        //Aplicacion recibe parametro de instancia Inicio
        public Aplicacion(bool EsAdmin, string TipoUsuario, string Usuario, string NombreCompleto, Inicio inicio) //Indicamos que el formulario recibe parámetros
        {
            InitializeComponent();
            //Asignamos a variables de este formulario la información del usuario obtenida al iniciar sesión
            this.TienePermiso = EsAdmin; //Recibimos si es Admin o no
            this.TipoUsuario = TipoUsuario; //Recibimos el permiso
            this.Usuario = Usuario;
            this.NombreCompleto = NombreCompleto; //Recibimos el nombre completo
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido

            //Todos los controles de usuario reciben como parametro un Inicio para tener acceso a cadconexion
            agregarProducto = new AgregarProducto(Inicio_Recibido); 
            buscarProducto = new BuscarProducto(Inicio_Recibido); 
            eliminarProducto = new EliminarProducto(Inicio_Recibido); 
            inventarioProductos = new InventarioProductos(Inicio_Recibido);
            modificarProducto = new ModificarProducto(Inicio_Recibido);
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            //Si no es Administrador únicamente puede acceder a "Buscar/Vender"
            if (!TienePermiso)
            {
                BtnAgregar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnModificar.Enabled = false;
                BtnCatalogoUsuarios.Enabled = false;
            }
        }

        private void BtnCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios catalogoUsuarios = new CatalogoUsuarios(Inicio_Recibido, this); //Catalogo recibe la instancia de Inicio inicial
            catalogoUsuarios.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario AgregarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(agregarProducto);
            agregarProducto.Dock = DockStyle.Fill;

            Inicio_Recibido.LimpiarControles(agregarProducto); //Limpiamos los controles del Control de Usuario
            agregarProducto.ReiniciarVariables(); //Reiniciamos variables
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario BuscarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(buscarProducto);
            buscarProducto.Dock = DockStyle.Fill;

            Inicio_Recibido.LimpiarControles(buscarProducto); //Limpiamos los controles del Control de Usuario
            buscarProducto.ReiniciarVariables(); //Reiniciamos variables
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario BuscarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(eliminarProducto);
            eliminarProducto.Dock = DockStyle.Fill;

            Inicio_Recibido.LimpiarControles(eliminarProducto); //Limpiamos los controles del Control de Usuario
            eliminarProducto.ReiniciarVariables(); //Reiniciamos variables
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario InventarioProductos
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(inventarioProductos);
            inventarioProductos.Dock = DockStyle.Fill;

            Inicio_Recibido.LimpiarControles(inventarioProductos); //Limpiamos los controles del Control de Usuario

            //LLamamos a la función CargarProductos
            inventarioProductos.CargarProductos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Limpiamos panel y cargamos el Control de Usuario ModificarProducto
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(modificarProducto);
            modificarProducto.Dock = DockStyle.Fill;
           
            Inicio_Recibido.LimpiarControles(modificarProducto); //Limpiamos los controles del Control de Usuario
            modificarProducto.ReiniciarVariables(); //Reiniciamos variables
        }
    }
}
