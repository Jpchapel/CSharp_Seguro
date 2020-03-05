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
    public partial class Seguro : Form
    {
        Asegurado asegurado = new Asegurado();
        
        public Seguro()
        {
            InitializeComponent();
        }
      
        private void NuevoAsegurado_Click(object sender, EventArgs e)
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
                if (item.Name.Equals("datosAsegurado"))
                {
                    item.Text = string.Empty;
                }                
            }

            datosAsegurado.Items.Clear();
        }

        private void Telefonos_Click(object sender, EventArgs e)
        {
            Telefonos telefono = new Telefonos(asegurado);
            telefono.ShowDialog();
        }

        private void OtrosDatos_Click(object sender, EventArgs e)
        {
            OtrosDatos otrosDatos = new OtrosDatos(asegurado);
            otrosDatos.ShowDialog();
        }

        private void DatosAsegurado_Click(object sender, EventArgs e)
        {
            MostrarDatosAsegurado();
        }

        private void MostrarDatosAsegurado()
        {
            asegurado.Nombre = nombre.Text;
            asegurado.Direccion = direccion.Text;
            datosAsegurado.Items.Clear();
            datosAsegurado.Items.Add(string.Format("Nombre:\t\t{0}", asegurado.Nombre));
            datosAsegurado.Items.Add(string.Format("Enderezo:\t{0}", asegurado.Direccion));
            datosAsegurado.Items.Add(string.Format("Sexo:\t\t{0}", asegurado.Sexo));
            datosAsegurado.Items.Add(string.Format("Edad:\t\t{0}", asegurado.Edad));
            datosAsegurado.Items.Add("Tlfno:\t\t");

            for (int i = 0; i < asegurado.Telefonos.GetLength(0); i++)
            {
                datosAsegurado.Items.Add(string.Format("\t\t{0}", asegurado.Telefonos[i]));
            }
        }
    }
}
