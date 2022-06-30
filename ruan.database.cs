using MySql.Data.MySqlClient;
namespace basedados
{
    class mariadb
    {
        public bool conectar()
        {
            var conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456789;database=aplication");
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
