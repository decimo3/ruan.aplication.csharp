using System.IO;
using System;

namespace registros
{
    public static class Registro
    {
        public static void escreverRegistro(string classe, string funcao, string tipo, string texto)
        {
            // tempo: data e hora da escrita do registro;
            // classe: de qual módulo o registro foi escrito;
            // função: método que o registro foi estrito;
            // tipo: [debug, error, create, fail, etc...];
            // texto: descrição detalhada do acontecido;
            // valores: lista de valores referentes ao método;
            var registro = $"{DateTime.Now.ToString("yyyy/MM/dd-HH:mm:ss.fff")}\t{classe}\t{funcao}\t{tipo}\t{texto}";
            using (StreamWriter lapis = new StreamWriter("registros.log", true))
            {
                lapis.WriteLine(registro);
            }
            System.Console.WriteLine(registro);
        }
    }
}
