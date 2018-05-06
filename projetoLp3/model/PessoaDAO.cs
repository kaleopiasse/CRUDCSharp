using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLp3.model
{
    class PessoaDAO
    {
        //ConexaoModel conexao = new ConexaoModel(); //Implementar depois
        private const String stringConexao = "server=localhost; user= root;database=projetovoluntario; port=3306; password=skiter";
        private MySqlConnection conexao;
        public void createPessoa(PessoaModel pessoaModel)
        {
            try
            {
                String consulta="insert into voluntario (cpf, nome, celular, email) values (@cpf,@nome,@celular,@email)";
                conexao = new MySqlConnection(stringConexao);
                MySqlCommand cmd = new MySqlCommand(consulta, conexao);
                cmd.Parameters.AddWithValue("@cpf", pessoaModel.Cpf);
                cmd.Parameters.AddWithValue("@nome", pessoaModel.Nome);
                cmd.Parameters.AddWithValue("@celular", pessoaModel.Celular);
                cmd.Parameters.AddWithValue("@email", pessoaModel.Email);
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        //Metodo de pesquisa por CPF, recebe string do campo pesquisa
        public PessoaModel readPessoaPorCpf(String cpf)
        {
            PessoaModel pessoaModel = new PessoaModel();

            try
            {
                String consulta = "select * from voluntario where cpf ="+cpf;
                conexao = new MySqlConnection(stringConexao);
                MySqlCommand cmd = new MySqlCommand(consulta, conexao);
                conexao.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dataReader.Read())
                {
                    pessoaModel.Cpf = dataReader["cpf"].ToString();
                    pessoaModel.Nome = dataReader["nome"].ToString();
                    pessoaModel.Celular = dataReader["celular"].ToString();
                    pessoaModel.Email = dataReader["email"].ToString();
                }

                return pessoaModel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
