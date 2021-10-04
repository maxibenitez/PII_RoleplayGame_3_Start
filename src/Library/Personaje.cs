using System.Collections.Generic;

namespace Program
{
    public abstract class Personaje
    {
        public const int K_AtaqueBase = 5;

        public const int K_DefensaBase = 2;

        public const int K_maxHealth = 100;

        public abstract string Nombre{get; set;}

        public abstract int Health{get; set;}

        public abstract int VP{get;}

        public abstract string TipoPersonaje{get; set;}

        List<IItem> Inventario{get;}

        public abstract IAttack Arma{get;}

        public abstract IDefense Armadura{get;}

        public abstract int Ataque {get;}

        public abstract int Defensa {get;}

        public abstract void AddItem(IItem item);

        public abstract void RemoveItem(IItem item);
    }
}

