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
    public partial class frmAutopartes : Form
    {
        private Autopartes a = new Autopartes();

        private int c;

        private Autopartes[] arrayAutopartes = new Autopartes[300];

        private string consultaSql = "";

        private bool nuevaAutoparte;

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-EN4EVL9; database=FABRICA_AUTOMOTRIZ ; integrated security = true");

        private SqlDataAdapter adp = new SqlDataAdapter();

        public frmAutopartes()
        {
            InitializeComponent();

            for (int i = 0; i < arrayAutopartes.Length; i++)
            {
                arrayAutopartes[i] = null;
            }
            nuevaAutoparte = false;

            var tipoA = new List<string>();
            tipoA.Add("OEM");
            tipoA.Add("Certificado");

            cboTipoA.DataSource = tipoA;
        }

        private void frmAutopartes_Load(object sender, EventArgs e)
        {
            cboTipoA.SelectedIndex = -1;

            cargarLst("Autopartes", "id_Autoparte");

            habilitar(false);
        }

        private void frmAutopartes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea volver al menú principal? ", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void cargarLst(string nombreTabla, string pk)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + nombreTabla, conexion);
            conexion.Open();
            SqlDataReader dreader;
            dreader = cmd.ExecuteReader();
            c = 0;

            while (dreader.Read())
            {
                Autopartes a = new Autopartes();
                if (!dreader.IsDBNull(0)) a.pId_Autoparte = dreader.GetInt32(0);
                if (!dreader.IsDBNull(1)) a.pNombreA = dreader.GetString(1);
                if (!dreader.IsDBNull(2)) a.pTipoA = dreader.GetString(2);
                if (!dreader.IsDBNull(3)) a.pPrecioA = dreader.GetInt32(3);
                if (!dreader.IsDBNull(4)) a.pStockMin = dreader.GetInt32(4);
                if (!dreader.IsDBNull(5)) a.pStockAct = dreader.GetInt32(5);

                arrayAutopartes[c] = a;
                c++;
            }

            conexion.Close();

            limpiarCampos();

            for (int i = 0; i < c; i++)
            {
                lstAutopartes.Items.Add(arrayAutopartes[i].toString());
            }
            lstAutopartes.ValueMember = pk;
        }

        private void actualizarTabla(string consultaSql)
        {
            SqlCommand cmd = new SqlCommand(consultaSql, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void cargarCampos(int posicion)
        {
            txtIdA.Text = arrayAutopartes[posicion].pId_Autoparte.ToString();
            txtNombreA.Text = arrayAutopartes[posicion].pNombreA;
            cboTipoA.Text = arrayAutopartes[posicion].pTipoA;
            txtPrecioA.Text = arrayAutopartes[posicion].pPrecioA.ToString();
            txtStockMin.Text = arrayAutopartes[posicion].pStockMin.ToString();
            txtStockActual.Text = arrayAutopartes[posicion].pStockAct.ToString();
        }

        private void limpiarCampos()
        {
            txtIdA.Clear();
            txtNombreA.Clear();
            cboTipoA.SelectedIndex = -1;
            txtPrecioA.Clear();
            txtStockMin.Clear();
            txtStockActual.Clear();
            this.lstAutopartes.Items.Clear();
        }

        private void lstAutopartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstAutopartes.SelectedIndex);
        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtNombreA.Text))
            {
                MessageBox.Show("Debe ingresar el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreA.Focus();
                return false;
            }
            if (cboTipoA.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el Tipo de Autoparte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoA.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecioA.Text))
            {
                MessageBox.Show("Debe ingresar el Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioA.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStockMin.Text))
            {
                MessageBox.Show("Debe ingresar el Stock Mínimo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockMin.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStockActual.Text))
            {
                MessageBox.Show("Debe ingresar el Stock Actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockActual.Focus();
                return false;
            }
            return true;
        }

        private bool existe(int pk)
        {
            bool siExiste = false;
            for (int i = 0; i < c; i++)
            {
                if (arrayAutopartes[i].pId_Autoparte == pk)
                {
                    MessageBox.Show("No se puede ingresar la misma autoparte 2 veces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    siExiste = true;
                }
            }
            return siExiste;
        }

        private void btnConfirmarAP_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (nuevaAutoparte)
                {
                    Autopartes n = new Autopartes();
                    n.pNombreA = txtNombreA.Text;
                    n.pTipoA = cboTipoA.SelectedValue.ToString();
                    n.pPrecioA = Convert.ToInt32(txtPrecioA.Text);
                    n.pStockMin = Convert.ToInt32(txtStockMin.Text);
                    n.pStockAct = Convert.ToInt32(txtStockActual.Text);
                    if (!existe(n.pId_Autoparte))
                    {
                        consultaSql = "INSERT INTO Autopartes (nombre, tipoA, precio, stock_minimo, stock_actual) " +
                                       "VALUES (" + " '" + n.pNombreA + "' , '" +
                                                    n.pTipoA + "' , " +
                                                    n.pPrecioA + " , " +
                                                    n.pStockMin + " , " +
                                                    n.pStockAct + ")";
                        SqlCommand registrar = new SqlCommand(consultaSql, conexion);
                        actualizarTabla(consultaSql);

                        MessageBox.Show("Se ha registrado con éxito", "Registro", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    int i = lstAutopartes.SelectedIndex;
                    arrayAutopartes[i].pNombreA = txtNombreA.Text;
                    arrayAutopartes[i].pTipoA = cboTipoA.SelectedValue.ToString();
                    arrayAutopartes[i].pPrecioA = Convert.ToInt32(txtPrecioA.Text);
                    arrayAutopartes[i].pStockMin = Convert.ToInt32(txtStockMin.Text);
                    arrayAutopartes[i].pStockAct = Convert.ToInt32(txtStockActual.Text);

                    //update
                    consultaSql = "UPDATE Autopartes SET nombre = '" + arrayAutopartes[i].pNombreA + "' , " +
                                                         "tipoA = '" + arrayAutopartes[i].pTipoA + "' , " +
                                                         "precio = " + arrayAutopartes[i].pPrecioA + " , " +
                                                   "stock_minimo = " + arrayAutopartes[i].pStockMin + " , " +
                                                   "stock_actual = " + arrayAutopartes[i].pStockAct +
                                            " WHERE id_Autoparte = " + arrayAutopartes[i].pId_Autoparte;
                    SqlCommand actualizar = new SqlCommand(consultaSql, conexion);
                    actualizarTabla(consultaSql);

                    MessageBox.Show("Se ha actualizado con éxito", "Actualización", MessageBoxButtons.OK);
                }
                limpiarCampos();
                cargarLst("Autopartes", "id_Autoparte");
            }
            nuevaAutoparte = false;
            habilitar(false);
        }

        private void nuevoVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculos frmV = new frmVehiculos();
            frmV.ShowDialog();
        }

        private void habilitar(bool x)
        {
            txtNombreA.Enabled = x;
            txtPrecioA.Enabled = x;
            txtIdA.Enabled = x;
            cboTipoA.Enabled = x;
            txtStockActual.Enabled = x;
            txtStockMin.Enabled = x;
            btnConfirmarAP.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            lstAutopartes.Enabled = !x;
            btnCancelar.Enabled = x;
            btnBorrar.Enabled = !x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevaAutoparte = true;
            habilitar(true);
            txtIdA.Enabled = false;
            limpiarCampos();
            txtNombreA.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtIdA.Enabled = false;
            txtNombreA.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar esta autoparte?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //DELETE
                string consultaSql = "DELETE FROM Autopartes WHERE id_Autoparte = " +
                                      arrayAutopartes[lstAutopartes.SelectedIndex].pId_Autoparte;

                SqlCommand borrar = new SqlCommand(consultaSql, conexion);
                actualizarTabla(consultaSql);
                limpiarCampos();
            }
            cargarLst("Autopartes", "id_Autoparte");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            limpiarCampos();
            nuevaAutoparte = false;
            lstAutopartes.Enabled = true;
            cargarLst("Autopartes", "id_Autoparte");
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Arias, Franco \n Conforte, Facundo \n Miskowski, Santiago \n Lopez Scidá, Bruno", "Sobre Nosotros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}