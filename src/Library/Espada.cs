using System.Collections;

namespace Program
{
  public class Espada : IItem, IAttack
  {
    private int _dmg;

    public string Name{get; set;}

    public int DMG
    {
      get
      {
        return this._dmg;
      }
      private set
      {
        this._dmg = value;
      }

    }

    public Espada(string name, int dmg)
    {
      this.Name = name;
      this.DMG = dmg;
    }

  }
}
