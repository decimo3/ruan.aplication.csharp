using usuario;
namespace aplication {
  static class principal {
    static void Main (string[] args){
      System.Console.WriteLine("Olá mundo!");
      var user = new ContaUsuario();
      user.criarUsuario("lordruan", "a4ky997z");
    }
  }
}
