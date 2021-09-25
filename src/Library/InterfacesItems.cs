namespace Program
{
    public interface IItem
    {
        string Name{get; set;}
    }

    public interface IDefense
    {
        int DEF {get; set;}   
    }

    public interface IAttack
    {
        int DMG {get; set;}
    }
}