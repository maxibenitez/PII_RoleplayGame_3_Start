namespace Program
{
  public class Espada : IItem, IAttack
  {
    public string Name{get; set;}

    public int DMG{get; private set;}

    public Espada(string name, int dmg)
    {
      this.Name = name;
      this.DMG = dmg;
    }

  }
}
