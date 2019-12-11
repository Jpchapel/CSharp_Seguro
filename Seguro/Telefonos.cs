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
    public partial class Telefonos : Form
    {
        private Asegurado asegurado = new Asegurado();

        public Telefonos(Asegurado asegurado)
        {
            InitializeComponent();
            this.asegurado = asegurado;
        }

        private void AñadirTelefono_Click(object sender, EventArgs e)
        {
            if (AseguradoTelefonos.Items.Count >= 5)
            {
                MessageBox.Show("Solo pueden meterse 5 numeros", "Aforo maximo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ComprobarNumero() != 0)
            {
                AseguradoTelefonos.Items.Add(ComprobarNumero());
                telefono.Text = String.Empty;
                telefono.Focus();
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            GuardarTlfnos();

            this.Close();
        }

        private int ComprobarNumero()
        {
            bool comprobador = true;
            string numeroString = "";

            if (telefono.TextLength != 9)
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
                telefono.Text = String.Empty;
                telefono.Focus();
                return 0;
            }
        }

        private void ComprobarDigitos(ref bool comprobador, ref string numeroString)
        {
            char[] numeros = telefono.Text.ToCharArray();

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
            for (int i = 0; i < AseguradoTelefonos.Items.Count; i++)
            {
                asegurado.Telefonos[i] = Convert.ToInt32(AseguradoTelefonos.Items[i]);
            }
        }
    }
}
