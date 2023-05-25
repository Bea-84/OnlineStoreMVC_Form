using OnlineStoreMVC_Form.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreMVC_Form.Controller
{
    internal class PedidoController
    {
        Datos datos;

        public PedidoController(Datos pDatos)
        {
            datos = pDatos; 
        }

        public string getCliente(string email)
        {
            string nombre = datos.getNombreClienteByEmail(email);
            return nombre;
        }

        public void añadirClientes2(Hashtable clienteHash)
        {
            datos.addCliente(clienteHash);
        }

        public string getArticulo(string codigo)
        {
            string descrip_Articulo = datos.getDescripcionArticulo(codigo);
            return descrip_Articulo;
        }

        public int newPedido() //método para nuevo numero inscripción
        {
            int newInscripcion = datos.getNewNumPedido();
            return newInscripcion;
        }

        public void añadirPedido2(Hashtable pedidoHash)
        {
            datos.addPedido(pedidoHash);
        }

        public List<string> getlistaPedidos()
        {
            return datos.getListaPedidos();
        }

        public List<string>getPedido(string mail)
        {
            return datos.getlistaPedidos(mail);
        }

       




    }
}
