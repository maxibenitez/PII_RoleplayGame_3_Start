using System.Collections.Generic;

namespace Program
{
  public class Enano : IPersonaje
  {
    public string Nombre{get; set;}

    public int HP{get; set;}

    public List<IItem> Inventario{get;}

    public void AddItem(IItem item)
    {
      this.Inventario.Add(item);
    }
    public void RemoveItem(IItem item)
    {
      this.Inventario.Remove(item);
    }

    public IAttack Arma{get;}

    public int Ataque 
    {
      get
      {
        return Arma.DMG + IPersonaje.K_AtaqueBase;
      }
    }
    public IDefense Armadura{get;}
    public int Defensa 
    {
      get
      {
        return Armadura.DEF + IPersonaje.K_DefensaBase;
      }
    }

    public Enano(string nombre)
    {
      this.Nombre = nombre;
      this.HP = IPersonaje.K_maxHP;
    }
  }
}