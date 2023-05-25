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
    public partial class MostrarClienteView : Form
    {

        ClienteController clienteController;
        public MostrarClienteView(object controlador)
        {
            InitializeComponent();
            clienteController=(ClienteController)controlador;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list box
            List<string> lista = clienteController.getlistaClientes(); 
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //botón buscar
            String nombre = clienteController.getCliente(this.textBoxmail.Text);
            if (nombre.Equals(""))
            {
                MessageBox.Show("El cliente no existe");
            }
            else
            {
                this.listBox1.Items.Add("El nombre del cliente es:" + "" + nombre);
            }

            borrarDatos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }

        private void borrarDatos()
        {
            this.textBoxmail.Text = "";
        }
    }
}
