using OnlineStoreMVC_Form.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStoreMVC_Form.View
{
    public partial class MenuView : Form
    {
        MenuController menuController;
        public MenuView(object controlador)
        {
            InitializeComponent();
            menuController=(MenuController)controlador;
        }

        private void btAñadirArt_Click(object sender, EventArgs e)
        {
            //boton añadir artículo
            menuController.añadirArticulo();
        }

        private void btMostrarArt_Click(object sender, EventArgs e)
        {
            //botón mostrar artículo
            menuController.mostrarArticulo();
        }

        private void btAñadirClie_Click(object sender, EventArgs e)
        {
            //botón añadir cliente
            menuController.añadirCliente();
        }

        private void btMostrarClien_Click(object sender, EventArgs e)
        {
            //botón mostrar cliente
            menuController.mostrarCliente();
        }

        private void btAñadirPed_Click(object sender, EventArgs e)
        {
            //botón añadir pedido
            menuController.añadirPedido();
        }

        private void btMostrarPed_Click(object sender, EventArgs e)
        {
            //botón mostrar pedido
            menuController.mostrarPedido();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }
    }
}
