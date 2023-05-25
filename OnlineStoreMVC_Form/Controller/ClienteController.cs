using OnlineStoreMVC_Form.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreMVC_Form.Controller
{
    internal class ClienteController
    {
        Datos datos;

        public ClienteController(Datos pDatos)
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

        public List<string> getlistaClientes()
        {
            return datos.getlistaClientes();
        }
    } 
}
