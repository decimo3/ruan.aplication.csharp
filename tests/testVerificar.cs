using Verificador;
namespace tests
{
    public class testVerificar
    {
        [Fact]
        public void verificarUsuario()
        {
            Assert.Equal(true, verificarse.validoUsuario("Lordruan"));
            Assert.Equal(false, verificarse.validoUsuario("lordruan"));
            Assert.Equal(false, verificarse.validoUsuario("Lord-ruan"));
            Assert.Equal(true, verificarse.validoUsuario("Lord9ruan"));
            Assert.Equal(false, verificarse.validoUsuario("9lordruan"));
            Assert.Equal(false, verificarse.validoUsuario("9Lordruan"));
            Assert.Equal(true, verificarse.validoUsuario("Lordruan9"));
        }
    }    
}

