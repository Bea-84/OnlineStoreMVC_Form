namespace OnlineStoreMVC_Form.View
{
    partial class AñadirClienteView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDomicilio = new System.Windows.Forms.Label();
            this.lbNif = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxdomicilio = new System.Windows.Forms.TextBox();
            this.textBoxnif = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelintroemail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siga las instrucciones para darse de alta:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNombre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Violet;
            this.lbNombre.Location = new System.Drawing.Point(25, 124);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(117, 35);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDomicilio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDomicilio.ForeColor = System.Drawing.Color.Violet;
            this.lbDomicilio.Location = new System.Drawing.Point(25, 187);
            this.lbDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(132, 35);
            this.lbDomicilio.TabIndex = 2;
            this.lbDomicilio.Text = "Domicilio:";
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNif.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNif.ForeColor = System.Drawing.Color.Violet;
            this.lbNif.Location = new System.Drawing.Point(25, 247);
            this.lbNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(58, 35);
            this.lbNif.TabIndex = 3;
            this.lbNif.Text = "Nif:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbEmail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Violet;
            this.lbEmail.Location = new System.Drawing.Point(53, 314);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(86, 35);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(217, 132);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(132, 22);
            this.textBoxNombre.TabIndex = 5;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxdomicilio
            // 
            this.textBoxdomicilio.Location = new System.Drawing.Point(217, 194);
            this.textBoxdomicilio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxdomicilio.Name = "textBoxdomicilio";
            this.textBoxdomicilio.Size = new System.Drawing.Size(132, 22);
            this.textBoxdomicilio.TabIndex = 6;
            this.textBoxdomicilio.TextChanged += new System.EventHandler(this.textBoxdomicilio_TextChanged);
            // 
            // textBoxnif
            // 
            this.textBoxnif.Location = new System.Drawing.Point(217, 255);
            this.textBoxnif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxnif.Name = "textBoxnif";
            this.textBoxnif.Size = new System.Drawing.Size(132, 22);
            this.textBoxnif.TabIndex = 7;
            this.textBoxnif.TextChanged += new System.EventHandler(this.textBoxnif_TextChanged);
            this.textBoxnif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnif_KeyPress);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(201, 321);
            this.textBoxemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(132, 22);
            this.textBoxemail.TabIndex = 8;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.Violet;
            this.btAceptar.Location = new System.Drawing.Point(117, 341);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 28);
            this.btAceptar.TabIndex = 9;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.Violet;
            this.btCancelar.Location = new System.Drawing.Point(357, 341);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 28);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Borrar Datos";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.Violet;
            this.btSalir.Location = new System.Drawing.Point(1231, 711);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 28);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMensaje.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.Color.Violet;
            this.lbMensaje.Location = new System.Drawing.Point(397, 321);
            this.lbMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(197, 35);
            this.lbMensaje.TabIndex = 12;
            this.lbMensaje.Text = "Cliente ya existe";
            this.lbMensaje.Visible = false;
            this.lbMensaje.Click += new System.EventHandler(this.lbMensaje_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.lbDomicilio);
            this.panel1.Controls.Add(this.textBoxdomicilio);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.lbNif);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btAceptar);
            this.panel1.Controls.Add(this.textBoxnif);
            this.panel1.Location = new System.Drawing.Point(784, 220);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 405);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // labelintroemail
            // 
            this.labelintroemail.AutoSize = true;
            this.labelintroemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelintroemail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelintroemail.ForeColor = System.Drawing.Color.Violet;
            this.labelintroemail.Location = new System.Drawing.Point(53, 220);
            this.labelintroemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelintroemail.Name = "labelintroemail";
            this.labelintroemail.Size = new System.Drawing.Size(242, 35);
            this.labelintroemail.TabIndex = 15;
            this.labelintroemail.Text = "Introduzca su email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(60, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 43);
            this.label2.TabIndex = 16;
            this.label2.Text = "Añadir Cliente";
            // 
            // AñadirClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1459, 767);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelintroemail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.lbEmail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AñadirClienteView";
            this.Text = "AñadirClienteView";
            this.Load += new System.EventHandler(this.AñadirClienteView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDomicilio;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxdomicilio;
        private System.Windows.Forms.TextBox textBoxnif;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelintroemail;
        private System.Windows.Forms.Label label2;
    }
}