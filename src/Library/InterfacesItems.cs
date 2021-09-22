namespace Program
{
    public interface IItem
    {
        string Name{get; set;}
    }

    public interface IDefense
    {
        int DEF {get;}   
    }

    public interface IAttack
    {
        int DMG {get;}
    }
}