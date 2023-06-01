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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineStoreMVC_Form.View
{
    public partial class AñadirPedidoView : Form
    {
        PedidoController pedidoController;
        public AñadirPedidoView(object controlador)
        {
            InitializeComponent();
            pedidoController = (PedidoController)controlador;
        }

        private void textBoxemail_TextChanged(object sender, EventArgs e)
        {
            //box email
            string nombre = "";
            this.lbmensajeCliente.Visible = false;
            this.lbmensajeArt.Visible = false;
            nombre = pedidoController.getCliente(this.textBoxemail.Text);
            if (!nombre.Equals(""))
            {
                this.lbmensajeCliente.Text = "El cliente ya existe" + nombre;
                this.lbmensajeCliente.Visible = true;
                this.panel1.Visible = false;
            }
            else
            {
                this.lbmensajeCliente.Visible = false;
                this.panel1.Visible = true;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //box panel
        }

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
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

        private void btaceptaralta_Click(object sender, EventArgs e)
        {
            //boton aceptar alta
            Hashtable clienteHash = new Hashtable();

            if (this.textBoxemail.Text != "" && this.textBoxemail.Text != "")
            {
                clienteHash.Add("Email", this.textBoxemail.Text);
                clienteHash.Add("Nombre", this.textBoxnombre.Text);
                clienteHash.Add("Domicilio", this.textBoxdomicilio.Text);
                clienteHash.Add("Nif", this.textBoxnif.Text);

                pedidoController.añadirClientes2(clienteHash);
                MessageBox.Show("Bienvenido a Online Store, alta cliente realizada con éxito");
            }
            else
            {
                this.lbmensajeCliente.Text = "No hay datos";
                this.lbmensajeCliente.Visible = true;
            }

            borrarDatospanel();
        }

        private void buttonbtcancelatalta_Click(object sender, EventArgs e)
        {
            //boton cancelar alta
            borrarDatospanel();

        }

        private void btSaliralta_Click(object sender, EventArgs e)
        {
            //boton salir alta
            this.Dispose();
        }

        private void textBoxnif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Hashtable clienteHash = new Hashtable();

                if (this.textBoxemail.Text != "" && this.textBoxemail.Text != "")
                {
                    clienteHash.Add("Email", this.textBoxemail.Text);
                    clienteHash.Add("Nombre", this.textBoxnombre.Text);
                    clienteHash.Add("Domicilio", this.textBoxdomicilio.Text);
                    clienteHash.Add("Nif", this.textBoxnif.Text);

                    pedidoController.añadirClientes2(clienteHash);
                    MessageBox.Show("Bienvenido a Online Store, alta cliente realizada con éxito");
                }
                else
                {
                    this.lbmensajeCliente.Text = "No hay datos";
                    this.lbmensajeCliente.Visible = true;
                }

                borrarDatospanel();
            }
        }

        //-------------------------------------------------------------------------------------------------

        private void textBoxcodigoArt_TextChanged(object sender, EventArgs e)
        {
           

        }

        //---------------------------------------------------------------------------------------------------

        private void textBoxNumPedido_TextChanged(object sender, EventArgs e)
        {
            //box numero pedido

        }

        private void textBoxunidades_TextChanged(object sender, EventArgs e)
        {
            //box unidades
        }

        private void textBoxfecha_TextChanged(object sender, EventArgs e)
        {
            //box fecha
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //boton aceptar
            Hashtable pedidoHash = new Hashtable();

            if (this.textBoxNumPedido.Text != "" && this.textBoxNumPedido.Text != "")
            {
                pedidoHash.Add("Numero pedido", this.textBoxNumPedido.Text);
                pedidoHash.Add("Unidades", this.textBoxunidades.Text);
                pedidoHash.Add("Fecha", this.dateTimecalendario.Text);
                pedidoHash.Add("Cliente", this.textBoxemail.Text);
                pedidoHash.Add("Articulo", this.textBoxcodigoArt.Text);

                pedidoController.añadirPedido2(pedidoHash);
                MessageBox.Show("Pedido realizado con éxito");
            }
            else
            {
                MessageBox.Show("Ha sido imposible realizar el pedido");
            }

            borrarDatos();


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //boton cancelar
            borrarDatos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //boton salir
            this.Dispose();
        }

        private void lbmensajeCliente_Click(object sender, EventArgs e)
        {
            //mensaje cliente
        }

        private void lbmensajeArt_Click(object sender, EventArgs e)
        {
            //mensaje articulo
        }

        private void borrarDatos()
        {
            this.textBoxemail.Text = "";
            this.textBoxcodigoArt.Text = "";
            this.textBoxNumPedido.Text = "";
            this.textBoxunidades.Text = "";
            this.dateTimecalendario.Text = "";
            this.lbmensajeArt.Visible = false;
            this.lbmensajeCliente.Visible = false;
        }

        private void borrarDatospanel()
        {
            this.textBoxnombre.Text = "";
            this.textBoxdomicilio.Text = "";
            this.textBoxnif.Text = "";
            this.lbmensajeArt.Visible = false;
            this.lbmensajeCliente.Visible = false;
        }

        private void textBoxcodigoArt_TextChanged_1(object sender, EventArgs e)
        {
            if (!this.textBoxcodigoArt.Text.Equals("")) //si esta vacio 
            {
                string descripcion = "";
                this.lbmensajeArt.Visible = false;
                descripcion = pedidoController.getArticulo(textBoxcodigoArt.Text);
                if (!descripcion.Equals(""))
                {
                    this.lbmensajeArt.Text = "Artículo ya existente\t" + descripcion;
                    this.lbmensajeArt.Visible = true;
                    int numPedido = pedidoController.newPedido();
                    this.textBoxNumPedido.Text = numPedido.ToString();
                }
                else
                {
                    MessageBox.Show("Artículo no existe no se puede hacer pedido");
                    borrarDatos();
                }
            } 
        }

        private void AñadirPedidoView_Load(object sender, EventArgs e)
        {
            this.textBoxNumPedido.Enabled = true;
        }

        private void dateTimecalendario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(e.KeyChar))
            {
                Hashtable pedidoHash = new Hashtable();

                if (this.textBoxNumPedido.Text != "" && this.textBoxNumPedido.Text != "")
                {
                    pedidoHash.Add("Numero pedido", this.textBoxNumPedido.Text);
                    pedidoHash.Add("Unidades", this.textBoxunidades.Text);
                    pedidoHash.Add("Fecha", this.dateTimecalendario.Text);
                    pedidoHash.Add("Cliente", this.textBoxemail.Text);
                    pedidoHash.Add("Articulo", this.textBoxcodigoArt.Text);

                    pedidoController.añadirPedido2(pedidoHash);
                    MessageBox.Show("Pedido realizado con éxito");
                }
                else
                {
                    MessageBox.Show("Ha sido imposible realizar el pedido");
                }

                borrarDatos();
            }
        }
    }
}
