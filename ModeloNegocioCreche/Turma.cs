
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocioCreche
{
    class Turma
    {
        int id;
        string sala;
        string descricao;
        int ano;
        int semestre;
        int turno;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }

    }
}
