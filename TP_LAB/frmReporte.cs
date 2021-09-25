using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

using System.Data.SqlClient;

namespace TP_LAB
{
    public partial class frmReporte : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-EN4EVL9; database=FABRICA_AUTOMOTRIZ ; integrated security = true");
        private string consultaSql = "";

        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'FABRICA_AUTOMOTRIZDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            //this.ClientesTableAdapter.Fill(this.FABRICA_AUTOMOTRIZDataSet.Clientes);

            //this.reportViewer1.RefreshReport();
        }

        public DataTable consultar(string consultaSql)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(consultaSql, conexion);
            conexion.Open();
            table.Load(cmd.ExecuteReader());
            conexion.Close();
            return table;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultaSql = "SELECT * FROM Clientes WHERE ape_cliente like '" + txtApeCliente.Text + "%'";

            SqlCommand reporte = new SqlCommand(consultaSql, conexion);
            if (rbtFec.Checked)
            {
                consultaSql += " order by fecha_nac";
            }
            else
                consultaSql += " order by ape_cliente";

            ClientesBindingSource.DataSource = consultar(consultaSql);

            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultaSql = "SELECT ape_cliente, nom_cliente, fecha_nac FROM Clientes";
            SqlCommand reporte2 = new SqlCommand(consultaSql, conexion);
            if (rbtFec.Checked)
            {
                consultaSql += " order by fecha_nac";
            }
            else
                consultaSql += " order by ape_cliente";

            ClientesBindingSource.DataSource = consultar(consultaSql);

            reportViewer1.RefreshReport();
        }

        private void frmReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea volver al menú principal? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}