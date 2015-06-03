using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloNegocioCreche;
using ModeloCreche;

namespace ControleCreche
{
    public class CriacaCtrl
    {
        public void SalvarCrianca(Crianca _crianca)
        {
            CriancaDAO dao = new CriancaDAO();

            dao.SalvarNoArquivo(_crianca);
        }
    }
}
