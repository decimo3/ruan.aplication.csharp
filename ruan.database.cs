using MySql.Data.MySqlClient;
namespace basedados
{
    class mariadb
    {
        private MySqlConnection conexao;
        private MysqlAdapter cursor;
        public bool conectar()
        {
            conexao = new MySqlConnection("server=127.0.0.1;uid=root;pwd=123456789;database=aplication");
            try
            {
                conexao.Open();
            }
            catch (System.Exception erro)
            {
                System.Console.WriteLine("Erro ao abrir conexão com o servidor MySQL");
                System.Console.WriteLine(erro.Message.ToString());
            }
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                System.Console.WriteLine("A conexão foi estabelecida com sucesso!");
                return true;
            }
            System.Console.WriteLine("A conexão fracassou com sucesso!");
            return false;
        }
    }
}
