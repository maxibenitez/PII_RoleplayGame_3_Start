using System.Linq;

namespace Program {
    public class Hechizo {
        private static string[] _tiposHechizos = {"Daño", "Curación"};
        public string Nombre { get; set; }
        private string _tipoEfecto;
        public string TipoEfecto {
            get {
                return _tipoEfecto;
            }
            set {
                if (_tiposHechizos.Contains(value)) {
                    this._tipoEfecto = value;
                }
            }
        }
        public int Poder { get; set; }

        public Hechizo(string nombre, string tipoEfecto, int poder) 
        {
            this.Nombre = nombre;
            this.TipoEfecto = tipoEfecto;
            this.Poder = poder;
        }
    }
}