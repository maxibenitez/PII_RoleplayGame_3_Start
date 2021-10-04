using System.Collections.Generic;

namespace Program
{
  public class Elfo : Personaje
  {
    public override string Nombre{get; set;}

    public override int Health{get; set;}

    public override int VP{get;}

    public override string TipoPersonaje{get; set;}

    public List<IItem> Inventario{get;}

    public override void AddItem(IItem item)
    {
      this.Inventario.Add(item);
    }
    public override void RemoveItem(IItem item)
    {
      this.Inventario.Remove(item);
    }

    public override IAttack Arma
    {
      get
      {
        IAttack mejorArma = new Espada ("Manos", 0);
        foreach (IItem item in Inventario)
        {
          if(item is IAttack && ((IAttack) item).Damage > mejorArma.Damage)
          {
            mejorArma = (IAttack) item;
          }
        }
        return mejorArma;
      }
    }
    public override int Ataque 
    {
      get
      {
        return this.Arma.Damage + Personaje.K_AtaqueBase;
      }
    }
    public override IDefense Armadura
    {
      get
      {
        IDefense mejorArmadura = new Pechera ("Desnudo", 0);
        foreach (IItem item in Inventario)
        {
          if(item is IDefense && ((IDefense) item).Defense > mejorArmadura.Defense)
          {
            mejorArmadura = (IDefense) item;
          }
        }
        return mejorArmadura;
      }
    }
    public override int Defensa 
        {
          get
          {
            return this.Armadura.Defense + Personaje.K_DefensaBase;
          }
        }
    public Elfo(string nombre, string tipo)
    {
      this.Nombre = nombre;
      this.Health = Personaje.K_maxHealth;
      this.VP = 50;
      this.TipoPersonaje = tipo;
      this.Inventario = new List<IItem>{};
    }
  }
}