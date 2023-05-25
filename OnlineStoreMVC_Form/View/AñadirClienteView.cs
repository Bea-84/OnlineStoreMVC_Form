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
    public partial class AñadirClienteView : Form
    {

        ClienteController clienteController;
        public AñadirClienteView(object controlador)
        {
            InitializeComponent();
            clienteController=(ClienteController)controlador;  
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            //box nombre
        }

        private void textBoxdomicilio_TextChanged(object sender, EventArgs e)
        {
            //box domicilio
        }

        private void textBoxnif_TextChanged(object sender, EventArgs e)
        {
            //box nif
        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {
            //box email
            string nombre = "";
            this.lbMensaje.Visible = false;
            nombre = clienteController.getCliente(this.textBoxemail.Text);
            if(!nombre.Equals(""))
            {
                this.lbMensaje.Text = "El cliente ya existe\t" + nombre;
                this.lbMensaje.Visible = true;
                this.panel1.Visible = false;    
            }
            else
            {
                this.panel1.Visible = true;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //botón aceptar
            Hashtable clienteHash=new Hashtable();

            if(this.textBoxemail.Text != "" && this.textBoxemail.Text != "")
            {
                clienteHash.Add("Email",this.textBoxemail.Text);
                clienteHash.Add("Nombre", this.textBoxNombre.Text);
                clienteHash.Add("Domicilio", this.textBoxdomicilio.Text);
                clienteHash.Add("Nif", this.textBoxnif.Text);

                clienteController.añadirClientes2(clienteHash);

                MessageBox.Show("Bienvenido a Online Store, alta cliente realizada con éxito"); 
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

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }

        private void lbMensaje_Click(object sender, EventArgs e)
        {
            //mensaje 
        }

        private void borrarDatos()
        {
            this.textBoxemail.Text = "";
            this.textBoxNombre.Text = "";
            this.textBoxdomicilio.Text = "";
            this.textBoxnif.Text = "";
            this.lbMensaje.Visible = false;
        }
    }
}
