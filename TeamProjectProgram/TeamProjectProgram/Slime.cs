namespace TeamProjectProgram;

public class Slime : Monster, IDamageable
{
    private int _health;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    // public Slime(string name) : base(name) { }
    //
    // public void TakeDamage(int damAmount)
    // {
    //     _health -= damAmount;
    // }
    //
    //
    // public override void OnNotify()
    // {
    //     Console.WriteLine($"몬스터 이름 : {Name}  체력 : {Health}");
    // }
}