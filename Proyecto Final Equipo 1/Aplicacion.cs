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

        //Aplicacion recibe parametro de instancia Inicio
        public Aplicacion(bool EsAdmin, string tipoUsuario, string nombreCompleto, Inicio inicio) //Indicamos que el formulario recibe parámetros
        {
            InitializeComponent();
            //Asignamos a variables de este formulario la información del usuario obtenida al iniciar sesión
            this.EsAdmin = EsAdmin; //Recibimos si es Admin o no
            this.tipoUsuario = tipoUsuario; //Recibimos el permiso
            this.nombreCompleto = nombreCompleto; //Recibimos el nombre completo
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
            agregarProducto = new AgregarProducto(Inicio_Recibido); //El user control AgregarProducto recibe como parametro un Inicio
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
    }
}
