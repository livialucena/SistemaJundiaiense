using SistemaJundiaiense.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJundiaiense.Models
{
    public static class UsuarioRepositorio
    {
        public static void InserirUsuario(string login, string senha, string nome, string email, string grupo, string inativo)
        {
            ConexaoHelper.Executar(string.Format(@"INSERT INTO TVD_PSA (id_psa, pass_psa, nm_psa, email_psa, grupo, inativo) 
                                                   VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                                   login, senha, nome, email, grupo, inativo), false);
        }
    }
}
