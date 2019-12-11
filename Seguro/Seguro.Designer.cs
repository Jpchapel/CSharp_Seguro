namespace Seguro
{
    partial class Seguro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguro));
            this.NuevoAsegurado = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.datosAsegurado = new System.Windows.Forms.ListBox();
            this.btDatosAsegurado = new System.Windows.Forms.Button();
            this.OtrosDatos = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.telefonos = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NuevoAsegurado
            // 
            this.NuevoAsegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoAsegurado.Location = new System.Drawing.Point(442, 373);
            this.NuevoAsegurado.Name = "NuevoAsegurado";
            this.NuevoAsegurado.Size = new System.Drawing.Size(99, 54);
            this.NuevoAsegurado.TabIndex = 25;
            this.NuevoAsegurado.Text = "Nuevo Asegurado";
            this.NuevoAsegurado.UseVisualStyleBackColor = true;
            this.NuevoAsegurado.Click += new System.EventHandler(this.NuevoAsegurado_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(0, -1);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(559, 33);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Seguros MiViDA";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 201);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(525, 16);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "datos asegurado";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datosAsegurado
            // 
            this.datosAsegurado.Enabled = false;
            this.datosAsegurado.FormattingEnabled = true;
            this.datosAsegurado.Location = new System.Drawing.Point(16, 220);
            this.datosAsegurado.Name = "datosAsegurado";
            this.datosAsegurado.Size = new System.Drawing.Size(525, 147);
            this.datosAsegurado.TabIndex = 22;
            // 
            // btDatosAsegurado
            // 
            this.btDatosAsegurado.Enabled = false;
            this.btDatosAsegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatosAsegurado.Location = new System.Drawing.Point(16, 170);
            this.btDatosAsegurado.Name = "btDatosAsegurado";
            this.btDatosAsegurado.Size = new System.Drawing.Size(166, 28);
            this.btDatosAsegurado.TabIndex = 21;
            this.btDatosAsegurado.Text = "ver datos asegurado";
            this.btDatosAsegurado.UseVisualStyleBackColor = true;
            this.btDatosAsegurado.Click += new System.EventHandler(this.DatosAsegurado_Click);
            // 
            // OtrosDatos
            // 
            this.OtrosDatos.Enabled = false;
            this.OtrosDatos.Image = ((System.Drawing.Image)(resources.GetObject("OtrosDatos.Image")));
            this.OtrosDatos.Location = new System.Drawing.Point(455, 125);
            this.OtrosDatos.Name = "OtrosDatos";
            this.OtrosDatos.Size = new System.Drawing.Size(86, 36);
            this.OtrosDatos.TabIndex = 20;
            this.OtrosDatos.UseVisualStyleBackColor = true;
            this.OtrosDatos.Click += new System.EventHandler(this.OtrosDatos_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(455, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 16);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "otros datos";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonos
            // 
            this.telefonos.Enabled = false;
            this.telefonos.Image = ((System.Drawing.Image)(resources.GetObject("telefonos.Image")));
            this.telefonos.Location = new System.Drawing.Point(455, 65);
            this.telefonos.Name = "telefonos";
            this.telefonos.Size = new System.Drawing.Size(86, 36);
            this.telefonos.TabIndex = 18;
            this.telefonos.UseVisualStyleBackColor = true;
            this.telefonos.Click += new System.EventHandler(this.Telefonos_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(455, 50);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 16);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "teléfonos";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(13, 109);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(404, 16);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "direccion";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // direccion
            // 
            this.direccion.Enabled = false;
            this.direccion.Location = new System.Drawing.Point(12, 125);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(405, 20);
            this.direccion.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(404, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "nombre";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(12, 77);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(405, 20);
            this.nombre.TabIndex = 13;
            // 
            // Seguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 433);
            this.Controls.Add(this.NuevoAsegurado);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.datosAsegurado);
            this.Controls.Add(this.btDatosAsegurado);
            this.Controls.Add(this.OtrosDatos);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.telefonos);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.nombre);
            this.Name = "Seguro";
            this.Text = "seguros vida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NuevoAsegurado;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ListBox datosAsegurado;
        internal System.Windows.Forms.Button btDatosAsegurado;
        internal System.Windows.Forms.Button OtrosDatos;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button telefonos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox direccion;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox nombre;
    }
}

