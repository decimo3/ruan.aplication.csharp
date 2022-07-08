using basedados;
using System.Text.RegularExpressions;
namespace usuario
{
    class ContaUsuario
    {
        private MyBanco banco;
        public ContaUsuario()
        {
            banco = new MyBanco();
        }
        public bool criarUsuario(string usuario, string palavra)
        {
            if (!Regex.IsMatch(usuario, "[0-9A-z]{5,16}")) return false;
            if (!Regex.IsMatch(palavra, "[0-9A-z]{8,32}")) return false;
            banco.tabela = "usuario";
            banco.colunas = "usuario, palavra";
            banco.valores = $"'{usuario}', '{palavra}'";
            banco.inserir();
            System.Console.WriteLine("Usuario criado com sucesso!");
            return true;
        }
        public bool buscarUsuario(string usuario)
        {
            return false;
        }
        public bool logarUsuario() { return true; }
    }
}
