using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro
{
    public class Asegurado
    {
        #region privadas
        private string nombre;
        private string direccion;
        private int[] telefonos = new int[5];
        private char sexo;
        private short edad;
        #endregion

        #region publicas

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int[] Telefonos
        {
            get
            {
                return telefonos;
            }

            set
            {
                telefonos = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public short Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }      

        #endregion

    }
}
