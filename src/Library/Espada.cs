using System.Collections;

namespace Program
{
  public class Espada : IItem, IAttack
  {
    private int _dmg;

    public string Name{get; set;}

    public int DMG{get; set;}

    public Espada(string name, int dmg)
    {
      this.Name = name;
      this.DMG = dmg;
    }

  }
}
