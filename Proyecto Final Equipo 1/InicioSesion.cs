using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_Final_Equipo_1
{
    public partial class InicioSesion : Form
    {
        Inicio Inicio_Recibido;
        bool CorrectoInicioSesion;

        //Booleano para controlar la primer tecla ingresada
        bool PrimerTeclaPresionada = true;

        public InicioSesion(Inicio inicio) 
        {
            InitializeComponent();
            Inicio_Recibido = inicio;
        }

        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {
            CorrectoInicioSesion = FuncionesAplicacion.IniciarSesion(Txt_Usuario.Text, Txt_Password.Text, Txt_Usuario, Txt_Password, this); //llamda a función de Inicio de Sesion

            if( CorrectoInicioSesion ) //Mostramos la ventan de dinero en caja
            {
                this.Hide();
                DineroInicial VentanaDineroInicial = new DineroInicial(Inicio_Recibido, this);
                VentanaDineroInicial.ShowDialog();
            }
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorUsuario); //Llamamos a la función validar entrada de Usuario
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesCatalogoUsuarios.ValidarEntradaTxtUsuarioOPassword(e, LblErrorPassword); //Llamamos a la función validar entrada de Password
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            KeyPreview = true; //Habilitamos el KeyPreview para capturar teclas antes de que lleguen a los controles

            this.ActiveControl = null; // Desactiva el foco inicial en cualquier control
            this.Focus(); // Asegura que el formulario capture el foco
        }

        private void BtnVolverInicio_Click(object sender, EventArgs e)
        {
            Dispose(); //Volvemos a la Ventana de Inicio con el Logo de la Aplicacion
            Inicio_Recibido.Show();
        }

        private void BtnPassword_MouseDown(object sender, MouseEventArgs e)
        {
            BtnPassword.BackgroundImage = Properties.Resources.Mostrar_Password; // Imagen de mostrar contraseña
            Txt_Password.PasswordChar = '\0'; //Se muestra
        }

        private void BtnPassword_MouseUp(object sender, MouseEventArgs e)
        {
            BtnPassword.BackgroundImage = Properties.Resources.Esconder_Password; // Imagen de ocultar contraseña
            Txt_Password.PasswordChar = '*'; //Se oculta
        }

        private void InicioSesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (PrimerTeclaPresionada) //Si es la primer tecla que se presiona
            {
                Txt_Password.Enabled = true;
                Txt_Usuario.Enabled = true;
                Btn_Ingreso.Enabled = true;
                Txt_Usuario.TabStop = true; //Indicamos que los controles se recorran con tabindex
                Txt_Password.TabStop = true;
                Btn_Ingreso.TabStop = true;
                BtnVolverInicio.TabStop = true;
                Txt_Usuario.Clear(); //Limpiamos las cajas
                Txt_Password.Clear();
                Txt_Usuario.Focus(); //Foco en la caja de usuario
                BtnPassword.BackgroundImage = Properties.Resources.Esconder_Password; // Imagen de ocultar contraseña
                Txt_Password.PasswordChar = '*'; //Se oculta
                LblIndicacion.Visible = false; //Escondemos la etiqueta con el texto de presionar cualquier tecla
                PrimerTeclaPresionada = false; //Booleano falso para indicar que ya se ingresó la primer tecla
            }
        }
    }
}
