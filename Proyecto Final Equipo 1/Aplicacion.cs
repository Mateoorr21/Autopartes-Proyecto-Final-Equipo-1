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

        //Aplicacion recibe parametro de instancia Inicio
        public Aplicacion(bool EsAdmin, string tipoUsuario, string nombreCompleto, Inicio inicio) //Indicamos que el formulario recibe parámetros
        {
            InitializeComponent();
            //Asignamos a variables de este formulario la información del usuario obtenida al iniciar sesión
            this.EsAdmin = EsAdmin;
            this.tipoUsuario = tipoUsuario;
            this.nombreCompleto = nombreCompleto;
            this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            if (!EsAdmin)
            {
                //Inhabilitar Funciones
            }
        }

        private void BtnCatalogoUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogoUsuarios catalogoUsuarios = new CatalogoUsuarios(Inicio_Recibido); //Catalogo recibe la instancia de Inicio inicial
            catalogoUsuarios.ShowDialog();
        }
    }
}
