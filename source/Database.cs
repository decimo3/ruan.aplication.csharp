using MySql.Data.MySqlClient;
using Verificador;
using registros;

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
                Registro.escreverRegistro("MyBanco", "MyBanco", 200, "A conexão com banco de dados estabelecida com sucesso!");
            }
            else
            {
                Registro.escreverRegistro("MyBanco", "MyBanco", 500, "A conexão com banco de dados fracassou com sucesso!");
            }
        }
        public bool criarUsuario(string usuario, string palavra)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            if (!verificarse.validoPalavra(palavra)) return false;
            if (existeUsuario(usuario)) return false;
            // INSERT INTO tabela (usuario, palavra) VALUES ('usuario','palavra');
            instrucao = $"INSERT INTO usuario (usuario, palavra) VALUES ('{usuario}', '{palavra}');";
            cursor.CommandText = instrucao;
            cursor.ExecuteNonQuery();
            Registro.escreverRegistro("MyBanco", "criarUsuario", 201, $"Usuario {usuario} registrado no banco de dados");
            return true;
        }
        public bool existeUsuario(string usuario)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            instrucao = $"SELECT usuario FROM usuario WHERE usuario = '{usuario}';";
            cursor.CommandText = instrucao;
            if (cursor.ExecuteNonQuery() == 1)
            {
                Registro.escreverRegistro("MyBanco", "existeUsuario", 200, $"Usuario {usuario} consultado sim existe");
                return true;
            }
            else
            {
                Registro.escreverRegistro("MyBanco", "existeUsuario", 404, $"Usuario {usuario} consultado não existe");
                return false;
            }
        }
        public bool logarUsuario(string usuario, string palavra)
        {
            instrucao = $"SELECT usuario FROM usuario WHERE usuario = '{usuario}' AND palavra = '{palavra}'";
            cursor.CommandText = instrucao;
            if (cursor.ExecuteNonQuery() == (-1))
            {
                Registro.escreverRegistro("MyBanco", "logarUsuario", 200, $"Usuario {usuario} logado com sucesso");
                return true;
            }
            else
            {
                Registro.escreverRegistro("MyBanco", "logarUsuario", 403, $"Credenciais do {usuario} são inválidas ");
                return false;
            }
        }
    }
}
