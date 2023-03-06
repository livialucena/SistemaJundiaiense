using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJundiaiense.Conexao
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=LAPTOP-7437KB24\SQLEXPRESS; integrated security=SSPI; initial catalog= dbjund";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

                    /*create database dbjund;
             use dbjund;


            Create table tblpsa
            (
                id_psa int primary key,
                nome_psa varchar(40),
                pass_psa varchar(10)
            )

            INSERT INTO TBLPSA (id_psa, NOME_PSA, PASS_PSA) VALUES (1, 'Livia', 'TESTE123');



            select *
	            from tblpsa


                    */

    }
}
