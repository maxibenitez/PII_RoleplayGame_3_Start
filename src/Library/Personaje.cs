/*using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
  public class Personaje : IPersonaje
  {
    private const int K_ataqueBase = 5;
    private const int K_defensaBase = 2;
    private const int K_maxHP = 100;

    private string especie;

    private static string[] especiesValidas = {"MAGO", "ENANO", "ELFO"};
    public Personaje(string nombre, string especie)
    {
      this.Nombre = nombre;
      this.Especie = especie;
      this.HP = K_maxHP;
    }

    public string Nombre{get; set;}
    public string Especie
    {
      get{
        return this.especie;
      }
      set{
          if (especiesValidas.Contains(value.ToUpper()))
          {
            this.especie = value.ToUpper();
          }else
          {
            this.especie  = null;
          }
      }
    }
    private List<IItem> inventario = new List<IItem>();

    public List<IItem> Inventario
      {
        get
      {
        return this.inventario;
      }
    }
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
        foreach (IAttack item in this.Inventario)
        {
          if(item.GetType().Equals(typeof(IAttack)))
          {
            return item;
          }
        }
        return new Espada ("Manos Vacías", 0);
      }
    }

    public IDefense Armadura 
    {
      get
      {
        foreach (IDefense item in this.Inventario)
        {
          if(item.GetType().Equals(typeof(IDefense)))
          {
            return item;
          }
        }
        return new Pechera ("Desnudo", 0);
      }
    }

    private int hp;
    public int HP
    {
      get
      {
        return this.hp;
      }
      set
      {
        if(value < 0)
        {
          this.hp = 0;
        }
        else 
        {
          if (value <= K_maxHP)
          {
            this.hp = value;
          } 
          else
          {
            this.hp = K_maxHP;
          }
        }
      }
    }

    public int Ataque
    {
      get 
      {
        return Arma.DMG + K_ataqueBase;
      }
      
    }

    public int Defensa
    {
      get
      {
        return Armadura.DEF + K_defensaBase;
      }
    }

    public Item LibroEquipado
    {
      get
      {
        if(this.especie == "MAGO")
        {
          foreach (Item item in this.Inventario)
          {
            if(item.Tipo == "LIBRO")
            {
              return item;
            }
          }
          return null;
        }
        else
        {
          return null;
        }
      }
    }
  }
} */
