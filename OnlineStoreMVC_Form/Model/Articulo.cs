using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreMVC_Form.Model
{
    internal class Articulo
    {
        private string codigo;
        private string descripcion;
        private double precio;
        private double gastos_envio;
        private DateTime fechaEntrega;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Gastos_envio { get => gastos_envio; set => gastos_envio = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }

        public override string ToString()
        {
            return codigo + "\t" + descripcion + "\t" + precio + "\t" + gastos_envio + "\t" + fechaEntrega;
        } 
    }
}
