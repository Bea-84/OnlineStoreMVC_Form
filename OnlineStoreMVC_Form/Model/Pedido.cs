using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreMVC_Form.Model
{
    internal class Pedido
    {
        private int num_Pedido;
        private int unidad;
        private DateTime fechaPedido;
        private Cliente cliente;
        private Articulo articulo;

        public int Num_Pedido { get => num_Pedido; set => num_Pedido = value; }
        public int Unidad { get => unidad; set => unidad = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; } 
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Articulo Articulo { get => articulo; set => articulo = value; }

        public override string ToString()
        {
            return num_Pedido + "\t" + unidad + "\t" + fechaPedido + "\t" + cliente + "\t" + articulo;
        } 
    }
}
