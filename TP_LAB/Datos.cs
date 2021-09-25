using System.Data;
using System.Data.SqlClient;

namespace TP_LAB
{
    internal class Datos
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dreader;
        private string cadenaCnn;

        public Datos()
        {
            cnn = new SqlConnection();
            cmd = new SqlCommand();
        }

        public Datos(string cadenaConexion)
        {
            cnn = new SqlConnection();
            cmd = new SqlCommand();
            cnn.ConnectionString = cadenaConexion;
        }

        public string pCadenaCnn
        {
            set { cadenaCnn = value; }
            get { return cadenaCnn; }
        }

        public SqlDataReader pDreader
        {
            set { dreader = value; }
            get { return dreader; }
        }

        public void conectar()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
        }

        public void desconectar()
        {
            cnn.Close();
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            conectar();

            cmd.CommandText = "SELECT * FROM " + nombreTabla;

            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());

            desconectar();
            return table;
        }

        public void leerTabla(string nombreTabla)
        {
            conectar();
            cmd.CommandText = "SELECT * FROM " + nombreTabla;
            dreader = cmd.ExecuteReader();
        }

        public void actualizarTabla(string consultaSQL)
        {
            conectar();
            cmd.CommandText = consultaSQL;
            cmd.ExecuteNonQuery();
            desconectar();
        }
    }
}