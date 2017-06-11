using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconstruct.DAO
{
    class reconstrucaoBD
    {
        string Con;

        public reconstrucaoBD()
        {
            Con = ConfigurationSettings.AppSettings["ConexaoBD"];
        }

        // Método para incluir
        public void IncluirReconstrucao(negocio.Reconstrucoes reconstrucoes)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "insert into reconstrucoes(nome, caminho, osexame) values (?nome,?caminho, ?osexame)";
            Com.Parameters.AddWithValue("?nome", reconstrucoes.Nome);
            Com.Parameters.AddWithValue("?caminho", reconstrucoes.Caminho);
            Com.Parameters.AddWithValue("?osexame", reconstrucoes.Osexame);
            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());

            }
            finally
            {
                CN.Close();
            }

        }

        //Pega todos os registros da tabela
        public DataTable getReconstrucoes()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "select * from reconstrucoes";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                DataTable dtReconstrucoes = new DataTable();
                da.Fill(dtReconstrucoes);
                return dtReconstrucoes;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }

        }
        
    }
}
