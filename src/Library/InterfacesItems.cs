namespace Program
{
    public interface IItem
    {
        string Name{get; set;}
    }

    public interface IDefense : IItem
    {
        int DEF {get; set;}   
    }

    public interface IAttack : IItem
    {
        int DMG {get; set;}
    }
}