namespace Program
{
    public interface IItem
    {
        string Name{get; set;}
    }

    public interface IDefense : IItem
    {
        int Defense {get;}   
    }

    public interface IAttack : IItem
    {
        int Damage {get;}
    }
}