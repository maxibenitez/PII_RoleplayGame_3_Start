namespace Program
{
    public interface IItem
    {
        string Name{get; set;}
    }

    public interface IDefense : IItem
    {
        int DEF {get;}   
    }

    public interface IAttack : IItem
    {
        int DMG {get;}
    }
}