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
        private bool EsAdmin;
        private string tipoUsuario;
        private string nombreCompleto;
        Inicio Inicio_Recibido; //Declaramos el Inicio que asignaremos al que se recibe como parametro
        AgregarProducto agregarProducto; //Declaramos control de usuario tipo agergar producto
        BuscarProducto buscarProducto; //Declaramos control de usuario tipo buscar producto
        EliminarProducto eliminarProducto; //Declaramos control de usuario tipo agergar producto
        InventarioProductos inventarioProductos; //Declaramos control de usuario tipo inventario

        //Aplicacion recibe parametro de instancia Inicio
        public Aplicacion(bool EsAdmin, string tipoUsuario, string nombreCompleto, Inicio inicio) //Indicamos que el formulario recibe parámetros
        {
            InitializeComponent();
            //Asignamos a variables de este formulario la información del usuario obtenida al iniciar sesión
            this.EsAdmin = EsAdmin; //Recibimos si es Admin o no
            this.tipoUsuario = tipoUsuario; //Recibimos el permiso
            this.nombreCompleto = nombreCompleto; //Recibimos el nombre completo
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido

            //Todos los controles de usuario reciben como parametro un Inicio para tener acceso a cadconexion
            agregarProducto = new AgregarProducto(Inicio_Recibido); 
            buscarProducto = new BuscarProducto(Inicio_Recibido); 
            eliminarProducto = new EliminarProducto(Inicio_Recibido); 
            inventarioProductos = new InventarioProductos(Inicio_Recibido);
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            //Si no es Administrador únicamente puede acceder a "Buscar/Vender"
            if (!EsAdmin)
            {
                BtnAgregar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnModificar.Enabled = false;
                BtnCatalogoUsuarios.Enabled = false;
            }
        }

        private void BtnCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            CatalogoUsuarios catalogoUsuarios = new CatalogoUsuarios(Inicio_Recibido); //Catalogo recibe la instancia de Inicio inicial
            catalogoUsuarios.ShowDialog();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(agregarProducto);
            agregarProducto.Dock = DockStyle.Fill;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(buscarProducto);
            buscarProducto.Dock = DockStyle.Fill;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(eliminarProducto);
            eliminarProducto.Dock = DockStyle.Fill;
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            PanelAutoPartes.Controls.Clear();
            PanelAutoPartes.Controls.Add(inventarioProductos);
            inventarioProductos.Dock = DockStyle.Fill;

            //LLamamos a la función CargarProductos
            inventarioProductos.CargarProductos();
        }
    }
}
