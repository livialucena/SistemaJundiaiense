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
       

        public  static  void EnviarDado(string comando)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = comando;

            try
            {
                //Conectar ao banco de dados
                cmd.Connection = conexao.Conectar();

                //Enviar dados ao banco de dados
                cmd.ExecuteNonQuery();

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
