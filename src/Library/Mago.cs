using System.Collections.Generic;

namespace Program
{
  public class Mago : IPersonaje
  {
    public string Nombre{get; set;}
    public int HP{get;set;}
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
        return this.Armadura.DEF + IPersonaje.K_DefensaBase;
      }
    }

    public List<Hechizo> LibroEquipado
    {
      get
      {
        foreach (IItem item in Inventario)
        {
          if (item.GetType().Equals(typeof(Libro)))
          {
          return (item as Libro).HechizosGuardados;
          }
        }
        return new Libro ("Libro vacío").HechizosGuardados;
      }
    }
  
    public Mago(string nombre)
    {
      this.Nombre = nombre;
      this.HP = IPersonaje.K_maxHP;
      this.Inventario = new List<IItem>{};
    }
  }
}