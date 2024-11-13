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
    public partial class Inicio : Form
    {
        //Declaramos la cadena de conexion global disponible para formulario Inicio
        public string cadconexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Base\Mi_prueva_personal.accdb;Persist Security Info=False;";

        //NOTAS A TOMAR EN CUENTA
        /*La cadena de conexion se declaro de manera global para no tener que estarla declarando cada vez que se use
         *Cuando trabajen en un nuevo formulario (Eliminacion, grabado y modificacion) recuerden nombrarlo
         *Se debe indicar cuando se declare el formulario el parametro al llamarlo (una instancia de tipo Inicio)
         *En el nuevo formulario...
         *     - Se declara la instancia Tipo Inicio que recibira el parametro
         *     - Se debe indicar que el formulario recibe un parametro de inicio
         *     - Se le asigna al que inicio delcarado el formulario que se recibe como parametro
         *     
         * PARA ACCEDER A LA CADENA DE CONEXION CON Inicio_Recibido.cadconexion
         */

        //EJEMPLO
        /* Si se tiene un formulario Eliminar
         * En formulario Aplicaion escribir
         *          Eliminar eliminar = new Eliminar(Inicio_Recibido);
         *          
         * En formulario Eliminar escrbir como global
         *          Inicio Inicio_Recibido;
         * 
         * public CatalogoUsuarios(Inicio inicio)
                {
                    InitializeComponent();
                    this.Inicio_Recibido = inicio; //a Inicio_Recibido le asignamos el parametro recibido
                }
         */

        //Se pueden ver ejemplos de esto en cualquiera de los formularios.
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion inicioSesion = new InicioSesion(this); //Pasamos al siguiente formulario una instancia de Inicio
            inicioSesion.Width = 818;   // Ancho deseado
            inicioSesion.Height = 497;  // Alto deseado
            inicioSesion.ShowDialog();
        }
    }
}
