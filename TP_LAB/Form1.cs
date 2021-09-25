using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP_LAB
{
    public partial class frmConsultas : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-EN4EVL9; database=FABRICA_AUTOMOTRIZ ; integrated security = true");

        private SqlDataAdapter adp = new SqlDataAdapter();

        public frmConsultas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCONSULTAR.Enabled = false;
        }

        private void mostrarTabla(string nombreTabla)
        {
            //conectar();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + nombreTabla, conexion);
            adp.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            conexion.Close();
            dgAutos.DataSource = tabla;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Vehiculos_Terminados");
        }

        private void autopartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Autopartes");
        }

        private void autoPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("AutoPlan");
        }

        private void ordenPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Orden_Pedido");
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Facturas");
        }

        private void detalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("DetalleFactura");
        }

        private void formasPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Formas_Pago");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Clientes");
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Vendedores");
        }

        private void tiposClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Tipos_Clientes");
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Barrios");
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Localidades");
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarTabla("Provincias");
        }

        private void ejecutarParametro(string nombreParametro, string tipoDatoParam, int param)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("execute " + nombreParametro + " @" + tipoDatoParam + "= " + param, conexion);
            adp.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            conexion.Close();
            dgAutos.DataSource = tabla;
            btnCONSULTAR.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parametro = int.Parse(txtParametro.Text);
            string nombre = txtConsulta.Text;
            string condicion = txtCondicion.Text;
            ejecutarParametro(nombre, condicion, parametro);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblQueConsulta.Text = "Muestre el nombre de los vehiculos mayores a $2.000.000 en el año 2017";
            txtConsulta.Text = "pa_vehiculos";
            txtCondicion.Text = "Precio";
            txtParametro.Text = "2000000";
            btnCONSULTAR.Enabled = true;
        }

        private void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblQueConsulta.Text = "Listar el número de factura y el nombre de los clientes que compraron menos de 15 autopartes";
            txtConsulta.Text = "pa_autopartes";
            txtCondicion.Text = "Cantidad";
            txtParametro.Text = "15";
            btnCONSULTAR.Enabled = true;
        }

        private void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblQueConsulta.Text = "Total recaudado en efectivo por los vendedores en lo que va del año";
            txtConsulta.Text = "pa_año";
            txtCondicion.Text = "Año";
            txtParametro.Text = "2020";
            btnCONSULTAR.Enabled = true;
        }

        private void consulta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblQueConsulta.Text = "Cuáles son las facturas y la forma de pago donde el precio sea $1.500.000?";
            txtConsulta.Text = "pa_nroFac";
            txtCondicion.Text = "precio";
            txtParametro.Text = "1500000";
            btnCONSULTAR.Enabled = true;
        }

        private void consulta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblQueConsulta.Text = "Quiénes realizaron la mayor y la menor compra en 2019?";
            txtConsulta.Text = "pa_max_min";
            txtCondicion.Text = "num";
            txtParametro.Text = "2019";
            btnCONSULTAR.Enabled = true;
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblQueConsulta.Text = "Clientes y vendedores mayores de 30 años que no tengan residencia en los barrios 'Santa Rosa','Matienzo' ni 'Cofico'";
            txtConsulta.Text = "pa_mayor_30";
            txtCondicion.Text = "num";
            txtParametro.Text = "5";
            btnCONSULTAR.Enabled = true;
        }

        private void nuevoVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculos frmV = new frmVehiculos();
            frmV.ShowDialog();
        }

        private void nuevaAutoparteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutopartes frmA = new frmAutopartes();
            frmA.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Arias, Franco \n Conforte, Facundo \n Miskowski, Santiago \n Lopez Scidá, Bruno", "Sobre Nosotros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void informe1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte frmR = new frmReporte();
            frmR.ShowDialog();
        }

        private void informe2VehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes2 frmr2 = new frmReportes2();
            frmr2.ShowDialog();
        }
    }
}