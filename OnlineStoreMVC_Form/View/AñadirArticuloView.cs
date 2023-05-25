using OnlineStoreMVC_Form.Controller;
using System;
using System.Collections;
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
    public partial class AñadirArticuloView : Form
    {

        ArticuloController articuloController;
        public AñadirArticuloView(object controlador)
        {
            InitializeComponent();
            articuloController=(ArticuloController)controlador; 
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }

        private void textBoxcodigo_TextChanged(object sender, EventArgs e)
        {
            //text box código

            string descripcion = "";
            this.lbMensaje.Visible = false; 
            descripcion = articuloController.getArticulo(textBoxcodigo.Text);
            if(!descripcion.Equals(""))
            {
                this.lbMensaje.Text="Artículo ya existente\t"+descripcion; 
                this.lbMensaje.Visible = true;
                this.panelarticulo.Visible = false;
            }
            else
            {
                this.panelarticulo.Visible = true;
            }
             
        }

        private void panelarticulo_Paint(object sender, PaintEventArgs e)
        {
            //panel artículo
        }

        private void textBoxdescripcion_TextChanged(object sender, EventArgs e)
        {
            //text box descripción
        }

        private void textBoxprecio_TextChanged(object sender, EventArgs e)
        {
            //text box precio
        }

        private void textBoxgastos_TextChanged(object sender, EventArgs e)
        {
            //text box gastos
        }

        private void textBoxtiempo_TextChanged(object sender, EventArgs e)
        {
            //text box tiempo
        }

        private void lbMensaje_Click(object sender, EventArgs e)
        {
            //mensaje 
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //botón aceptar
            Hashtable articuloHash=new Hashtable();
            if(this.textBoxcodigo.Text != "" && this.textBoxcodigo.Text != "")
            {
                articuloHash.Add("Codigo",this.textBoxcodigo.Text);
                articuloHash.Add("Descripcion",this.textBoxdescripcion.Text);
                articuloHash.Add("Precio",this.textBoxprecio.Text);
                articuloHash.Add("Gastos",this.textBoxgastos.Text);
                articuloHash.Add("Tiempo", this.dateTimecalendario.Text); 
                articuloController.añadirArticulo(articuloHash);
                MessageBox.Show("Artículo añadido con éxito");
            }
            else
            {
                this.lbMensaje.Text = "No hay datos";
                this.lbMensaje.Visible = true;
            }

            borrarDatos();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //botón cancelar
            borrarDatos();
        }

        private void borrarDatos()
        {
            this.textBoxcodigo.Text = "";
            this.textBoxdescripcion.Text = "";
            this.textBoxprecio.Text = "";
            this.textBoxgastos.Text = "";
            this.dateTimecalendario.Text = "";
            this.lbMensaje.Visible=false; 
        }

      
    }
}
