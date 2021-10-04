using System.Collections.Generic;

namespace Program
{
  public class Enano : Personaje
  {
    public Enano(string nombre, int vp, string tipo)
    {
      this.Nombre = nombre;
      this.Health = Personaje.K_maxHealth;
      this.VP = vp;
      this.TipoPersonaje = tipo;
      this.Inventario = new List<IItem>{};
    }
  }
}