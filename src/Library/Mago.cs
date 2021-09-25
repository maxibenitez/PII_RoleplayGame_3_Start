using System.Collections.Generic;

namespace Program
{
  public class Mago : IPersonaje
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

    public IDefense Armadura{get;}

    public Libro LibroEquipado{get;}
  
    public Mago(string nombre)
    {
      this.Nombre = nombre;
      this.HP = IPersonaje.K_maxHP;
    }
    
  }
}