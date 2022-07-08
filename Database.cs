using MySql.Data.MySqlClient;
namespace basedados
{
    class MyBanco
    {
        private MySqlConnection conexao;
        private MySqlCommand cursor;
        public string tabela;
        public string colunas;
        public string valores;
        public string instrucao;
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
        public bool inserir()
        {
            // INSERT INTO tabela (usuario, palavra) VALUES ('usuario','palavra');
            instrucao = $"INSERT INTO {tabela} ({colunas}) VALUES ({valores});";
            cursor.CommandText = instrucao;
            cursor.ExecuteNonQuery();
            return true;
        }
        public bool buscar(string instrucao)
        {
            cursor.CommandText = instrucao;
            cursor.ExecuteNonQuery();
            return true;
        }
    }
}
