using System.Collections.Generic;

namespace Program
{
  public class Mago : Personaje
  {
    public List<Hechizo> LibroEquipado
    {
      get
      {
        foreach (IItem item in Inventario)
        {
          if (item is Libro)
          {
          return (item as Libro).HechizosGuardados;
          }
        }
        return new Libro ("Libro vacío").HechizosGuardados;
      }
    }
  
    public Mago(string nombre, int vp, string tipo)
    {
      this.Nombre = nombre;
      this.Health = Personaje.K_maxHealth;
      this.VP = vp;
      this.TipoPersonaje = tipo;
      this.Inventario = new List<IItem>{};
    }
  }
}