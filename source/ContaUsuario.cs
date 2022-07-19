using basedados;
using Verificador;
using registros;

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
            if (buscarUsuario(usuario)) return false;
            if (banco.criarUsuario(@usuario, @palavra))
            {
                Registro.escreverRegistro("ContaUsuario", "CriarUsuario", 201, $"Usuário {usuario} criado com sucesso!");
                return true;
            }
            else
            {
                Registro.escreverRegistro("ContaUsuario", "CriarUsuario", 400, $"Usuário {usuario} falhou na criação!");
                return false;
            }
        }
        public bool buscarUsuario(string usuario)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            if (banco.existeUsuario(usuario))
            {
                Registro.escreverRegistro("ContaUsuario", "CriarUsuario", 200, $"O usuário {usuario} foi sim encontrado!");
                return false;
            }
            else
            {
                Registro.escreverRegistro("ContaUsuario", "CriarUsuario", 404, $"O usuário {usuario} não foi encontrado!");
                return true;
            }
        }
        public bool logarUsuario(string usuario, string palavra)
        {
            if (!verificarse.validoUsuario(usuario)) return false;
            if (!verificarse.validoPalavra(palavra)) return false;
            if (banco.logarUsuario(@usuario, @palavra))
            {
                Registro.escreverRegistro("ContaUsuario", "logarUsuario", 200, $"O usuario {usuario} logou com sucesso!");
                return true;
            }
            else
            {
                Registro.escreverRegistro("ContaUsuario", "logarUsuario", 400, $"O usuario {usuario} falhou em logar!");
                return false;
            }
        }
    }
}
