namespace Program
{
    public class Pechera : IItem , IDefense
    {
        public string Name {get; set;}

        public int DEF {get; private set;}
        
        public Item (string nombre, int def)
        {
            this.Name = nombre;
            this.DEF = def;
        }
    }
}
