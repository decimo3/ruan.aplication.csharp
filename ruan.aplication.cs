using basedados;
namespace aplication {
  static class principal {
    static void Main (string[] args){
      System.Console.WriteLine("Olá mundo!");
      var banco = new mariadb();
      banco.conectar();
    }
  }
}