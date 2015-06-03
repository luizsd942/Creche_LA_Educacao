using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocioCreche
{
    public class Crianca
    {
        int id;
        string nome;
        string dataNasc;
        string sexo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
