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
            this.lbAñadirPedido.Location = new System.Drawing.Point(65, 84);
            this.lbAñadirPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAñadirPedido.Name = "lbAñadirPedido";
            this.lbAñadirPedido.Size = new System.Drawing.Size(228, 43);
            this.lbAñadirPedido.TabIndex = 0;
            this.lbAñadirPedido.Text = "Añadir pedido:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbemail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.Color.Violet;
            this.lbemail.Location = new System.Drawing.Point(65, 186);
            this.lbemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(187, 31);
            this.lbemail.TabIndex = 1;
            this.lbemail.Text = "Indique su email:";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(435, 192);
            this.textBoxemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(188, 22);
            this.textBoxemail.TabIndex = 2;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // lbmensajeCliente
            // 
            this.lbmensajeCliente.AutoSize = true;
            this.lbmensajeCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmensajeCliente.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensajeCliente.ForeColor = System.Drawing.Color.Violet;
            this.lbmensajeCliente.Location = new System.Drawing.Point(695, 192);
            this.lbmensajeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmensajeCliente.Name = "lbmensajeCliente";
            this.lbmensajeCliente.Size = new System.Drawing.Size(197, 35);
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
            this.lbCodigoArt.Location = new System.Drawing.Point(65, 267);
            this.lbCodigoArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigoArt.Name = "lbCodigoArt";
            this.lbCodigoArt.Size = new System.Drawing.Size(251, 31);
            this.lbCodigoArt.TabIndex = 4;
            this.lbCodigoArt.Text = "Indique codigo artículo:";
            // 
            // textBoxcodigoArt
            // 
            this.textBoxcodigoArt.Location = new System.Drawing.Point(435, 273);
            this.textBoxcodigoArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxcodigoArt.Name = "textBoxcodigoArt";
            this.textBoxcodigoArt.Size = new System.Drawing.Size(188, 22);
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
            this.lbmensajeArt.Location = new System.Drawing.Point(695, 265);
            this.lbmensajeArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmensajeArt.Name = "lbmensajeArt";
            this.lbmensajeArt.Size = new System.Drawing.Size(208, 35);
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
            this.panel1.Location = new System.Drawing.Point(1107, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 286);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btSaliralta
            // 
            this.btSaliralta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSaliralta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaliralta.ForeColor = System.Drawing.Color.Violet;
            this.btSaliralta.Location = new System.Drawing.Point(397, 241);
            this.btSaliralta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSaliralta.Name = "btSaliralta";
            this.btSaliralta.Size = new System.Drawing.Size(100, 28);
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
            this.buttonbtcancelatalta.Location = new System.Drawing.Point(211, 241);
            this.buttonbtcancelatalta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonbtcancelatalta.Name = "buttonbtcancelatalta";
            this.buttonbtcancelatalta.Size = new System.Drawing.Size(100, 28);
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
            this.btaceptaralta.Location = new System.Drawing.Point(41, 242);
            this.btaceptaralta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btaceptaralta.Name = "btaceptaralta";
            this.btaceptaralta.Size = new System.Drawing.Size(100, 28);
            this.btaceptaralta.TabIndex = 7;
            this.btaceptaralta.Text = "Aceptar";
            this.btaceptaralta.UseVisualStyleBackColor = false;
            this.btaceptaralta.Click += new System.EventHandler(this.btaceptaralta_Click);
            // 
            // textBoxnif
            // 
            this.textBoxnif.Location = new System.Drawing.Point(249, 178);
            this.textBoxnif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxnif.Name = "textBoxnif";
            this.textBoxnif.Size = new System.Drawing.Size(132, 22);
            this.textBoxnif.TabIndex = 6;
            this.textBoxnif.TextChanged += new System.EventHandler(this.textBoxnif_TextChanged);
            this.textBoxnif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnif_KeyPress);
            // 
            // textBoxdomicilio
            // 
            this.textBoxdomicilio.Location = new System.Drawing.Point(249, 135);
            this.textBoxdomicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxdomicilio.Name = "textBoxdomicilio";
            this.textBoxdomicilio.Size = new System.Drawing.Size(132, 22);
            this.textBoxdomicilio.TabIndex = 5;
            this.textBoxdomicilio.TextChanged += new System.EventHandler(this.textBoxdomicilio_TextChanged);
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(249, 95);
            this.textBoxnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(132, 22);
            this.textBoxnombre.TabIndex = 4;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBoxnombre_TextChanged);
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNif.ForeColor = System.Drawing.Color.Violet;
            this.lbNif.Location = new System.Drawing.Point(41, 178);
            this.lbNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(42, 26);
            this.lbNif.TabIndex = 3;
            this.lbNif.Text = "Nif:";
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDomicilio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDomicilio.ForeColor = System.Drawing.Color.Violet;
            this.lbDomicilio.Location = new System.Drawing.Point(41, 137);
            this.lbDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(97, 26);
            this.lbDomicilio.TabIndex = 2;
            this.lbDomicilio.Text = "Domicilio:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Violet;
            this.lbNombre.Location = new System.Drawing.Point(41, 97);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(86, 26);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbAlta
            // 
            this.lbAlta.AutoSize = true;
            this.lbAlta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAlta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlta.ForeColor = System.Drawing.Color.Violet;
            this.lbAlta.Location = new System.Drawing.Point(36, 33);
            this.lbAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAlta.Name = "lbAlta";
            this.lbAlta.Size = new System.Drawing.Size(351, 26);
            this.lbAlta.TabIndex = 0;
            this.lbAlta.Text = "Siga las instrucciones para darse de alta:";
            // 
            // lbInstruccion
            // 
            this.lbInstruccion.AutoSize = true;
            this.lbInstruccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbInstruccion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruccion.ForeColor = System.Drawing.Color.Violet;
            this.lbInstruccion.Location = new System.Drawing.Point(60, 361);
            this.lbInstruccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInstruccion.Name = "lbInstruccion";
            this.lbInstruccion.Size = new System.Drawing.Size(548, 35);
            this.lbInstruccion.TabIndex = 8;
            this.lbInstruccion.Text = "Siga las instrucciones para seguir con el pedido:";
            // 
            // lbNumPed
            // 
            this.lbNumPed.AutoSize = true;
            this.lbNumPed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNumPed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumPed.ForeColor = System.Drawing.Color.Violet;
            this.lbNumPed.Location = new System.Drawing.Point(60, 464);
            this.lbNumPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumPed.Name = "lbNumPed";
            this.lbNumPed.Size = new System.Drawing.Size(263, 31);
            this.lbNumPed.TabIndex = 9;
            this.lbNumPed.Text = "Su numero de pedido es:";
            // 
            // textBoxNumPedido
            // 
            this.textBoxNumPedido.Location = new System.Drawing.Point(435, 470);
            this.textBoxNumPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumPedido.Name = "textBoxNumPedido";
            this.textBoxNumPedido.Size = new System.Drawing.Size(188, 22);
            this.textBoxNumPedido.TabIndex = 10;
            this.textBoxNumPedido.TextChanged += new System.EventHandler(this.textBoxNumPedido_TextChanged);
            // 
            // lbunidades
            // 
            this.lbunidades.AutoSize = true;
            this.lbunidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbunidades.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunidades.ForeColor = System.Drawing.Color.Violet;
            this.lbunidades.Location = new System.Drawing.Point(60, 549);
            this.lbunidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunidades.Name = "lbunidades";
            this.lbunidades.Size = new System.Drawing.Size(117, 31);
            this.lbunidades.TabIndex = 11;
            this.lbunidades.Text = "Unidades:";
            // 
            // textBoxunidades
            // 
            this.textBoxunidades.Location = new System.Drawing.Point(435, 549);
            this.textBoxunidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxunidades.Name = "textBoxunidades";
            this.textBoxunidades.Size = new System.Drawing.Size(188, 22);
            this.textBoxunidades.TabIndex = 12;
            this.textBoxunidades.TextChanged += new System.EventHandler(this.textBoxunidades_TextChanged);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbfecha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.Violet;
            this.lbfecha.Location = new System.Drawing.Point(60, 629);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(155, 31);
            this.lbfecha.TabIndex = 13;
            this.lbfecha.Text = "Fecha Pedido:";
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.Violet;
            this.btAceptar.Location = new System.Drawing.Point(236, 719);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 28);
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
            this.btCancelar.Location = new System.Drawing.Point(491, 719);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(133, 28);
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
            this.btSalir.Location = new System.Drawing.Point(1540, 719);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 28);
            this.btSalir.TabIndex = 17;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // dateTimecalendario
            // 
            this.dateTimecalendario.Location = new System.Drawing.Point(435, 629);
            this.dateTimecalendario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimecalendario.Name = "dateTimecalendario";
            this.dateTimecalendario.Size = new System.Drawing.Size(188, 22);
            this.dateTimecalendario.TabIndex = 18;
            this.dateTimecalendario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimecalendario_KeyPress);
            // 
            // AñadirPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1697, 791);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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