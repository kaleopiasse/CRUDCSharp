using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp3.model
{
    class ConexaoModel
    {
        private const String stringConexao = "server=localhost; user= root;database=projetovoluntario; port=3306; password=skiter";
        private MySqlConnection conexao;

        public ConexaoModel ()
        {
            this.conexao = new MySqlConnection(stringConexao);
        }

        public MySqlConnection Conexao { get => conexao; set => conexao = value; }

        public void Conectar()
        {
            this.conexao.Open();
            Console.WriteLine("Conectado a base de dados!");
        }

        public void Desconectar()
        {
            this.conexao.Close();
            Console.WriteLine("Desconectado a base de dados!");
        }

    }
}
