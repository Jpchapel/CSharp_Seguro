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
        
        private void PerderFoco(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void btSair_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void GuardarDatos()
        {
            ComprobarEdad();
            ComprobarSexo();
        }

        private void ComprobarEdad()
        {
            if(tbxEdade.TextLength <= 2)
            {
                char[] edadArray = tbxEdade.Text.ToCharArray();
                String edadString = "";
                bool comprobador = false;

                for (int i = 0; i < edadArray.GetLength(0); i++)
                {
                    if (Char.IsDigit(edadArray[i]))
                    {
                        edadString += edadArray[i];
                        comprobador = true;
                    }
                    else
                    {
                        MessageBox.Show("Edad en formato incorrecto", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbxEdade.Text = String.Empty;
                        tbxEdade.Focus();
                        comprobador = false;
                        break;
                    }
                }
                if (comprobador)
                {
                    if (Convert.ToInt16(tbxEdade.Text) < 18 || Convert.ToInt16(tbxEdade.Text) > 90)
                    {
                        MessageBox.Show("Ha introducido una edad No valida", "Error de edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        asegurado.Edade = Convert.ToInt16(tbxEdade.Text);
                    }                    
                }
            }           
        }

        private void ComprobarSexo()
        {
            if (rbtHome.Checked)
            {
                asegurado.Sexo = 'H';
            }
            else if (rbtMuller.Checked)
            {
                asegurado.Sexo = 'M';
            }
        }

    }
}
