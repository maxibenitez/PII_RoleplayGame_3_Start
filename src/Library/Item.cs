using System.Collections;
using System.Linq;
using System.Text;

namespace Program
{
    public class Item
    {
        private string _tipo;
        private static string[] _tiposValidos = {"ARMA", "ARMADURA", "LIBRO"};
        private int _dmg;
        private int _def;

        private ArrayList hechizosGuardados;

        public ArrayList HechizosGuardados 

        {
            get
            {
                return this.hechizosGuardados;
            }
        }

        public string Nombre {get;set;}
        public string Tipo 
        {
            get
            {
                return this._tipo;
            }
            set
            {
                if (_tiposValidos.Contains(value.ToUpper()))
                {
                    this._tipo = value.ToUpper();
                }
                else
                {
                    {
                        this._tipo = null;
                    }
                }
            }
        }
        
        public int DMG 
        {
            get
            {
                return this._dmg;
            } 
            set
            {
                if (this.Tipo == "ARMA")
                {
                    this._dmg = value;
                }
                else
                {
                    this._dmg = 0;
                }
            }
        }
        public int DEF 
        {
            get
            {
                return this._def;
            } 
            set
            {
                if (this.Tipo == "ARMADURA")
                {
                    this._def = value;
                }
                else
                {
                    this._def = 0;
                }
            }
        }
        
        public Item (string nombre, string tipo, int dmg, int def)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.DMG = dmg;
            this.DEF = def;

            if (this.Tipo == "LIBRO")
            {
                this.hechizosGuardados = new ArrayList();
            }
        }

        public void AñadirHechizo(Hechizo hechizo)
        {
            if (this.Tipo == "LIBRO")
            {
                this.HechizosGuardados.Add(hechizo);
            }
        }

        public string VerHechizosGuardados()
        {
            StringBuilder result = new StringBuilder();
            if (this.Tipo == "LIBRO")
            {
                foreach (Hechizo spell in this.HechizosGuardados)
                {
                    result.Append($" * {spell.Nombre} \n");
                }
            }
            return result.ToString();

        }
        
         /* CrearItemsGenericos para copiar y pegar

            Item espadaStarter = new Item("Espada de Madera", "ARMA", 8, 0);
            Item espadaAvanzada = new Item("Espada de Diamante", "ARMA", 16, 0);
            Item armaduraStarter = new Item("Armadura de Cuero", "ARMADURA", 0, 4);
            Item armaduraAvanzada = new Item("Armadura de Acero", "ARMADURA", 0, 8);
         */
    }
}
