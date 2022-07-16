using MySql.Data.MySqlClient;
using Verificador;
namespace basedados
{
    class MyBanco
    {
        private MySqlConnection conexao;
        private MySqlCommand cursor;
        private MySqlDataReader leitor;
        private string instrucao;
        public MyBanco()
        {
            conexao = new MySqlConnection("server=127.0.0.1;uid=root;pwd=123456789;database=aplication");
            cursor = new MySqlCommand();
            cursor.Connection = conexao;
            instrucao = "";
            conexao.Open();
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                System.Console.WriteLine("A conexão estabelecida com sucesso!");
            }
            else
            {
                System.Console.WriteLine("A conexão fracassou com sucesso!");
            }
        }
        public bool criarUsuario(string usuario, string palavra)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            if (!verificarse.validoPalavra(palavra)) return false;
            // INSERT INTO tabela (usuario, palavra) VALUES ('usuario','palavra');
            instrucao = $"INSERT INTO usuario (usuario, palavra) VALUES ('{usuario}', '{palavra}');";
            cursor.CommandText = instrucao;
            cursor.ExecuteNonQuery();
            return true;
        }
        public bool existeUsuario(string usuario)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            instrucao = $"SELECT usuario FROM usuario WHERE usuario = '{usuario}';";
            cursor.CommandText = instrucao;
            return (cursor.ExecuteNonQuery() == 1) ? true : false;
        }
        public bool logarUsuario(string usuario, string palavra)
        {
            instrucao = $"SELECT usuario FROM usuario WHERE usuario = '{usuario}' AND palavra = '{palavra}'";
            cursor.CommandText = instrucao;
            return (cursor.ExecuteNonQuery() == (-1)) ? true : false;
        }
    }
}
