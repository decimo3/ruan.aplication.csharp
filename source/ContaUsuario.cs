using basedados;
using Verificador;
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
            if (!verificarse.validoUsuario(usuario)) return false;
            if (!verificarse.validoPalavra(palavra)) return false;
            if (banco.criarUsuario(@usuario, @palavra))
            {
                System.Console.WriteLine("Usuario criado com sucesso!");
                return true;
            }
            else
            {
                System.Console.WriteLine("Criação do usuario falhou!");
                return false;
            }
        }
        public bool buscarUsuario(string usuario)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            if (banco.existeUsuario(usuario))
            {
                System.Console.WriteLine($"O usuário {usuario} sim foi encontrado!");
                return false;
            }
            else
            {
                System.Console.WriteLine($"O usuário {usuario} não foi encontrado!");
                return true;
            }
        }
        public bool logarUsuario(string usuario, string palavra)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            if (!verificarse.validoPalavra(palavra)) return false;
            return true;
        }
    }
}
