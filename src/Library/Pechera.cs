namespace Program
{
    public class Pechera : IItem: IDefense
    {
        private int _def;

        public string Name {get; set;}

        public int DEF 
        {
            get
            {
                return this._def;
            }

            private set
            {
                this._def = value;
            } 
        }
        
        public Item (string nombre, int def)
        {
            this.Name = nombre;
            this.DEF = def;
        }
    }
}
