using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TP_LAB
{
    public partial class frmVehiculos : Form
    {
        private Vehiculos v = new Vehiculos();
        private int c;

        private Vehiculos[] arrayVehiculo = new Vehiculos[300];

        private string consultaSql = "";

        private bool nuevoVehiculo;

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-EN4EVL9; database=FABRICA_AUTOMOTRIZ ; integrated security = true");

        private SqlDataAdapter adp = new SqlDataAdapter();

        public frmVehiculos()
        {
            InitializeComponent();

            for (int i = 0; i < arrayVehiculo.Length; i++)
            {
                arrayVehiculo[i] = null;
            }
            nuevoVehiculo = false;

            var colores = new List<string>();
            colores.Add("Rojo");
            colores.Add("Blanco");
            colores.Add("Plateado");
            colores.Add("Verde");
            colores.Add("Negro");
            colores.Add("Azul");
            colores.Add("Gris");

            cboColor.DataSource = colores;

            var tiposV = new List<string>();
            tiposV.Add("Sedan");
            tiposV.Add("Deportivo");
            tiposV.Add("Camioneta");
            tiposV.Add("Pick Up");

            cboTipoV.DataSource = tiposV;
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            cboColor.SelectedIndex = -1;
            cboTipoV.SelectedIndex = -1;

            cargarLst("Vehiculos_Terminados", "id_vehiculo");
            habilitar(false);
        }

        private void frmVehiculo_FormClosing(object sender, FormClosingEventArgs e)
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
                Vehiculos v = new Vehiculos();
                if (!dreader.IsDBNull(0)) v.pId = dreader.GetInt32(0);
                if (!dreader.IsDBNull(1)) v.pNombre = dreader.GetString(1);
                if (!dreader.IsDBNull(2)) v.pColor = dreader.GetString(2);
                if (!dreader.IsDBNull(3)) v.pTipo = dreader.GetString(3);
                if (!dreader.IsDBNull(4)) v.pPrecio = dreader.GetInt32(4);

                arrayVehiculo[c] = v;
                c++;
            }

            conexion.Close();

            limpiarCampos();

            for (int i = 0; i < c; i++)
            {
                lstVehiculos.Items.Add(arrayVehiculo[i].toString());
            }
            lstVehiculos.ValueMember = pk;
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
            txtId.Text = arrayVehiculo[posicion].pId.ToString();
            txtNombreV.Text = arrayVehiculo[posicion].pNombre;
            cboColor.Text = arrayVehiculo[posicion].pColor;
            cboTipoV.Text = arrayVehiculo[posicion].pTipo;
            txtPrecioV.Text = arrayVehiculo[posicion].pPrecio.ToString();
        }

        private void limpiarCampos()
        {
            txtId.Clear();
            txtNombreV.Clear();
            txtPrecioV.Clear();
            cboColor.SelectedIndex = -1;
            cboTipoV.SelectedIndex = -1;
            this.lstVehiculos.Items.Clear();
        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstVehiculos.SelectedIndex);
        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtNombreV.Text))
            {
                MessageBox.Show("Debe ingresar el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreV.Focus();
                return false;
            }
            if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboColor.Focus();
                return false;
            }
            if (cboTipoV.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el Tipo de Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecioV.Text))
            {
                MessageBox.Show("Debe ingresar el Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioV.Focus();
                return false;
            }
            return true;
        }

        private bool existe(int pk)
        {
            bool siExiste = false;
            for (int i = 0; i < c; i++)
            {
                if (arrayVehiculo[i].pId == pk)
                {
                    MessageBox.Show("No se puede ingresar el mismo vehículo 2 veces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    siExiste = true;
                }
            }
            return siExiste;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (nuevoVehiculo)
                {
                    Vehiculos n = new Vehiculos();
                    n.pNombre = txtNombreV.Text;
                    n.pColor = cboColor.SelectedValue.ToString();
                    n.pTipo = cboTipoV.SelectedValue.ToString();
                    n.pPrecio = Convert.ToInt32(txtPrecioV.Text);
                    if (!existe(n.pId))
                    {
                        consultaSql = "INSERT INTO Vehiculos_Terminados (nombre, color, tipoV, precio) " +
                                       "VALUES ('" + n.pNombre + "' , '" +
                                                    n.pColor + "' , '" +
                                                    n.pTipo + "' , " +
                                                    n.pPrecio + ")";
                        SqlCommand registrar = new SqlCommand(consultaSql, conexion);
                        actualizarTabla(consultaSql);

                        MessageBox.Show("Se ha registrado con éxito", "Registro", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    int i = lstVehiculos.SelectedIndex;
                    arrayVehiculo[i].pNombre = txtNombreV.Text;
                    arrayVehiculo[i].pColor = cboColor.SelectedValue.ToString();
                    arrayVehiculo[i].pTipo = cboTipoV.SelectedValue.ToString();
                    arrayVehiculo[i].pPrecio = Convert.ToInt32(txtPrecioV.Text);

                    //update
                    consultaSql = "UPDATE Vehiculos_Terminados SET nombre = '" + arrayVehiculo[i].pNombre + "' , " +
                                                       "color = '" + arrayVehiculo[i].pColor + "' , " +
                                                 "tipoV = '" + arrayVehiculo[i].pTipo + "' , " +
                                              "precio = " + arrayVehiculo[i].pPrecio +
                                               " WHERE id_vehiculo = " + arrayVehiculo[i].pId;
                    SqlCommand actualizar = new SqlCommand(consultaSql, conexion);
                    actualizarTabla(consultaSql);

                    MessageBox.Show("Se ha actualizado con éxito", "Actualización", MessageBoxButtons.OK);
                }
                limpiarCampos();
                cargarLst("Vehiculos_Terminados", "id_vehiculo");
            }
            nuevoVehiculo = false;
            habilitar(false);
        }

        private void nuevaAutoparteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutopartes frmA = new frmAutopartes();
            frmA.ShowDialog();
        }

        private void habilitar(bool x)
        {
            txtId.Enabled = x;
            txtNombreV.Enabled = x;
            txtPrecioV.Enabled = x;
            cboTipoV.Enabled = x;
            cboColor.Enabled = x;
            btnRegistrar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            lstVehiculos.Enabled = !x;
            btnCancelar.Enabled = x;
            btnBorrar.Enabled = !x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevoVehiculo = true;
            habilitar(true);
            txtId.Enabled = false;
            limpiarCampos();
            txtNombreV.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtId.Enabled = false;
            txtNombreV.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar este vehículo?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //DELETE
                string consultaSql = "DELETE FROM Vehiculos_Terminados WHERE id_vehiculo = " +
                                      arrayVehiculo[lstVehiculos.SelectedIndex].pId;

                SqlCommand borrar = new SqlCommand(consultaSql, conexion);
                actualizarTabla(consultaSql);
                limpiarCampos();
            }
            cargarLst("Vehiculos_Terminados", "id_vehiculo");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            limpiarCampos();
            lstVehiculos.Enabled = true;
            nuevoVehiculo = false;
            cargarLst("Vehiculos_Terminados", "id_vehiculo");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Arias, Franco \n Conforte, Facundo \n Miskowski, Santiago \n Lopez Scidá, Bruno", "Sobre Nosotros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}