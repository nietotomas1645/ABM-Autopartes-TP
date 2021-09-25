namespace TP_LAB
{
    internal class Vehiculos
    {
        private int id;
        private string nombre;
        private string color;
        private string tipo;
        private int precio;

        public Vehiculos()
        {
            id = 0;
            nombre = "";
            color = "";
            tipo = "";
            precio = 0;
        }

        public Vehiculos(int id, string nombre, string color, string tipo, int precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.color = color;
            this.tipo = tipo;
            this.precio = precio;
        }

        public int pId { set { id = value; } get { return id; } }

        public string pNombre { set { nombre = value; } get { return nombre; } }

        public string pColor { set { color = value; } get { return color; } }

        public string pTipo { set { tipo = value; } get { return tipo; } }

        public int pPrecio { set { precio = value; } get { return precio; } }

        public string toString()
        {
            return id + " / " + nombre + " / " + color + " / " + tipo + " / " + precio;
        }
    }
}