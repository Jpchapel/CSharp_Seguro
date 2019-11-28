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
    public partial class fSeguro : Form
    {
        clsAsegurado asegurado = new clsAsegurado();

        public fSeguro()
        {
            InitializeComponent();
        }
      
        private void btNovoAsegurado_Click(object sender, EventArgs e)
        {
            ActivarControles();
            BorrarContenido();            
        }
        
        private void ActivarControles()
        {
            foreach (Control item in Controls)
            {
                if (!item.Enabled)
                {
                    item.Enabled = true;
                }
            }
        }

        private void BorrarContenido()
        {
            foreach (Control item in Controls)
            {
                if (item.Name.Contains("tbx"))
                {
                    item.Text = string.Empty;
                }                
            }

            lbxDatosAsegurado.Items.Clear();
        }

        private void btTelefonos_Click(object sender, EventArgs e)
        {
            fTelefonos telefono = new fTelefonos(asegurado);
            telefono.ShowDialog();
        }

        private void btOutrosDatos_Click(object sender, EventArgs e)
        {
            fOutrosDatos otrosDatos = new fOutrosDatos(asegurado);
            otrosDatos.ShowDialog();
        }

        private void btDatosAsegurado_Click(object sender, EventArgs e)
        {
            MostrarDatosAsegurado();
        }

        private void MostrarDatosAsegurado()
        {
            asegurado.Nome = tbxNome.Text;
            asegurado.Enderezo = tbxEnderezo.Text;
            lbxDatosAsegurado.Items.Clear();
            lbxDatosAsegurado.Items.Add(string.Format("Nombre:\t\t{0}", asegurado.Nome));
            lbxDatosAsegurado.Items.Add(string.Format("Enderezo:\t{0}", asegurado.Enderezo));
            lbxDatosAsegurado.Items.Add(string.Format("Sexo:\t\t{0}", asegurado.Sexo));
            lbxDatosAsegurado.Items.Add(string.Format("Edad:\t\t{0}", asegurado.Edade));
            lbxDatosAsegurado.Items.Add("Tlfno:\t\t");
            for (int i = 0; i < asegurado.Telefonos.GetLength(0); i++)
            {
                lbxDatosAsegurado.Items.Add(string.Format("\t\t{0}", asegurado.Telefonos[i]));
            }
        }
    }
}
