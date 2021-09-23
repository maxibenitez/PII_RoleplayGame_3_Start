namespace Program
{
    public interface IItem
    {
        string Name{get; set;}
    }

    public interface IDefense
    {
        int DEF {get; private set;}   
    }

    public interface IAttack
    {
        int DMG {get; private set;}
    }
}