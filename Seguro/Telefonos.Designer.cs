namespace Seguro
{
    partial class Telefonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telefonos));
            this.btSair = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btEngadirTelefono = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.AseguradoTelefonos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(179, 243);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(100, 24);
            this.btSair.TabIndex = 15;
            this.btSair.Text = "guardar y salír";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(267, 20);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "teléfonos del asegurado (máx. 5 )";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEngadirTelefono
            // 
            this.btEngadirTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btEngadirTelefono.Image")));
            this.btEngadirTelefono.Location = new System.Drawing.Point(234, 16);
            this.btEngadirTelefono.Name = "btEngadirTelefono";
            this.btEngadirTelefono.Size = new System.Drawing.Size(45, 32);
            this.btEngadirTelefono.TabIndex = 12;
            this.btEngadirTelefono.UseVisualStyleBackColor = true;
            this.btEngadirTelefono.Click += new System.EventHandler(this.AñadirTelefono_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "teléfonos";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(104, 22);
            this.telefono.MaxLength = 100;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(125, 20);
            this.telefono.TabIndex = 10;
            this.telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AseguradoTelefonos
            // 
            this.AseguradoTelefonos.FormattingEnabled = true;
            this.AseguradoTelefonos.Location = new System.Drawing.Point(15, 100);
            this.AseguradoTelefonos.Name = "AseguradoTelefonos";
            this.AseguradoTelefonos.Size = new System.Drawing.Size(264, 121);
            this.AseguradoTelefonos.TabIndex = 16;
            // 
            // Telefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 289);
            this.Controls.Add(this.AseguradoTelefonos);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btEngadirTelefono);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.telefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Telefonos";
            this.Text = "teléfonos del asegurado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btSair;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox telefonos;
        internal System.Windows.Forms.Button btEngadirTelefono;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.ListBox AseguradoTelefonos;
    }
}