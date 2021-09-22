using System;
using System.Collections;
using System.Linq;

namespace Program
{
  public class Personaje
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
    private ArrayList inventario = new ArrayList();

    public ArrayList Inventario
      {
        get
      {
        return this.inventario;
      }
    }
    public void AddItem(Item item)
    {
      this.Inventario.Add(item);
    }
    public void RemoveItem(Item item)
    {
      this.Inventario.Remove(item);
    }

    public Item Arma 
    {
      get
      {
        foreach (Item item in this.Inventario)
        {
          if(item.Tipo == "ARMA")
          {
            return item;
          }
        }
        return null;
      }
    }

    private int hp;
    public int HP{
      get{
        return this.hp;
      }
      set{
        if(value < 0){
          this.hp = 0;
        }else {
          if (value <= K_maxHP){
            this.hp = value;
          } else{
            this.hp = K_maxHP;
          }
        }
      }
    }

    public int Ataque
    {
      get {
        int arma = 0;
        foreach (Item item in this.Inventario)
        {
          if(item.Tipo == "ARMA")
          {
            if(arma < item.DMG){
              arma = item.DMG;
            }
          }
        }
        return arma + K_ataqueBase;
      }
      
    }

    public int Defensa
    {
      get{
        int def = 0;
        foreach (Item item in this.Inventario)
        {
          if(item.Tipo == "ARMADURA")
          {
            def = item.DEF;
          }
        }
        return def + K_defensaBase;
      }
    }

    public Item LibroEquipado
    {
      get{
        if(this.especie == "MAGO"){
          foreach (Item item in this.Inventario)
          {
            if(item.Tipo == "LIBRO")
            {
              return item;
            }
          }
          return null;
        }
        else{
          return null;
        }
      }
    }
  }
} 
