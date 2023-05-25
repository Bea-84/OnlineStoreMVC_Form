namespace OnlineStoreMVC_Form.View
{
    partial class MostrarArticuloView
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
            this.lbmostrar = new System.Windows.Forms.Label();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.lbcodigoArt = new System.Windows.Forms.Label();
            this.textBoxcodigoArt = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbmostrar
            // 
            this.lbmostrar.AutoSize = true;
            this.lbmostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmostrar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmostrar.ForeColor = System.Drawing.Color.Violet;
            this.lbmostrar.Location = new System.Drawing.Point(58, 218);
            this.lbmostrar.Name = "lbmostrar";
            this.lbmostrar.Size = new System.Drawing.Size(221, 35);
            this.lbmostrar.TabIndex = 0;
            this.lbmostrar.Text = "Mostrar Articulos:";
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbbuscar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.ForeColor = System.Drawing.Color.Violet;
            this.lbbuscar.Location = new System.Drawing.Point(58, 46);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(201, 35);
            this.lbbuscar.TabIndex = 1;
            this.lbbuscar.Text = "Buscar artículos:";
            // 
            // lbcodigoArt
            // 
            this.lbcodigoArt.AutoSize = true;
            this.lbcodigoArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbcodigoArt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigoArt.ForeColor = System.Drawing.Color.Violet;
            this.lbcodigoArt.Location = new System.Drawing.Point(58, 135);
            this.lbcodigoArt.Name = "lbcodigoArt";
            this.lbcodigoArt.Size = new System.Drawing.Size(149, 28);
            this.lbcodigoArt.TabIndex = 2;
            this.lbcodigoArt.Text = "Código artículo:";
            // 
            // textBoxcodigoArt
            // 
            this.textBoxcodigoArt.Location = new System.Drawing.Point(352, 141);
            this.textBoxcodigoArt.Name = "textBoxcodigoArt";
            this.textBoxcodigoArt.Size = new System.Drawing.Size(100, 20);
            this.textBoxcodigoArt.TabIndex = 3;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.Violet;
            this.btBuscar.Location = new System.Drawing.Point(714, 140);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 4;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.Violet;
            this.btSalir.Location = new System.Drawing.Point(714, 399);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(352, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 147);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MostrarArticuloView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(857, 471);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.textBoxcodigoArt);
            this.Controls.Add(this.lbcodigoArt);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.lbmostrar);
            this.Name = "MostrarArticuloView";
            this.Text = "MostrarArticuloView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmostrar;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.Label lbcodigoArt;
        private System.Windows.Forms.TextBox textBoxcodigoArt;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.ListBox listBox1;
    }
}