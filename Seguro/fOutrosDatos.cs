using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguro
{
    public partial class fOutrosDatos : Form
    {
        private clsAsegurado asegurado = new clsAsegurado();

        public fOutrosDatos(clsAsegurado asegurado)
        {
            InitializeComponent();
            this.asegurado = asegurado;          
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            GuardarDatos();

            this.Close();
        }

        private void GuardarDatos()
        {
            ComprobarEdad();

            if (rbtHome.Checked)
            {
                asegurado.Sexo = 'H';
            }
            else if (rbtMuller.Checked)
            {
                asegurado.Sexo = 'M';
            }
        }

        private void ComprobarEdad()
        {
            if(tbxEdade.TextLength <= 2)
            {
                if (Convert.ToInt16(tbxEdade.Text) < 18 || Convert.ToInt16(tbxEdade.Text) > 90)
                {
                    MessageBox.Show("Ha introducido una edad No valida", "Error de edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                }
                asegurado.Edade = Convert.ToInt16(tbxEdade.Text);
            }
           
        }
    }
}
