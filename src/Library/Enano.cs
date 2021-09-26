using System.Collections.Generic;

namespace Program
{
  public class Enano : IPersonaje
  {
    public string Nombre{get; set;}

    public int HP
    {
      get
      {
        return this.HP;
      } 
      set
      {
        if (value + this.HP < 0)
        {
          this.HP = 0;
        }
        else if (value + this.HP > IPersonaje.K_maxHP)
        {
          this.HP = IPersonaje.K_maxHP;
        }
        else
        {
          this.HP += value;
        }
      }
    }

    public List<IItem> Inventario{get;}

    public void AddItem(IItem item)
    {
      this.Inventario.Add(item);
    }
    public void RemoveItem(IItem item)
    {
      this.Inventario.Remove(item);
    }

    public IAttack Arma
    {
      get
      {
        foreach (IItem item in Inventario)
        {
          if(item.GetType().Equals(typeof(IAttack)))
          {
            return item as IAttack;
          }
        }
        return new Espada ("Manos", 0);
      }
    }
    public int Ataque 
    {
      get
      {
        return this.Arma.DMG + IPersonaje.K_AtaqueBase;
      }
    }
    public IDefense Armadura
    {
      get
      {
        foreach (IItem item in Inventario)
        {
          if (item.GetType().Equals(typeof(IDefense)))
          {
            return item as IDefense;
          }
        }
        return new Pechera ("Desnudo", 0);
      }
    }
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
      this.Inventario = new List<IItem>{};
    }
  }
}