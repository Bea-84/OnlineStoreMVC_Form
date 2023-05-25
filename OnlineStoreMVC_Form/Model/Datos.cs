using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreMVC_Form.Model
{
    internal class Datos
    {
        private List<Articulo> articulos;
        private List<Cliente> clientes;
        private List<Pedido> pedidos;

        public Datos()
        {
            articulos = new List<Articulo>(); 
            clientes = new List<Cliente>();
            pedidos = new List<Pedido>();
        }

        //métodos artículos 

        public string getDescripcionArticulo(string codigo)
        {
            foreach (Articulo articulo in articulos)
            {
                if (articulo.Codigo.Equals(codigo))
                {
                    return articulo.Descripcion;
                }
            }
            return "";
        }

        public void addArticulo(Hashtable articuloHash) 
        {
            Articulo articulo = new Articulo();
            articulo.Codigo = (string)articuloHash["Codigo"];
            articulo.Descripcion = (string)articuloHash["Descripcion"];
            articulo.Precio = double.Parse((string)articuloHash["Precio"]);
            articulo.Gastos_envio = double.Parse((string)articuloHash["Gastos"]);
            articulo.FechaEntrega = DateTime.Parse((string)articuloHash["Tiempo"]); 

            articulos.Add(articulo);
        }

        public List<string> listaArticulos()
        {
            List<string> listaArticulos = new List<string>();

            foreach (Articulo articulo in articulos)
            {
                listaArticulos.Add(articulo.ToString());
            }
            return listaArticulos;  
        }

        //---------------------------------------------------------------------------------------------------

        //métodos clientes

        public string getNombreClienteByEmail(string email)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Email.Equals(email))
                {
                    return cliente.Nombre;
                }
            }
            return "";
        }

        public void addCliente(Hashtable clienteHash) 
        {
            Cliente cliente = new Cliente();
            cliente.Email = (string)clienteHash["Email"]; 
            cliente.Nombre = (string)clienteHash["Nombre"];
            cliente.Domicilio = (string)clienteHash["Direccion"];
            cliente.Nif = int.Parse((string)clienteHash["Nif"]); 
           

            clientes.Add(cliente);
        }

        public List<string> getlistaClientes()
        {
            List<string> listaClientes = new List<string>();

            foreach (Cliente cliente in clientes)
            {
               
               listaClientes.Add(cliente.ToString());
                
            }
            return listaClientes;
        }  

        //---------------------------------------------------------------------------------------------------

        //métodos pedidos


        private static int numPedido = 0; //declaro variable

        public int getNewNumPedido() //método genera numero pedido
        {
            numPedido++;
            return numPedido;
        }

        public void addPedido(Hashtable pedidoHash)
        {
            Pedido pedido = new Pedido();
            pedido.Num_Pedido = int.Parse((string)pedidoHash["Numero pedido"]);
            pedido.Unidad = int.Parse((string)pedidoHash["Unidades"]);
            pedido.FechaPedido= DateTime.Parse((string)pedidoHash["Fecha"]); 

            string email = (string)pedidoHash["Cliente"];
            Cliente cliente = getClienteObjectByEmail(email);
            pedido.Cliente = cliente;

            string codigo = (string)pedidoHash["Articulo"];
            Articulo articulo = getArticuloObjetoByCodigo(codigo);
            pedido.Articulo = articulo;

            pedidos.Add(pedido);
        }

        public Cliente getClienteObjectByEmail(string email)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Email.Equals(email))
                {
                    return cliente;
                }
            }
            return null;

        }

        public Articulo getArticuloObjetoByCodigo(string codigo)
        {
            foreach (Articulo articulo in articulos)
            {
                if (articulo.Codigo.Equals(codigo))
                {
                    return articulo;
                }
            }
            return null;

        } 

        public List<string> getListaPedidos()
        {
            List<string> listaPedidos = new List<string>();

            foreach(Pedido pedido in pedidos)
            {
                listaPedidos.Add(pedido.ToString());
            }
            return listaPedidos;
        }

        public List<string>getlistaPedidos(string mail)
        {
            List<string>listaPedidos=new List<string>();

            foreach(Pedido pedido in pedidos)
            {
                if(pedido.Cliente.Email.Equals(mail))
                {
                    listaPedidos.Add(pedido.ToString());   
                }
            }
            return listaPedidos ;
        } 

     

  

    
    }
}
