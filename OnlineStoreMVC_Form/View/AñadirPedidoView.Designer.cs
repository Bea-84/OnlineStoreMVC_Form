namespace OnlineStoreMVC_Form.View
{
    partial class AñadirPedidoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAñadirPedido = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.lbmensajeCliente = new System.Windows.Forms.Label();
            this.lbCodigoArt = new System.Windows.Forms.Label();
            this.textBoxcodigoArt = new System.Windows.Forms.TextBox();
            this.lbmensajeArt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSaliralta = new System.Windows.Forms.Button();
            this.buttonbtcancelatalta = new System.Windows.Forms.Button();
            this.btaceptaralta = new System.Windows.Forms.Button();
            this.textBoxnif = new System.Windows.Forms.TextBox();
            this.textBoxdomicilio = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.lbNif = new System.Windows.Forms.Label();
            this.lbDomicilio = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbAlta = new System.Windows.Forms.Label();
            this.lbInstruccion = new System.Windows.Forms.Label();
            this.lbNumPed = new System.Windows.Forms.Label();
            this.textBoxNumPedido = new System.Windows.Forms.TextBox();
            this.lbunidades = new System.Windows.Forms.Label();
            this.textBoxunidades = new System.Windows.Forms.TextBox();
            this.lbfecha = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.dateTimecalendario = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAñadirPedido
            // 
            this.lbAñadirPedido.AutoSize = true;
            this.lbAñadirPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAñadirPedido.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAñadirPedido.ForeColor = System.Drawing.Color.Violet;
            this.lbAñadirPedido.Location = new System.Drawing.Point(49, 68);
            this.lbAñadirPedido.Name = "lbAñadirPedido";
            this.lbAñadirPedido.Size = new System.Drawing.Size(182, 35);
            this.lbAñadirPedido.TabIndex = 0;
            this.lbAñadirPedido.Text = "Añadir pedido:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbemail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.Color.Violet;
            this.lbemail.Location = new System.Drawing.Point(49, 151);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(147, 25);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "Indique su email:";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(326, 156);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(142, 20);
            this.textBoxemail.TabIndex = 2;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // lbmensajeCliente
            // 
            this.lbmensajeCliente.AutoSize = true;
            this.lbmensajeCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmensajeCliente.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensajeCliente.ForeColor = System.Drawing.Color.Violet;
            this.lbmensajeCliente.Location = new System.Drawing.Point(521, 156);
            this.lbmensajeCliente.Name = "lbmensajeCliente";
            this.lbmensajeCliente.Size = new System.Drawing.Size(154, 28);
            this.lbmensajeCliente.TabIndex = 3;
            this.lbmensajeCliente.Text = "Cliente ya existe";
            this.lbmensajeCliente.Visible = false;
            this.lbmensajeCliente.Click += new System.EventHandler(this.lbmensajeCliente_Click);
            // 
            // lbCodigoArt
            // 
            this.lbCodigoArt.AutoSize = true;
            this.lbCodigoArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCodigoArt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoArt.ForeColor = System.Drawing.Color.Violet;
            this.lbCodigoArt.Location = new System.Drawing.Point(49, 217);
            this.lbCodigoArt.Name = "lbCodigoArt";
            this.lbCodigoArt.Size = new System.Drawing.Size(197, 25);
            this.lbCodigoArt.TabIndex = 4;
            this.lbCodigoArt.Text = "Indique codigo artículo:";
            // 
            // textBoxcodigoArt
            // 
            this.textBoxcodigoArt.Location = new System.Drawing.Point(326, 222);
            this.textBoxcodigoArt.Name = "textBoxcodigoArt";
            this.textBoxcodigoArt.Size = new System.Drawing.Size(142, 20);
            this.textBoxcodigoArt.TabIndex = 5;
            this.textBoxcodigoArt.TabIndexChanged += new System.EventHandler(this.textBoxcodigoArt_TextChanged);
            this.textBoxcodigoArt.TextChanged += new System.EventHandler(this.textBoxcodigoArt_TextChanged_1);
            // 
            // lbmensajeArt
            // 
            this.lbmensajeArt.AutoSize = true;
            this.lbmensajeArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmensajeArt.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensajeArt.ForeColor = System.Drawing.Color.Violet;
            this.lbmensajeArt.Location = new System.Drawing.Point(521, 215);
            this.lbmensajeArt.Name = "lbmensajeArt";
            this.lbmensajeArt.Size = new System.Drawing.Size(163, 28);
            this.lbmensajeArt.TabIndex = 6;
            this.lbmensajeArt.Text = "Artículo ya existe";
            this.lbmensajeArt.Visible = false;
            this.lbmensajeArt.Click += new System.EventHandler(this.lbmensajeArt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btSaliralta);
            this.panel1.Controls.Add(this.buttonbtcancelatalta);
            this.panel1.Controls.Add(this.btaceptaralta);
            this.panel1.Controls.Add(this.textBoxnif);
            this.panel1.Controls.Add(this.textBoxdomicilio);
            this.panel1.Controls.Add(this.textBoxnombre);
            this.panel1.Controls.Add(this.lbNif);
            this.panel1.Controls.Add(this.lbDomicilio);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.lbAlta);
            this.panel1.Location = new System.Drawing.Point(830, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 232);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btSaliralta
            // 
            this.btSaliralta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSaliralta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaliralta.ForeColor = System.Drawing.Color.Violet;
            this.btSaliralta.Location = new System.Drawing.Point(298, 196);
            this.btSaliralta.Name = "btSaliralta";
            this.btSaliralta.Size = new System.Drawing.Size(75, 23);
            this.btSaliralta.TabIndex = 9;
            this.btSaliralta.Text = "Salir";
            this.btSaliralta.UseVisualStyleBackColor = false;
            this.btSaliralta.Click += new System.EventHandler(this.btSaliralta_Click);
            // 
            // buttonbtcancelatalta
            // 
            this.buttonbtcancelatalta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonbtcancelatalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbtcancelatalta.ForeColor = System.Drawing.Color.Violet;
            this.buttonbtcancelatalta.Location = new System.Drawing.Point(158, 196);
            this.buttonbtcancelatalta.Name = "buttonbtcancelatalta";
            this.buttonbtcancelatalta.Size = new System.Drawing.Size(75, 23);
            this.buttonbtcancelatalta.TabIndex = 8;
            this.buttonbtcancelatalta.Text = "Borrar Datos";
            this.buttonbtcancelatalta.UseVisualStyleBackColor = false;
            this.buttonbtcancelatalta.Click += new System.EventHandler(this.buttonbtcancelatalta_Click);
            // 
            // btaceptaralta
            // 
            this.btaceptaralta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btaceptaralta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaceptaralta.ForeColor = System.Drawing.Color.Violet;
            this.btaceptaralta.Location = new System.Drawing.Point(31, 197);
            this.btaceptaralta.Name = "btaceptaralta";
            this.btaceptaralta.Size = new System.Drawing.Size(75, 23);
            this.btaceptaralta.TabIndex = 7;
            this.btaceptaralta.Text = "Aceptar";
            this.btaceptaralta.UseVisualStyleBackColor = false;
            this.btaceptaralta.Click += new System.EventHandler(this.btaceptaralta_Click);
            // 
            // textBoxnif
            // 
            this.textBoxnif.Location = new System.Drawing.Point(187, 145);
            this.textBoxnif.Name = "textBoxnif";
            this.textBoxnif.Size = new System.Drawing.Size(100, 20);
            this.textBoxnif.TabIndex = 6;
            this.textBoxnif.TextChanged += new System.EventHandler(this.textBoxnif_TextChanged);
            // 
            // textBoxdomicilio
            // 
            this.textBoxdomicilio.Location = new System.Drawing.Point(187, 110);
            this.textBoxdomicilio.Name = "textBoxdomicilio";
            this.textBoxdomicilio.Size = new System.Drawing.Size(100, 20);
            this.textBoxdomicilio.TabIndex = 5;
            this.textBoxdomicilio.TextChanged += new System.EventHandler(this.textBoxdomicilio_TextChanged);
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(187, 77);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre.TabIndex = 4;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBoxnombre_TextChanged);
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNif.ForeColor = System.Drawing.Color.Violet;
            this.lbNif.Location = new System.Drawing.Point(31, 145);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(35, 21);
            this.lbNif.TabIndex = 3;
            this.lbNif.Text = "Nif:";
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDomicilio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDomicilio.ForeColor = System.Drawing.Color.Violet;
            this.lbDomicilio.Location = new System.Drawing.Point(31, 111);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(79, 21);
            this.lbDomicilio.TabIndex = 2;
            this.lbDomicilio.Text = "Domicilio:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Violet;
            this.lbNombre.Location = new System.Drawing.Point(31, 79);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(71, 21);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbAlta
            // 
            this.lbAlta.AutoSize = true;
            this.lbAlta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAlta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlta.ForeColor = System.Drawing.Color.Violet;
            this.lbAlta.Location = new System.Drawing.Point(27, 27);
            this.lbAlta.Name = "lbAlta";
            this.lbAlta.Size = new System.Drawing.Size(286, 21);
            this.lbAlta.TabIndex = 0;
            this.lbAlta.Text = "Siga las instrucciones para darse de alta:";
            // 
            // lbInstruccion
            // 
            this.lbInstruccion.AutoSize = true;
            this.lbInstruccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbInstruccion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruccion.ForeColor = System.Drawing.Color.Violet;
            this.lbInstruccion.Location = new System.Drawing.Point(45, 293);
            this.lbInstruccion.Name = "lbInstruccion";
            this.lbInstruccion.Size = new System.Drawing.Size(423, 28);
            this.lbInstruccion.TabIndex = 8;
            this.lbInstruccion.Text = "Siga las instrucciones para seguir con el pedido:";
            // 
            // lbNumPed
            // 
            this.lbNumPed.AutoSize = true;
            this.lbNumPed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNumPed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumPed.ForeColor = System.Drawing.Color.Violet;
            this.lbNumPed.Location = new System.Drawing.Point(45, 377);
            this.lbNumPed.Name = "lbNumPed";
            this.lbNumPed.Size = new System.Drawing.Size(207, 25);
            this.lbNumPed.TabIndex = 9;
            this.lbNumPed.Text = "Su numero de pedido es:";
            // 
            // textBoxNumPedido
            // 
            this.textBoxNumPedido.Location = new System.Drawing.Point(326, 382);
            this.textBoxNumPedido.Name = "textBoxNumPedido";
            this.textBoxNumPedido.Size = new System.Drawing.Size(142, 20);
            this.textBoxNumPedido.TabIndex = 10;
            this.textBoxNumPedido.TextChanged += new System.EventHandler(this.textBoxNumPedido_TextChanged);
            // 
            // lbunidades
            // 
            this.lbunidades.AutoSize = true;
            this.lbunidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbunidades.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunidades.ForeColor = System.Drawing.Color.Violet;
            this.lbunidades.Location = new System.Drawing.Point(45, 446);
            this.lbunidades.Name = "lbunidades";
            this.lbunidades.Size = new System.Drawing.Size(91, 25);
            this.lbunidades.TabIndex = 11;
            this.lbunidades.Text = "Unidades:";
            // 
            // textBoxunidades
            // 
            this.textBoxunidades.Location = new System.Drawing.Point(326, 446);
            this.textBoxunidades.Name = "textBoxunidades";
            this.textBoxunidades.Size = new System.Drawing.Size(142, 20);
            this.textBoxunidades.TabIndex = 12;
            this.textBoxunidades.TextChanged += new System.EventHandler(this.textBoxunidades_TextChanged);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfecha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.Violet;
            this.lbfecha.Location = new System.Drawing.Point(45, 511);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(122, 25);
            this.lbfecha.TabIndex = 13;
            this.lbfecha.Text = "Fecha Pedido:";
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.Violet;
            this.btAceptar.Location = new System.Drawing.Point(177, 584);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 15;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Violet;
            this.btCancelar.Location = new System.Drawing.Point(368, 584);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 23);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Borrar Datos";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.Violet;
            this.btSalir.Location = new System.Drawing.Point(1155, 584);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 17;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // dateTimecalendario
            // 
            this.dateTimecalendario.Location = new System.Drawing.Point(326, 511);
            this.dateTimecalendario.Name = "dateTimecalendario";
            this.dateTimecalendario.Size = new System.Drawing.Size(142, 20);
            this.dateTimecalendario.TabIndex = 18;
            // 
            // AñadirPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1273, 643);
            this.Controls.Add(this.dateTimecalendario);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.textBoxunidades);
            this.Controls.Add(this.lbunidades);
            this.Controls.Add(this.textBoxNumPedido);
            this.Controls.Add(this.lbNumPed);
            this.Controls.Add(this.lbInstruccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbmensajeArt);
            this.Controls.Add(this.textBoxcodigoArt);
            this.Controls.Add(this.lbCodigoArt);
            this.Controls.Add(this.lbmensajeCliente);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbAñadirPedido);
            this.Name = "AñadirPedidoView";
            this.Text = "AñadirPedidoView";
            this.Load += new System.EventHandler(this.AñadirPedidoView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAñadirPedido;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label lbmensajeCliente;
        private System.Windows.Forms.Label lbCodigoArt;
        private System.Windows.Forms.TextBox textBoxcodigoArt;
        private System.Windows.Forms.Label lbmensajeArt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSaliralta;
        private System.Windows.Forms.Button buttonbtcancelatalta;
        private System.Windows.Forms.Button btaceptaralta;
        private System.Windows.Forms.TextBox textBoxnif;
        private System.Windows.Forms.TextBox textBoxdomicilio;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.Label lbDomicilio;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbAlta;
        private System.Windows.Forms.Label lbInstruccion;
        private System.Windows.Forms.Label lbNumPed;
        private System.Windows.Forms.TextBox textBoxNumPedido;
        private System.Windows.Forms.Label lbunidades;
        private System.Windows.Forms.TextBox textBoxunidades;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DateTimePicker dateTimecalendario;
    }
}