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
    public partial class MostrarArticuloView : Form
    {

        ArticuloController articuloController;
        public MostrarArticuloView(object controlador)
        {
            InitializeComponent();
            articuloController=(ArticuloController)controlador;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list box
            List<string> lista = articuloController.getlistaArticulos();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //boton buscar 
            String descripcion = articuloController.getArticulo(this.textBoxcodigoArt.Text);
            if (descripcion.Equals(""))
            {
                MessageBox.Show("El artículo no existe");
            }
            else
            {
                this.listBox1.Items.Add("La descripción del artículo es:" + ""+descripcion);
            }

            borrarDatos(); 
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //boton salir 
            this.Dispose();
        }

        private void borrarDatos()
        {
            this.textBoxcodigoArt.Text = "";
        }

      
    }
}
