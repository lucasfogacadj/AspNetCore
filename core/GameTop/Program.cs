
using System;

namespace GameTop
{
  class Program
  {
    static void Main(string[] args)
    {
      var jogo = new JogoFoda(
        new Jogador1("Lucas"),
        new Jogador2()
      );

      jogo.IniciarJogo();
    }
  }

  public class Jogador
  {
    public readonly string _Nome;

    public Jogador(string nome)
    {
      _Nome = nome;
    }

    //chuta
    public void chuta()
    {
      Console.Write($"{_Nome} está chutando\n");
    }

    //corre
    public void corre()
    {
      Console.Write($"{_Nome} está correndo\n");
    }
    //passe
    public void passe()
    {
      Console.Write($"{_Nome} está passando\n");
    }
  }


}
