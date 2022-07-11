using System.Text.RegularExpressions;
namespace Verificador
{
    public static class verificarse
    {
        public static bool validoUsuario(string texto)
        {
            return (Regex.IsMatch(texto, "^[A-Z][a-z0-9]{4,16}$")) ? true : false;
        }
        public static bool validoPalavra(string texto)
        {
            return (Regex.IsMatch(texto, "^[A-Z][a-z0-9]{7,32}$")) ? true : false;
        }
    }
}
