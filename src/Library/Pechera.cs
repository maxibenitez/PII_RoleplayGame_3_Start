namespace Program
{
    public class Pechera : IItem , IDefense
    {
        public string Name {get; set;}

        public int Defense {get; private set;}
        
        public Pechera (string nombre, int def)
        {
            this.Name = nombre;
            this.Defense = def;
        }
    }
}
