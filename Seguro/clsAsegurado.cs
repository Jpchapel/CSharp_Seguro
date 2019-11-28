using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro
{
    public class clsAsegurado
    {
        #region privadas
        private string nome;
        private string enderezo;
        private int[] telefonos = new int[5];
        private char sexo;
        private short edade;
        #endregion

        #region publicas

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Enderezo
        {
            get
            {
                return enderezo;
            }

            set
            {
                enderezo = value;
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

        public short Edade
        {
            get
            {
                return edade;
            }

            set
            {
                edade = value;
            }
        }      

        #endregion

    }
}
