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
    public partial class DineroInicial : Form
    {
        bool DineroEnCajaValido = false;

        Inicio Inicio_Recibido;
        InicioSesion Sesion_Recibido;
        public DineroInicial(Inicio inicio, InicioSesion inicioSesion)
        {
            InitializeComponent();
            Inicio_Recibido = inicio;
            Sesion_Recibido = inicioSesion;
        }

        private void Txt_DineroInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtPrecio(e, Txt_DineroInicial, LblErrorDineroInicial); //Llamamos a la función para validar el dinero inicial en caja
        }

        private void BtnDineroEnCaja_Click(object sender, EventArgs e)
        {
            DineroEnCajaValido = FuncionesAplicacion.GuardarDineroInicialYContinuar(Txt_DineroInicial, LblErrorDineroInicial, this); //Procedimiento de Guardar Dinero Inicial para continuar al sisetma

            if(DineroEnCajaValido)
            {
                this.Hide();
                Aplicacion aplicacion = new Aplicacion(this, Sesion_Recibido, Inicio_Recibido); //Abrimos el de aplicacion
                aplicacion.ShowDialog();
            }
        }
    }
}
