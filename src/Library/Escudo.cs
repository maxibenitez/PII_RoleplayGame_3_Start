using System.Collections;

namespace Program
{
  public class Escudo : IItem, IDefense
  {
    private int _def;

    public string Name{get; set;}

    public int DEF 
    {
      get
      {
        return this._def;
      }
      private set
      {
        this._def = value;
      }
    }

    public Escudo(string name, int def)
    {
      this.Name = name;
      this.DEF = def;
    }
  }
}
