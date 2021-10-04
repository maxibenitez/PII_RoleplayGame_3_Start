namespace Program
{
  public class Escudo : IItem, IDefense, IAttack
  {
    public string Name{get; set;}

    public int Defense{get; private set;}

    public int Damage{get; private set;}

    public Escudo(string name, int def, int dmg)
    {
      this.Name = name;
      this.Defense = def;
      this.Damage = dmg;
    }
  }
}
