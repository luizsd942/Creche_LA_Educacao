using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocioCreche
{
    class Responsavel
    {
        int id;
        string nome;
        string tel;
        string cel;
        int parentesco;
        string email;
        string CPF;
        int idade;
        int tipoEnd;
        string localEnd;
        string cep;
        string municipio;
        string uf;

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

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Cel
        {
            get { return cel; }
            set { cel = value; }
        }

        public int Parentesco
        {
            get { return parentesco; }
            set { parentesco = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string cpf
        {
            get { return CPF; }
            set { CPF = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public int TipoEnd
        {
            get { return tipoEnd; }
            set { tipoEnd = value; }
        }

        public string LocalEnd
        {
            get { return localEnd; }
            set { localEnd = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
