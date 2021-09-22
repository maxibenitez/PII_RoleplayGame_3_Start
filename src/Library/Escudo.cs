using System.Collections;

namespace Program
{
  public class Escudo : IItem, IDefense, IAttack
  {
    private int _def;

    public string Name{get; set;}

    public int DEF{get; set;}

    public Escudo(string name, int def)
    {
      this.Name = name;
      this.DEF = def;
    }
  }
}
