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
    public partial class HacerPago : Form
    {
        public HacerPago()
        {
            InitializeComponent();
        }

        private void HacerPago_Load(object sender, EventArgs e)
        {
            TxtPorPagar.Text = FuncionesAplicacion.PorPagar.ToString("C"); //Cargamos la cantidad a pagar
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose(); //Cerramos el formulario de Cobro
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            //Le asinamos al booleano se hizo cobro lo que retorne la función
            FuncionesAplicacion.SeCompletoOperacion = FuncionesAplicacion.HacerCobro(TxtDineroRecibo, LblErrorDineroRecibo);

            if(FuncionesAplicacion.SeCompletoOperacion) Dispose(); //Si se hizo el cobro cerramos el formulario
        }

        private void TxtDineroRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAplicacion.ValidarEntradaTxtCantidad(e, LblErrorDineroRecibo); //Llamamos la función para validar el dinero que recibo
        }
    }
}
