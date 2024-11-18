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

namespace Proyecto_Final_Equipo_1.Controles_Aplicacion_Autopartes
{
    public partial class CorteCaja : UserControl
    {
        int ContarVentas = 0;
        float DineroVentas = 0;
        public CorteCaja()
        {
            InitializeComponent();
        }

        private void CorteCaja_Load(object sender, EventArgs e)
        {
            //Establecemos el ListView, sus propiedades y columnas
            LvVentas.View = View.Details;
            LvVentas.GridLines = true;
            LvVentas.FullRowSelect = true;
            LvVentas.Columns.Add("Nombre Completo", 100);
            LvVentas.Columns.Add("Usuario", 100);
            LvVentas.Columns.Add("Id Producto", 100);
            LvVentas.Columns.Add("Nombre", 150);
            LvVentas.Columns.Add("Precio", 80);
            LvVentas.Columns.Add("Cantidad", 80);
            LvVentas.Columns.Add("Total", 80);
        }

        public void CargarDineroCaja()
        {
            // Mostrar el dinero en caja en el TextBox
            TxtDineroCaja.Text = Properties.Settings.Default.DineroEnCaja.ToString("C"); // Le ponemos formato de Moneda
        }

        public void CargarVentas()
        {
            //Si la no se han realizado ventas mensaje de error
            if (FuncionesAplicacion.HayVentas == false)
            {
                MessageBox.Show("Error. No se han realizado ventas.", "ERROR. NO HAY VENTAS POR MOSTRAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LvVentas.Items.Count > 0) // Si las ventas ya están cargadas indicamos advertencia
            {
                MessageBox.Show("Advertencia. Las ventas ya han sido cargadas.", "ADVERTENCIA. VENTAS YA CARGADAS",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(FuncionesAplicacion.cadconexion))
            {
                conexion.Open(); //Abrimos conexion
                ListViewItem Venta;

                string ComandoVentas = "SELECT Nombre_Completo, Usuario, Id_Producto, Nombre_Producto, Precio_Producto, Cantidad_Producto, Total" +
                    " FROM Ventas WHERE SeGuardo = No"; //Consulta para seleccionar las ventas hechas por el Usuario

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(ComandoVentas, conexion)) //pasamos consulta y conexion
                {
                    OleDbDataReader LeerVentas = comando.ExecuteReader(); //Objeto de lectura

                    ContarVentas = 0; //Variable para contar los registros
                    DineroVentas = 0; //Vairable para contar el dinero generado

                    if (LeerVentas.HasRows) //Si se obtuvieron registros de la busqueda
                    {
                        LvVentas.Items.Clear(); //Limpiamos el contenido del ListView

                        while (LeerVentas.Read()) //Para cada registro obtenido
                        {
                            //Aumentamos el contador de registros
                            ContarVentas++;

                            //Ingresamos a las columnas del ListView los valores de la base de datos 
                            Venta = new ListViewItem(LeerVentas["Nombre_Completo"].ToString());
                            Venta.SubItems.Add(LeerVentas["Usuario"].ToString());
                            Venta.SubItems.Add(LeerVentas["Id_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Nombre_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Precio_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Cantidad_Producto"].ToString());
                            Venta.SubItems.Add(LeerVentas["Total"].ToString());

                            //Cargamos el registro al ListView
                            LvVentas.Items.Add(Venta);

                            DineroVentas += float.Parse(LeerVentas["Total"].ToString()); //Sumamos el dinero generado de cada Venta

                            //Actualizamos la etiqueta que cuenta los registros
                            LblCantidadRegistros.Text = "Ventas Realizadas: " + ContarVentas.ToString();
                        }
                    }
                }

                TxtDineroVentas.Text = DineroVentas.ToString(); //Actualizamos la caja de texto de Dinero Ventas
            }
        }


        public void MostrarVentaSeleccionada()
        {
            //Si no hay registro seleccionado menssaje de Error
            if (LvVentas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para mostrar sus detalles",
                    "ERROR. NO HAY VENTA SELECCIONADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem VentaSeleccionada = LvVentas.SelectedItems[0]; //Obtenemos el registro Seleccionado

            //Mostramos en un Message Box la información obtenida de la venta seleccionada
            MessageBox.Show("Datos de la Venta Seleccioada Seleccionada:" +
                "\n\n\nNombre Completo: " + VentaSeleccionada.SubItems[0].Text +
                "\n\nUsuario: " + VentaSeleccionada.SubItems[1].Text +
                " \n\nId de Producto: " + VentaSeleccionada.SubItems[2].Text +
                " \n\nNombre de Producto: " + VentaSeleccionada.SubItems[3].Text +
                " \n\nPrecio: $ " + VentaSeleccionada.SubItems[4].Text +
                " \n\nCantidad Vendida: " + VentaSeleccionada.SubItems[5].Text +
                " \n\nTotal: $ " + VentaSeleccionada.SubItems[6].Text,
                "INFORMACIÓN DE LA VENTA SELECCIONADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GuardarVentaCerrarSesion()
        {
            //Si no se han realizado ventas mensaje de error
            if (FuncionesAplicacion.HayVentas == false)
            {
                MessageBox.Show("Error. No se han realizado ventas.", "ERROR. NO HAY VENTAS POR REGISTRAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LvVentas.Items.Count == 0) // Si las ventas no han sido cargadas mensaje de error
            {
                MessageBox.Show("Cargue las ventas para poder guardarlas correctamente.", "ERROR. NO SE HAN CARGADO VENTAS",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //using para establecer conexion con la base de datos
            using (OleDbConnection conexion = new OleDbConnection(FuncionesAplicacion.cadconexion))
            {
                conexion.Open(); //Abrimos conexion

                //Actualizamos la BDDS Ventas para Guardar las ventas hechas por el Usuario
                string ComandoVentas = "UPDATE Ventas SET SeGuardo = Si WHERE SeGuardo = No";

                //Using para liberar objeto cuando ya no se use
                using (OleDbCommand comando = new OleDbCommand(ComandoVentas, conexion)) //pasamos consulta y conexion
                {
                    comando.ExecuteNonQuery(); //Ejecutamos consulta
                }
            }

            // Sumar las ventas del usuario al dinero que tenemos en la caja
            Properties.Settings.Default.DineroEnCaja += DineroVentas;

            //Mostramos un mensaje de éxito en el Guardado de Ventas
            MessageBox.Show("Las ventas han sido guardadas con Éxito. Gracias por usar nuestro sistema. ¡Vuelva Pronto!",
                "VENTAS HAN SIDOO GUARDADAS CON EXITO. CERRANADO SESIÓN Y APLICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit(); ; //Cerramos Aplicacion
        }

        private void BtnCargarVentas_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.CargarVentas(LvVentas, LblCantidadRegistros, TxtDineroVentas); //Llamamos a la función Cargar Ventas
        }

        private void BtnMostrarVenta_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.MostrarVentaSeleccionada(LvVentas); //LLamamos a la función para mostrar una venta seleccionada
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.LimpiarControles(this); //Si se selecciona cancelar limpiamos el control de Usuario
            CargarDineroCaja(); //Cargamos el dinero en caja
        }

        private void LvVentas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FuncionesAplicacion.OrdenamientoColumnas(e, LvVentas); //Llamamos a la función de Ordenamiento de columnas
        }

        private void BtnRegistrarVentas_Click(object sender, EventArgs e)
        {
            FuncionesAplicacion.GuardarVentasCerrarSesion(LvVentas); //Llamamos a la función de Guardar Ventas y Cierre de Sesión
        }
    }
}
