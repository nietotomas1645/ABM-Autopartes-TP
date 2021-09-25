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
    public partial class frmReportes2 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-EN4EVL9; database=FABRICA_AUTOMOTRIZ ; integrated security = true");
        private string consultaSql = "";

        public frmReportes2()
        {
            InitializeComponent();
        }

        private void frmReportes2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'FABRICA_AUTOMOTRIZDataSet.Vehiculos_Terminados' Puede moverla o quitarla según sea necesario.
            //this.Vehiculos_TerminadosTableAdapter.Fill(this.FABRICA_AUTOMOTRIZDataSet.Vehiculos_Terminados);

            //this.reportViewer1.RefreshReport();
        }

        private void frmReportes2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea volver al menú principal? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
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

        private void btnTodos_Click(object sender, EventArgs e)
        {
            consultaSql = "SELECT * FROM Vehiculos_Terminados";
            SqlCommand reporte = new SqlCommand(consultaSql, conexion);

            Vehiculos_TerminadosBindingSource.DataSource = consultar(consultaSql);

            reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultaSql = "SELECT * FROM Vehiculos_Terminados WHERE precio between " + txtParam1.Text + " and " + txtParam2.Text;
            SqlCommand reporte2 = new SqlCommand(consultaSql, conexion);

            Vehiculos_TerminadosBindingSource.DataSource = consultar(consultaSql);

            reportViewer1.RefreshReport();
        }
    }
}