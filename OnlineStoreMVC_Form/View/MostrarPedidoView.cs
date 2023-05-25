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
    public partial class MostrarPedidoView : Form
    {
        PedidoController pedidoController;
        public MostrarPedidoView(object controlador)
        {
            InitializeComponent();
            pedidoController = (PedidoController)controlador;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //botón buscar
            String nombre = pedidoController.getCliente(this.textBoxmail.Text);
            if (nombre.Equals(""))
            {
                MessageBox.Show("El cliente no existe");
            }
            else
            {
                List<string> lista = pedidoController.getPedido(textBoxmail.Text);
                this.listBox1.DataSource = lista; 
            }

            borrarDatos();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list box
            List<string> lista = pedidoController.getlistaPedidos(); 
        }

        private void borrarDatos()
        {
            this.textBoxmail.Text = "";
        }
    }
}
