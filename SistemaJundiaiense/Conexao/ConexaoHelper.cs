using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJundiaiense.Conexao
{
    public class ConexaoHelper
    {
       

        public  static  void Executar(string query, bool resultado)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;

            try
            {
                //Conectar ao banco de dados
                cmd.Connection = conexao.Conectar();

                if(resultado)
                {
                    cmd.ExecuteReader();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }

                //Desconectar
                conexao.desconectar();
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
