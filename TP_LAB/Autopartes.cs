using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LAB
{
    internal class Autopartes
    {
        private int id_Autoparte;
        private string nombreA;
        private string tipoA;
        private int precio;
        private int stock_min;
        private int stock_act;

        public Autopartes()
        {
            id_Autoparte = 0;
            nombreA = "";
            tipoA = "";
            precio = 0;
            stock_min = 0;
            stock_act = 0;
        }

        public Autopartes(int id_Autoparte, string nombreA, string tipoA, int precio, int stock_min, int stock_act)
        {
            this.id_Autoparte = id_Autoparte;
            this.nombreA = nombreA;
            this.tipoA = tipoA;
            this.precio = precio;
            this.stock_min = stock_min;
            this.stock_act = stock_act;
        }

        public int pId_Autoparte { set { id_Autoparte = value; } get { return id_Autoparte; } }
        public string pNombreA { set { nombreA = value; } get { return nombreA; } }
        public string pTipoA { set { tipoA = value; } get { return tipoA; } }
        public int pPrecioA { set { precio = value; } get { return precio; } }
        public int pStockMin { set { stock_min = value; } get { return stock_min; } }
        public int pStockAct { set { stock_act = value; } get { return stock_act; } }

        public string toString()
        {
            return id_Autoparte + " / " + nombreA + " / " + tipoA + " / " + precio + " / " + stock_min + " / " + stock_act;
        }
    }
}