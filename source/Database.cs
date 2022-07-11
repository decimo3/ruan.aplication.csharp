using MySql.Data.MySqlClient;
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
            conexao.Open();
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                System.Console.WriteLine("A conexão foi estabelecida com sucesso!");
            }
            else
            {
                System.Console.WriteLine("A conexão fracassou com sucesso!");
            }
        }
        public bool criarUsuario(string usuario, string palavra)
        {
            // INSERT INTO tabela (usuario, palavra) VALUES ('usuario','palavra');
            instrucao = $"INSERT INTO usuario (usuario, palavra) VALUES ('{usuario}', '{palavra}');";
            cursor.CommandText = instrucao;
            cursor.ExecuteNonQuery();
            return true;
        }
        public bool existeUsuario(string usuario)
        {
            instrucao = $"SELECT usuario FROM usuario WHERE usuario = '{usuario}';";
            cursor.CommandText = instrucao;
            leitor = cursor.ExecuteReader();
            while (leitor.Read())
            {
                System.Console.WriteLine($"{leitor.GetString(0)}");
            }
            leitor.Close();
            return true;
        }
        public bool logarUsuario(string usuario, string palavra)
        {
            instrucao = $"SELECT usuario FROM usuario WHERE usuario = '{usuario}' AND palavra = '{palavra}'";
            cursor.CommandText = instrucao;
            var correspondencias = cursor.ExecuteNonQuery();
            if (correspondencias == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
