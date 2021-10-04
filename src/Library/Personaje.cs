using System.Collections.Generic;

namespace Program
{
    public abstract class Personaje
    {
        public const int K_AtaqueBase = 5;

        public const int K_DefensaBase = 2;

        public const int K_maxHealth = 100;

        public string Nombre{get; set;}

        public int Health{get; set;}

        public int VP{get; set;}

        public string TipoPersonaje{get; set;}

        public IAttack Arma
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

        public IDefense Armadura
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

        public int Ataque 
        {
            get
            {
                return this.Arma.Damage + Personaje.K_AtaqueBase;
            }
        }

        public int Defensa 
        {
            get
            {
                return this.Armadura.Defense + Personaje.K_DefensaBase;
            }
        }

        public List<IItem> Inventario{get; set;}

        public void AddItem(IItem item)
        {
            this.Inventario.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.Inventario.Remove(item);
        }
    }
}

