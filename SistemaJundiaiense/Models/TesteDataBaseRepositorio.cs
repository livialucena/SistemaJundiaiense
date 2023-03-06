using SistemaJundiaiense.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJundiaiense.Models
{
    public static class TesteDataBaseRepositorio
    {
        public static void CriarTabela()
        {
            string sql = @"INSERT INTO TBLPSA (id_psa, NOME_PSA, PASS_PSA) VALUES (2, 'Ana', 'TESTE123')";

            ConexaoHelper.EnviarDado(sql);
        }
    }
}
