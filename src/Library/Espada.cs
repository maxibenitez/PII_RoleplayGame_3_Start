namespace Program
{
  public class Espada : IItem, IAttack
  {
    public string Name{get; set;}

    public int Damage{get; private set;}

    public Espada(string name, int damage)
    {
      this.Name = name;
      this.Damage = damage;
    }
  }
}
