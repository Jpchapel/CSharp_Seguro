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
    public partial class fTelefonos : Form
    {
        private clsAsegurado asegurado = new clsAsegurado();

        public fTelefonos(clsAsegurado asegurado)
        {
            InitializeComponent();
            this.asegurado = asegurado;
        }

        private void btEngadirTelefono_Click(object sender, EventArgs e)
        {
            if (lbxTelefonos.Items.Count >= 5)
            {
                MessageBox.Show("Solo pueden meterse 5 numeros", "Aforo maximo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ComprobarNumero() != 0)
            {
                lbxTelefonos.Items.Add(ComprobarNumero());
                tbxTelefono.Text = String.Empty;
                tbxTelefono.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            GuardarTlfnos();

            this.Close();
        }

        private int ComprobarNumero()
        {
            bool comprobador = true;
            string numeroString = "";

            if (tbxTelefono.TextLength != 9)
            {
                MessageBox.Show("Faltan numeros en el telefono", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comprobador = false;
            }
            else
            {
                ComprobarDigitos(ref comprobador, ref numeroString);
            }

            if (comprobador)
            {
                return Convert.ToInt32(numeroString);
            }
            else
            {
                tbxTelefono.Text = String.Empty;
                tbxTelefono.Focus();
                return 0;
            }
        }

        private void ComprobarDigitos(ref bool comprobador, ref string numeroString)
        {
            char[] numeros = tbxTelefono.Text.ToCharArray();

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                if (!Char.IsDigit(numeros[i]))
                {
                    MessageBox.Show("Caracter Erroneo en los telefonos", "Caracter incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comprobador = false;
                    break;
                }
                else
                {
                    numeroString += numeros[i];
                    comprobador = true;
                }
            }
        }       

        private void GuardarTlfnos()
        {
            for (int i = 0; i < lbxTelefonos.Items.Count; i++)
            {
                asegurado.Telefonos[i] = Convert.ToInt32(lbxTelefonos.Items[i]);
            }
        }
    }
}
