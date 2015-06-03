using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloNegocioCreche;
using System.Data.SqlServerCe;

namespace ModeloCreche
{
    public class CriancaDAO
    {
        public void SalvarNoArquivo(Crianca _crianca)
        {
            try
            {
                string path = @"I:\FACULDADE\8_Periodo\Topicos_II_C#\crecheLAEducacao\BD\tblCrianca.txt";
                StreamWriter escritor = new StreamWriter(path, true);

                escritor.Write(_crianca.Nome + ";");
                escritor.Write(_crianca.DataNasc + ";");
                escritor.Write(_crianca.Sexo + ";");
                
                escritor.WriteLine();

                escritor.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
