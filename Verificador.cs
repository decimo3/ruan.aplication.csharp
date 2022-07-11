using System.Text.RegularExpressions;
namespace Verificador
{
    public static class verificarse
    {
        public static bool validoUsuario(string valor)
        {
            return (Regex.IsMatch(texto, "[0-9A-z]{5,16}")) ? true : false;
        }
        public static bool validoPalavra(string valor)
        {
            return (Regex.IsMatch(texto, "[0-9A-z]{8,32}")) ? true : false;
        }
    }
}
