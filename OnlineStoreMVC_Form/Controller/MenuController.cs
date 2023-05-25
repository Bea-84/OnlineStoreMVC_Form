using OnlineStoreMVC_Form.Model;
using OnlineStoreMVC_Form.View;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreMVC_Form.Controller
{
    internal class MenuController
    {
        public Datos datos;

        public MenuController(Datos pDatos)
        {
            datos = pDatos;
        }

        //métodos menú

        public void añadirArticulo()
        {
            ArticuloController articuloController=new ArticuloController(datos);

            AñadirArticuloView añadirArticuloView=new AñadirArticuloView(articuloController);
            
            añadirArticuloView.Show();  
        }

        public void mostrarArticulo()
        {
            ArticuloController articuloController=new ArticuloController(datos);

            MostrarArticuloView mostrarArticuloView = new MostrarArticuloView(articuloController);  

            mostrarArticuloView.Show();
        }

        //---------------------------------------------------------------------------------------------------

        public void añadirCliente()
        {
            ClienteController clienteController=new ClienteController(datos);

            AñadirClienteView añadirClienteView=new AñadirClienteView(clienteController);

            añadirClienteView.Show();
        }

        public void mostrarCliente()
        {
            ClienteController clienteController= new ClienteController(datos);  

            MostrarClienteView mostrarClienteView=new MostrarClienteView(clienteController);

            mostrarClienteView.Show();
        }

        //-----------------------------------------------------------------------------------------------------

        public void añadirPedido()
        {
            PedidoController pedidoController=new PedidoController(datos);  

            AñadirPedidoView añadirPedidoView=new AñadirPedidoView(pedidoController);

            añadirPedidoView.Show();
        }

        public void mostrarPedido()
        {
            PedidoController pedidoController = new PedidoController(datos);

            MostrarPedidoView mostrarPedidoView = new MostrarPedidoView(pedidoController);

            mostrarPedidoView.Show();

        }  
    }
}
