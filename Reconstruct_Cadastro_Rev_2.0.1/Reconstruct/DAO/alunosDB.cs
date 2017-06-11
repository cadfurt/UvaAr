using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Reconstruct.DAO
{
    /* Camada de acesso de dados*/

    class alunosDB
    {
        string Con;
        // Pega a string de conexão do arquivo App.Config

        public alunosDB()
        {
            Con = ConfigurationSettings.AppSettings["ConexaoBD"];
        }

        // Método para incluir
        public void IncluirAluno(negocio.Alunos alunos)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "insert into Alunos(nome, endereco,idade) values (?nome,?endereco,?idade)";
            Com.Parameters.AddWithValue("?nome", alunos.Nome);
            Com.Parameters.AddWithValue("?endereco", alunos.Endereco);
            Com.Parameters.AddWithValue("?idade", alunos.Idade);

            try{
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            } catch (MySqlException ex) { 
                throw new ApplicationException(ex.ToString());
                
            } finally {
                    CN.Close();
            }

        }

        //Pega todos os registros da tabela
        public DataTable getAlunos()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "select * from alunos";

            try{

                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                DataTable dtAlunos = new DataTable();
                da.Fill(dtAlunos);
                return dtAlunos;

            } catch (MySqlException ex){

                throw new ApplicationException(ex.ToString());

            } finally{

                CN.Close();
            }
            
        }


    }
}
